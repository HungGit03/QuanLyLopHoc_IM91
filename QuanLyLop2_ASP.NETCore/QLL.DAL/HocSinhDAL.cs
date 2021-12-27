using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLL.DAL.Models;
using QLL.DTO;

namespace QLL.DAL
{
    public class HocSinhDAL
    {
        private QuanLySinhVienContext db;
        public HocSinhDAL()
        {
            db = new QuanLySinhVienContext();
        }
        public List<string> GetID()
        {
            List<string> ma;
            var ls = (from ad in db.HocSinhDbs select ad.MaHs).
                Except(from tk in db.TaiKhoanHsdbs select tk.MaHs);
            ma = ls.ToList();
            return ma;

        }
        public IList<HocSinhDTO> GetAll()
        {

            List<HocSinhDTO> res = new List<HocSinhDTO>();
            try
            {
                var ls = db.HocSinhDbs.ToList();
                foreach (var hs in ls)
                {
                    HocSinhDTO dto = new HocSinhDTO();
                    dto.MaHs = hs.MaHs;
                    dto.TenHs = hs.TenHs;
                    dto.GioiTinh = hs.GioiTinh;
                    dto.NamSinh = hs.NamSinh;
                    dto.DiaChi = hs.DiaChi;
                    dto.Sdt = hs.Sdt;
                    dto.Email = hs.Email;
                    dto.MaLop = hs.MaLop;
                    res.Add(dto);
                }
            }
            catch (Exception ex)
            {
                res = null;
            }
            return res;
        }
        public bool Update(HocSinhDTO hs)
        {
            bool res = false;
            var c = db.HocSinhDbs.FirstOrDefault(x=>x.MaHs == hs.MaHs);
            if(c.TenHs !=hs.TenHs)
                c.TenHs=hs.TenHs;
            if (c.GioiTinh != hs.GioiTinh)
                c.GioiTinh = hs.GioiTinh;
            if (c.NamSinh != hs.NamSinh)
                c.NamSinh=hs.NamSinh;
            if (c.DiaChi != hs.DiaChi)
                c.DiaChi = hs.DiaChi;
            if (c.Sdt != hs.Sdt)
                c.Sdt = hs.Sdt;
            if (c.Email != hs.Email)
                c.Email = hs.Email;
            if (c.MaLop != hs.MaLop)
                c.MaLop = hs.MaLop;
            try
            {
                db.HocSinhDbs.Update(c);
                db.SaveChanges();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        public bool Delete(string maHS)
        {
            bool res = false;
            var hs = db.HocSinhDbs.FirstOrDefault(x => x.MaHs == maHS);
            try
            {
                db.HocSinhDbs.Remove(hs);
                db.SaveChanges();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        public HocSinhDTO Add(HocSinhDTO hs)
        {
            if (db.HocSinhDbs.FirstOrDefault(x=>x.MaHs == hs.MaHs) == null)
            {
                HocSinhDTO res = new HocSinhDTO();
                var c = new HocSinhDb();
                c.MaHs = hs.MaHs;
                c.TenHs = hs.TenHs;
                c.GioiTinh = hs.GioiTinh;
                c.NamSinh = hs.NamSinh;
                c.Sdt = hs.Sdt;
                c.DiaChi = hs.DiaChi;
                c.Email = hs.Email;
                c.MaLop = hs.MaLop;
                try
                {
                    db.HocSinhDbs.Add(c);
                    db.SaveChanges();
                    res.MaHs = c.MaHs;
                    res.TenHs = c.TenHs;
                    res.GioiTinh = c.GioiTinh;
                    res.NamSinh = c.NamSinh;
                    res.Sdt = c.Sdt;
                    res.DiaChi = c.DiaChi;
                    res.Email = c.Email;
                    res.MaLop = c.MaLop;
                }
                catch (Exception ex)
                {
                    res = null;
                }
                return res;
            }
            return null;
        }
    }
}
