#pragma checksum "C:\Users\TEST\OneDrive\BCIT\3973_Semester_7\Week_2\InClass\AspCorePrimer\Views\Category\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b60187da18fa7402002b71ca4484e0c9c6bee65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Details), @"mvc.1.0.view", @"/Views/Category/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/Details.cshtml", typeof(AspNetCore.Views_Category_Details))]
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
#line 1 "C:\Users\TEST\OneDrive\BCIT\3973_Semester_7\Week_2\InClass\AspCorePrimer\Views\_ViewImports.cshtml"
using AspCorePrimer;

#line default
#line hidden
#line 2 "C:\Users\TEST\OneDrive\BCIT\3973_Semester_7\Week_2\InClass\AspCorePrimer\Views\_ViewImports.cshtml"
using AspCorePrimer.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b60187da18fa7402002b71ca4484e0c9c6bee65", @"/Views/Category/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c229c2798faa4a902f2669bdc4478333728c3d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspCorePrimer.NW.Categories>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\TEST\OneDrive\BCIT\3973_Semester_7\Week_2\InClass\AspCorePrimer\Views\Category\Details.cshtml"
  
    ViewData["Title"] = "Northwind Category Details";

#line default
#line hidden
            BeginContext(100, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(105, 17, false);
#line 6 "C:\Users\TEST\OneDrive\BCIT\3973_Semester_7\Week_2\InClass\AspCorePrimer\Views\Category\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(122, 117, true);
            WriteLiteral("</h2>\r\n\r\n<p>This Card will display Details of Categoy Selected in the previous card.</p>\r\n\r\n<h1>Category Details of: ");
            EndContext();
            BeginContext(240, 18, false);
#line 10 "C:\Users\TEST\OneDrive\BCIT\3973_Semester_7\Week_2\InClass\AspCorePrimer\Views\Category\Details.cshtml"
                    Write(Model.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(258, 24, true);
            WriteLiteral("</h1>\r\n<h3>Category Id: ");
            EndContext();
            BeginContext(283, 16, false);
#line 11 "C:\Users\TEST\OneDrive\BCIT\3973_Semester_7\Week_2\InClass\AspCorePrimer\Views\Category\Details.cshtml"
            Write(Model.CategoryId);

#line default
#line hidden
            EndContext();
            BeginContext(299, 26, true);
            WriteLiteral("</h3>\r\n<h3>Category Name: ");
            EndContext();
            BeginContext(326, 18, false);
#line 12 "C:\Users\TEST\OneDrive\BCIT\3973_Semester_7\Week_2\InClass\AspCorePrimer\Views\Category\Details.cshtml"
              Write(Model.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(344, 33, true);
            WriteLiteral("</h3>\r\n<h3>Category Description: ");
            EndContext();
            BeginContext(378, 17, false);
#line 13 "C:\Users\TEST\OneDrive\BCIT\3973_Semester_7\Week_2\InClass\AspCorePrimer\Views\Category\Details.cshtml"
                     Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(395, 5, true);
            WriteLiteral("</h3>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspCorePrimer.NW.Categories> Html { get; private set; }
    }
}
#pragma warning restore 1591
