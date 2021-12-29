using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using QLL.BLL;
using QLL.DTO;
using System.Linq;
using System.Collections.Generic;
using System;

namespace QuanLyLop2_ASP.NETCore.Pages
{
    public class HocSinhModel : PageModel
    {
        private HocSinhBLL busHS;
        private LopBLL busLop;
        public List<HocSinhDTO> lstHS;
        public List<LopDTO> lstLop;
        public HocSinhModel()
        {
           busHS = new HocSinhBLL();
           busLop = new LopBLL(); 
        }
        public void OnGet()
        {
            lstHS = busHS.GetAll().ToList();
            lstLop = busLop.GetAll().ToList();
        }
        public IActionResult OnPostUpdate(String hs)
        {
            var obj = JsonSerializer.Deserialize<HocSinhDTO>(hs);
            var res = busHS.Update(obj);
            if (res)
                return new ObjectResult(new { success = true, hs = obj }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostDelete(String maHS)
        {
            var id = maHS;
            var res = busHS.Delete(id);
            if (res)
                return new ObjectResult(new { success = true }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostAdd(String hs)
        {
            var obj = JsonSerializer.Deserialize<HocSinhDTO>(hs);
            var res = busHS.Add(obj);
            if (res != null)
                return new ObjectResult(new { success = true, hs = res }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false, }) { StatusCode = 500 };
        }
    }
}
