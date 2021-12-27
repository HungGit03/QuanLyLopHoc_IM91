using System;
using System.Collections.Generic;

namespace QLL.DAL.Models
{
    public partial class DiemDb
    {
        public int MaMh { get; set; }
        public string MaHs { get; set; } = null!;
        public double? Diem { get; set; }

        public virtual HocSinhDb MaHsNavigation { get; set; } = null!;
        public virtual MonHocDb MaMhNavigation { get; set; } = null!;
    }
}
