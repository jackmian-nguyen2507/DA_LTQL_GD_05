using System.Drawing;
using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyQuanCaPhe.Data;
using static QuanLyQuanCaPhe.Data.HoaDon;
using QuanLyQuanCaPhe.Services;
using ClosedXML.Excel;
using System.Linq;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmHoaDon : Form
    {

        QLCPDbContext context = new QLCPDbContext();
        HoaDonService hoaDonService = new HoaDonService();

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
            dsHoaDonCache = hoaDonService.GetDanhSachHoaDon();

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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvHoaDon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn!");
                return;
            }

            string maHD = dtgvHoaDon.CurrentRow.Cells["MaHD"].Value.ToString();

            var confirm = MessageBox.Show(
                $"Xóa hóa đơn {maHD}?",
                "Xác nhận",
                MessageBoxButtons.YesNo
            );

            if (confirm != DialogResult.Yes) return;

            string message;
            bool result = hoaDonService.DeleteHoaDon(maHD, out message);

            MessageBox.Show(message);

            if (result)
            {
                LoadHoaDon();
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Xuất Hóa Đơn (2 Sheets)",
                Filter = "Excel (*.xlsx)|*.xlsx",
                FileName = $"HoaDon_{DateTime.Now:dd_MM_yyyy}.xlsx"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                var dsHoaDon = context.HoaDon.ToList();
                var dsChiTiet = context.ChiTietHoaDon.ToList();

                using (var wb = new XLWorkbook())
                {
                    // Sheet 1: HoaDon
                    var wsHD = wb.Worksheets.Add("HoaDon");
                    wsHD.Cell(1, 1).Value = "MaHD";
                    wsHD.Cell(1, 2).Value = "idBan";
                    wsHD.Cell(1, 3).Value = "MaNV";
                    wsHD.Cell(1, 4).Value = "NgayLap";
                    wsHD.Cell(1, 5).Value = "TongTien";
                    wsHD.Cell(1, 6).Value = "GiamGia";
                    wsHD.Cell(1, 7).Value = "MaKH";
                    wsHD.Cell(1, 8).Value = "GhiChu";
                    wsHD.Cell(1, 9).Value = "TrangThai";

                    wsHD.Range(1, 1, 1, 9).Style.Font.Bold = true;
                    wsHD.Range(1, 1, 1, 9).Style.Fill.BackgroundColor = XLColor.LightGray;

                    int rHD = 2;
                    foreach (var hd in dsHoaDon)
                    {
                        wsHD.Cell(rHD, 1).Value = hd.MaHD;
                        wsHD.Cell(rHD, 2).Value = hd.idBan;
                        wsHD.Cell(rHD, 3).Value = hd.MaNV;
                        wsHD.Cell(rHD, 4).Value = hd.NgayLap;
                        wsHD.Cell(rHD, 5).Value = hd.TongTien;
                        wsHD.Cell(rHD, 6).Value = hd.GiamGia;
                        wsHD.Cell(rHD, 7).Value = hd.MaKH;
                        wsHD.Cell(rHD, 8).Value = hd.GhiChu;
                        wsHD.Cell(rHD, 9).Value = hd.TrangThai;
                        rHD++;
                    }
                    wsHD.Columns().AdjustToContents();

                    // Sheet 2: HoaDon_ChiTiet
                    var wsCT = wb.Worksheets.Add("HoaDon_ChiTiet");
                    wsCT.Cell(1, 1).Value = "ID";
                    wsCT.Cell(1, 2).Value = "MaHD";
                    wsCT.Cell(1, 3).Value = "MaSP";
                    wsCT.Cell(1, 4).Value = "SoLuong";
                    wsCT.Cell(1, 5).Value = "DonGia";

                    wsCT.Range(1, 1, 1, 5).Style.Font.Bold = true;
                    wsCT.Range(1, 1, 1, 5).Style.Fill.BackgroundColor = XLColor.LightBlue;

                    int rCT = 2;
                    foreach (var ct in dsChiTiet)
                    {
                        wsCT.Cell(rCT, 1).Value = ct.ChiTietID;
                        wsCT.Cell(rCT, 2).Value = ct.MaHD;
                        wsCT.Cell(rCT, 3).Value = ct.MaSP;
                        wsCT.Cell(rCT, 4).Value = ct.SoLuong;
                        wsCT.Cell(rCT, 5).Value = ct.DonGia;
                        rCT++;
                    }
                    wsCT.Columns().AdjustToContents();

                    wb.SaveAs(sfd.FileName);
                }
                MessageBox.Show("Xuất file Excel thành công gồm 2 sheet: HoaDon và HoaDon_ChiTiet", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất: " + ex.Message);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Nhập Hóa Đơn (2 Sheets)",
                Filter = "Excel (*.xlsx)|*.xlsx|Excel (*.xls)|*.xls"
            };

            if (ofd.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (var wb = new XLWorkbook(ofd.FileName))
                {
                    // 1. Nhập Sheet HoaDon
                    if (wb.Worksheets.Contains("HoaDon"))
                    {
                        var wsHD = wb.Worksheet("HoaDon");
                        bool isFirstHD = true;

                        foreach (var row in wsHD.RowsUsed())
                        {
                            if (isFirstHD) { isFirstHD = false; continue; }

                            string maHD = row.Cell(1).GetValue<string>().Trim();
                            if (string.IsNullOrEmpty(maHD)) continue;
                            
                            var existingHD = context.HoaDon.FirstOrDefault(h => h.MaHD == maHD);
                            if (existingHD == null)
                            {
                                int idBan; int.TryParse(row.Cell(2).GetValue<string>(), out idBan);
                                string maNV = row.Cell(3).GetValue<string>();
                                DateTime time; DateTime.TryParse(row.Cell(4).GetValue<string>(), out time);
                                decimal tong; decimal.TryParse(row.Cell(5).GetValue<string>(), out tong);
                                decimal km; decimal.TryParse(row.Cell(6).GetValue<string>(), out km);
                                string maKH = row.Cell(7).GetValue<string>();
                                string note = row.Cell(8).GetValue<string>();
                                string status = row.Cell(9).GetValue<string>();

                                context.HoaDon.Add(new HoaDon
                                {
                                    MaHD = maHD,
                                    idBan = idBan == 0 ? 1 : idBan,
                                    MaNV = string.IsNullOrEmpty(maNV) ? "NV01" : maNV,
                                    NgayLap = time,
                                    TongTien = tong, GiamGia = km, MaKH = maKH,
                                    GhiChu = note, TrangThai = status
                                });
                            }
                        }
                    }

                    // 2. Nhập Sheet HoaDon_ChiTiet
                    if (wb.Worksheets.Contains("HoaDon_ChiTiet"))
                    {
                        var wsCT = wb.Worksheet("HoaDon_ChiTiet");
                        bool isFirstCT = true;

                        foreach (var row in wsCT.RowsUsed())
                        {
                            if (isFirstCT) { isFirstCT = false; continue; }

                            string maHD = row.Cell(2).GetValue<string>().Trim();
                            string maSP = row.Cell(3).GetValue<string>().Trim();
                            if (string.IsNullOrEmpty(maHD) || string.IsNullOrEmpty(maSP)) continue;

                            var existingCT = context.ChiTietHoaDon.FirstOrDefault(ct => ct.MaHD == maHD && ct.MaSP == maSP);
                            if (existingCT == null)
                            {
                                int sl; int.TryParse(row.Cell(4).GetValue<string>(), out sl);
                                decimal dg; decimal.TryParse(row.Cell(5).GetValue<string>(), out dg);

                                context.ChiTietHoaDon.Add(new ChiTietHoaDon
                                {
                                    MaHD = maHD,
                                    MaSP = maSP,
                                    SoLuong = sl,
                                    DonGia = dg
                                });
                            }
                        }
                    }

                    context.SaveChanges();
                    MessageBox.Show("Nhập dữ liệu Hóa Đơn và Chi Tiết Hóa Đơn hoàn tất!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHoaDon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nhập: " + ex.Message);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
