using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCaPhe.Data;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmDonVi : Form
    {

        QLCPDbContext context = new QLCPDbContext();
        public frmDonVi()
        {
            InitializeComponent();
        }

        private void frmDonVi_Load(object sender, EventArgs e)
        {
            dtgvDonVi.AutoGenerateColumns = false;
            LoadDonVi();
            txtTenDonVi.Focus();
        }

        void LoadDonVi()
        {
            var list = context.DonVi
                .Select(d => new
                {
                    d.MaDonVi,
                    d.TenDonVi
                })
                .ToList();

            dtgvDonVi.DataSource = list;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTenDonVi.Text.Trim();

            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập tên đơn vị!");
                return;
            }

            // tránh trùng
            var check = context.DonVi
                .FirstOrDefault(d => d.TenDonVi.ToLower() == ten.ToLower());

            if (check != null)
            {
                MessageBox.Show("Đơn vị đã tồn tại!");
                return;
            }

            DonVi dv = new DonVi();
            dv.TenDonVi = ten;

            context.DonVi.Add(dv);
            context.SaveChanges();

            MessageBox.Show("Thêm đơn vị thành công!");

            txtTenDonVi.Clear();
            LoadDonVi();

            // báo về form cha
            this.DialogResult = DialogResult.OK;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvDonVi.CurrentRow == null) return;

            int ma = (int)dtgvDonVi.CurrentRow.Cells["MaDonVi"].Value;

            var dv = context.DonVi.Find(ma);

            // check FK
            bool dangSuDung = context.NguyenLieu.Any(nl => nl.MaDonVi == ma);

            if (dangSuDung)
            {
                MessageBox.Show("Đơn vị đang được sử dụng, không thể xóa!");
                return;
            }

            if (MessageBox.Show("Xóa đơn vị?", "Xóa",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.DonVi.Remove(dv);
                context.SaveChanges();
                LoadDonVi();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenDonVi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem.PerformClick();
            }
        }   
    }
}
