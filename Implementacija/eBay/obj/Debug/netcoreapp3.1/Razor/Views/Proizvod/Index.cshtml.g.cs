#pragma checksum "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "177d5eb98858977b21238963ecd692f86bd1d564"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proizvod_Index), @"mvc.1.0.view", @"/Views/Proizvod/Index.cshtml")]
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
#line 1 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\_ViewImports.cshtml"
using eBay;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\_ViewImports.cshtml"
using eBay.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"177d5eb98858977b21238963ecd692f86bd1d564", @"/Views/Proizvod/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50a8c44649866c2c8d465decbd5ef314ae65923e", @"/Views/_ViewImports.cshtml")]
    public class Views_Proizvod_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eBay.Models.Proizvod>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
  
    ViewData["Title"] = "Proizvodi";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Proizvodi</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
 if (User.IsInRole("Prodavac"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "177d5eb98858977b21238963ecd692f86bd1d5645123", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 14 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.URLSlike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OpisProizvoda));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cijena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
#nullable restore
#line 30 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
             if (User.IsInRole("Kupac"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>Kupi</th>\r\n");
#nullable restore
#line 33 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>Opcije</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td style=\"width: 50px; height: auto\">\r\n                    <img style=\"width: 100%; height: auto\"");
            BeginWriteAttribute("src", " src=\"", 1023, "\"", 1074, 1);
#nullable restore
#line 42 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
WriteAttributeValue("", 1029, Html.DisplayFor(modelItem  => item.URLSlike), 1029, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"slika\" />\r\n                </td>\r\n                <td style=\"vertical-align: middle;\">\r\n                    ");
#nullable restore
#line 45 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"vertical-align:middle\">\r\n                    ");
#nullable restore
#line 48 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.OpisProizvoda));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"vertical-align:middle\">\r\n                    ");
#nullable restore
#line 51 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cijena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 53 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
                 if (User.IsInRole("Kupac"))
                {
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "177d5eb98858977b21238963ecd692f86bd1d56410752", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1751, "\"", 1775, 1);
#nullable restore
#line 58 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
WriteAttributeValue("", 1759, item.ProizvodId, 1759, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <input");
                BeginWriteAttribute("id", " id=\"", 1819, "\"", 1840, 1);
#nullable restore
#line 59 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
WriteAttributeValue("", 1824, item.ProizvodId, 1824, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"number\" min=\"1\" max=\"30\" step=\"1\" value=\"1\" />\r\n                                <input type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1948, "\"", 1989, 3);
                WriteAttributeValue("", 1958, "doAJAXRequest(", 1958, 14, true);
#nullable restore
#line 60 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
WriteAttributeValue("", 1972, item.ProizvodId, 1972, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1988, ")", 1988, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"Send request\"/>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n\r\n                    ");
#nullable restore
#line 64 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
                           
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td style=\"vertical-align:middle\">\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "177d5eb98858977b21238963ecd692f86bd1d56413961", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
                                              WriteLiteral(item.ProizvodId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 69 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
                     if (User.IsInRole("Prodavac"))
                    {
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            |\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "177d5eb98858977b21238963ecd692f86bd1d56416502", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
                                                   WriteLiteral(item.ProizvodId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            |\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "177d5eb98858977b21238963ecd692f86bd1d56418739", async() => {
                WriteLiteral(" Delete ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
                                                     WriteLiteral(item.ProizvodId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
#nullable restore
#line 76 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
                               
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 80 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<script type=""text/javascript"">
    function doAJAXRequest(proizvodId) {
        const kolicina = document.getElementById(proizvodId).value;
        const data = {
            ProizvodId: proizvodId,
            Kolicina: Number(kolicina)
        };
        console.log(data);
        fetch(""");
#nullable restore
#line 92 "C:\Users\Amina\source\repos\Grupa2-Ebay\Implementacija\eBay\Views\Proizvod\Index.cshtml"
          Write(Url.Action("AddToCart"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",{
            method: ""POST"",
            body: JSON.stringify(data),
            headers: {
                ""Content-Type"":""application/json""
            }
        })
            .then(response => response.json())
            .then(data => console.log(data))
            .catch(err => console.log(err));
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eBay.Models.Proizvod>> Html { get; private set; }
    }
}
#pragma warning restore 1591
