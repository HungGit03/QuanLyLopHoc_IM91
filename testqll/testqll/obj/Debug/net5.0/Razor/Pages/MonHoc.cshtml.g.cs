#pragma checksum "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\MonHoc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41f048be5603587c9739930835f604401c616e52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(testqll.Pages.Pages_MonHoc), @"mvc.1.0.razor-page", @"/Pages/MonHoc.cshtml")]
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
#line 2 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\MonHoc.cshtml"
using QLL.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\MonHoc.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\MonHoc.cshtml"
using Microsoft.AspNetCore.Antiforgery;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41f048be5603587c9739930835f604401c616e52", @"/Pages/MonHoc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f603635730e0b9d9481a2739a97b83f9b692d31", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MonHoc : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\MonHoc.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\MonHoc.cshtml"
  
   var token = antiforgery.GetAndStoreTokens(HttpContext).RequestToken;

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\"text/javascript\">\r\n    var dataMH = ");
#nullable restore
#line 12 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\MonHoc.cshtml"
            Write(Html.Raw(JsonSerializer.Serialize(Model.lstMH)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
</script>
<div class=""text-center"">
    <h1 class=""display-4"">L???p</h1>
    <p>Danh s??ch m??n h???c.</p>
    <button type=""button"" onclick=""openModalMH(null);"" class=""btn btn-outline-primary btn-sm"">Th??m M??n h???c</button>
    <table id=""tableMH""class=""table table-striped"">
        <tr>
            <th>M?? m??n h???c</th>
            <th>T??n m??n h???c</th>
            <th>Action</th>
        </tr>
");
#nullable restore
#line 24 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\MonHoc.cshtml"
         foreach (MonHocDTO m  in Model.lstMH)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 853, "\"", 870, 2);
            WriteAttributeValue("", 858, "trMH_", 858, 5, true);
#nullable restore
#line 26 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\MonHoc.cshtml"
WriteAttributeValue("", 863, m.MaMh, 863, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>");
#nullable restore
#line 27 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\MonHoc.cshtml"
               Write(m.MaMh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\MonHoc.cshtml"
               Write(m.TenMh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1006, "\"", 1037, 3);
            WriteAttributeValue("", 1016, "openModalMH(", 1016, 12, true);
#nullable restore
#line 30 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\MonHoc.cshtml"
WriteAttributeValue("", 1028, m.MaMh, 1028, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1035, ");", 1035, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary btn-sm\">S???a</button>\r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1133, "\"", 1162, 3);
            WriteAttributeValue("", 1143, "deleteMH(", 1143, 9, true);
#nullable restore
#line 31 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\MonHoc.cshtml"
WriteAttributeValue("", 1152, m.TenMh, 1152, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1160, ");", 1160, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger btn-sm\">xo??</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\MonHoc.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>
<div id =""DivModalMH"" class=""modal"" tabindex=""-1"" role=""dialog"">
  <div class=""modal-dialog modal-lg"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"">S???a m??n h???c: <span id=""MaMH""></span></h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""closeModal()"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <div class=""form-group"">
            <label for=""txtTenMH"">T??n m??n h???c</label>
            <input type=""text"" class=""form-control"" id=""txtTenMH"" aria-describedby=""TenMHHelp"" placeholder=""T??n m??n h???c"">
            <small id=""TenMHHelp"" class=""form-text text-muted"">Kh??ng ???????c b??? tr???ng.</small>
        </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" onclick=""closeModal()"" data-dismiss=""modal"">Close</button>
        <button type=""button"" onclick=""save");
            WriteLiteral("MH()\" class=\"btn btn-primary\">Save changes</button>\r\n      </div>\r\n      </div>\r\n    </div>\r\n   </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyLop2_ASP.NETCore.Pages.MonHocModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyLop2_ASP.NETCore.Pages.MonHocModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyLop2_ASP.NETCore.Pages.MonHocModel>)PageContext?.ViewData;
        public QuanLyLop2_ASP.NETCore.Pages.MonHocModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
