#pragma checksum "C:\Users\Shayne Maravillo\source\repos\Larich.Achiever\Larich.Achiever.Web\Views\Achievers\Achievers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86af409458f0cc045e6783c1b8094e421f9613c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Achievers_Achievers), @"mvc.1.0.view", @"/Views/Achievers/Achievers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Achievers/Achievers.cshtml", typeof(AspNetCore.Views_Achievers_Achievers))]
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
#line 1 "C:\Users\Shayne Maravillo\source\repos\Larich.Achiever\Larich.Achiever.Web\Views\_ViewImports.cshtml"
using Larich.Achiever.Web;

#line default
#line hidden
#line 2 "C:\Users\Shayne Maravillo\source\repos\Larich.Achiever\Larich.Achiever.Web\Views\_ViewImports.cshtml"
using Larich.Achiever.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86af409458f0cc045e6783c1b8094e421f9613c8", @"/Views/Achievers/Achievers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb92122824c2452926900700f4e490fb60d62c85", @"/Views/_ViewImports.cshtml")]
    public class Views_Achievers_Achievers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Larich.Achiever.Web.ViewModels.Achievers.AchieversViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:750px;max-height:300px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Shayne Maravillo\source\repos\Larich.Achiever\Larich.Achiever.Web\Views\Achievers\Achievers.cshtml"
  
    ViewData["Title"] = "Achievers";
    Layout = "~/Views/Shared/_BlogWithWidgets.cshtml";

#line default
#line hidden
            BeginContext(169, 160, true);
            WriteLiteral("\r\n<div id=\"myCarousel\" class=\"carousel slide\"> \r\n    <!-- Carousel items --> \r\n    <div class=\"carousel-inner\">\r\n        <div class=\"active item\">\r\n            ");
            EndContext();
            BeginContext(329, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "48a6ce6df61b4cdd88869aa863fe1caf", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 360, "~/achievers/", 360, 12, true);
#line 11 "C:\Users\Shayne Maravillo\source\repos\Larich.Achiever\Larich.Achiever.Web\Views\Achievers\Achievers.cshtml"
AddHtmlAttributeValue("", 372, Model.AchieverId, 372, 17, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 389, "/banner.png", 389, 11, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(465, 43, true);
            WriteLiteral("\r\n\r\n        </div> <div class=\"item\">\r\n    ");
            EndContext();
            BeginContext(508, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "22dd58209ae342dcb6b7920d4de1ec9b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 539, "~/achievers/", 539, 12, true);
#line 14 "C:\Users\Shayne Maravillo\source\repos\Larich.Achiever\Larich.Achiever.Web\Views\Achievers\Achievers.cshtml"
AddHtmlAttributeValue("", 551, Model.AchieverId, 551, 17, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 568, "/banner.png", 568, 11, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(644, 284, true);
            WriteLiteral(@"
</div> 
        <div class=""item"" ></div> 
     </div> <!-- Carousel nav --> 
        <a class=""carousel-control left"" href=""#myCarousel"" data-slide=""prev"">&lsaquo;</a> 
        <a class=""carousel-control right"" href=""#myCarousel"" data-slide=""next"">&rsaquo;</a> 
</div>

<h2>");
            EndContext();
            BeginContext(929, 11, false);
#line 22 "C:\Users\Shayne Maravillo\source\repos\Larich.Achiever\Larich.Achiever.Web\Views\Achievers\Achievers.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(940, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(948, 23, false);
#line 23 "C:\Users\Shayne Maravillo\source\repos\Larich.Achiever\Larich.Achiever.Web\Views\Achievers\Achievers.cshtml"
Write(Html.Raw(Model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(971, 22, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Larich.Achiever.Web.ViewModels.Achievers.AchieversViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591