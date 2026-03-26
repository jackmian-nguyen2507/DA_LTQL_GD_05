using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyQuanCaPhe.Data;
using static QuanLyQuanCaPhe.Data.KhachHang;


namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmKhachHang : Form
    {
        QLCPDbContext context = new QLCPDbContext();

        List<DanhSachKhachHang> dsKhachHangCache = new List<DanhSachKhachHang>();

        public frmKhachHang()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Tự động phóng to
            this.StartPosition = FormStartPosition.CenterScreen; // Căn giữa màn hình

            SetupLayout();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dtgvKhachHang.AutoGenerateColumns = false;
            LoadKhachHang();
        }

        void LoadKhachHang()
        {
            dsKhachHangCache = context.KhachHang
                .Select(k => new DanhSachKhachHang
                {
                    MaKH = k.MaKH,
                    TenKH = k.TenKH,
                    SDT = k.SDT,
                    DiemTichLuy = k.DiemTichLuy
                })
                .ToList();

            BindData(dsKhachHangCache);
        }

        void BindData(List<DanhSachKhachHang> data)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data;
            dtgvKhachHang.DataSource = bs;
        }


        void SetupLayout()
        {
            Panel pnlHeader = this.Controls["pnlHeader"] as Panel;
            Label lblTitle = null;
            foreach (Control c in pnlHeader.Controls) { if (c is Label) lblTitle = (Label)c; }

            Panel pnlControl = this.Controls["pnlControl"] as Panel;


            // --- CẤU HÌNH HEADER ---
            if (pnlHeader != null)
            {
                pnlHeader.AutoSize = false;       // Tắt tự động co giãn
                pnlHeader.Height = 60;
                pnlHeader.Dock = DockStyle.Top;   // Buộc neo lên đỉnh (Full Width)

                foreach (Control c in pnlHeader.Controls)
                {
                    if (c is Label)
                    {
                        c.AutoSize = false;
                        c.Dock = DockStyle.Fill;
                        ((Label)c).TextAlign = ContentAlignment.MiddleCenter;
                    }
                }
            }

            // --- CẤU HÌNH PANEL NÚT ---
            if (pnlControl != null)
            {
                pnlControl.AutoSize = false;      // Tắt tự động co giãn 
                pnlControl.Dock = DockStyle.Top;  // Buộc neo lên đỉnh (Full Width)
                pnlControl.Height = 70;           // Đặt chiều cao cố định cho đẹp 
            }

            // --- CẤU HÌNH GRID ---
            dtgvKhachHang.AutoSize = false;
            dtgvKhachHang.Dock = DockStyle.Fill;


            // 1. Grid xuống đáy cùng
            dtgvKhachHang.BringToFront();

            // 2. Header đè lên Panel Nút (Nằm cao nhất)
            if (pnlControl != null) pnlControl.SendToBack();

            // 3. Panel Nút đè lên Grid
            if (pnlHeader != null) pnlHeader.SendToBack();


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemKhachHang f = new frmThemKhachHang();

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadKhachHang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvKhachHang.CurrentRow == null) return;

            string maKH = dtgvKhachHang.CurrentRow.Cells["MaKH"].Value.ToString();

            frmThemKhachHang f = new frmThemKhachHang(maKH);

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadKhachHang();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa khách hàng?",
                "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string maKH = dtgvKhachHang.CurrentRow.Cells["MaKH"].Value.ToString();

                var kh = context.KhachHang.Find(maKH);

                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                    context.SaveChanges();
                }

                LoadKhachHang();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();

            var result = dsKhachHangCache
                .Where(k =>
                    (k.TenKH ?? "").ToLower().Contains(keyword) ||
                    (k.SDT ?? "").Contains(keyword)
                )
                .ToList();

            BindData(result);
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender ,e);
        }
    }
}
