#pragma checksum "D:\c#\Blog-Project\Blog-Project\Views\Shared\Components\AuthorBlogs\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9de91089d1e1212903628250187bc5b7b6182483"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AuthorBlogs_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AuthorBlogs/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de91089d1e1212903628250187bc5b7b6182483", @"/Views/Shared/Components/AuthorBlogs/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c8e0b416c3cc64e3f27590a32b512a6a4bf172f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AuthorBlogs_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"tech-btm\">\r\n    <h4>Yazarın Diğer Blogları</h4>\r\n");
#nullable restore
#line 4 "D:\c#\Blog-Project\Blog-Project\Views\Shared\Components\AuthorBlogs\Default.cshtml"
     foreach (var blog in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"blog-grids row mb-3\">\r\n             <div class=\"col-md-5 blog-grid-left\">\r\n                 <a");
            BeginWriteAttribute("href", " href=\"", 244, "\"", 281, 2);
            WriteAttributeValue("", 251, "/Blog/BlogDetails/", 251, 18, true);
#nullable restore
#line 8 "D:\c#\Blog-Project\Blog-Project\Views\Shared\Components\AuthorBlogs\Default.cshtml"
WriteAttributeValue("", 269, blog.BlogId, 269, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                         <img");
            BeginWriteAttribute("src", " src=\"", 314, "\"", 339, 1);
#nullable restore
#line 9 "D:\c#\Blog-Project\Blog-Project\Views\Shared\Components\AuthorBlogs\Default.cshtml"
WriteAttributeValue("", 320, blog.BlogImagePath, 320, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 358, "\"", 364, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                 </a>\r\n             </div>\r\n             <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                 <h5>\r\n                         <a");
            BeginWriteAttribute("href", " href=\"", 517, "\"", 554, 2);
            WriteAttributeValue("", 524, "/Blog/BlogDetails/", 524, 18, true);
#nullable restore
#line 15 "D:\c#\Blog-Project\Blog-Project\Views\Shared\Components\AuthorBlogs\Default.cshtml"
WriteAttributeValue("", 542, blog.BlogId, 542, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "D:\c#\Blog-Project\Blog-Project\Views\Shared\Components\AuthorBlogs\Default.cshtml"
                                                             Write(blog.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                 </h5>\r\n                 <div class=\"sub-meta\">\r\n                     <span>\r\n                             <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 19 "D:\c#\Blog-Project\Blog-Project\Views\Shared\Components\AuthorBlogs\Default.cshtml"
                                                      Write(((DateTime)blog.BlogCreateDate).ToString("MMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                 </div>\r\n             </div>\r\n\r\n         </div>\r\n");
#nullable restore
#line 24 "D:\c#\Blog-Project\Blog-Project\Views\Shared\Components\AuthorBlogs\Default.cshtml"

    }   

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>\r\n");
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
