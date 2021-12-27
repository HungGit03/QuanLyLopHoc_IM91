using System;
using System.Collections.Generic;

namespace QLL.DAL.Models
{
    public partial class HocSinhDb
    {
        public HocSinhDb()
        {
            DiemDbs = new HashSet<DiemDb>();
        }

        public string MaHs { get; set; } = null!;
        public string TenHs { get; set; } = null!;
        public string GioiTinh { get; set; } = null!;
        public DateTime NamSinh { get; set; }
        public string DiaChi { get; set; } = null!;
        public double? Sdt { get; set; }
        public string? Email { get; set; }
        public int MaLop { get; set; }

        public virtual LopDb MaLopNavigation { get; set; } = null!;
        public virtual TaiKhoanHsdb? TaiKhoanHsdb { get; set; }
        public virtual ICollection<DiemDb> DiemDbs { get; set; }
    }
}
