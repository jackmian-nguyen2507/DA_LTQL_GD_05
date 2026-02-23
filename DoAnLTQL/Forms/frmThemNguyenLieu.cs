using System;
using System.Windows.Forms;
using QuanLyQuanCaPhe.Data;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmThemNguyenLieu : Form
    {

        QLCPDbContext context = new QLCPDbContext();

        string maNL = "";
        bool isEdit = false;

        public frmThemNguyenLieu(string maNL)
        {
            InitializeComponent();
            this.maNL = maNL;
            isEdit = true;
        }

        public frmThemNguyenLieu()
        {
            InitializeComponent();

        }

        void LoadDonVi()
        {
            cboDonVi.DataSource = context.DonVi.ToList();
            cboDonVi.ValueMember = "MaDonVi";
            cboDonVi.DisplayMember = "TenDonVi";
        }


        private void frmThemNguyenLieu_Load(object sender, EventArgs e)
        {
            LoadDonVi();
            if (isEdit)
            {
                txtMaNL.Enabled = false;

                var nl = context.NguyenLieu.Find(maNL);

                if (nl != null)
                {
                    txtMaNL.Text = nl.MaNL;
                    txtTenNL.Text = nl.TenNL;
                    cboDonVi.SelectedValue = nl.MaDonVi;
                    numSoLuong.Value = nl.SoLuongTon ?? 0;
                }
            }
            else
            {
                txtMaNL.Text = TaoMaNguyenLieuTuDong();
                txtMaNL.Enabled = false;

                numSoLuong.Value = 0;
            }
        }



        string TaoMaNguyenLieuTuDong()
        {
            var listMa = context.NguyenLieu
                .Select(x => x.MaNL)
                .ToList();

            List<int> numbers = listMa
                .Where(x => x.StartsWith("NL"))
                .Select(x =>
                {
                    int n;
                    return int.TryParse(x.Substring(2), out n) ? n : 0;
                })
                .Where(x => x > 0)
                .OrderBy(x => x)
                .ToList();

            int newNumber = 1;

            foreach (var num in numbers)
            {
                if (num == newNumber)
                    newNumber++;
                else
                    break;
            }

            return "NL" + newNumber.ToString("D3"); // NL001
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNL.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nguyên liệu!");
                return;
            }

            if (cboDonVi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đơn vị!");
                return;
            }

            if (isEdit)
            {
                var nl = context.NguyenLieu.Find(maNL);

                if (nl != null)
                {
                    nl.TenNL = txtTenNL.Text;
                    nl.MaDonVi = (int)cboDonVi.SelectedValue; // 🔥 FIX
                    nl.SoLuongTon = numSoLuong.Value;
                }
            }
            else
            {
                NguyenLieu nl = new NguyenLieu();

                nl.MaNL = txtMaNL.Text;
                nl.TenNL = txtTenNL.Text;
                nl.MaDonVi = (int)cboDonVi.SelectedValue; // 🔥 FIX
                nl.SoLuongTon = numSoLuong.Value;

                context.NguyenLieu.Add(nl);
            }

            context.SaveChanges();

            MessageBox.Show("Lưu thành công!");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemDonVi_Click(object sender, EventArgs e)
        {
            frmDonVi f = new frmDonVi();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadDonVi();
            }
        }
    }
}