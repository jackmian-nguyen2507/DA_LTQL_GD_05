using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyQuanCaPhe.Data
{
    public class NguyenLieu
    {
        public string MaNL { get; set; } = null!;
        public string? TenNL { get; set; }
        public int MaDonVi { get; set; }
        public virtual DonVi DonVi { get; set; }

        public decimal? SoLuongTon { get; set; }

        // Navigation
        public virtual ObservableCollectionListSource<CongThuc> CongThuc { get; } = new();
        public virtual ObservableCollectionListSource<InventoryMovements> InventoryMovements { get; } = new();


        [NotMapped]
        public class DanhSachNguyenLieu
        {
            public string MaNL { get; set; }
            public string TenNL { get; set; }
            public string TenDonVi { get; set; }
            public decimal? SoLuongTon { get; set; }
        }
    }
}

