#pragma checksum "D:\c#\Blog-Project\Blog-Project\Views\Blog\BlogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17100d5acd3318ec053487d0132b06ad804d9c88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogList), @"mvc.1.0.view", @"/Views/Blog/BlogList.cshtml")]
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
#line 1 "D:\c#\Blog-Project\Blog-Project\Views\Blog\BlogList.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17100d5acd3318ec053487d0132b06ad804d9c88", @"/Views/Blog/BlogList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c8e0b416c3cc64e3f27590a32b512a6a4bf172f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\c#\Blog-Project\Blog-Project\Views\Blog\BlogList.cshtml"
  
	ViewData["Title"] = "BlogList";
	ViewData["CurrentPage"] = "BlogList";
	Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
	<!--/banner-->
	<div class=""banner-inner""></div>
	
	<!--//banner-->

	<!--/main-->
	<section class=""main-content-w3layouts-agileits"">
		<div class=""container"">
			<h3 class=""tittle"">T??m Bloglar</h3>
			<div class=""inner-sec"">
				<!--left-->
				<div class=""left-blog-info-w3layouts-agileits text-left"">
					<div class=""row"">
");
#nullable restore
#line 23 "D:\c#\Blog-Project\Blog-Project\Views\Blog\BlogList.cshtml"
                         foreach(var blog in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<div class=\"col-lg-4 card my-lg-4 my-md-1 my-0\">\r\n\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 624, "\"", 661, 2);
            WriteAttributeValue("", 631, "/Blog/BlogDetails/", 631, 18, true);
#nullable restore
#line 25 "D:\c#\Blog-Project\Blog-Project\Views\Blog\BlogList.cshtml"
WriteAttributeValue("", 649, blog.BlogId, 649, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: flex;justify-content: center;\">\r\n\t\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 725, "\"", 750, 1);
#nullable restore
#line 26 "D:\c#\Blog-Project\Blog-Project\Views\Blog\BlogList.cshtml"
WriteAttributeValue("", 731, blog.BlogImagePath, 731, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\" style=\"height:190px;width:330px;\"");
            BeginWriteAttribute("alt", " alt=\"", 816, "\"", 822, 0);
            EndWriteAttribute();
            WriteLiteral(@">
							</a>
							<div class=""card-body"">
                                <ul class=""blog-icons my-4"">
                                    <li>
                                        <a>
                                            <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 32 "D:\c#\Blog-Project\Blog-Project\Views\Blog\BlogList.cshtml"
                                                                            Write(((DateTime)blog.BlogCreateDate).ToString("MMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </li>\r\n                                    ");
#nullable restore
#line 35 "D:\c#\Blog-Project\Blog-Project\Views\Blog\BlogList.cshtml"
                               Write(await Component.InvokeAsync("BlogCommentStats", new { id = @blog.BlogId, display=2 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <li>\r\n\r\n                                        <span class=\"badge\"");
            BeginWriteAttribute("style", " style=\"", 1477, "\"", 1586, 8);
            WriteAttributeValue("", 1485, "border-radius:", 1485, 14, true);
            WriteAttributeValue(" ", 1499, "0px;", 1500, 5, true);
            WriteAttributeValue(" ", 1504, "background-color:", 1505, 18, true);
#nullable restore
#line 38 "D:\c#\Blog-Project\Blog-Project\Views\Blog\BlogList.cshtml"
WriteAttributeValue(" ", 1522, blog.Category.CategoryColorHex, 1523, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1554, ";", 1554, 1, true);
            WriteAttributeValue(" ", 1555, "color:white;", 1556, 13, true);
            WriteAttributeValue(" ", 1568, "font-weight:500;", 1569, 17, true);
            WriteAttributeValue(" ", 1585, "", 1586, 1, true);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 38 "D:\c#\Blog-Project\Blog-Project\Views\Blog\BlogList.cshtml"
                                                                                                                                                                      Write(blog.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </li>\r\n\r\n                                </ul>\r\n\t\t\t\t\t\t\t\t<h5 class=\"card-title\">\r\n\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1754, "\"", 1791, 2);
            WriteAttributeValue("", 1761, "/Blog/BlogDetails/", 1761, 18, true);
#nullable restore
#line 43 "D:\c#\Blog-Project\Blog-Project\Views\Blog\BlogList.cshtml"
WriteAttributeValue("", 1779, blog.BlogId, 1779, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "D:\c#\Blog-Project\Blog-Project\Views\Blog\BlogList.cshtml"
                                                                            Write(blog.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t</h5>\r\n");
#nullable restore
#line 45 "D:\c#\Blog-Project\Blog-Project\Views\Blog\BlogList.cshtml"
                                 if (blog.BlogContentText.Length >= 200)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<p class=\"card-text mb-3\">");
#nullable restore
#line 47 "D:\c#\Blog-Project\Blog-Project\Views\Blog\BlogList.cshtml"
                                                         Write(blog.BlogContentText.Substring(0, blog.BlogContentText.Substring(0, 200).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\t\t\t\t\t\t\t\t");
#nullable restore
#line 47 "D:\c#\Blog-Project\Blog-Project\Views\Blog\BlogList.cshtml"
                                                                                                                                                                                                }
								else
								{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<p class=\"card-text mb-3\">");
#nullable restore
#line 50 "D:\c#\Blog-Project\Blog-Project\Views\Blog\BlogList.cshtml"
                                                         Write(blog.BlogContentText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 51 "D:\c#\Blog-Project\Blog-Project\Views\Blog\BlogList.cshtml"
								}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2143, "\"", 2180, 2);
            WriteAttributeValue("", 2150, "/Blog/BlogDetails/", 2150, 18, true);
#nullable restore
#line 52 "D:\c#\Blog-Project\Blog-Project\Views\Blog\BlogList.cshtml"
WriteAttributeValue("", 2168, blog.BlogId, 2168, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Devam??n?? Oku</a>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 55 "D:\c#\Blog-Project\Blog-Project\Views\Blog\BlogList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"						
					</div>
					<nav aria-label=""Page navigation example"">
							<ul class=""pagination justify-content-left mt-4"">
								<li class=""page-item disabled"">
									<a class=""page-link"" href=""#"" tabindex=""-1"">Previous</a>
								</li>
								<li class=""page-item"">
									<a class=""page-link"" href=""#"">1</a>
								</li>
								<li class=""page-item"">
									<a class=""page-link"" href=""#"">2</a>
								</li>
								<li class=""page-item"">
									<a class=""page-link"" href=""#"">3</a>
								</li>
								<li class=""page-item"">
									<a class=""page-link"" href=""#"">Next</a>
								</li>
							</ul>
						</nav>
					<!--//left-->
				</div>
			</div>
		</div>
	</section>
	<!--//main-->

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
