#pragma checksum "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c66a4667c31880ca1fb2e6e3552cbafadc350ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\_ViewImports.cshtml"
using MyCreate;

#line default
#line hidden
#line 2 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\_ViewImports.cshtml"
using MyCreate.model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c66a4667c31880ca1fb2e6e3552cbafadc350ed", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a464be36d847ed30dd62ab4636f424ea3d05bc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Categoty>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(66, 153, true);
            WriteLiteral("\r\n\r\n    <section id=\"featured-services\" class=\"featured-services\">\r\n        <div class=\"container\" data-aos=\"fade-up\">\r\n\r\n            <div class=\"row\">\r\n");
            EndContext();
#line 12 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\Home\Index.cshtml"
                 foreach (var item in Model)
                {



#line default
#line hidden
            BeginContext(288, 344, true);
            WriteLiteral(@"                    <div class=""col-md-6 col-lg-3 d-flex align-items-stretch mb-5 mb-lg-0"">
                        <div class=""icon-box"" style="" width:100%"" data-aos=""fade-up"" data-aos-delay=""100"">
                            <div class=""icon""><i class=""fas fa-newspaper""></i></div>
                            <h4 class=""title""><a href="""">");
            EndContext();
            BeginContext(633, 9, false);
#line 19 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\Home\Index.cshtml"
                                                    Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(642, 62, true);
            WriteLiteral("</a></h4>\r\n                            <p class=\"description\">");
            EndContext();
            BeginContext(705, 16, false);
#line 20 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\Home\Index.cshtml"
                                              Write(item.Discription);

#line default
#line hidden
            EndContext();
            BeginContext(721, 57, true);
            WriteLiteral("</p>\r\n                            <a class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 778, "\"", 803, 2);
            WriteAttributeValue("", 785, "Home/News/", 785, 10, true);
#line 21 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\Home\Index.cshtml"
WriteAttributeValue("", 795, item.Id, 795, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(804, 71, true);
            WriteLiteral(">Read</a>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 24 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\Home\Index.cshtml"


                }

#line default
#line hidden
            BeginContext(898, 92, true);
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n    </section><!-- End Featured Services Section -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Categoty>> Html { get; private set; }
    }
}
#pragma warning restore 1591
