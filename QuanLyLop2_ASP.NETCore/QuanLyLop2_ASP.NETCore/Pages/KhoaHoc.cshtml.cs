using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using QLL.DTO;
using QLL.BLL;

namespace QuanLyLop2_ASP.NETCore.Pages
{
    public class KhoaHocModel : PageModel
    {
        private KhoaHocBLL bus;
        public List<KhoaHocDTO> lstKH;
        public KhoaHocModel()
        {
            bus = new KhoaHocBLL();
        }
        public void OnGet()
        {
            lstKH = bus.GetAll().ToList();
        }
        public IActionResult OnGetTest()
        {
            return new ObjectResult(new { Id = 123, name = "hero" }) { StatusCode = 200 };
        }
        public IActionResult OnPostUpdate(String kh)
        {
            var obj = JsonSerializer.Deserialize<KhoaHocDTO>(kh);
            var res = bus.Update(obj);
            if (res)
                return new ObjectResult(new { success = true, kh = obj }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostDelete(String maKH)
        {
            var id = int.Parse(maKH);
            var res = bus.Delete(id);
            if (res)
                return new ObjectResult(new { success = true }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostAdd(String kh)
        {
            var obj = JsonSerializer.Deserialize<KhoaHocDTO>(kh);
            var res = bus.Add(obj);
            if (res != null)
                return new ObjectResult(new { success = true, kh = res }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
    }
}
