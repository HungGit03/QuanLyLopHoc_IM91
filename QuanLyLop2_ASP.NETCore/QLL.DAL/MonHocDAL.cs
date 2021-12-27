using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLL.DAL.Models;
using QLL.DTO;

namespace QLL.DAL
{
    public class MonHocDAL
    {
        private QuanLySinhVienContext db;
        public MonHocDAL()
        {
            db = new QuanLySinhVienContext();
        }
        public IList<MonHocDTO> GetAll()
        {
            List<MonHocDTO> res = new List<MonHocDTO>();
            try
            {
                var ls = db.MonHocDbs.ToList();
                foreach (var m in ls)
                {
                    MonHocDTO dto = new MonHocDTO();
                    dto.MaMh = m.MaMh;
                    dto.TenMh = m.TenMh;
                    res.Add(dto);
                }
            }
            catch (Exception ex)
            {
                res = null;
            }
            return res;

        }
        public bool Update(MonHocDTO mh)
        {
            bool res = false;
            var c = db.MonHocDbs.FirstOrDefault(x => x.MaMh == mh.MaMh);
            if (c.TenMh != mh.TenMh)
                c.TenMh = mh.TenMh;
            try
            {
                db.MonHocDbs.Update(c);
                db.SaveChanges();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        public bool Delete(int maMh)
        {
            bool res = false;
            var mh = db.MonHocDbs.FirstOrDefault(x => x.MaMh == maMh);
            try
            {
                db.MonHocDbs.Remove(mh);
                db.SaveChanges();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        public MonHocDTO Add(MonHocDTO mh)
        {
            MonHocDTO res = new MonHocDTO();
            var c = new MonHocDb();
            c.TenMh = mh.TenMh;
            try
            {
                db.MonHocDbs.Add(c);
                db.SaveChanges();
                res.MaMh = c.MaMh;
                res.TenMh = c.TenMh;
            }
            catch (Exception ex)
            {
                res = null;
            }
            return res;
        }
    }
}
