using System;
using System.Collections.Generic;

namespace QLL.DAL.Models
{
    public partial class TaiKhoanGvdb
    {
        public int MaTk { get; set; }
        public string MaGv { get; set; } = null!;
        public string TenDangNhap { get; set; } = null!;
        public string MatKhau { get; set; } = null!;

        public virtual GiaoVienDb MaGvNavigation { get; set; } = null!;
    }
}
