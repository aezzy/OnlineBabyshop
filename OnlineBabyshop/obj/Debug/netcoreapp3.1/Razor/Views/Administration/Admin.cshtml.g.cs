#pragma checksum "C:\Users\Lexicon\source\repos\OnlineBabyshop\OnlineBabyshop\Views\Administration\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac082e37b8c7f5989c6a34ad0326da4b2b85542a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_Admin), @"mvc.1.0.view", @"/Views/Administration/Admin.cshtml")]
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
#line 1 "C:\Users\Lexicon\source\repos\OnlineBabyshop\OnlineBabyshop\Views\_ViewImports.cshtml"
using OnlineBabyshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lexicon\source\repos\OnlineBabyshop\OnlineBabyshop\Views\_ViewImports.cshtml"
using OnlineBabyshop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac082e37b8c7f5989c6a34ad0326da4b2b85542a", @"/Views/Administration/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d509ab7cbd5f1f00856129f9fe81aefbf12ecdd", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Lexicon\source\repos\OnlineBabyshop\OnlineBabyshop\Views\Administration\Admin.cshtml"
  
    ViewData["Title"] = "Admin";
   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""main"">
<h1>Administration</h1>


<a href=""https://localhost:44354/Administration/Index""><h3>All Users</h3></a>

<a href=""https://localhost:44354/Categories/Index""><h3>Categories</h3></a>

<a href=""https://localhost:44354/Products/Index""><h3>Products</h3></a>
<a href=""https://localhost:44354/Sizes/Index""><h3>Sizes</h3></a>
<a href=""https://localhost:44354/Genders/Index""><h3>Gender</h3></a>

    </div>");
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
