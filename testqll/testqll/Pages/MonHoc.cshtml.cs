using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using QLL.DTO;
using QLL.BLL;
using System.Collections.Generic;
using System.Linq;
using System;

namespace QuanLyLop2_ASP.NETCore.Pages
{
    public class MonHocModel : PageModel
    {
        private MonHocBLL bus;
        public List<MonHocDTO> lstMH;
        public MonHocModel()
        {
            bus = new MonHocBLL();
        }
        public void OnGet()
        {
            lstMH = bus.GetAll().ToList();
        }
        public IActionResult OnPostUpdate(String mh)
        {
            var obj = JsonSerializer.Deserialize<MonHocDTO>(mh);
            var res = bus.Update(obj);
            if (res)
                return new ObjectResult(new { success = true, mh = obj }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostDelete(String maMH)
        {
            var id = int.Parse(maMH);
            var res = bus.Delete(id);
            if (res)
                return new ObjectResult(new { success = true }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostAdd(String mh)
        {
            var obj = JsonSerializer.Deserialize<MonHocDTO>(mh);
            var res = bus.Add(obj);
            if (res != null)
                return new ObjectResult(new { success = true, mh = res }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
    }
}
