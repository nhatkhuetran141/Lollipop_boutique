#pragma checksum "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\ThongKe\TK_NhaVanChuyen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92d8f7a150a7eef462ce87fc7e0cd272d05cba28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ThongKe_TK_NhaVanChuyen), @"mvc.1.0.view", @"/Areas/Admin/Views/ThongKe/TK_NhaVanChuyen.cshtml")]
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
#line 1 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\_ViewImports.cshtml"
using Lollipop_boutique;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\_ViewImports.cshtml"
using doan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92d8f7a150a7eef462ce87fc7e0cd272d05cba28", @"/Areas/Admin/Views/ThongKe/TK_NhaVanChuyen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abc694818fac65187b9cb4275eddd0e963ee043d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ThongKe_TK_NhaVanChuyen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:2%; margin-top:2%; margin-left:5%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\ThongKe\TK_NhaVanChuyen.cshtml"
  
    ViewData["Title"] = "Thống kê nhà vận chuyển";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\ThongKe\TK_NhaVanChuyen.cshtml"
  
    var list_nvc = (SortedList<string, int>)ViewBag.ListNVC; 

#line default
#line hidden
#nullable disable
            WriteLiteral("   -\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <div class=\"d-flex justify-content-between align-items-center\">\r\n            <h5>Thống kê nhà vận chuyển </h5>\r\n             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92d8f7a150a7eef462ce87fc7e0cd272d05cba285083", async() => {
                WriteLiteral("Back to Dashboard");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" 
        </div>
        <div class=""m-t-30"">
            <div class=""table-responsive"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th>Tên nhà vận chuyển</th>
                            <th>Số lượng</th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 29 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\ThongKe\TK_NhaVanChuyen.cshtml"
                         if (list_nvc != null)
                        {
                            foreach (var item in list_nvc)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 35 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\ThongKe\TK_NhaVanChuyen.cshtml"
                                   Write(item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 38 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\ThongKe\TK_NhaVanChuyen.cshtml"
                                   Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\ThongKe\TK_NhaVanChuyen.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
