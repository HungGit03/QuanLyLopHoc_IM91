using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLL.DTO;
using QLL.BLL;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System;

namespace QuanLyLop2_ASP.NETCore.Pages
{
    
    public class LopModel : PageModel
    {
        private LopBLL bus;
        public List<LopDTO> lstLop;
        public LopModel()
        {
            bus = new LopBLL();
        }
        public void OnGet()
        {
            lstLop = bus.GetAll().ToList();
        }
        public IActionResult OnGetTest()
        {
            return new ObjectResult(new { Id = 123, name = "hero" }) { StatusCode = 200 };
        }
        public IActionResult OnPostUpdate(String lop)
        {
            var obj = JsonSerializer.Deserialize<LopDTO>(lop);
            var res = bus.UpdateLop(obj);
            if (res)
                return new ObjectResult(new { success = true, lop = obj }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostDelete(String maLop)
        {
            var id = int.Parse(maLop);
            var res = bus.Delete(id);
            if (res)
                return new ObjectResult(new { success = true}) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostAdd(String lop)
        {
            var obj = JsonSerializer.Deserialize<LopDTO>(lop);
            var res = bus.Add(obj);
            if (res != null)
                return new ObjectResult(new { success = true, lop = res }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
    }
}
