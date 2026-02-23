using Microsoft.EntityFrameworkCore;
using QuanLyQuanCaPhe.Data;

namespace QuanLyQuanCaPhe.Services
{
    public class HoaDonService
    {
        private readonly QLCPDbContext _context;

        public HoaDonService()
        {
            _context = new QLCPDbContext();
        }

        // Lấy danh sách hóa đơn
        public List<HoaDon.DanhSachHoaDon> GetDanhSachHoaDon()
        {
            return _context.HoaDon
                .Select(h => new HoaDon.DanhSachHoaDon
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
        }

        // Xóa hóa đơn
        public bool DeleteHoaDon(string maHD, out string message)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                var hoaDon = _context.HoaDon
                    .Include(h => h.ChiTietHoaDon)
                    .FirstOrDefault(h => h.MaHD == maHD);

                if (hoaDon == null)
                {
                    message = "Không tìm thấy hóa đơn";
                    return false;
                }

                // Xóa inventory liên quan 
                var movements = _context.InventoryMovements
                    .Where(m => m.RefMaHD == maHD)
                    .ToList();

                _context.InventoryMovements.RemoveRange(movements);

                _context.HoaDon.Remove(hoaDon);

                _context.SaveChanges();
                transaction.Commit();

                message = "Xóa thành công";
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                message = "Lỗi: " + ex.Message;
                return false;

            }
        }



        public bool CreateHoaDonTam(
        int idBan,
        string maNV,
        string maKH,
        List<ChiTietHoaDon> cart,
        out string maHD,
        out string message)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                if (cart == null || cart.Count == 0)
                {
                    message = "Giỏ hàng rỗng";
                    maHD = null;
                    return false;
                }

                maHD = "HD" + DateTime.Now.ToString("HHmmss");

                decimal tongTien = cart.Sum(x => x.ThanhTien ?? 0);

                var hoaDon = new HoaDon
                {
                    MaHD = maHD,
                    NgayLap = DateTime.Now,
                    MaNV = maNV,
                    MaKH = maKH,
                    TongTien = tongTien,
                    GiamGia = 0,
                    idBan = idBan,
                    TrangThai = "Đang phục vụ"
                };

                _context.HoaDon.Add(hoaDon);

                // Insert chi tiết
                foreach (var it in cart)
                {
                    _context.ChiTietHoaDon.Add(new ChiTietHoaDon
                    {
                        MaHD = maHD,
                        MaSP = it.MaSP,
                        SoLuong = it.SoLuong,
                        DonGia = it.DonGia,
                        ThanhTien = it.SoLuong * it.DonGia // đảm bảo luôn có giá trị
                    });
                }

                // Update bàn
                var ban = _context.Ban.Find(idBan);
                if (ban != null)
                {
                    ban.TrangThai = "Có người";
                }

                foreach (var item in cart)
                {
                    var exists = _context.SanPham.Any(x => x.MaSP == item.MaSP);

                    MessageBox.Show($"MaSP: [{item.MaSP}] - Exists: {exists}");
                }

                _context.SaveChanges();
                transaction.Commit();

                message = "Lưu hóa đơn thành công";
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                message = ex.Message;
                maHD = null;
                return false;
            }
        }

        public bool ThanhToanHoaDon(int idBan, List<ChiTietHoaDon> cart, out string message)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                var hoaDon = _context.HoaDon
                    .FirstOrDefault(h => h.idBan == idBan && h.TrangThai == "Đang phục vụ");

                if (hoaDon == null)
                {
                    message = "Không tìm thấy hóa đơn";
                    return false;
                }

                // XÓA CHI TIẾT CŨ
                var oldDetails = _context.ChiTietHoaDon
                    .Where(ct => ct.MaHD == hoaDon.MaHD);

                _context.ChiTietHoaDon.RemoveRange(oldDetails);

                // INSERT LẠI TỪ CART
                foreach (var item in cart)
                {
                    _context.ChiTietHoaDon.Add(new ChiTietHoaDon
                    {
                        MaHD = hoaDon.MaHD,
                        MaSP = item.MaSP,
                        SoLuong = item.SoLuong,
                        DonGia = item.DonGia,
                        ThanhTien = item.SoLuong * item.DonGia
                    });
                }

                // TÍNH TIỀN
                decimal tongTien = cart.Sum(x => (x.SoLuong * x.DonGia));

                // NẾU Có Giảm giá
                decimal giamGia = hoaDon.GiamGia ?? 0;

                hoaDon.TongTien = tongTien;
                hoaDon.GiamGia = giamGia;
                hoaDon.TrangThai = "Đã thanh toán";

                // Update bàn
                var ban = _context.Ban.Find(idBan);
                if (ban != null)
                {
                    ban.TrangThai = "Trống";
                }

                _context.SaveChanges();
                transaction.Commit();

                message = "Thanh toán thành công";
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                message = ex.Message;
                return false;
            }
        }

        public List<ChiTietHoaDon> GetCartByBan(int idBan)
        {
            var hoaDon = _context.HoaDon
                .FirstOrDefault(h => h.idBan == idBan && h.TrangThai == "Đang phục vụ");

            if (hoaDon == null) return new List<ChiTietHoaDon>();

            return _context.ChiTietHoaDon
                .Where(ct => ct.MaHD == hoaDon.MaHD)
                .ToList();
        }
    }
}