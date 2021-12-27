using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using QLL.DTO;
using QLL.BLL;

namespace QuanLyLop2_ASP.NETCore.Pages
{
    public class TaiKhoanHSModel : PageModel
    {
        private TaiKhoanHSBLL bus;
        public List<TaiKhoanHSDTO> lstTKHS;
        public TaiKhoanHSModel()
        {
            bus = new TaiKhoanHSBLL();
        }
        public void OnGet()
        {
            lstTKHS = bus.GetAll().ToList();
        }
        public IActionResult OnGetTest()
        {
            return new ObjectResult(new { Id = 123, name = "hero" }) { StatusCode = 200 };
        }
        public IActionResult OnPostUpdate(String tkhs)
        {
            var obj = JsonSerializer.Deserialize<TaiKhoanHSDTO>(tkhs);
            var res = bus.Update(obj);
            if (res)
                return new ObjectResult(new { success = true, tkhs = obj }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostDelete(String maTKHS)
        {
            var id = int.Parse(maTKHS);
            var res = bus.Delete(id);
            if (res)
                return new ObjectResult(new { success = true }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostAdd(String tkhs)
        {
            var obj = JsonSerializer.Deserialize<TaiKhoanHSDTO>(tkhs);
            var res = bus.Add(obj);
            if (res != null)
                return new ObjectResult(new { success = true, tkhs = res }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
    }
}
