#pragma checksum "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daf5413f7dd63ed64952382ba357b68a961dd85b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daf5413f7dd63ed64952382ba357b68a961dd85b", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1a281e6d29a6845ae334c740ecd5dc3a34e35b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Product List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 75, "\"", 117, 1);
#nullable restore
#line 6 "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\Product\Index.cshtml"
WriteAttributeValue("", 82, Url.Action("NewProduct","Product"), 82, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">New Product</a>\r\n</div>\r\n\r\n<div class=\"row\">\r\n\r\n</div>");
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
