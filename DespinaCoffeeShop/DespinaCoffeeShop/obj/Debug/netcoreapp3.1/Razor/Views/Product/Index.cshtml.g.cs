#pragma checksum "C:\Users\Orkhan\source\repos\DespinaCoffeeShop\DespinaCoffeeShop\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2ae08ad829629a5dbcc21201d4ad7215e438e6a"
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
#line 1 "C:\Users\Orkhan\source\repos\DespinaCoffeeShop\DespinaCoffeeShop\Views\_ViewImports.cshtml"
using DespinaCoffeeShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Orkhan\source\repos\DespinaCoffeeShop\DespinaCoffeeShop\Views\_ViewImports.cshtml"
using DespinaCoffeeShop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2ae08ad829629a5dbcc21201d4ad7215e438e6a", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbd778a1e458c72c2596643226a8db09b850e4f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Orkhan\source\repos\DespinaCoffeeShop\DespinaCoffeeShop\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"product-details\">\r\n        <div class=\"product\">\r\n            <img src=\"./assets/Img/4237922e6a7c11fb5b7d98858569130b.png\"");
            BeginWriteAttribute("alt", " alt=\"", 206, "\"", 212, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        </div>
        <div class=""prod-details"">
            <h2>TITLE</h2>
            <h4>Lorem ipsum dolor sit amet consectetur adipisicing elit</h4>
            <p>$52.00</p>
            <div class=""counter"">
                <span class=""down"" onClick='decreaseCount(event, this)'>-</span>
                <input type=""text"" value=""1"">
                <span class=""up"" onClick='increaseCount(event, this)'>+</span>
            </div>
            <button class=""pr-button"">Add To Cart</button>
        </div>
    </div>
</div>
");
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
