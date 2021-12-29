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
    public class TaiKhoanGVModel : PageModel
    {
        private TaiKhoanGVBLL bus;
        public List<TaiKhoanGVDTO> lstTKGV;
        public TaiKhoanGVModel()
        {
            bus = new TaiKhoanGVBLL();
        }
        public void OnGet()
        {
            lstTKGV = bus.GetAll().ToList();
        }
        public IActionResult OnGetTest()
        {
            return new ObjectResult(new { Id = 123, name = "hero" }) { StatusCode = 200 };
        }
        public IActionResult OnPostUpdate(String tkgv)
        {
            var obj = JsonSerializer.Deserialize<TaiKhoanGVDTO>(tkgv);
            var res = bus.Update(obj);
            if (res)
                return new ObjectResult(new { success = true, tkgv = obj }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostDelete(String maTKGV)
        {
            var id = int.Parse(maTKGV);
            var res = bus.Delete(id);
            if (res)
                return new ObjectResult(new { success = true }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostAdd(String tkgv)
        {
            var obj = JsonSerializer.Deserialize<TaiKhoanGVDTO>(tkgv);
            var res = bus.Add(obj);
            if (res != null)
                return new ObjectResult(new { success = true, tkgv = res }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
    }
}
