using System.Drawing;
using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyQuanCaPhe.Data;
using static QuanLyQuanCaPhe.Data.HoaDon;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmHoaDon : Form
    {

        QLCPDbContext context = new QLCPDbContext();

        List<DanhSachHoaDon> dsHoaDonCache = new List<DanhSachHoaDon>();


        public frmHoaDon()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dtgvHoaDon.AutoGenerateColumns = false;
            SetupLayout();

            LoadHoaDon();
        }

        void LoadHoaDon()
        {
            dsHoaDonCache = context.HoaDon
                .Select(h => new DanhSachHoaDon
                {
                    MaHD = h.MaHD,
                    NgayLap = h.NgayLap,

                    TenKH = h.KhachHang != null ? h.KhachHang.TenKH : "Khách lẻ",
                    TenNV = h.NhanVien.HoTen,
                    TenBan = h.Ban.TenBan,

                    TongTien = h.TongTien,
                    TrangThai = h.TrangThai
                })
                .ToList();

            BindData(dsHoaDonCache);
        }

        void BindData(List<DanhSachHoaDon> data)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data;
            dtgvHoaDon.DataSource = bs;
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
            dtgvHoaDon.AutoSize = false;
            dtgvHoaDon.Dock = DockStyle.Fill;


            // 1. Grid xuống đáy cùng
            dtgvHoaDon.BringToFront();

            // 2. Header đè lên Panel Nút (Nằm cao nhất)
            if (pnlControl != null) pnlControl.SendToBack();

            // 3. Panel Nút đè lên Grid
            if (pnlHeader != null) pnlHeader.SendToBack();

        }

        private void dtgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvHoaDon.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                string maHD = dtgvHoaDon.Rows[e.RowIndex]
                    .Cells["MaHD"].Value.ToString();

                frmChiTietHoaDon f = new frmChiTietHoaDon(maHD);
                f.ShowDialog();
            }
        }
    }
}
