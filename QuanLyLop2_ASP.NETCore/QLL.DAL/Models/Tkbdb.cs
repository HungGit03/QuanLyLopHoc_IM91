using System;
using System.Collections.Generic;

namespace QLL.DAL.Models
{
    public partial class Tkbdb
    {
        public Tkbdb()
        {
            Tkbctdbs = new HashSet<Tkbctdb>();
        }

        public int MaTkb { get; set; }
        public int MaKh { get; set; }

        public virtual KhoaHocDb MaKhNavigation { get; set; } = null!;
        public virtual ICollection<Tkbctdb> Tkbctdbs { get; set; }
    }
}
