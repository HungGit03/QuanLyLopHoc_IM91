using System;
using System.Collections.Generic;

namespace QLL.DAL.Models
{
    public partial class AdminDb
    {
        public string MaAdmin { get; set; } = null!;
        public string TenAdmin { get; set; } = null!;
        public string GioiTinh { get; set; } = null!;
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; } = null!;
        public double Sdt { get; set; }
        public string Email { get; set; } = null!;

        public virtual TaiKhoanAdDb TaiKhoanAdDb { get; set; } = null!;
    }
}
