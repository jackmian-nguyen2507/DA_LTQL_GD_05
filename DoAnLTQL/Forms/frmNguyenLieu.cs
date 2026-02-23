using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanCaPhe.Data;
using ClosedXML.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmNguyenLieu : Form
    {
        QLCPDbContext context = new QLCPDbContext();

        List<NguyenLieu.DanhSachNguyenLieu> dsNguyenLieuCache
                                            = new List<NguyenLieu.DanhSachNguyenLieu>();

        public frmNguyenLieu()
        {
            InitializeComponent();
            SetupLayout();
        }


        private void frmNguyenLieu_Load(object sender, EventArgs e)
        {
            dtgvNguyenLieu.AutoGenerateColumns = false;
            LoadNguyenLieu();
        }

        void LoadNguyenLieu()
        {
            dsNguyenLieuCache = context.NguyenLieu
                .Include(nl => nl.DonVi)
                .Select(nl => new NguyenLieu.DanhSachNguyenLieu
                {
                    MaNL = nl.MaNL,
                    TenNL = nl.TenNL,
                    TenDonVi = nl.DonVi != null ? nl.DonVi.TenDonVi : "",
                    SoLuongTon = nl.SoLuongTon
                }).ToList();

            BindData(dsNguyenLieuCache);
        }

        void BindData(List<NguyenLieu.DanhSachNguyenLieu> data)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data;
            dtgvNguyenLieu.DataSource = bs;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();

            var result = dsNguyenLieuCache
                .Where(nl =>
                    (nl.TenNL ?? "").ToLower().Contains(keyword) ||
                    (nl.TenDonVi ?? "").ToLower().Contains(keyword)
                )
                .ToList();

            BindData(result);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNguyenLieu f = new frmThemNguyenLieu();

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadNguyenLieu();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nguyên liệu?",
                "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string maNL = dtgvNguyenLieu.CurrentRow.Cells["MaNL"].Value.ToString();

                var nl = context.NguyenLieu.Find(maNL);

                if (nl != null)
                {
                    context.NguyenLieu.Remove(nl);
                    context.SaveChanges();
                }

                LoadNguyenLieu();
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadNguyenLieu();
        }

        // =============================
        // 1. Setup Layout (Fullscreen)
        // =============================
        private void SetupLayout()
        {
            this.WindowState = FormWindowState.Maximized;

            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 80;

            panelControl.Dock = DockStyle.Top;
            panelControl.Height = 80;

            dtgvNguyenLieu.Dock = DockStyle.Fill;

            // Tô màu đều 2 panel
            pnlHeader.BackColor = Color.FromArgb(92, 58, 46);
            panelControl.BackColor = Color.FromArgb(246, 236, 210);

            // Tự căn label + icon trong header
            pictureBox1.Left = (pnlHeader.Width / 2) - 150;
            pictureBox1.Top = 18;

            lblQLNL.Left = pictureBox1.Right + 15;
            lblQLNL.Top = 20;

            pnlHeader.Resize += (s, e) =>
            {
                pictureBox1.Left = (pnlHeader.Width / 2) - 150;
                lblQLNL.Left = pictureBox1.Right + 15;
            };
        }

        private void dtgvNguyenLieu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgvNguyenLieu.Columns[e.ColumnIndex].Name == "SoLuongTon")
            {
                if (e.Value != null)
                {
                    e.Value = string.Format("{0:N2}", e.Value);
                    e.FormattingApplied = true;
                }
            }

        }

        private void btnDieuChinh_Click(object sender, EventArgs e)
        {
            if (dtgvNguyenLieu.CurrentRow == null) return;

            string maNL = dtgvNguyenLieu.CurrentRow.Cells["MaNL"].Value.ToString();

            frmDieuChinhNguyenLieu f = new frmDieuChinhNguyenLieu(maNL);

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadNguyenLieu();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvNguyenLieu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần sửa!");
                return;
            }

            string maNL = dtgvNguyenLieu.CurrentRow.Cells["MaNL"].Value.ToString();

            frmThemNguyenLieu f = new frmThemNguyenLieu(maNL);

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadNguyenLieu();
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Nhập Nguyên Liệu",
                Filter = "Excel (*.xlsx)|*.xlsx|Excel (*.xls)|*.xls"
            };

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using (var wb = new XLWorkbook(ofd.FileName))
                {
                    var ws = wb.Worksheet(1);
                    var rows = ws.RowsUsed();

                    bool isFirstRow = true;
                    int insertCount = 0;
                    int updateCount = 0;
                    int skipCount = 0;

                    foreach (var row in rows)
                    {
                        if (isFirstRow)
                        {
                            if (row.Cell(1).GetValue<string>().Trim() != "MaNL" ||
                                row.Cell(2).GetValue<string>().Trim() != "TenNL" ||
                                row.Cell(3).GetValue<string>().Trim() != "MaDonVi" ||
                                row.Cell(4).GetValue<string>().Trim() != "SoLuongTon")
                            {
                                throw new Exception("File Excel không đúng format (MaNL | TenNL | MaDonVi | SoLuongTon)");
                            }
                            isFirstRow = false;
                            continue;
                        }

                        string maNL = row.Cell(1).GetValue<string>().Trim();
                        string tenNL = row.Cell(2).GetValue<string>().Trim();
                        string maDonViStr = row.Cell(3).GetValue<string>().Trim();
                        string soLuongStr = row.Cell(4).GetValue<string>().Trim();

                        if (string.IsNullOrWhiteSpace(maNL))
                        {
                            skipCount++;
                            continue;
                        }

                        int? maDonVi = null;
                        if (int.TryParse(maDonViStr, out int dv))
                            maDonVi = dv;

                        decimal soLuong = 0;
                        if (decimal.TryParse(soLuongStr, out decimal sl))
                            soLuong = sl;

                        var existing = context.NguyenLieu.FirstOrDefault(x => x.MaNL == maNL);

                        if (existing != null)
                        {
                            existing.TenNL = tenNL;
                            if (maDonVi.HasValue) existing.MaDonVi = maDonVi.Value;
                            existing.SoLuongTon = soLuong;
                            updateCount++;
                        }
                        else
                        {
                            context.NguyenLieu.Add(new NguyenLieu
                            {
                                MaNL = maNL,
                                TenNL = tenNL,
                                MaDonVi = maDonVi ?? 1, // Default fallback if not provided but required
                                SoLuongTon = soLuong
                            });
                            insertCount++;
                        }
                    }

                    context.SaveChanges();
                    MessageBox.Show($"Insert: {insertCount}\nUpdate: {updateCount}\nBỏ qua: {skipCount}", "Kết quả import Nguyên Liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNguyenLieu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Xuất Nguyên Liệu",
                Filter = "Excel (*.xlsx)|*.xlsx",
                FileName = $"NguyenLieu_{DateTime.Now:dd_MM_yyyy}.xlsx"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                var data = context.NguyenLieu.ToList();

                if (data.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất.");
                    return;
                }

                using (var wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("NguyenLieu");

                    ws.Cell(1, 1).Value = "MaNL";
                    ws.Cell(1, 2).Value = "TenNL";
                    ws.Cell(1, 3).Value = "MaDonVi";
                    ws.Cell(1, 4).Value = "SoLuongTon";

                    var header = ws.Range(1, 1, 1, 4);
                    header.Style.Font.Bold = true;
                    header.Style.Fill.BackgroundColor = XLColor.LightGray;

                    int row = 2;
                    foreach (var item in data)
                    {
                        ws.Cell(row, 1).Value = item.MaNL;
                        ws.Cell(row, 2).Value = item.TenNL;
                        ws.Cell(row, 3).Value = item.MaDonVi;
                        ws.Cell(row, 4).Value = item.SoLuongTon;
                        row++;
                    }

                    ws.Columns().AdjustToContents();
                    wb.SaveAs(sfd.FileName);
                }

                MessageBox.Show("Xuất Excel Nguyên Liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
