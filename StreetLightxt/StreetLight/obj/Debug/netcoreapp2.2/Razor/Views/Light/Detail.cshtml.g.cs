#pragma checksum "C:\Users\john\Desktop\StreetLight\StreetLight\Views\Light\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "773de19ed8fb473b7be3d792e890e6eff988bbce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Light_Detail), @"mvc.1.0.view", @"/Views/Light/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Light/Detail.cshtml", typeof(AspNetCore.Views_Light_Detail))]
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
#line 1 "C:\Users\john\Desktop\StreetLight\StreetLight\Views\_ViewImports.cshtml"
using StreetLight;

#line default
#line hidden
#line 2 "C:\Users\john\Desktop\StreetLight\StreetLight\Views\_ViewImports.cshtml"
using StreetLight.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"773de19ed8fb473b7be3d792e890e6eff988bbce", @"/Views/Light/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d71ee686ccd5105c93c06c624f505a8e29406392", @"/Views/_ViewImports.cshtml")]
    public class Views_Light_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StreetLight.Models.Light>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/cel.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Light", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(35, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\john\Desktop\StreetLight\StreetLight\Views\Light\Detail.cshtml"
  

    var photoPath = "~/images/" + (Model.PhotoPath ?? "light2.png");



#line default
#line hidden
            BeginContext(120, 19, true);
            WriteLiteral("}\r\n    <html>\r\n    ");
            EndContext();
            BeginContext(139, 810, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "773de19ed8fb473b7be3d792e890e6eff988bbce6482", async() => {
                BeginContext(145, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(155, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "773de19ed8fb473b7be3d792e890e6eff988bbce6872", async() => {
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
                EndContext();
                BeginContext(201, 741, true);
                WriteLiteral(@"
        <style>
            .detail { 
                       position:absolute;
                       top:15%;
                       right:40%; 
                       width:300px;

            }
            .detail-main {
                padding:5px;
            }
            .detail-main-lable {
                font-weight:bold;
                
                
                width:140px;
            }
            .detail-main-main {
                display:inline-block;
                margin-left:10px;
            }
            .detail-img {
                position: absolute;
                top: 15%;
                left: 15%;
                width:auto;
            }

        </style>
    ");
                EndContext();
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
            EndContext();
            BeginContext(949, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(955, 3001, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "773de19ed8fb473b7be3d792e890e6eff988bbce9745", async() => {
                BeginContext(961, 297, true);
                WriteLiteral(@"

        <div class=""detail"">

            <div class=""detail-main"">
                <label class=""detail-main-lable"">
                    路&nbsp&nbsp&nbsp灯&nbsp&nbsp&nbsp名&nbsp&nbsp&nbsp称&nbsp：
                </label>
                <div class=""detail-main-main"">
                    ");
                EndContext();
                BeginContext(1259, 10, false);
#line 53 "C:\Users\john\Desktop\StreetLight\StreetLight\Views\Light\Detail.cshtml"
               Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1269, 308, true);
                WriteLiteral(@"
                </div>
            </div>


            <div class=""detail-main"">
                <label class=""detail-main-lable"">

                    路&nbsp&nbsp&nbsp灯&nbsp&nbsp&nbsp经&nbsp&nbsp度&nbsp：
                </label>
                <div class=""detail-main-main"">
                    ");
                EndContext();
                BeginContext(1578, 9, false);
#line 64 "C:\Users\john\Desktop\StreetLight\StreetLight\Views\Light\Detail.cshtml"
               Write(Model.Lng);

#line default
#line hidden
                EndContext();
                BeginContext(1587, 313, true);
                WriteLiteral(@"
                </div>
            </div>


            <div class=""detail-main"">
                <label class=""detail-main-lable"">

                    路&nbsp&nbsp&nbsp灯&nbsp&nbsp&nbsp纬&nbsp&nbsp&nbsp度&nbsp：
                </label>
                <div class=""detail-main-main"">
                    ");
                EndContext();
                BeginContext(1901, 9, false);
#line 75 "C:\Users\john\Desktop\StreetLight\StreetLight\Views\Light\Detail.cshtml"
               Write(Model.Lat);

#line default
#line hidden
                EndContext();
                BeginContext(1910, 313, true);
                WriteLiteral(@"

                </div>
            </div>

            <div class=""detail-main"">
                <label class=""detail-main-lable"">

                    路&nbsp&nbsp&nbsp灯&nbsp&nbsp&nbsp状&nbsp&nbsp&nbsp况&nbsp：
                </label>
                <div class=""detail-main-main"">
                    ");
                EndContext();
                BeginContext(2224, 12, false);
#line 86 "C:\Users\john\Desktop\StreetLight\StreetLight\Views\Light\Detail.cshtml"
               Write(Model.Iswell);

#line default
#line hidden
                EndContext();
                BeginContext(2236, 292, true);
                WriteLiteral(@"

                </div>
            </div>


            <div class=""detail-main"">
                <label class=""detail-main-lable"">

                    路&nbsp灯&nbsp照&nbsp明&nbsp情&nbsp况：
                </label>
                <div class=""detail-main-main"">
                    ");
                EndContext();
                BeginContext(2529, 12, false);
#line 98 "C:\Users\john\Desktop\StreetLight\StreetLight\Views\Light\Detail.cshtml"
               Write(Model.Iswork);

#line default
#line hidden
                EndContext();
                BeginContext(2541, 304, true);
                WriteLiteral(@"

                </div>
            </div>


            <div class=""detail-main"">
                <label class=""detail-main-lable"">
                    路&nbsp&nbsp灯&nbsp&nbsp采&nbsp&nbsp集&nbsp&nbsp器：
                </label>
                <div class=""detail-main-main"">
                    ");
                EndContext();
                BeginContext(2846, 11, false);
#line 109 "C:\Users\john\Desktop\StreetLight\StreetLight\Views\Light\Detail.cshtml"
               Write(Model.Celle);

#line default
#line hidden
                EndContext();
                BeginContext(2857, 306, true);
                WriteLiteral(@"

                </div>
            </div>


            <div class=""detail-main"">
                <label class=""detail-main-lable"">

                    路&nbsp&nbsp灯&nbsp&nbsp控&nbsp&nbsp制&nbsp&nbsp器：
                </label>
                <div class=""detail-main-main"">
                    ");
                EndContext();
                BeginContext(3164, 13, false);
#line 121 "C:\Users\john\Desktop\StreetLight\StreetLight\Views\Light\Detail.cshtml"
               Write(Model.Control);

#line default
#line hidden
                EndContext();
                BeginContext(3177, 304, true);
                WriteLiteral(@"

                </div>
            </div>


            <div class=""detail-main"">
                <label class=""detail-main-lable"">
                    路&nbsp&nbsp灯&nbsp&nbsp传&nbsp&nbsp感&nbsp&nbsp器：
                </label>
                <div class=""detail-main-main"">
                    ");
                EndContext();
                BeginContext(3482, 10, false);
#line 132 "C:\Users\john\Desktop\StreetLight\StreetLight\Views\Light\Detail.cshtml"
               Write(Model.Sens);

#line default
#line hidden
                EndContext();
                BeginContext(3492, 103, true);
                WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n      \r\n\r\n\r\n\r\n\r\n\r\n\r\n            <div>\r\n                ");
                EndContext();
                BeginContext(3595, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "773de19ed8fb473b7be3d792e890e6eff988bbce15499", async() => {
                    BeginContext(3688, 4, true);
                    WriteLiteral("编辑路灯");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 144 "C:\Users\john\Desktop\StreetLight\StreetLight\Views\Light\Detail.cshtml"
                                                              WriteLiteral(Model.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3696, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(3714, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "773de19ed8fb473b7be3d792e890e6eff988bbce18281", async() => {
                    BeginContext(3785, 2, true);
                    WriteLiteral("返回");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3791, 82, true);
                WriteLiteral("\r\n            </div>\r\n    </div>\r\n\r\n        <div class=\"detail-img\">\r\n            ");
                EndContext();
                BeginContext(3873, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "773de19ed8fb473b7be3d792e890e6eff988bbce20130", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                BeginWriteTagHelperAttribute();
#line 150 "C:\Users\john\Desktop\StreetLight\StreetLight\Views\Light\Detail.cshtml"
          WriteLiteral(photoPath);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 150 "C:\Users\john\Desktop\StreetLight\StreetLight\Views\Light\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3923, 26, true);
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3956, 29, true);
            WriteLiteral("\r\n    </html>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StreetLight.Models.Light> Html { get; private set; }
    }
}
#pragma warning restore 1591