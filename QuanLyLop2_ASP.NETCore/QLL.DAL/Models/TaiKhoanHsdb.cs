using System;
using System.Collections.Generic;

namespace QLL.DAL.Models
{
    public partial class TaiKhoanHsdb
    {
        public int MaTk { get; set; }
        public string? MaHs { get; set; }
        public string TenDangNhap { get; set; } = null!;
        public string MatKhau { get; set; } = null!;

        public virtual HocSinhDb? MaHsNavigation { get; set; }
    }
}
