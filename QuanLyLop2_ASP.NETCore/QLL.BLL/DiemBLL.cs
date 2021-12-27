using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLL.DAL;
using QLL.DTO;

namespace QLL.BLL
{
   public class DiemBLL
    {
        private DiemDAL dal;
        public DiemBLL()
        {
            dal = new DiemDAL();  
        }
        public IList<DiemDTO> GetAll()
        {
            return dal.GetAll();
        }
        public bool Update(DiemDTO d)
        {
            return dal.Update(d);
        }
        public bool Delete(int maMh, string maHs)
        {
            return dal.Delete(maMh, maHs);
        }
        public DiemDTO Add(DiemDTO d)
        {
            return dal.Add(d);
        }
    }
}
