using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLyQuanCaPhe.Data;
using static QuanLyQuanCaPhe.Data.ChiTietHoaDon;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmChiTietHoaDon : Form
    {
        private string maHD ="";
        QLCPDbContext context = new QLCPDbContext();
        public frmChiTietHoaDon(string maHD)
        {
            InitializeComponent();
            this.maHD = maHD;
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            dtgvChiTiet.AutoGenerateColumns = false;
            dtgvChiTiet.ReadOnly = true;   

            LoadChiTietHoaDon();
            LoadThongTinHoaDon();
        }

        void LoadChiTietHoaDon()
        {
            var ds = context.ChiTietHoaDon
                .Where(ct => ct.MaHD == maHD)
                .Select(ct => new DanhSachChiTietHoaDon
                {
                    TenSP = ct.SanPham.TenSP,
                    SoLuong = ct.SoLuong,
                    DonGia = ct.DonGia,
                    ThanhTien = ct.ThanhTien,
                    GhiChu = ct.GhiChu
                })
                .ToList();

            dtgvChiTiet.DataSource = ds;
        }

        void LoadThongTinHoaDon()
        {
            var hd = context.HoaDon
                .Where(h => h.MaHD == maHD)
                .Select(h => new
                {
                    h.MaHD,
                    h.TongTien
                })
                .FirstOrDefault();

            if (hd != null)
            {
                // Hiển thị mã hóa đơn
                lblMaHDValue.Text = hd.MaHD;

                // Hiển thị tổng tiền (format đẹp)
                lblTongTienValue.Text = hd.TongTien.HasValue
                    ? string.Format("{0:N0} VNĐ", hd.TongTien)
                    : "0 VNĐ";
            }
        }


        private void dtgvChiTiet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgvChiTiet.Columns[e.ColumnIndex].Name == "DonGia" ||
                dtgvChiTiet.Columns[e.ColumnIndex].Name == "ThanhTien")
            {
                if (e.Value != null)
                {
                    e.Value = string.Format("{0:N0} VNĐ", e.Value);
                    e.FormattingApplied = true;
                }
            }
        }


        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
