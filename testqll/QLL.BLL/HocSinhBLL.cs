using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLL.DAL;
using QLL.DTO;

namespace QLL.BLL
{
    public class HocSinhBLL
    {
        private HocSinhDAL dal;
        public HocSinhBLL()
        {
            dal = new HocSinhDAL();
        }
        public IList<HocSinhDTO> GetAll()
        {
            return dal.GetAll();
        }
        public bool Update(HocSinhDTO hs)
        {
            return dal.Update(hs);
        }
        public bool Delete(string maHS)
        {
            return dal.Delete(maHS);
        }
        public HocSinhDTO Add(HocSinhDTO hs)
        {
            return dal.Add(hs);
        }
    }
}
