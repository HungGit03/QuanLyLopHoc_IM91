using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using QLL.DTO;
using QLL.BLL;

namespace QuanLyLop2_ASP.NETCore.Pages
{
    public class AdminModel : PageModel
    {
        private AdminBLL bus;
        public List<AdminDTO> lstAd;
        public AdminModel()
        {
            bus = new AdminBLL();
        }
        public void OnGet()
        {
            lstAd = bus.GetAll().ToList();
        }
        public IActionResult OnPostUpdate(String ad)
        {
            var obj = JsonSerializer.Deserialize<AdminDTO>(ad);
            var res = bus.Update(obj);
            if (res)
                return new ObjectResult(new { success = true, ad = obj }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostDelete(String maAd)
        {
            var id = maAd;
            var res = bus.Delete(id);
            if (res)
                return new ObjectResult(new { success = true }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostAdd(String ad)
        {
            var obj = JsonSerializer.Deserialize<AdminDTO>(ad);
            var res = bus.Add(obj);
            if (res != null)
                return new ObjectResult(new { success = true, ad = res }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false, }) { StatusCode = 500 };
        }
    }
}
