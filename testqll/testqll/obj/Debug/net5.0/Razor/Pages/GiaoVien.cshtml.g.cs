#pragma checksum "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fa4effe63fa378cf6f81299f9e15b82dc8112a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(testqll.Pages.Pages_GiaoVien), @"mvc.1.0.razor-page", @"/Pages/GiaoVien.cshtml")]
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
#line 2 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml"
using QLL.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml"
using Microsoft.AspNetCore.Antiforgery;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fa4effe63fa378cf6f81299f9e15b82dc8112a5", @"/Pages/GiaoVien.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f603635730e0b9d9481a2739a97b83f9b692d31", @"/Pages/_ViewImports.cshtml")]
    public class Pages_GiaoVien : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml"
  
   var token = antiforgery.GetAndStoreTokens(HttpContext).RequestToken;

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\"text/javascript\">\r\n    var dataGV = ");
#nullable restore
#line 12 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml"
            Write(Html.Raw(JsonSerializer.Serialize(Model.lstGV)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
</script>
<div class=""text-center"">
    <h1 class=""display-4"">Lớp</h1>
    <p>Danh sách giáo viên.</p>
    <button type=""button"" onclick=""openModalGV(null);"" class=""btn btn-outline-primary btn-sm"">Thêm giáo viên</button>
    <table id=""tableGV""class=""table table-striped"">
        <tr>
            <th>Mã Giáo viên</th>
            <th>Tên Giáo viên</th>
            <th>Giới tính</th>
            <th>Ngày sinh</th>
            <th>Đia chỉ</th>
            <th>SĐT</th>
            <th>Email</th>
            <th>Chuyên Ngành</th>
            <th>Trình độ</th>
            <th>Action</th>
        </tr>
");
#nullable restore
#line 31 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml"
         foreach (GiaoVienDTO hs in Model.lstGV)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 1079, "\"", 1097, 2);
            WriteAttributeValue("", 1084, "trGV_", 1084, 5, true);
#nullable restore
#line 33 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml"
WriteAttributeValue("", 1089, hs.MaGv, 1089, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>");
#nullable restore
#line 34 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml"
               Write(hs.MaGv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml"
               Write(hs.TenGv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml"
               Write(hs.GioiTinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml"
               Write(hs.NgaySinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml"
               Write(hs.DiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml"
               Write(hs.Sdt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml"
               Write(hs.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml"
               Write(hs.ChuyenNganh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml"
               Write(hs.TrinhDoChuyenMon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1509, "\"", 1543, 3);
            WriteAttributeValue("", 1519, "openModalGV(\'", 1519, 13, true);
#nullable restore
#line 44 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml"
WriteAttributeValue("", 1532, hs.MaGv, 1532, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1540, "\');", 1540, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary btn-sm\">Sửa</button>\r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1639, "\"", 1670, 3);
            WriteAttributeValue("", 1649, "deleteGV(\'", 1649, 10, true);
#nullable restore
#line 45 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml"
WriteAttributeValue("", 1659, hs.MaGv, 1659, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1667, "\');", 1667, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger btn-sm\">xoá</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 48 "D:\Thanh_Hung\LTCSDL\testqll\testqll\Pages\GiaoVien.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>
<div id =""DivModalGV"" class=""modal"" tabindex=""-1"" role=""dialog"">
  <div class=""modal-dialog modal-lg"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"">Sửa giáo viên: <span id=""MaGV""></span></h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""closeModal()"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
          <div class=""form-group"">
            <label for=""txtMaGV"">Mã giáo viên</label>
            <input type=""text"" class=""form-control"" id=""txtMaGV"" aria-describedby=""MaGVHelp"" placeholder=""Mã Giáo viên: gv..."">
            <small id=""MaGVHelp"" class=""form-text text-muted"">Không được bỏ trống, 5 kí tự.</small>
        </div>
        <div class=""form-group"">
            <label for=""txtTenGV"">Tên giáo viên</label>
            <input type=""text"" class=""form-control"" id=""txtTenGV"" aria-describedby=""");
            WriteLiteral(@"TenGVHelp"" placeholder=""Tên giáo viên"">
            <small id=""TenGVHelp"" class=""form-text text-muted"">Không được bỏ trống.</small>
        </div>
        <div class=""form-group"">
            <label for=""txtNS"">Ngày sinh</label>
            <input type=""date"" class=""form-control"" id=""txtNS"" value=""2000-01-01""
                 aria-describedby=""NSHelp"">
            <small id=""NSHelp"" class=""form-text text-muted"">Không được bỏ trống.</small>
        </div>
        <div class=""form-group"">
            <label for=""selGT"">Giới tính</label>
            <select class=""form-control"" id=""selGT"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fa4effe63fa378cf6f81299f9e15b82dc8112a510655", async() => {
                WriteLiteral("Nam");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fa4effe63fa378cf6f81299f9e15b82dc8112a511627", async() => {
                WriteLiteral("Nữ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </select>
        </div>
        <div class=""form-group"">
            <label for=""txtDiaChi"">Địa chỉ</label>
            <input type=""text"" class=""form-control"" id=""txtDiaChi"" aria-describedby=""DiaChiHelp"" placeholder=""Địa chỉ"">
            <small id=""DiaChiHelp"" class=""form-text text-muted"">Không được bỏ trống.</small>
        </div>
        <div class=""form-group"">
            <label for=""txtSDT"">Số điện thoại</label>
            <input type=""text"" class=""form-control"" id=""txtSDT"" aria-describedby=""SDTlHelp"" placeholder=""Số điện thoại"">
            <small id=""SDTHelp"" class=""form-text text-muted"">Không được bỏ trống.</small>
        </div>
        <div class=""form-group"">
            <label for=""txtEmail"">Email</label>
            <input type=""email"" class=""form-control"" id=""txtEmail"" aria-describedby=""DiaChiHelp"" placeholder=""Địa chỉ email"">
            <small id=""EmailHelp"" class=""form-text text-muted"">Không được bỏ trống.</small>
        </div>
        <div class=""form-grou");
            WriteLiteral(@"p"">
            <label for=""txtCN"">Chuyên ngành</label>
            <input type=""text"" class=""form-control"" id=""txtCN"" aria-describedby=""CNHelp"" placeholder=""Chuyên ngành"">
            <small id=""CNlHelp"" class=""form-text text-muted"">Không được bỏ trống.</small>
        </div>
        <div class=""form-group"">
            <label for=""txtTDCM"">Trình độ chuyên môn</label>
            <input type=""text"" class=""form-control"" id=""txtTDCM"" aria-describedby=""TDCMHelp"" placeholder=""Trình độ chuyên môn"">
            <small id=""TDCMlHelp"" class=""form-text text-muted"">Không được bỏ trống.</small>
        </div>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" onclick=""closeModal()"" data-dismiss=""modal"">Close</button>
        <button type=""button"" onclick=""saveGV()"" class=""btn btn-primary"">Save changes</button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyLop2_ASP.NETCore.Pages.GiaoVienModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyLop2_ASP.NETCore.Pages.GiaoVienModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyLop2_ASP.NETCore.Pages.GiaoVienModel>)PageContext?.ViewData;
        public QuanLyLop2_ASP.NETCore.Pages.GiaoVienModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
