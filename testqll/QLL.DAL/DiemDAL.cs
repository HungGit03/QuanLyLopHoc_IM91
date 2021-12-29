using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLL.DAL.Models;
using QLL.DTO;

namespace QLL.DAL
{
    public class DiemDAL
    {
        private QuanLySinhVienContext db;
        public DiemDAL()
        {
            db = new QuanLySinhVienContext();
        }
        public IList<DiemDTO> GetAll()
        {
            List<DiemDTO> res = new List<DiemDTO>();
            try
            {
                var ls = db.DiemDbs.ToList();
                foreach (var d in ls)
                {
                    DiemDTO dto = new DiemDTO();
                    dto.MaMh = d.MaMh;
                    dto.MaHs = d.MaHs;
                    dto.Diem = d.Diem;
                    res.Add(dto);
                }
            }
            catch (Exception ex)
            {
                res = null;
            }
            return res;

        }
        public bool Update(DiemDTO d)
        {
            bool res = false;
            var c = db.DiemDbs.FirstOrDefault(x=> x.MaMh == d.MaMh  && x.MaHs == d.MaHs);
            if (c.Diem != d.Diem)
                c.Diem = d.Diem;
            try
            {
                db.DiemDbs.Update(c);
                db.SaveChanges();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        public bool Delete(int maMh, string maHs)
        {
            bool res = false;
            var d = db.DiemDbs.FirstOrDefault(x => x.MaMh == maMh && x.MaHs == maHs);
            try
            {
                db.DiemDbs.Remove(d);
                db.SaveChanges();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        public DiemDTO Add(DiemDTO d)
        {
            DiemDTO res = new DiemDTO();
            var c = new DiemDb();
            c.MaMh = d.MaMh;
            c.MaHs = d.MaHs;
            c.Diem = d.Diem;
            try
            {
                db.DiemDbs.Add(c);
                db.SaveChanges();
                res.MaMh = c.MaMh;
                res.MaHs = c.MaHs;
                res.Diem = c.Diem;
            }
            catch (Exception ex)
            {
                res = null;
            }
            return res;
        }
    }
}
