using System;
using System.Collections.Generic;

namespace QLL.DAL.Models
{
    public partial class MonHocDb
    {
        public MonHocDb()
        {
            DiemDbs = new HashSet<DiemDb>();
            Tkbctdbs = new HashSet<Tkbctdb>();
        }

        public int MaMh { get; set; }
        public string TenMh { get; set; } = null!;

        public virtual ICollection<DiemDb> DiemDbs { get; set; }
        public virtual ICollection<Tkbctdb> Tkbctdbs { get; set; }
    }
}
