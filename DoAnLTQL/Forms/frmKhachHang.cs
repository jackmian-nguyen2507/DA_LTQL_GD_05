using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
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

        private void btnXuatKH_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Xuất Khách Hàng",
                Filter = "Excel (*.xlsx)|*.xlsx",
                FileName = $"KhachHang_{DateTime.Now:dd_MM_yyyy}.xlsx"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                var data = context.KhachHang.ToList();

                if (data.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất.");
                    return;
                }

                using (var wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("KhachHang");

                    // Header
                    ws.Cell(1, 1).Value = "MaKH";
                    ws.Cell(1, 2).Value = "TenKH";
                    ws.Cell(1, 3).Value = "SDT";
                    ws.Cell(1, 4).Value = "DiemTichLuy";

                    var header = ws.Range(1, 1, 1, 4);
                    header.Style.Font.Bold = true;
                    header.Style.Fill.BackgroundColor = XLColor.LightGray;

                    int row = 2;
                    foreach (var item in data)
                    {
                        ws.Cell(row, 1).Value = item.MaKH;
                        ws.Cell(row, 2).Value = item.TenKH;
                        ws.Cell(row, 3).Value = item.SDT;
                        ws.Cell(row, 4).Value = item.DiemTichLuy;
                        row++;
                    }

                    ws.Columns().AdjustToContents();
                    wb.SaveAs(sfd.FileName);
                }

                MessageBox.Show("Xuất Excel Khách Hàng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnNhapKH_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Nhập Khách Hàng",
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
                        // Header check
                        if (isFirstRow)
                        {
                            if (row.Cell(1).GetValue<string>().Trim() != "MaKH" ||
                                row.Cell(2).GetValue<string>().Trim() != "TenKH" ||
                                row.Cell(3).GetValue<string>().Trim() != "SDT" ||
                                row.Cell(4).GetValue<string>().Trim() != "DiemTichLuy")
                            {
                                throw new Exception("File Excel không đúng format (MaKH | TenKH | SDT | DiemTichLuy)");
                            }

                            isFirstRow = false;
                            continue;
                        }

                        // Đọc dữ liệu
                        string maKH = row.Cell(1).GetValue<string>().Trim();
                        string tenKH = row.Cell(2).GetValue<string>().Trim();
                        string sdt = row.Cell(3).GetValue<string>().Trim();
                        string diemStr = row.Cell(4).GetValue<string>().Trim();

                        // 🔹 Validate
                        if (string.IsNullOrWhiteSpace(maKH))
                        {
                            skipCount++;
                            continue;
                        }

                        int? diem = null;
                        if (int.TryParse(diemStr, out int d))
                            diem = d;

                        // Check tồn tại
                        var existing = context.KhachHang
                            .FirstOrDefault(x => x.MaKH == maKH);

                        if (existing != null)
                        {
                            // UPDATE
                            existing.TenKH = tenKH;
                            existing.SDT = sdt;
                            existing.DiemTichLuy = diem;
                            updateCount++;
                        }
                        else
                        {
                            // INSERT
                            context.KhachHang.Add(new KhachHang
                            {
                                MaKH = maKH,
                                TenKH = tenKH,
                                SDT = sdt,
                                DiemTichLuy = diem
                            });
                            insertCount++;
                        }
                    }

                    context.SaveChanges();

                    MessageBox.Show(
                        $"Insert: {insertCount}\nUpdate: {updateCount}\nBỏ qua: {skipCount}",
                        "Kết quả import Khách Hàng",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    frmKhachHang_Load(sender, e);
                }
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
