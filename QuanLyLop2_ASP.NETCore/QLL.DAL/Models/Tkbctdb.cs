using System;
using System.Collections.Generic;

namespace QLL.DAL.Models
{
    public partial class Tkbctdb
    {
        public int MaTkb { get; set; }
        public int Malop { get; set; }
        public int Thu { get; set; }
        public int Tiet { get; set; }
        public int MaMh { get; set; }
        public string MaGv { get; set; } = null!;

        public virtual GiaoVienDb MaGvNavigation { get; set; } = null!;
        public virtual MonHocDb MaMhNavigation { get; set; } = null!;
        public virtual Tkbdb MaTkbNavigation { get; set; } = null!;
        public virtual LopDb MalopNavigation { get; set; } = null!;
    }
}
