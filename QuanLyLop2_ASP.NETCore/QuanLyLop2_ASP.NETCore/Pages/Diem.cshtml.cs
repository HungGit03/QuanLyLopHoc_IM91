using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using QLL.BLL;
using QLL.DTO;

namespace QuanLyLop2_ASP.NETCore.Pages
{
    public class DiemModel : PageModel
    {
        private DiemBLL busd;
        public List<DiemDTO> lstd;
        public DiemModel()
        {
            busd = new DiemBLL();
        }
        public void OnGet()
        {
            lstd = busd.GetAll().ToList();
        }
        public IActionResult OnPostUpdate(String d)
        {
            var obj = JsonSerializer.Deserialize<DiemDTO>(d);
            var res = busd.Update(obj);
            if (res)
                return new ObjectResult(new { success = true, d = obj }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostDelete(String maMH, string maHS)
        {
            var idMH = int.Parse(maMH);
            var idHS = maHS;
            var res = busd.Delete(idMH, idHS);
            if (res)
                return new ObjectResult(new { success = true }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
        public IActionResult OnPostAdd(String d)
        {
            var obj = JsonSerializer.Deserialize<DiemDTO>(d);
            var res = busd.Add(obj);
            if (res != null)
                return new ObjectResult(new { success = true, d = res }) { StatusCode = 200 };
            else
                return new ObjectResult(new { success = false }) { StatusCode = 500 };
        }
    }
}
