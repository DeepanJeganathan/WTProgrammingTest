#pragma checksum "C:\Users\14168\Downloads\WTProgammingTest (1)\WTProgammingTest\WTProgammingTest\WTProgammingTest\Views\Home\Sorted.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae9f70e874d972391d5d3d6d450e494fcbf7fb5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Sorted), @"mvc.1.0.view", @"/Views/Home/Sorted.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Sorted.cshtml", typeof(AspNetCore.Views_Home_Sorted))]
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
#line 1 "C:\Users\14168\Downloads\WTProgammingTest (1)\WTProgammingTest\WTProgammingTest\WTProgammingTest\Views\_ViewImports.cshtml"
using WTProgammingTest;

#line default
#line hidden
#line 2 "C:\Users\14168\Downloads\WTProgammingTest (1)\WTProgammingTest\WTProgammingTest\WTProgammingTest\Views\_ViewImports.cshtml"
using WTProgammingTest.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae9f70e874d972391d5d3d6d450e494fcbf7fb5b", @"/Views/Home/Sorted.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dec44d770af1875bfa72fbe60f5cdf1b7de1bf5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Sorted : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WTProgammingTest.ViewModels.MainObjectViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\14168\Downloads\WTProgammingTest (1)\WTProgammingTest\WTProgammingTest\WTProgammingTest\Views\Home\Sorted.cshtml"
  
    ViewData["Title"] = "ByLocation";

#line default
#line hidden
            BeginContext(117, 11, true);
            WriteLiteral("\r\n    <h3> ");
            EndContext();
            BeginContext(129, 19, false);
#line 7 "C:\Users\14168\Downloads\WTProgammingTest (1)\WTProgammingTest\WTProgammingTest\WTProgammingTest\Views\Home\Sorted.cshtml"
    Write(ViewData["Heading"]);

#line default
#line hidden
            EndContext();
            BeginContext(148, 343, true);
            WriteLiteral(@"</h3>

    <div class=""row "">
        <table class=""table"">
            <thead class=""bg-primary"">
                <tr>
                    <th scope=""col"">Values</th>
                    <th scope=""col"">Characters</th>
                    <th scope=""col"">Data</th>
                </tr>
            </thead>
            <tbody>

");
            EndContext();
#line 20 "C:\Users\14168\Downloads\WTProgammingTest (1)\WTProgammingTest\WTProgammingTest\WTProgammingTest\Views\Home\Sorted.cshtml"
                 foreach (var obj in Model)
                {

#line default
#line hidden
            BeginContext(555, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(610, 9, false);
#line 23 "C:\Users\14168\Downloads\WTProgammingTest (1)\WTProgammingTest\WTProgammingTest\WTProgammingTest\Views\Home\Sorted.cshtml"
                       Write(obj.Value);

#line default
#line hidden
            EndContext();
            BeginContext(619, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(655, 14, false);
#line 24 "C:\Users\14168\Downloads\WTProgammingTest (1)\WTProgammingTest\WTProgammingTest\WTProgammingTest\Views\Home\Sorted.cshtml"
                       Write(obj.Characters);

#line default
#line hidden
            EndContext();
            BeginContext(669, 457, true);
            WriteLiteral(@"</td>
                        <td>
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">Values</th>
                                        <th scope=""col"" class=""text-center"">Location</th>
                                    </tr>
                                </thead>
                                <tbody>
");
            EndContext();
#line 34 "C:\Users\14168\Downloads\WTProgammingTest (1)\WTProgammingTest\WTProgammingTest\WTProgammingTest\Views\Home\Sorted.cshtml"
                                     foreach (var nestedObj in obj.Data)
                                    {                                       

#line default
#line hidden
            BeginContext(1278, 174, true);
            WriteLiteral("                                            <tr>\r\n                                                <td class=\"text-left\">\r\n                                                    ");
            EndContext();
            BeginContext(1453, 15, false);
#line 38 "C:\Users\14168\Downloads\WTProgammingTest (1)\WTProgammingTest\WTProgammingTest\WTProgammingTest\Views\Home\Sorted.cshtml"
                                               Write(nestedObj.Value);

#line default
#line hidden
            EndContext();
            BeginContext(1468, 186, true);
            WriteLiteral("\r\n                                                </td>\r\n\r\n                                                <td class=\"text-center \">\r\n                                                    ");
            EndContext();
            BeginContext(1655, 18, false);
#line 42 "C:\Users\14168\Downloads\WTProgammingTest (1)\WTProgammingTest\WTProgammingTest\WTProgammingTest\Views\Home\Sorted.cshtml"
                                               Write(nestedObj.Location);

#line default
#line hidden
            EndContext();
            BeginContext(1673, 108, true);
            WriteLiteral("\r\n                                                </td>\r\n                                            </tr>\r\n");
            EndContext();
#line 45 "C:\Users\14168\Downloads\WTProgammingTest (1)\WTProgammingTest\WTProgammingTest\WTProgammingTest\Views\Home\Sorted.cshtml"
                                   
                                    }

#line default
#line hidden
            BeginContext(1857, 138, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 51 "C:\Users\14168\Downloads\WTProgammingTest (1)\WTProgammingTest\WTProgammingTest\WTProgammingTest\Views\Home\Sorted.cshtml"
                }

#line default
#line hidden
            BeginContext(2014, 54, true);
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WTProgammingTest.ViewModels.MainObjectViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591