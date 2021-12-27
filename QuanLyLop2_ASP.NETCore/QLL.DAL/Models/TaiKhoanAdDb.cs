using System;
using System.Collections.Generic;

namespace QLL.DAL.Models
{
    public partial class TaiKhoanAdDb
    {
        public int MaTk { get; set; }
        public string MaAdmin { get; set; } = null!;
        public string TenDangNhap { get; set; } = null!;
        public string MatKhau { get; set; } = null!;

        public virtual AdminDb MaAdminNavigation { get; set; } = null!;
    }
}
