#pragma checksum "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Search\SearchSP.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6a149244cc5f8775df83e91e07c6eb131624635"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_SearchSP), @"mvc.1.0.view", @"/Views/Search/SearchSP.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\_ViewImports.cshtml"
using doan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Search\SearchSP.cshtml"
using doan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6a149244cc5f8775df83e91e07c6eb131624635", @"/Views/Search/SearchSP.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32245f2a035dda76030e7fe1b4cad468586c06eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_SearchSP : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Search\SearchSP.cshtml"
  
    ViewData["Title"] = "Tìm kiếm";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Search\SearchSP.cshtml"
  
    List<string> list_HA = (List<string>)ViewBag.HinhAnhSP;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container tab-content text-charcoal pt-8 pb-8\">\n    <div class=\"tab-pane fade show active\" id=\"grid-view\" role=\"tabpanel\" aria-labelledby=\"grid-view-tab\">\n        <div class=\"product-grid-view row\">\n");
#nullable restore
#line 13 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Search\SearchSP.cshtml"
               var stt = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Search\SearchSP.cshtml"
             foreach (var item in (List<Sanpham>)Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-3 col-sm-6\">\n            <div class=\"product-item\">\n                <div class=\"product-img img-zoom-effect\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6a149244cc5f8775df83e91e07c6eb1316246355013", async() => {
                WriteLiteral("\n                        <img class=\"img-full\"");
                BeginWriteAttribute("src", " src=\"", 735, "\"", 754, 1);
#nullable restore
#line 20 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Search\SearchSP.cshtml"
WriteAttributeValue("", 741, list_HA[stt], 741, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Product Images\">\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 654, "~/SanPham/Details?masp=", 654, 23, true);
#nullable restore
#line 19 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Search\SearchSP.cshtml"
AddHtmlAttributeValue("", 677, item.MaSp, 677, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <div class=\"product-add-action\">\n                        <ul>\n                            <li>\n");
#nullable restore
#line 25 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Search\SearchSP.cshtml"
                                   stt += 1;
                                    var id_add = "add_cart" + @stt.ToString(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6a149244cc5f8775df83e91e07c6eb1316246357475", async() => {
                WriteLiteral("\n                                    <a href=\"#\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1206, "\"", 1260, 3);
                WriteAttributeValue("", 1216, "document.getElementById(\'", 1216, 25, true);
#nullable restore
#line 28 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Search\SearchSP.cshtml"
WriteAttributeValue("", 1241, id_add, 1241, 7, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1248, "\').submit();", 1248, 12, true);
                EndWriteAttribute();
                WriteLiteral(">\n                                        <i class=\"pe-7s-cart\"></i>\n                                    </a>\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1090, "/GioHang/Add_cart?product_id=", 1090, 29, true);
#nullable restore
#line 27 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Search\SearchSP.cshtml"
AddHtmlAttributeValue("", 1119, item.MaSp, 1119, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 27 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Search\SearchSP.cshtml"
AddHtmlAttributeValue("", 1149, id_add, 1149, 7, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </li>\n                        </ul>\n                    </div>\n                </div>\n                <div class=\"product-content\">\n                    <a class=\"product-name\" href=\"single-product.html\">");
#nullable restore
#line 37 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Search\SearchSP.cshtml"
                                                                  Write(item.TenSp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                    <div class=\"price-box pb-1\">\n                        <span class=\"new-price text-danger\">");
#nullable restore
#line 39 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Search\SearchSP.cshtml"
                                                       Write(item.GiaTien.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\n                    </div>\n                </div>\n            </div>\n        </div>");
#nullable restore
#line 43 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Views\Search\SearchSP.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        </div>\n    </div>\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591