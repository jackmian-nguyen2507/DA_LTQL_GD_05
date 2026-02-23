using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyQuanCaPhe.Migrations
{
    /// <inheritdoc />
    public partial class AddIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
    name: "IX_HoaDon_MaNV_v2",
    table: "HoaDon",
    column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaKH_v2",
                table: "HoaDon",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_idBan_v2",
                table: "HoaDon",
                column: "idBan");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_NgayLap_v2",
                table: "HoaDon",
                column: "NgayLap");

            // ChiTietHoaDon
            migrationBuilder.CreateIndex(
                name: "IX_CTHD_MaHD_v2",
                table: "ChiTietHoaDon",
                column: "MaHD");

            migrationBuilder.CreateIndex(
                name: "IX_CTHD_MaHD_MaSP_v2",
                table: "ChiTietHoaDon",
                columns: new[] { "MaHD", "MaSP" });

            // SanPham
            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaLoai_v2",
                table: "SanPham",
                column: "MaLoai");

            // InventoryMovements
            migrationBuilder.CreateIndex(
                name: "IX_IM_MaNL_v2",
                table: "InventoryMovements",
                column: "MaNL");

            migrationBuilder.CreateIndex(
                name: "IX_IM_RefMaHD_v2",
                table: "InventoryMovements",
                column: "RefMaHD");

            migrationBuilder.CreateIndex(
                name: "IX_IM_CreatedAt_v2",
                table: "InventoryMovements",
                column: "CreatedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex("IX_HoaDon_MaNV_v2", "HoaDon");
            migrationBuilder.DropIndex("IX_HoaDon_MaKH_v2", "HoaDon");
            migrationBuilder.DropIndex("IX_HoaDon_idBan_v2", "HoaDon");
            migrationBuilder.DropIndex("IX_HoaDon_NgayLap_v2", "HoaDon");

            migrationBuilder.DropIndex("IX_CTHD_MaHD_v2", "ChiTietHoaDon");
            migrationBuilder.DropIndex("IX_CTHD_MaHD_MaSP_v2", "ChiTietHoaDon");

            migrationBuilder.DropIndex("IX_SanPham_MaLoai_v2", "SanPham");

            migrationBuilder.DropIndex("IX_IM_MaNL_v2", "InventoryMovements");
            migrationBuilder.DropIndex("IX_IM_RefMaHD_v2", "InventoryMovements");
            migrationBuilder.DropIndex("IX_IM_CreatedAt_v2", "InventoryMovements");
        }
    }
}
