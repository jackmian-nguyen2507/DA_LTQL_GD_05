using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyQuanCaPhe.Data;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmThemKhachHang : Form
    {

        QLCPDbContext context = new QLCPDbContext();

        string maKH = "";
        bool isEdit = false;

        //Constructor để nhận mã KH từ frmKhachHang
        public frmThemKhachHang(string maKH)
        {
            InitializeComponent();
            this.maKH = maKH;
            isEdit = true;
        }

        public frmThemKhachHang()
        {
            InitializeComponent();
        }

        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                txtMaKH.Enabled = false;

                var kh = context.KhachHang.Find(maKH);

                if (kh != null)
                {
                    txtMaKH.Text = kh.MaKH;
                    txtTenKH.Text = kh.TenKH;
                    txtSDT.Text = kh.SDT;
                    numDiem.Value = kh.DiemTichLuy ?? 0;
                }
            }
            else
            {
                txtMaKH.Text = TaoMaKhachHangTuDong();
                txtMaKH.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                var kh = context.KhachHang.Find(maKH);

                if (kh != null)
                {
                    kh.TenKH = txtTenKH.Text;
                    kh.SDT = txtSDT.Text;
                    kh.DiemTichLuy = (int)numDiem.Value;
                }
            }
            else
            {
                KhachHang kh = new KhachHang();

                kh.MaKH = txtMaKH.Text;
                kh.TenKH = txtTenKH.Text;
                kh.SDT = txtSDT.Text;
                kh.DiemTichLuy = (int)numDiem.Value;

                context.KhachHang.Add(kh);
            }

            context.SaveChanges();

            MessageBox.Show("Lưu thành công!");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        string TaoMaKhachHangTuDong()
        {
            var listMa = context.KhachHang
                .Select(x => x.MaKH)
                .ToList();

            List<int> numbers = listMa
                .Where(x => x.StartsWith("KH"))
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

            return "KH" + newNumber.ToString("D3");
        }



    }
}
