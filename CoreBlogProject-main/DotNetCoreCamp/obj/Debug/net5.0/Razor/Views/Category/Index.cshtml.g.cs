#pragma checksum "C:\Users\yildi\Desktop\.netcore\dosyaaa\CoreBlogProject-main\CoreBlogProject-main\DotNetCoreCamp\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a683c5d8221c88a6199f30456e230243ffaf21f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\yildi\Desktop\.netcore\dosyaaa\CoreBlogProject-main\CoreBlogProject-main\DotNetCoreCamp\Views\_ViewImports.cshtml"
using DotNetCoreCamp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yildi\Desktop\.netcore\dosyaaa\CoreBlogProject-main\CoreBlogProject-main\DotNetCoreCamp\Views\_ViewImports.cshtml"
using DotNetCoreCamp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\yildi\Desktop\.netcore\dosyaaa\CoreBlogProject-main\CoreBlogProject-main\DotNetCoreCamp\Views\Category\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a683c5d8221c88a6199f30456e230243ffaf21f", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02323c758e8c08e0d923359d2e1696433b261ea0", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\yildi\Desktop\.netcore\dosyaaa\CoreBlogProject-main\CoreBlogProject-main\DotNetCoreCamp\Views\Category\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a683c5d8221c88a6199f30456e230243ffaf21f4435", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<table class=\"table table-bordered\">\n    <tr>\n        <th>#</th>\n        <th>KATEGORİ ADI</th>\n        <th>DURUM</th>\n        <th>DETAYLAR</th>\n        <th>SİL</th>\n    </tr>\n");
#nullable restore
#line 17 "C:\Users\yildi\Desktop\.netcore\dosyaaa\CoreBlogProject-main\CoreBlogProject-main\DotNetCoreCamp\Views\Category\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 20 "C:\Users\yildi\Desktop\.netcore\dosyaaa\CoreBlogProject-main\CoreBlogProject-main\DotNetCoreCamp\Views\Category\Index.cshtml"
           Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 21 "C:\Users\yildi\Desktop\.netcore\dosyaaa\CoreBlogProject-main\CoreBlogProject-main\DotNetCoreCamp\Views\Category\Index.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 22 "C:\Users\yildi\Desktop\.netcore\dosyaaa\CoreBlogProject-main\CoreBlogProject-main\DotNetCoreCamp\Views\Category\Index.cshtml"
           Write(item.CategoryStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td><a href=\"#\" class=\"btn btn-warning\">Detaylar</a></td>\n            <td><a href=\"#\" class=\"btn btn-danger\">Sil</a></td>\n        </tr>\n");
#nullable restore
#line 26 "C:\Users\yildi\Desktop\.netcore\dosyaaa\CoreBlogProject-main\CoreBlogProject-main\DotNetCoreCamp\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
