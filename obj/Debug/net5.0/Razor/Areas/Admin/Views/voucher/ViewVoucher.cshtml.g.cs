#pragma checksum "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\voucher\ViewVoucher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8b47c747abf87e7dcb46f48305186016d15f288"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_voucher_ViewVoucher), @"mvc.1.0.view", @"/Areas/Admin/Views/voucher/ViewVoucher.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8b47c747abf87e7dcb46f48305186016d15f288", @"/Areas/Admin/Views/voucher/ViewVoucher.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abc694818fac65187b9cb4275eddd0e963ee043d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_voucher_ViewVoucher : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lollipop_boutique.Areas.Admin.Models.voucher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/css/EditCustomer.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/voucher/LietKeVoucher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:2%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\voucher\ViewVoucher.cshtml"
  
    ViewData["Title"] = "Update Voucher";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8b47c747abf87e7dcb46f48305186016d15f2885720", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b8b47c747abf87e7dcb46f48305186016d15f2885982", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n");
                WriteLiteral(@"    <script src=""https://code.jquery.com/jquery-3.3.1.min.js""></script>
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
    <script src=""https://unpkg.com/gijgo@1.9.13/js/gijgo.min.js"" type=""text/javascript""></script>
    <link href=""https://unpkg.com/gijgo@1.9.13/css/gijgo.min.css"" rel=""stylesheet"" type=""text/css"" />
            
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("        \r\n<div class=\"card-header\"><h3>Update Voucher ");
#nullable restore
#line 17 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\voucher\ViewVoucher.cshtml"
                                       Write(Model.TenVoucher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></div>\r\n<div class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8b47c747abf87e7dcb46f48305186016d15f2888910", async() => {
                WriteLiteral("\r\n        <div class=\"Viewcustomer\" style=\"border-color: coral;border-radius: 25px;margin-top: 5%; padding: 3% 3% 7% 3%; border: 2px solid #aaa;\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8b47c747abf87e7dcb46f48305186016d15f2889332", async() => {
                    WriteLiteral("Back to Voucher Management");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"              
            <div class=""row body_insertcustomer"">
                <div class=""col-md"">            
                        <!-- MaKH input -->
                    <div class=""input_field"">
                                    <div class=""input_field_title"">Voucher ID*</div>
                                    <input type=""text"" id=""idcustomer"" name=""MaVoucher"" placeholder=""VD:KH01""");
                BeginWriteAttribute("value", " value=\"", 1697, "\"", 1721, 1);
#nullable restore
#line 27 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\voucher\ViewVoucher.cshtml"
WriteAttributeValue("", 1705, Model.MaVoucher, 1705, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled=""disabled""/>                   
                                </div>
                                <!-- Name -->
                                <div class=""input_field"">
                                    <div class=""input_field_title"">Name*</div>
                                    <input type=""text"" id=""namecustomer"" name=""TenVoucher"" placeholder=""sale Tet""");
                BeginWriteAttribute("value", " value=\"", 2104, "\"", 2129, 1);
#nullable restore
#line 32 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\voucher\ViewVoucher.cshtml"
WriteAttributeValue("", 2112, Model.TenVoucher, 2112, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/>
                                </div>           
                                <div class=""input_field"">
                                    <div class=""input_field_title"">Value*</div>
                                    <input type=""text"" id=""phonecustomer"" name=""TiLeGiamGia"" placeholder=""SĐT""");
                BeginWriteAttribute("value", "value=\"", 2435, "\"", 2460, 1);
#nullable restore
#line 36 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\voucher\ViewVoucher.cshtml"
WriteAttributeValue("", 2442, Model.TiLeGiamGia, 2442, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                </div>\r\n                                <!-- street address -->\r\n                                <div class=\"input_field\">\r\n                                     <div class=\"input_field_title\">Start Date*</div>\r\n");
                WriteLiteral("                                     <input id=\"datepicker\" class=\"datepicker1\" width=\"276\" name=\"NgayBatDau\"");
                BeginWriteAttribute("value", "value=\"", 2918, "\"", 2942, 1);
#nullable restore
#line 42 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\voucher\ViewVoucher.cshtml"
WriteAttributeValue("", 2925, Model.NgayBatDau, 2925, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/>
                                </div>                      
                                <script>
                                    $('#datepicker').datepicker({
                                        uiLibrary: 'bootstrap4'
                                    });                                       
                                </script>
                                <div class=""input_field"">
                                     <div class=""input_field_title"">Finish Date*</div>
");
                WriteLiteral("                                     <input id=\"datepicker4\" class=\"datepicker2\" width=\"276\" name=\"NgayKetThuc\"");
                BeginWriteAttribute("value", "value=\"", 3666, "\"", 3691, 1);
#nullable restore
#line 52 "C:\Users\LLong\Desktop\Framework\Lollipop\Lollipop\Areas\Admin\Views\voucher\ViewVoucher.cshtml"
WriteAttributeValue("", 3673, Model.NgayKetThuc, 3673, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/>
                                </div>                      
                                <script>
                                    $('#datepicker4').datepicker({
                                        uiLibrary: 'bootstrap4'
                                    });                                       
                                </script>
                               </div>
                </div>    
            <a href=""javascript:void(0)"" class=""btn btn-success btn_updatecustomer"" value=""Update"" style=""float:right"">Update</a>       
        </div>            
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script>
    $(document).ready(function () {
        $("".btn_updatecustomer"").click(function () {
            console.log ('Da vao click');    
            var id =$('#idcustomer').val();
            var ten = $('#namecustomer').val();
            var phone =$('#phonecustomer').val();
            var date1 = $('.datepicker1').val();
            var date2 = $('.datepicker2').val();           
            console.log(id,ten, phone, date1, date2);
            $.ajax({
                url: '/Admin/voucher/UpdateVoucher',
                method: ""GET"",
                data: {MaVoucher:id, TenVoucher:ten, TiLeGiamGia : phone, NgayBatDau :date1, NgayKetThuc:date2},
                success: function (data) {
                    //alert(""Them thông tin thành công"");
                    //console.log('Thanh cong');
                    location.href=""/Admin/voucher/LietKeVoucher"";
                    ale");
            WriteLiteral(@"rt(""Update Voucher Successful"");
                    //$('#test').attr(""class"",""alert alert-success"");
                    //$('#test').html('Da Them thanh cong');
                    console.log(""dang LietKeKH"");
                },
                error: function (data) {
                    alert('Error');
                }
            });
          
        });
    });
</script>
   
    

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lollipop_boutique.Areas.Admin.Models.voucher> Html { get; private set; }
    }
}
#pragma warning restore 1591
