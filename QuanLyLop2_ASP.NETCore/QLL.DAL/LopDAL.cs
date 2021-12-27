using QLL.DAL.Models;
using QLL.DTO;

namespace QLL.DAL
{
    public class LopDAL
    {
        private QuanLySinhVienContext db;
        public LopDAL()
        {
            db = new QuanLySinhVienContext();
        }
        public IList<LopDTO> GetAll()
        {
            List<LopDTO> res = new List<LopDTO>();
            try
            {
                var ls = db.LopDbs.ToList();
                foreach (var l in ls)
                {
                    LopDTO dto = new LopDTO();
                    dto.MaLop = l.MaLop;
                    dto.TenLop = l.TenLop;
                    dto.PhongHoc = l.PhongHoc;
                    dto.MoTa = l.MoTa;
                    dto.TrangThai = l.TrangThai;
                    res.Add(dto);
                }
            }
            catch (Exception ex)
            {
                res = null;
            }
            return res;

        }
        public bool Update(LopDTO lop)
        {
            bool res = false;
            var c = db.LopDbs.FirstOrDefault(x => x.MaLop == lop.MaLop);
            if (c.TenLop != lop.TenLop)
                c.TenLop = lop.TenLop;
            if (c.PhongHoc != lop.PhongHoc)
                c.PhongHoc = lop.PhongHoc;
            if (c.MoTa != lop.MoTa)
                c.MoTa = lop.MoTa;
            if (c.TrangThai != lop.TrangThai)
                c.TrangThai = lop.TrangThai;
            try
            {
                db.LopDbs.Update(c);
                db.SaveChanges();
                res = true;
            }
            catch (Exception ex)
            {
               res = false;
            }
            return res;
        }
        public bool Delete(int maLop)
        {
            bool res = false;
            var lop = db.LopDbs.FirstOrDefault(x=>x.MaLop==maLop);
            try
            {
                db.LopDbs.Remove(lop);
                db.SaveChanges();
                res = true;
            }
            catch(Exception ex)
            {
                res = false;
            }
            return res;
        }
        public LopDTO Add(LopDTO lop)
        {
            LopDTO res = new LopDTO();
            var c = new LopDb();
            c.TenLop = lop.TenLop;
            c.PhongHoc = lop.PhongHoc;
            c.MoTa = lop.MoTa;
            c.TrangThai = lop.TrangThai;
            try
            {
                db.LopDbs.Add(c);
                db.SaveChanges();
                res.MaLop = c.MaLop;
                res.TenLop = c.TenLop;
                res.PhongHoc = c.PhongHoc;
                res.MoTa = c.MoTa;  
                res.TrangThai = c.TrangThai;
            }
            catch (Exception ex)
            {
                res = null;
            }
            return res;
        }
    }
}
