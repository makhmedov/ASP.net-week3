#pragma checksum "C:\Users\2201\Desktop\Blackshot_lab3 (1)\Blackshot\Blackshot\Views\calculator\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea93a1f41117b9afe3ddc973275efb0aa4ae99fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_calculator_Result), @"mvc.1.0.view", @"/Views/calculator/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/calculator/Result.cshtml", typeof(AspNetCore.Views_calculator_Result))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea93a1f41117b9afe3ddc973275efb0aa4ae99fe", @"/Views/calculator/Result.cshtml")]
    public class Views_calculator_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\2201\Desktop\Blackshot_lab3 (1)\Blackshot\Blackshot\Views\calculator\Result.cshtml"
  
    ViewData["Title"] = "Sum";

#line default
#line hidden
            BeginContext(39, 25, true);
            WriteLiteral("\r\n<h1 class=\"title is-1\">");
            EndContext();
            BeginContext(65, 18, false);
#line 5 "C:\Users\2201\Desktop\Blackshot_lab3 (1)\Blackshot\Blackshot\Views\calculator\Result.cshtml"
                  Write(ViewData["action"]);

#line default
#line hidden
            EndContext();
            BeginContext(83, 33, true);
            WriteLiteral("</h1>\r\n<h2 class=\"subtitle is-2\">");
            EndContext();
            BeginContext(117, 23, false);
#line 6 "C:\Users\2201\Desktop\Blackshot_lab3 (1)\Blackshot\Blackshot\Views\calculator\Result.cshtml"
                     Write(ViewData["firstNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(140, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(142, 16, false);
#line 6 "C:\Users\2201\Desktop\Blackshot_lab3 (1)\Blackshot\Blackshot\Views\calculator\Result.cshtml"
                                              Write(ViewData["mark"]);

#line default
#line hidden
            EndContext();
            BeginContext(158, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(160, 24, false);
#line 6 "C:\Users\2201\Desktop\Blackshot_lab3 (1)\Blackshot\Blackshot\Views\calculator\Result.cshtml"
                                                                Write(ViewData["secondNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(184, 4, true);
            WriteLiteral("  = ");
            EndContext();
            BeginContext(189, 18, false);
#line 6 "C:\Users\2201\Desktop\Blackshot_lab3 (1)\Blackshot\Blackshot\Views\calculator\Result.cshtml"
                                                                                             Write(ViewData["result"]);

#line default
#line hidden
            EndContext();
            BeginContext(207, 7, true);
            WriteLiteral("</h2>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
