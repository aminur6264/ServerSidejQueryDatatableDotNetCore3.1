#pragma checksum "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "238f1254c923db9ba852c9b35a0e09f24e4934a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\_ViewImports.cshtml"
using ServerSidejQueryDatatableDotNetCore3._1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\_ViewImports.cshtml"
using ServerSidejQueryDatatableDotNetCore3._1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"238f1254c923db9ba852c9b35a0e09f24e4934a7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1a281e6d29a6845ae334c740ecd5dc3a34e35b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<div class=""row text-center"">
    <div class=""col-sm-4"">
        <a class=""btn-block hvr-rectangle-out box""");
            BeginWriteAttribute("href", " href=\"", 347, "\"", 384, 1);
#nullable restore
#line 12 "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\Home\Index.cshtml"
WriteAttributeValue("", 354, Url.Action("Index","Product"), 354, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div style=\"margin:30px;font-size:22px;\">Products</div>\r\n        </a>\r\n    </div>\r\n\r\n    <div class=\"col-sm-4\">\r\n        <a class=\"btn-block hvr-rectangle-out box\"");
            BeginWriteAttribute("href", " href=\"", 563, "\"", 597, 1);
#nullable restore
#line 18 "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\Home\Index.cshtml"
WriteAttributeValue("", 570, Url.Action("Index","Sale"), 570, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div style=\"margin:30px;font-size:22px;\">Sales</div>\r\n        </a>\r\n    </div>\r\n\r\n</div>\r\n");
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
