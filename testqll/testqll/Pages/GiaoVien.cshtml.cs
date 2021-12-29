using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using QLL.BLL;
using QLL.DTO;
using System.Collections.Generic;
using System.Linq;
using System;

namespace QuanLyLop2_ASP.NETCore.Pages
{
    public class GiaoVienModel : PageModel
    {
        private GiaoVienBLL busGV;
        public List<GiaoVienDTO> lstGV;
        public GiaoVienModel()
        {
            busGV = new GiaoVienBLL();
        }
        public void OnGet()
        {
            lstGV = busGV.GetAll().ToList();
        }
        public IActionResult OnPostUpdate(String gv)
        {
            var obj = JsonSerializer.Deserialize<GiaoVienDTO>(gv);
            var res = busGV.Update(obj);
            if (res)
                return new ObjectResult(new { success = true, gv = obj }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostDelete(String maGV)
        {
            var id = maGV;
            var res = busGV.Delete(id);
            if (res)
                return new ObjectResult(new { success = true }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostAdd(String gv)
        {
            var obj = JsonSerializer.Deserialize<GiaoVienDTO>(gv);
            var res = busGV.Add(obj);
            if (res != null)
                return new ObjectResult(new { success = true, gv = res }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false, }) { StatusCode = 500 };
        }
    }
}
