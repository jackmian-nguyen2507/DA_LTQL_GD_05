using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyQuanCaPhe.Data
{
    public class KhachHang
    {
        public string MaKH { get; set; } = null!;
        public string? TenKH { get; set; }
        public string? SDT { get; set; }
        public int? DiemTichLuy { get; set; }
        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();

        [NotMapped]
        public class DanhSachKhachHang
        {
            public string MaKH { get; set; }
            public string TenKH { get; set; }
            public string SDT { get; set; }
            public int? DiemTichLuy { get; set; }
        }

    }
}
