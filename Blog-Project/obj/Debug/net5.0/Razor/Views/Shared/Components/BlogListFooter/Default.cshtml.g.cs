#pragma checksum "D:\c#\Blog-Project\Blog-Project\Views\Shared\Components\BlogListFooter\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbb2b63066bb0939c0dc1944ea60be7bab069499"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogListFooter_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogListFooter/Default.cshtml")]
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
#line 1 "D:\c#\Blog-Project\Blog-Project\Views\_ViewImports.cshtml"
using Blog_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c#\Blog-Project\Blog-Project\Views\_ViewImports.cshtml"
using Blog_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c#\Blog-Project\Blog-Project\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbb2b63066bb0939c0dc1944ea60be7bab069499", @"/Views/Shared/Components/BlogListFooter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c8e0b416c3cc64e3f27590a32b512a6a4bf172f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogListFooter_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n<h3>Popüler Bloglar</h3>\r\n");
#nullable restore
#line 5 "D:\c#\Blog-Project\Blog-Project\Views\Shared\Components\BlogListFooter\Default.cshtml"
     foreach (var blog in Model)
    {    

#line default
#line hidden
#nullable disable
            WriteLiteral("         <div class=\"blog-grids row mb-3\">\r\n                 <div class=\"col-md-5 blog-grid-left\">\r\n                         <a");
            BeginWriteAttribute("href", " href=\"", 250, "\"", 287, 2);
            WriteAttributeValue("", 257, "/Blog/BlogDetails/", 257, 18, true);
#nullable restore
#line 9 "D:\c#\Blog-Project\Blog-Project\Views\Shared\Components\BlogListFooter\Default.cshtml"
WriteAttributeValue("", 275, blog.BlogId, 275, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                         <img");
            BeginWriteAttribute("src", " src=\"", 320, "\"", 345, 1);
#nullable restore
#line 10 "D:\c#\Blog-Project\Blog-Project\Views\Shared\Components\BlogListFooter\Default.cshtml"
WriteAttributeValue("", 326, blog.BlogImagePath, 326, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 364, "\"", 370, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                     </a>\r\n                 </div>\r\n                 <div class=\"col-md-7 blog-grid-right\">\r\n    \r\n                     <h5>\r\n                         <a");
            BeginWriteAttribute("href", " href=\"", 543, "\"", 580, 2);
            WriteAttributeValue("", 550, "/Blog/BlogDetails/", 550, 18, true);
#nullable restore
#line 16 "D:\c#\Blog-Project\Blog-Project\Views\Shared\Components\BlogListFooter\Default.cshtml"
WriteAttributeValue("", 568, blog.BlogId, 568, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "D:\c#\Blog-Project\Blog-Project\Views\Shared\Components\BlogListFooter\Default.cshtml"
                                                             Write(blog.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                     </h5>\r\n                     <div class=\"sub-meta\">\r\n                         <span>\r\n                                 <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 20 "D:\c#\Blog-Project\Blog-Project\Views\Shared\Components\BlogListFooter\Default.cshtml"
                                                          Write(((DateTime)blog.BlogCreateDate).ToString("MMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                     </div>\r\n                 </div>\r\n    \r\n         </div>\r\n");
#nullable restore
#line 25 "D:\c#\Blog-Project\Blog-Project\Views\Shared\Components\BlogListFooter\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591