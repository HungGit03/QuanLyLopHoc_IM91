using System;
using System.Collections.Generic;

namespace QLL.DAL.Models
{
    public partial class GiaoVienDb
    {
        public GiaoVienDb()
        {
            Tkbctdbs = new HashSet<Tkbctdb>();
        }

        public string MaGv { get; set; } = null!;
        public string TenGv { get; set; } = null!;
        public string GioiTinh { get; set; } = null!;
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; } = null!;
        public double Sdt { get; set; }
        public string Email { get; set; } = null!;
        public string ChuyenNganh { get; set; } = null!;
        public string TrinhDoChuyenMon { get; set; } = null!;

        public virtual TaiKhoanGvdb TaiKhoanGvdb { get; set; } = null!;
        public virtual ICollection<Tkbctdb> Tkbctdbs { get; set; }
    }
}
