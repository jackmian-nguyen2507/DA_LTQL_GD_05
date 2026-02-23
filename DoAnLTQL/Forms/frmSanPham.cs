using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using QuanLyQuanCaPhe.Data;
using static QuanLyQuanCaPhe.Data.SanPham;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmSanPham : Form
    {
        QLCPDbContext context = new QLCPDbContext();
        string imagesFolder = Path.Combine(Application.StartupPath, "Images");
        List<DanhSachSanPham> dsSanPhamCache = new List<DanhSachSanPham>(); //Khởi tạo cache để lưu toàn bộ danh sách -> dùng cho textchange để tìm kiếm sản phẩm 

        public frmSanPham()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Tự động phóng to
            this.StartPosition = FormStartPosition.CenterScreen; // Căn giữa màn hình

            SetupLayout();
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dtgvSanPham.AutoGenerateColumns = false;
            dtgvSanPham.RowTemplate.Height = 50;
            LoadSanPham();

            DataGridViewImageColumn col =
                (DataGridViewImageColumn)dtgvSanPham.Columns["HinhAnh"];

            col.ImageLayout = DataGridViewImageCellLayout.Zoom;
            col.ValueType = typeof(object);
        }

        void LoadSanPham()
        {
            SetupLayout();
            dsSanPhamCache = context.SanPham
            .Select(r => new DanhSachSanPham
            {
                MaSP = r.MaSP,
                TenSP = r.TenSP,
                MaLoai = r.MaLoai,
                TenLoai = r.LoaiSanPham.TenLoai,
                DonGia = r.DonGia,
                TrangThai = r.TrangThai,
                ImagePath = r.ImagePath
            })
            .ToList();

            BindData(dsSanPhamCache);
        }

        void BindData(List<DanhSachSanPham> data)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data;
            dtgvSanPham.DataSource = bs;
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
            dtgvSanPham.AutoSize = false;
            dtgvSanPham.Dock = DockStyle.Fill;


            // 1. Grid xuống đáy cùng
            dtgvSanPham.BringToFront();

            // 2. Header đè lên Panel Nút (Nằm cao nhất)
            if (pnlControl != null) pnlControl.SendToBack();

            // 3. Panel Nút đè lên Grid
            if (pnlHeader != null) pnlHeader.SendToBack();


        }


        private void dtgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {


            if (dtgvSanPham.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                var sp = dtgvSanPham.Rows[e.RowIndex].DataBoundItem as DanhSachSanPham;

                if (sp == null || string.IsNullOrEmpty(sp.ImagePath))
                    return;

                if (string.IsNullOrEmpty(sp.ImagePath))
                {
                    e.Value = Image.FromFile(Path.Combine(imagesFolder, "placeholder.png"));
                    e.FormattingApplied = true;
                    return;
                }

                string filePath = Path.Combine(imagesFolder, sp.ImagePath);

                if (!File.Exists(filePath))
                    return;


                Console.WriteLine(filePath);

                try
                {
                    byte[] bytes = File.ReadAllBytes(filePath);

                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        Image img = Image.FromStream(ms);

                        e.Value = new Bitmap(img, 40, 40);
                    }
                }
                catch
                {
                    // bỏ qua nếu file lỗi
                }
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemSanPham f = new frmThemSanPham();

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadSanPham();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa sản phẩm " +
                dtgvSanPham.CurrentRow.Cells["TenSP"].Value.ToString() + " ?",
                "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maSP = dtgvSanPham.CurrentRow.Cells["MaSP"].Value.ToString();

                SanPham sp = context.SanPham.Find(maSP);

                if (sp != null)
                {
                    context.SanPham.Remove(sp);
                }

                context.SaveChanges();

                frmSanPham_Load(sender, e);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvSanPham.CurrentRow == null) return;

            string maSP = dtgvSanPham.CurrentRow.Cells["MaSP"].Value.ToString();

            frmThemSanPham f = new frmThemSanPham(maSP); // truyền mã

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadSanPham();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();

            var result = dsSanPhamCache
                .Where(sp =>
                    sp.TenSP.ToLower().Contains(keyword) ||
                    sp.TenLoai.ToLower().Contains(keyword)
                )
                .ToList();

            BindData(result);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Nhập Sản Phẩm",
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
                            if (row.Cell(1).GetValue<string>().Trim() != "MaSP" ||
                                row.Cell(2).GetValue<string>().Trim() != "TenSP" ||
                                row.Cell(3).GetValue<string>().Trim() != "MaLoai" ||
                                row.Cell(4).GetValue<string>().Trim() != "DonGia" ||
                                row.Cell(5).GetValue<string>().Trim() != "TrangThai" ||
                                row.Cell(6).GetValue<string>().Trim() != "ImagePath")
                            {
                                throw new Exception("File Excel không đúng format (MaSP | TenSP | MaLoai | DonGia | TrangThai | ImagePath)");
                            }
                            isFirstRow = false;
                            continue;
                        }

                        string maSP = row.Cell(1).GetValue<string>().Trim();
                        string tenSP = row.Cell(2).GetValue<string>().Trim();
                        string maLoaiStr = row.Cell(3).GetValue<string>().Trim();
                        string donGiaStr = row.Cell(4).GetValue<string>().Trim();
                        string trangThaiStr = row.Cell(5).GetValue<string>().Trim();
                        string imagePath = row.Cell(6).GetValue<string>().Trim();

                        if (string.IsNullOrWhiteSpace(maSP))
                        {
                            skipCount++;
                            continue;
                        }

                        int? maLoai = null;
                        if (int.TryParse(maLoaiStr, out int ml)) maLoai = ml;

                        decimal donGia = 0;
                        if (decimal.TryParse(donGiaStr, out decimal dg)) donGia = dg;

                        string trangThai = trangThaiStr;

                        var existing = context.SanPham.FirstOrDefault(x => x.MaSP == maSP);

                        if (existing != null)
                        {
                            existing.TenSP = tenSP;
                            if (maLoai.HasValue) existing.MaLoai = maLoai.Value;
                            existing.DonGia = donGia;
                            existing.TrangThai = trangThai;
                            existing.ImagePath = imagePath;
                            updateCount++;
                        }
                        else
                        {
                            context.SanPham.Add(new QuanLyQuanCaPhe.Data.SanPham
                            {
                                MaSP = maSP,
                                TenSP = tenSP,
                                MaLoai = maLoai ?? 1, // fallback
                                DonGia = donGia,
                                TrangThai = trangThai,
                                ImagePath = imagePath
                            });
                            insertCount++;
                        }
                    }

                    context.SaveChanges();
                    MessageBox.Show($"Insert: {insertCount}\nUpdate: {updateCount}\nBỏ qua: {skipCount}", "Kết quả import Sản Phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSanPham();
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
                Title = "Xuất Sản Phẩm",
                Filter = "Excel (*.xlsx)|*.xlsx",
                FileName = $"SanPham_{DateTime.Now:dd_MM_yyyy}.xlsx"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                var data = context.SanPham.ToList();

                if (data.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất.");
                    return;
                }

                using (var wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("SanPham");

                    ws.Cell(1, 1).Value = "MaSP";
                    ws.Cell(1, 2).Value = "TenSP";
                    ws.Cell(1, 3).Value = "MaLoai";
                    ws.Cell(1, 4).Value = "DonGia";
                    ws.Cell(1, 5).Value = "TrangThai";
                    ws.Cell(1, 6).Value = "ImagePath";

                    var header = ws.Range(1, 1, 1, 6);
                    header.Style.Font.Bold = true;
                    header.Style.Fill.BackgroundColor = XLColor.LightGray;

                    int row = 2;
                    foreach (var item in data)
                    {
                        ws.Cell(row, 1).Value = item.MaSP;
                        ws.Cell(row, 2).Value = item.TenSP;
                        ws.Cell(row, 3).Value = item.MaLoai;
                        ws.Cell(row, 4).Value = item.DonGia;
                        ws.Cell(row, 5).Value = item.TrangThai;
                        ws.Cell(row, 6).Value = item.ImagePath;
                        row++;
                    }

                    ws.Columns().AdjustToContents();
                    wb.SaveAs(sfd.FileName);
                }

                MessageBox.Show("Xuất Excel Sản Phẩm thành công!");
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
