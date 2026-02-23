using QuanLyQuanCaPhe.Data;
using QuanLyQuanCaPhe.Services;
using Microsoft.EntityFrameworkCore;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmPOS : Form
    {
        private QLCPDbContext context = new QLCPDbContext();
        private HoaDonService _hoaDonService = new HoaDonService();

        private List<ChiTietHoaDon> cart = new List<ChiTietHoaDon>();

        private int _idBan;
        private string _tenBan;
        private string _trangThai;
        private string _maHD;

        public frmPOS(int idBan, string tenBan, string trangThai)
        {
            InitializeComponent();

            _idBan = idBan;
            _tenBan = tenBan;
            _trangThai = trangThai ?? "Trống";

            lblTenBan.Text = $"BÀN: {_tenBan}";

            SetupListView();
            LoadMenu();

            if (_trangThai != "Trống")
            {
                LoadCartFromDB();
                btnLuuHoaDon.Text = "THANH TOÁN";
            }
        }

        // ================= MENU =================
        private void LoadMenu()
        {
            tlpMenu.Controls.Clear();

            var listSP = context.SanPham.ToList();

            int col = 0, row = 0;

            foreach (var sp in listSP)
            {
                if (col == 0)
                {
                    tlpMenu.RowCount++;
                    tlpMenu.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }

                Button btn = new Button();
                btn.Text = $"{sp.TenSP}\n{sp.DonGia:#,0}đ";
                btn.Tag = sp;
                btn.Height = 80;
                btn.Dock = DockStyle.Fill;

                btn.Click += (s, e) => AddToCart(sp);

                tlpMenu.Controls.Add(btn, col, row);

                col++;
                if (col >= 3)
                {
                    col = 0;
                    row++;
                }
            }
        }

        // ================= CART =================
        private void SetupListView()
        {
            lstGioHang.View = View.Details;
            lstGioHang.FullRowSelect = true;
            lstGioHang.GridLines = true;

            lstGioHang.Columns.Clear();
            lstGioHang.Columns.Add("Mã SP", 80);
            lstGioHang.Columns.Add("Tên SP", 150);
            lstGioHang.Columns.Add("SL", 50);
            lstGioHang.Columns.Add("Đơn Giá", 100);
            lstGioHang.Columns.Add("Thành Tiền", 120);
        }

        private void RefreshCart()
        {
            lstGioHang.Items.Clear();

            foreach (var it in cart)
            {
                var sp = context.SanPham.Find(it.MaSP);

                ListViewItem lvi = new ListViewItem(it.MaSP);
                lvi.SubItems.Add(sp?.TenSP ?? "");
                lvi.SubItems.Add(it.SoLuong.ToString());
                lvi.SubItems.Add(it.DonGia.ToString("#,0"));
                lvi.SubItems.Add((it.ThanhTien ?? 0).ToString("#,0"));

                lstGioHang.Items.Add(lvi);
            }

            UpdateTotals();
        }

        private void AddToCart(SanPham sp)
        {
            var exist = cart.FirstOrDefault(x => x.MaSP == sp.MaSP);

            if (exist != null)
            {
                exist.SoLuong++;
                exist.ThanhTien = exist.SoLuong * exist.DonGia;
            }
            else
            {
                cart.Add(new ChiTietHoaDon
                {
                    MaSP = sp.MaSP,
                    SoLuong = 1,
                    DonGia = sp.DonGia,
                    ThanhTien = sp.DonGia
                });
            }

            RefreshCart();
        }

        private void LoadCartFromDB()
        {
            var list = context.ChiTietHoaDon
                .Where(x => x.HoaDon.idBan == _idBan && x.HoaDon.TrangThai == "Đang phục vụ")
                .Include(x => x.SanPham)
                .ToList();

            cart = list;
            RefreshCart();
        }

        // ================= TOTAL =================
        private void UpdateTotals()
        {
            decimal tong = cart.Sum(x => x.ThanhTien ?? 0);
            txtTongCong.Text = tong.ToString("#,0");

            int diem = 0;
            int.TryParse(txtDiemTichLuy.Text, out diem);

            decimal giamGia = chkSuDungDiem.Checked ? diem * 5000m : 0;
                
            txtDiemGiamGia.Text = giamGia.ToString("#,0");

            decimal khachTra = Math.Max(0, tong - giamGia);
            txtKhachCanTra.Text = khachTra.ToString("#,0");
        }

        private void chkSuDungDiem_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        // ================= BUTTON =================

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Giỏ hàng rỗng");
                return;
            }

            string message;

            if (_trangThai == "Trống")
            {
                bool ok = _hoaDonService.CreateHoaDonTam(
                    _idBan,
                    "NV001",
                    null,
                    cart,
                    out _maHD,
                    out message
                );

                MessageBox.Show(message);


                if (ok)
                {
                    _trangThai = "Có người";
                    btnLuuHoaDon.Text = "THANH TOÁN";
                }
            }
            else
            {
                bool ok = _hoaDonService.ThanhToanHoaDon(
                    _idBan,
                    cart,
                    out message
                );

                MessageBox.Show(message);

                if (ok)
                {
                    cart.Clear();
                    RefreshCart();
                    this.Close();
                }
            }
            
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            cart.Clear();
            RefreshCart();
        }

        private void btnquayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}