#pragma checksum "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\Diem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97f3f2b0c710ca3f6393098985482f8f05fed4ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(testqll.Pages.Pages_Diem), @"mvc.1.0.razor-page", @"/Pages/Diem.cshtml")]
namespace testqll.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\_ViewImports.cshtml"
using testqll;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\Diem.cshtml"
using QLL.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\Diem.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\Diem.cshtml"
using Microsoft.AspNetCore.Antiforgery;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97f3f2b0c710ca3f6393098985482f8f05fed4ea", @"/Pages/Diem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f603635730e0b9d9481a2739a97b83f9b692d31", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Diem : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\Diem.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\Diem.cshtml"
  
   var token = antiforgery.GetAndStoreTokens(HttpContext).RequestToken;

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\"text/javascript\">\r\n    var dataD = ");
#nullable restore
#line 12 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\Diem.cshtml"
           Write(Html.Raw(JsonSerializer.Serialize(Model.lstd)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
</script>
<div class=""text-center"">
    <h1 class=""display-4"">L???p</h1>
    <p>Danh s??ch ??i???m.</p>
    <button type=""button"" onclick=""openModalD(null, null);"" class=""btn btn-outline-primary btn-sm"">Th??m ??i???m</button>
    <table id=""tableD""class=""table table-striped"">
        <tr>
            <th>M?? m??n h???c</th>
            <th>M?? h???c sinh</th>
            <th>??i???m</th>
            <th>Action</th>
        </tr>
");
#nullable restore
#line 25 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\Diem.cshtml"
         foreach (DiemDTO m  in Model.lstd)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 871, "\"", 894, 3);
            WriteAttributeValue("", 876, "trD_", 876, 4, true);
#nullable restore
#line 27 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\Diem.cshtml"
WriteAttributeValue("", 880, m.MaMh, 880, 7, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\Diem.cshtml"
WriteAttributeValue("", 887, m.MaHs, 887, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>");
#nullable restore
#line 28 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\Diem.cshtml"
               Write(m.MaMh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\Diem.cshtml"
               Write(m.MaHs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\Diem.cshtml"
               Write(m.Diem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1063, "\"", 1104, 6);
            WriteAttributeValue("", 1073, "openModalD(", 1073, 11, true);
#nullable restore
#line 32 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\Diem.cshtml"
WriteAttributeValue("", 1084, m.MaMh, 1084, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1091, ",", 1091, 1, true);
            WriteAttributeValue(" ", 1092, "\'", 1093, 2, true);
#nullable restore
#line 32 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\Diem.cshtml"
WriteAttributeValue("", 1094, m.MaHs, 1094, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1101, "\');", 1101, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary btn-sm\">S???a</button>\r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1200, "\"", 1238, 6);
            WriteAttributeValue("", 1210, "deleteD(", 1210, 8, true);
#nullable restore
#line 33 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\Diem.cshtml"
WriteAttributeValue("", 1218, m.MaMh, 1218, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1225, ",", 1225, 1, true);
            WriteAttributeValue(" ", 1226, "\'", 1227, 2, true);
#nullable restore
#line 33 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\Diem.cshtml"
WriteAttributeValue("", 1228, m.MaHs, 1228, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1235, "\');", 1235, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger btn-sm\">xo??</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\Diem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>
<div id =""DivModalD"" class=""modal"" tabindex=""-1"" role=""dialog"">
  <div class=""modal-dialog modal-lg"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"">S???a ??i???m:  
            <span id=""MaMH""></span>
            <span id=""MaHS""></span>
        </h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""closeModal()"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <div class=""form-group"">
            <label for=""txtMaMH"">M?? m??n h???c</label>
            <input type=""text"" class=""form-control"" id=""txtMaMH"" aria-describedby=""MaMHHelp"" placeholder=""M?? m??n h???c"">
            <small id=""MaMHHelp"" class=""form-text text-muted"">Kh??ng ???????c b??? tr???ng.</small>
        </div>
        <div class=""form-group"">
            <label for=""txtMaHS"">M?? h???c sinh</label>
            <input type=""text"" class=""form-control"" i");
            WriteLiteral(@"d=""txtMaHS"" aria-describedby=""MaHSHelp"" placeholder=""M?? h???c sinh"">
            <small id=""MaHSHelp"" class=""form-text text-muted"">Kh??ng ???????c b??? tr???ng.</small>
        </div>
        <div class=""form-group"">
            <label for=""txtDiem"">M?? m??n h???c</label>
            <input type=""text"" class=""form-control"" id=""txtDiem"" aria-describedby=""DiemHelp"" placeholder=""??i???m"">
            <small id=""DiemHelp"" class=""form-text text-muted"">Kh??ng ???????c b??? tr???ng.</small>
        </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" onclick=""closeModal()"" data-dismiss=""modal"">Close</button>
        <button type=""button"" onclick=""saveD()"" class=""btn btn-primary"">Save changes</button>
      </div>
      </div>
    </div>
   </div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAntiforgery antiforgery { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyLop2_ASP.NETCore.Pages.DiemModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyLop2_ASP.NETCore.Pages.DiemModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyLop2_ASP.NETCore.Pages.DiemModel>)PageContext?.ViewData;
        public QuanLyLop2_ASP.NETCore.Pages.DiemModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
