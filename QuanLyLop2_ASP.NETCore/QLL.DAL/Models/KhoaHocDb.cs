using System;
using System.Collections.Generic;

namespace QLL.DAL.Models
{
    public partial class KhoaHocDb
    {
        public KhoaHocDb()
        {
            Tkbdbs = new HashSet<Tkbdb>();
            MaLops = new HashSet<LopDb>();
        }

        public int MaKh { get; set; }
        public string TenKh { get; set; } = null!;
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }

        public virtual ICollection<Tkbdb> Tkbdbs { get; set; }

        public virtual ICollection<LopDb> MaLops { get; set; }
    }
}
