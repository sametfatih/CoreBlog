#pragma checksum "D:\c#\Blog-Project\Blog-Project\Views\Shared\Navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a7db77c21542f28f5e8f9c3fde11b353aa10844"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Navbar), @"mvc.1.0.view", @"/Views/Shared/Navbar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a7db77c21542f28f5e8f9c3fde11b353aa10844", @"/Views/Shared/Navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c8e0b416c3cc64e3f27590a32b512a6a4bf172f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0 header-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\c#\Blog-Project\Blog-Project\Views\Shared\Navbar.cshtml"
  
	string c1 = ViewData["CurrentPage"] == "Home" ? "active" : "";
	string c2 = ViewData["CurrentPage"] == "BlogList" ? "active" : ""; ;
	string c3 = ViewData["CurrentPage"] == "About" ? "active" : ""; ;
	string c4 = ViewData["CurrentPage"] == "Contact" ? "active" : ""; ;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""header_top"" id=""home"">
				<nav class=""navbar navbar-expand-lg navbar-light bg-light"">
					<button class=""navbar-toggler navbar-toggler-right mx-auto"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent""
						aria-expanded=""false"" aria-label=""Toggle navigation"">
						<span class=""navbar-toggler-icon""></span>
				   </button>


					<div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
						<ul class=""navbar-nav mr-auto"">
							<li");
            BeginWriteAttribute("class", " class=\"", 820, "\"", 840, 2);
            WriteAttributeValue("", 828, "nav-item", 828, 8, true);
#nullable restore
#line 19 "D:\c#\Blog-Project\Blog-Project\Views\Shared\Navbar.cshtml"
WriteAttributeValue(" ", 836, c1, 837, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<a class=\"nav-link\" href=\"/Blog\">Anasayfa\r\n\t\t\t\t\t\t\t\t\t<span class=\"sr-only\">(current)</span>\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t<li");
            BeginWriteAttribute("class", " class=\"", 982, "\"", 1002, 2);
            WriteAttributeValue("", 990, "nav-item", 990, 8, true);
#nullable restore
#line 24 "D:\c#\Blog-Project\Blog-Project\Views\Shared\Navbar.cshtml"
WriteAttributeValue(" ", 998, c2, 999, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<a class=\"nav-link\" href=\"/Blog/BlogList\">Bloglar</a>\r\n\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t<li");
            BeginWriteAttribute("class", " class=\"", 1093, "\"", 1113, 2);
            WriteAttributeValue("", 1101, "nav-item", 1101, 8, true);
#nullable restore
#line 27 "D:\c#\Blog-Project\Blog-Project\Views\Shared\Navbar.cshtml"
WriteAttributeValue(" ", 1109, c3, 1110, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<a class=\"nav-link\" href=\"/About\">Hakk??m??zda</a>\r\n\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t<li");
            BeginWriteAttribute("class", " class=\"", 1199, "\"", 1219, 2);
            WriteAttributeValue("", 1207, "nav-item", 1207, 8, true);
#nullable restore
#line 30 "D:\c#\Blog-Project\Blog-Project\Views\Shared\Navbar.cshtml"
WriteAttributeValue(" ", 1215, c4, 1216, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<a class=\"nav-link\" href=\"/Contact\">Bize Ula????n</a>\r\n\t\t\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a7db77c21542f28f5e8f9c3fde11b353aa108447563", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<input class=\"form-control mr-sm-2\" type=\"search\" placeholder=\"Buradan Aray??n..\" name=\"Search\"");
                BeginWriteAttribute("required", " required=\"", 1502, "\"", 1513, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<button class=\"btn btn1 my-2 my-sm-0\" type=\"submit\"><i class=\"fas fa-search\"></i></button>\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</nav>\r\n\r\n\t\t\t</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
