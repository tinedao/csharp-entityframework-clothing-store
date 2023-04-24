#pragma checksum "C:\Users\tined\work space\csharp-entityframework-clothing-store\ClothingStoreMVC\Areas\Admin\Views\Products\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d015b584d8060c733659d63ca16b2403743d006b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Products/Edit.cshtml", typeof(AspNetCore.Areas_Admin_Views_Products_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d015b584d8060c733659d63ca16b2403743d006b", @"/Areas/Admin/Views/Products/Edit.cshtml")]
    public class Areas_Admin_Views_Products_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClothingStoreMVC.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\tined\work space\csharp-entityframework-clothing-store\ClothingStoreMVC\Areas\Admin\Views\Products\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Areas/Admin/Views/layout/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(146, 2427, true);
            WriteLiteral(@"
<h2>Edit</h2>

<h4>Product</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Star"" class=""control-label""></label>
                <input asp-for=""Star"" class=""form-control"" />
                <span asp-validation-for=""Star"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Price"" class=""control-label""></label>
                <input asp-for=""Price"" class=""form-control"" />
                <span asp-validation-for=""Price"" class=""tex");
            WriteLiteral(@"t-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Size"" class=""control-label""></label>
                <input asp-for=""Size"" class=""form-control"" />
                <span asp-validation-for=""Size"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Color"" class=""control-label""></label>
                <input asp-for=""Color"" class=""form-control"" />
                <span asp-validation-for=""Color"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Quantity"" class=""control-label""></label>
                <input asp-for=""Quantity"" class=""form-control"" />
                <span asp-validation-for=""Quantity"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""IdCate"" class=""control-label""></label>
                <select asp-for=""IdCate"" class=""form-con");
            WriteLiteral(@"trol"" asp-items=""ViewBag.IdCate""></select>
                <span asp-validation-for=""IdCate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2591, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 64 "C:\Users\tined\work space\csharp-entityframework-clothing-store\ClothingStoreMVC\Areas\Admin\Views\Products\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClothingStoreMVC.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
