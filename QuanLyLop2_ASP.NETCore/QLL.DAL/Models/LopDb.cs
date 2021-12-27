using System;
using System.Collections.Generic;

namespace QLL.DAL.Models
{
    public partial class LopDb
    {
        public LopDb()
        {
            HocSinhDbs = new HashSet<HocSinhDb>();
            Tkbctdbs = new HashSet<Tkbctdb>();
            MaKhs = new HashSet<KhoaHocDb>();
        }

        public int MaLop { get; set; }
        public string TenLop { get; set; } = null!;
        public string? MoTa { get; set; }
        public string PhongHoc { get; set; } = null!;
        public string TrangThai { get; set; } = null!;

        public virtual ICollection<HocSinhDb> HocSinhDbs { get; set; }
        public virtual ICollection<Tkbctdb> Tkbctdbs { get; set; }

        public virtual ICollection<KhoaHocDb> MaKhs { get; set; }
    }
}
