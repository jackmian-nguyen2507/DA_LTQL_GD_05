using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyQuanCaPhe.Data
{
    public class DonVi
    {
        public int MaDonVi { get; set; }
        public string TenDonVi { get; set; }

        public virtual ICollection<NguyenLieu> NguyenLieu { get; set; } = new List<NguyenLieu>();
    }


    [NotMapped]
        public class DanhSachNguyenLieu
        {
            public string MaNL { get; set; }
            public string TenNL { get; set; }
            public string TenDonVi { get; set; }
            public decimal? SoLuongTon { get; set; }
        }
}