#pragma checksum "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\News\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c58d3a113fd4e50dee51953fd3ea557f2a0be599"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_News_Details), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/News/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminPanel/Views/News/Details.cshtml", typeof(AspNetCore.Areas_AdminPanel_Views_News_Details))]
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
#line 1 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\_ViewImports.cshtml"
using MyCreate;

#line default
#line hidden
#line 2 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\_ViewImports.cshtml"
using MyCreate.model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c58d3a113fd4e50dee51953fd3ea557f2a0be599", @"/Areas/AdminPanel/Views/News/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"740999e1c5f99042b6870d9b6c7159674e777e28", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_News_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyCreate.model.News>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DetailsPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\News\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(68, 222, true);
            WriteLiteral("\n<h2>Details</h2>\n<div class=\"au-card recent-report\">\n    <div class=\"container\">\n\n        <div>\n            <h4>News</h4>\n            <hr />\n            <dl class=\"dl-horizontal\">\n                <dt>\n                    ");
            EndContext();
            BeginContext(291, 41, false);
#line 16 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\News\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(332, 64, true);
            WriteLiteral("\n                </dt>\n                <dd>\n                    ");
            EndContext();
            BeginContext(397, 37, false);
#line 19 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\News\Details.cshtml"
               Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(434, 64, true);
            WriteLiteral("\n                </dd>\n                <dt>\n                    ");
            EndContext();
            BeginContext(499, 40, false);
#line 22 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\News\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(539, 64, true);
            WriteLiteral("\n                </dt>\n                <dd>\n                    ");
            EndContext();
            BeginContext(604, 36, false);
#line 25 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\News\Details.cshtml"
               Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(640, 64, true);
            WriteLiteral("\n                </dd>\n                <dt>\n                    ");
            EndContext();
            BeginContext(705, 39, false);
#line 28 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\News\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.img));

#line default
#line hidden
            EndContext();
            BeginContext(744, 64, true);
            WriteLiteral("\n                </dt>\n                <dt>\n                    ");
            EndContext();
            BeginContext(809, 41, false);
#line 31 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\News\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Topic));

#line default
#line hidden
            EndContext();
            BeginContext(850, 64, true);
            WriteLiteral("\n                </dt>\n                <dd>\n                    ");
            EndContext();
            BeginContext(915, 37, false);
#line 34 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\News\Details.cshtml"
               Write(Html.DisplayFor(model => model.Topic));

#line default
#line hidden
            EndContext();
            BeginContext(952, 64, true);
            WriteLiteral("\n                </dd>\n                <dt>\n                    ");
            EndContext();
            BeginContext(1017, 44, false);
#line 37 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\News\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.categoty));

#line default
#line hidden
            EndContext();
            BeginContext(1061, 64, true);
            WriteLiteral("\n                </dt>\n                <dd>\n                    ");
            EndContext();
            BeginContext(1126, 45, false);
#line 40 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\News\Details.cshtml"
               Write(Html.DisplayFor(model => model.categoty.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1171, 168, true);
            WriteLiteral("\n                </dd>\n            </dl>\n        </div>\n        <div>\n            <div class=\"form-group row\">\n                <div class=\"col-5 \">\n                    ");
            EndContext();
            BeginContext(1339, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e22f8ae4c64846c786c0444674a5a32d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1370, 77, true);
            WriteLiteral("\n                </div>\n            </div> \n        </div>\n\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyCreate.model.News> Html { get; private set; }
    }
}
#pragma warning restore 1591