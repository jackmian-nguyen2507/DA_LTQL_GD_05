using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Configuration;


namespace QuanLyQuanCaPhe.Data
{
    public class QLCPDbContext : DbContext
    {
        public DbSet<Ban> Ban { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<LoaiSanPham> LoaiSanPham { get; set; }
        public DbSet<CongThuc> CongThuc { get; set; }
        public DbSet<NguyenLieu> NguyenLieu { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<DonVi> DonVi { get; set; }
        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        public DbSet<ChamCong> ChamCong { get; set; }
        public DbSet<CaLam> CaLam { get; set; }
        public DbSet<BangLuong> BangLuong { get; set; }

        public DbSet<InventoryMovements> InventoryMovements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                ConfigurationManager.ConnectionStrings["QLCPConnection"].ConnectionString
            );
        }

        // Mapping API

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban>(entity =>
            {
                entity.ToTable("Ban");

                entity.HasKey(e => e.ID);

                entity.Property(e => e.ID)
                      .ValueGeneratedOnAdd();

                entity.Property(e => e.TenBan)
                      .IsRequired()
                      .HasMaxLength(200)
                      .HasDefaultValue("Bàn mới");

                entity.Property(e => e.TrangThai)
                      .IsRequired()
                      .HasMaxLength(100)
                      .HasDefaultValue("Trống");
            });


            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.ToTable("HoaDon");

                entity.HasKey(e => e.MaHD);

                entity.Property(e => e.MaHD)
                      .HasColumnType("char(8)")
                      .IsRequired();

                entity.Property(e => e.NgayLap)
                      .HasDefaultValueSql("getdate()");

                entity.Property(e => e.MaNV)
                      .HasColumnType("char(6)")
                      .IsRequired();

                entity.Property(e => e.MaKH)
                      .HasColumnType("char(6)");

                entity.Property(e => e.TongTien)
                      .HasColumnType("decimal(12,2)")
                      .HasDefaultValue(0m);


                entity.Property(e => e.GiamGia)
                      .HasColumnType("decimal(18,2)")
                      .HasDefaultValue(0m);

                entity.Property(e => e.TrangThai)
                      .HasMaxLength(40)
                      .HasDefaultValue("Chưa thanh toán");

                entity.Property(e => e.GhiChu)
                      .HasMaxLength(510);

                // FK -> Ban
                entity.HasOne(d => d.Ban)
                      .WithMany(p => p.HoaDon)
                      .HasForeignKey(d => d.idBan)
                      .OnDelete(DeleteBehavior.NoAction);

                // FK -> KhachHang
                entity.HasOne(d => d.KhachHang)
                      .WithMany(p => p.HoaDon)
                      .HasForeignKey(d => d.MaKH)
                      .OnDelete(DeleteBehavior.NoAction);

                // FK -> NhanVien
                entity.HasOne(d => d.NhanVien)
                      .WithMany(p => p.HoaDon)
                      .HasForeignKey(d => d.MaNV)
                      .OnDelete(DeleteBehavior.NoAction);

                // INDEX
                entity.HasIndex(e => e.MaNV)
                      .HasDatabaseName("IX_HoaDon_MaNV_v2");

                entity.HasIndex(e => e.MaKH)
                      .HasDatabaseName("IX_HoaDon_MaKH_v2");

                entity.HasIndex(e => e.idBan)
                      .HasDatabaseName("IX_HoaDon_idBan_v2");

                entity.HasIndex(e => e.NgayLap)
                      .HasDatabaseName("IX_HoaDon_NgayLap_v2");

            });
            modelBuilder.Entity<ChiTietHoaDon>(entity =>
            {
                entity.ToTable("ChiTietHoaDon");

                entity.HasKey(e => e.ChiTietID);

                entity.Property(e => e.ChiTietID)
                      .ValueGeneratedOnAdd();

                entity.Property(e => e.MaHD)
                      .HasColumnType("char(8)")
                      .IsRequired();

                entity.Property(e => e.MaSP)
                      .HasColumnType("char(6)")
                      .IsRequired();

                entity.Property(e => e.SoLuong)
                      .IsRequired();

                entity.Property(e => e.DonGia)
                      .HasColumnType("decimal(12,2)")
                      .IsRequired();

                // ThanhTien là computed column (SQL tính)
                entity.Property(e => e.ThanhTien)
                      .HasColumnType("decimal(23,2)")
                      .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.GhiChu)
                      .HasMaxLength(200);

                // FK -> HoaDon
                entity.HasOne(d => d.HoaDon)
                      .WithMany(p => p.ChiTietHoaDon)
                      .HasForeignKey(d => d.MaHD)
                      .OnDelete(DeleteBehavior.Cascade);


                // FK -> SanPham
                entity.HasOne(d => d.SanPham)
                      .WithMany(p => p.ChiTietHoaDon)
                      .HasForeignKey(d => d.MaSP)
                      .OnDelete(DeleteBehavior.NoAction);

                // INDEX
                entity.HasIndex(e => e.MaHD)
                      .HasDatabaseName("IX_CTHD_MaHD_v2");

                // Composite
                entity.HasIndex(e => new { e.MaHD, e.MaSP })
                      .HasDatabaseName("IX_CTHD_MaHD_MaSP_v2");

            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.ToTable("SanPham");

                entity.HasKey(e => e.MaSP);

                entity.Property(e => e.MaSP)
                      .HasColumnType("char(6)")
                      .IsRequired();

                entity.Property(e => e.TenSP)
                      .IsRequired()
                      .HasMaxLength(300);

                entity.Property(e => e.DonGia)
                      .HasColumnType("decimal(12,2)")
                      .HasDefaultValue(0);

                entity.Property(e => e.TrangThai)
                      .HasMaxLength(40)
                      .HasDefaultValue("Còn bán");

                entity.Property(e => e.ImagePath)
                      .HasMaxLength(510);

                entity.HasOne(e => e.LoaiSanPham)
                      .WithMany(l => l.SanPham)
                      .HasForeignKey(e => e.MaLoai)
                      .OnDelete(DeleteBehavior.NoAction);

                // INDEX
                entity.HasIndex(e => e.MaLoai)
                      .HasDatabaseName("IX_SanPham_MaLoai_v2");
            });

            modelBuilder.Entity<LoaiSanPham>(entity =>
            {
                entity.ToTable("LoaiSanPham");

                entity.HasKey(e => e.MaLoai);  

                entity.Property(e => e.MaLoai)
                      .ValueGeneratedOnAdd();

                entity.Property(e => e.TenLoai)
                      .IsRequired()
                      .HasMaxLength(100);
            });


            modelBuilder.Entity<CongThuc>(entity =>
            {
                entity.ToTable("CongThuc");

                entity.HasKey(e => e.MaCT);

                entity.Property(e => e.MaCT)
                      .ValueGeneratedOnAdd();

                entity.Property(e => e.MaSP)
                      .HasColumnType("char(6)")
                      .IsRequired();

                entity.Property(e => e.MaNL)
                      .HasColumnType("char(6)")
                      .IsRequired();

                entity.Property(e => e.SoLuong)
                      .HasColumnType("decimal(12,3)")
                      .IsRequired();

                // FK -> SanPham
                entity.HasOne(d => d.SanPham)
                      .WithMany(p => p.CongThuc)
                      .HasForeignKey(d => d.MaSP)
                      .OnDelete(DeleteBehavior.NoAction);

                // FK -> NguyenLieu
                entity.HasOne(d => d.NguyenLieu)
                      .WithMany(p => p.CongThuc)
                      .HasForeignKey(d => d.MaNL)
                      .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<NguyenLieu>(entity =>
            {
                entity.ToTable("NguyenLieu");

                entity.HasKey(e => e.MaNL);

                entity.Property(e => e.MaNL)
                      .HasColumnType("char(6)")
                      .IsRequired();

                entity.Property(e => e.TenNL)
                      .HasMaxLength(300);

                entity.Property(e => e.MaDonVi)
                      .IsRequired();

                entity.Property(e => e.SoLuongTon)
                      .HasColumnType("decimal(12,3)")
                      .HasDefaultValue(0m);

                // 🔥 FK -> DonVi
                entity.HasOne(d => d.DonVi)
                      .WithMany(p => p.NguyenLieu)
                      .HasForeignKey(d => d.MaDonVi)
                      .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<DonVi>(entity =>
            {
                entity.ToTable("DonVi");

                entity.HasKey(e => e.MaDonVi);

                entity.Property(e => e.MaDonVi)
                      .ValueGeneratedOnAdd();

                entity.Property(e => e.TenDonVi)
                      .IsRequired()
                      .HasMaxLength(50);
            });

            modelBuilder.Entity<InventoryMovements>(entity =>
            {
                entity.ToTable("InventoryMovements");

                entity.HasKey(e => e.MovementID);

                entity.Property(e => e.MovementID)
                      .ValueGeneratedOnAdd();

                entity.Property(e => e.MaNL)
                      .HasColumnType("char(6)")
                      .IsRequired();

                entity.Property(e => e.ChangeQty)
                      .HasColumnType("decimal(12,3)")
                      .IsRequired();

                entity.Property(e => e.MovementType)
                      .HasMaxLength(510);

                entity.Property(e => e.RefMaHD)
                      .HasColumnType("char(8)");

                entity.Property(e => e.CreatedAt)
                      .HasDefaultValueSql("getdate()");

                // FK -> NguyenLieu (CASCADE)
                entity.HasOne(d => d.NguyenLieu)
                      .WithMany(p => p.InventoryMovements)
                      .HasForeignKey(d => d.MaNL)
                      .OnDelete(DeleteBehavior.Cascade);

                // FK -> HoaDon (NO ACTION)
                entity.HasOne(d => d.HoaDon)
                      .WithMany(p => p.InventoryMovements)
                      .HasForeignKey(d => d.RefMaHD)
                      .OnDelete(DeleteBehavior.NoAction);

                // INDEX
                entity.HasIndex(e => e.MaNL)
                      .HasDatabaseName("IX_IM_MaNL_v2");

                entity.HasIndex(e => e.RefMaHD)
                      .HasDatabaseName("IX_IM_RefMaHD_v2");

                entity.HasIndex(e => e.CreatedAt)
                      .HasDatabaseName("IX_IM_CreatedAt_v2");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.ToTable("KhachHang");

                entity.HasKey(e => e.MaKH);

                entity.Property(e => e.MaKH)
                      .HasColumnType("char(6)")
                      .IsRequired();

                entity.Property(e => e.TenKH)
                      .HasMaxLength(200);

                entity.Property(e => e.SDT)
                      .HasMaxLength(30);

                entity.Property(e => e.DiemTichLuy)
                      .HasDefaultValue(0);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.ToTable("NhanVien");

                entity.HasKey(e => e.MaNV);

                entity.Property(e => e.MaNV)
                      .HasColumnType("char(6)")
                      .IsRequired();

                entity.Property(e => e.HoTen)
                      .HasMaxLength(200);

                entity.Property(e => e.GioiTinh)
                      .HasMaxLength(20);

                entity.Property(e => e.ChucVu)
                      .HasMaxLength(100);

                entity.Property(e => e.LuongCoBan)
                      .HasColumnType("decimal(12,2)")
                      .HasDefaultValue(0m);

                entity.Property(e => e.TrangThai)
                      .HasMaxLength(40)
                      .HasDefaultValue("Đang làm");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.ToTable("TaiKhoan");

                entity.HasKey(e => e.TenDangNhap);

                entity.Property(e => e.TenDangNhap)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(e => e.MatKhauHash)
                      .HasMaxLength(512)
                      .IsRequired();

                entity.Property(e => e.Role)
                      .HasMaxLength(40)
                      .HasDefaultValue("Nhân viên");

                entity.Property(e => e.MaNV)
                      .HasColumnType("char(6)");

                entity.Property(e => e.CreatedAt)
                      .HasDefaultValueSql("getdate()");

                // FK -> NhanVien (1 - 1)
                entity.HasOne(d => d.NhanVien)
                      .WithOne(p => p.TaiKhoan)
                      .HasForeignKey<TaiKhoan>(d => d.MaNV)
                      .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<ChamCong>(entity =>
            {
                entity.ToTable("ChamCong");

                entity.HasKey(e => e.MaCham);

                entity.Property(e => e.MaCham)
                      .ValueGeneratedNever();

                entity.Property(e => e.MaNV)
                      .HasColumnType("char(6)")
                      .IsRequired();

                entity.Property(e => e.MaCa);

                entity.Property(e => e.NgayLam)
                      .HasColumnType("date")
                      .IsRequired();

                entity.Property(e => e.ClockIn)
                      .HasColumnType("datetime");

                entity.Property(e => e.ClockOut)
                      .HasColumnType("datetime");

                entity.Property(e => e.GhiChu)
                      .HasMaxLength(510);

                // FK -> NhanVien
                entity.HasOne(d => d.NhanVien)
                      .WithMany(p => p.ChamCong)
                      .HasForeignKey(d => d.MaNV)
                      .OnDelete(DeleteBehavior.NoAction);

                // FK -> CaLam
                entity.HasOne(d => d.CaLam)
                      .WithMany(p => p.ChamCong)
                      .HasForeignKey(d => d.MaCa)
                      .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<CaLam>(entity =>
            {
                entity.ToTable("CaLam");

                entity.HasKey(e => e.MaCa);

                entity.Property(e => e.MaCa)
                      .ValueGeneratedNever();

                entity.Property(e => e.TenCa)
                      .HasMaxLength(100);

                entity.Property(e => e.GioBatDau)
                      .HasColumnType("time");

                entity.Property(e => e.GioKetThuc)
                      .HasColumnType("time");
            });

            modelBuilder.Entity<BangLuong>(entity =>
            {
                entity.ToTable("BangLuong");

                entity.HasKey(e => e.MaLuong);

                entity.Property(e => e.MaLuong)
                      .ValueGeneratedOnAdd();

                entity.Property(e => e.MaNV)
                      .HasColumnType("char(6)")
                      .IsRequired();

                entity.Property(e => e.Thang)
                      .IsRequired();

                entity.Property(e => e.Nam)
                      .IsRequired();

                entity.Property(e => e.TongGio)
                      .HasColumnType("decimal(10,2)")
                      .HasDefaultValue(0m);

                entity.Property(e => e.LuongThucTe)
                      .HasColumnType("decimal(12,2)")
                      .HasDefaultValue(0m);

                entity.Property(e => e.TrangThai)
                      .HasMaxLength(40)
                      .HasDefaultValue("Chưa trả");

                // FK -> NhanVien
                entity.HasOne(d => d.NhanVien)
                      .WithMany(p => p.BangLuong)
                      .HasForeignKey(d => d.MaNV)
                      .OnDelete(DeleteBehavior.NoAction);
            });


        }
        

    }
}
