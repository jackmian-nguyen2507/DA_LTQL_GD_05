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
    }
}
