#pragma checksum "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiKursa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ead07c17a7d40b514dc126c7ae95247f646f31a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ajax_DetaljiKursa), @"mvc.1.0.view", @"/Views/Ajax/DetaljiKursa.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ajax/DetaljiKursa.cshtml", typeof(AspNetCore.Views_Ajax_DetaljiKursa))]
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
#line 1 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ead07c17a7d40b514dc126c7ae95247f646f31a", @"/Views/Ajax/DetaljiKursa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Ajax_DetaljiKursa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.VM.KursDetaljiVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ajax", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Zatvori", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiKursa.cshtml"
  
    ViewData["Title"] = "DetaljiKursa";

#line default
#line hidden
            BeginContext(96, 119, true);
            WriteLiteral("\r\n<center style=\"border-style:groove; margin-top:10px; padding-bottom:10px; border-color:grey\">\r\n    <h2>Detalji kursa ");
            EndContext();
            BeginContext(216, 11, false);
#line 7 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiKursa.cshtml"
                 Write(Model.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(227, 15, true);
            WriteLiteral("</h2>\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(242, 1496, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ead07c17a7d40b514dc126c7ae95247f646f31a4696", async() => {
                BeginContext(292, 123, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label>Naziv:</label>\r\n            <input type=\"text\" class=\"izmjenaNaziva\"");
                EndContext();
                BeginWriteAttribute("idkursa", " idkursa=\"", 415, "\"", 438, 1);
#line 13 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiKursa.cshtml"
WriteAttributeValue("", 425, Model.KursID, 425, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 439, "\"", 459, 1);
#line 13 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiKursa.cshtml"
WriteAttributeValue("", 447, Model.Naziv, 447, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(460, 151, true);
                WriteLiteral(" name=\"Naziv\"/>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>ECTS:</label>\r\n            <input type=\"text\" class=\"izmjenaECTS\"");
                EndContext();
                BeginWriteAttribute("idkursa", " idkursa=\"", 611, "\"", 634, 1);
#line 17 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiKursa.cshtml"
WriteAttributeValue("", 621, Model.KursID, 621, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 635, "\"", 654, 1);
#line 17 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiKursa.cshtml"
WriteAttributeValue("", 643, Model.ECTS, 643, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(655, 155, true);
                WriteLiteral("/>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Studijski program:</label>\r\n            <input type=\"text\" name=\"StudijskiProgram\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 810, "\"", 841, 1);
#line 21 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiKursa.cshtml"
WriteAttributeValue("", 818, Model.StudijskiProgram, 818, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(842, 153, true);
                WriteLiteral(" readonly />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Cijena:</label>\r\n            <input type=\"text\"  class=\"izmjenaCijena\"");
                EndContext();
                BeginWriteAttribute("idkursa", " idkursa=\"", 995, "\"", 1018, 1);
#line 25 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiKursa.cshtml"
WriteAttributeValue("", 1005, Model.KursID, 1005, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1019, "\"", 1040, 1);
#line 25 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiKursa.cshtml"
WriteAttributeValue("", 1027, Model.Cijena, 1027, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1041, 147, true);
                WriteLiteral("/>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Trajanje:</label>\r\n            <input type=\"text\"  class=\"izmjenaTrajanje\"");
                EndContext();
                BeginWriteAttribute("idkursa", " idkursa=\"", 1188, "\"", 1211, 1);
#line 29 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiKursa.cshtml"
WriteAttributeValue("", 1198, Model.KursID, 1198, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1212, "\"", 1235, 1);
#line 29 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiKursa.cshtml"
WriteAttributeValue("", 1220, Model.Trajanje, 1220, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1236, 150, true);
                WriteLiteral(" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Trazenost:</label>\r\n            <input type=\"text\"  class=\"izmjenaTrazenost\"");
                EndContext();
                BeginWriteAttribute("idkursa", " idkursa=\"", 1386, "\"", 1409, 1);
#line 33 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiKursa.cshtml"
WriteAttributeValue("", 1396, Model.KursID, 1396, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1410, "\"", 1434, 1);
#line 33 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiKursa.cshtml"
WriteAttributeValue("", 1418, Model.Trazenost, 1418, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1435, 140, true);
                WriteLiteral(" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Cilj:</label>\r\n            <input type=\"text\"  class=\"izmjenaCilj\"");
                EndContext();
                BeginWriteAttribute("idkursa", " idkursa=\"", 1575, "\"", 1598, 1);
#line 37 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiKursa.cshtml"
WriteAttributeValue("", 1585, Model.KursID, 1585, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1599, "\"", 1618, 1);
#line 37 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Ajax\DetaljiKursa.cshtml"
WriteAttributeValue("", 1607, Model.Cilj, 1607, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1619, 112, true);
                WriteLiteral("/>\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-default\" value=\"Zatvori\">Zatvori</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1738, 2300, true);
            WriteLiteral(@"
</center>

<script>
    $(function (event) {
        $("".izmjenaNaziva"").change(function (event) {
            var idkursa = $(this).attr(""idkursa"");
            var naziv = $(this).val();
            $.get(""/Ajax/IzmjenaNaziv?KursID="" + parseInt(idkursa)+""&Naziv=""+naziv,
                function (rezultat, status) {
                    $(""#ajaxDiv"").html(rezultat);
                });
        });
        $("".izmjenaECTS"").change(function (event) {
            var idkursa = $(this).attr(""idkursa"");
            var ects = $(this).val();
            $.get(""/Ajax/IzmjenaECTS?KursID="" + parseInt(idkursa) + ""&ECTS="" + ects,
                function (rezultat, status) {
                    $(""#ajaxDiv"").html(rezultat);
                });
        });
        $("".izmjenaCijena"").change(function (event) {
            var idkursa = $(this).attr(""idkursa"");
            var cijena = $(this).val();
            $.get(""/Ajax/IzmjenaCijena?KursID="" + parseInt(idkursa) + ""&Cijena="" + cijena,
       ");
            WriteLiteral(@"         function (rezultat, status) {
                    $(""#ajaxDiv"").html(rezultat);
              });
        });
        $("".izmjenaTrajanje"").change(function (event) {
            var idkursa = $(this).attr(""idkursa"");
            var trajanje = $(this).val();
            $.get(""/Ajax/IzmjenaTrajanje?KursID="" + parseInt(idkursa) + ""&Trajanje="" + trajanje,
                function (rezultat, status) {
                    $(""#ajaxDiv"").html(rezultat);
                });
        });
        $("".izmjenaTrazenost"").change(function (event) {
            var idkursa = $(this).attr(""idkursa"");
            var trazenost = $(this).val();
            $.get(""/Ajax/IzmjenaTrazenost?KursID="" + parseInt(idkursa) + ""&Trazenost="" + trazenost,
                function (rezultat, status) {
                    $(""#ajaxDiv"").html(rezultat);
                });
        });
        $("".izmjenaCilj"").change(function (event) {
            var idkursa = $(this).attr(""idkursa"");
            var cilj = $(th");
            WriteLiteral("is).val();\r\n            $.get(\"/Ajax/IzmjenaCilj?KursID=\" + parseInt(idkursa) + \"&Cilj=\" + cilj,\r\n                function (rezultat, status) {\r\n                    $(\"#ajaxDiv\").html(rezultat);\r\n                });\r\n        });\r\n    });\r\n</script>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.VM.KursDetaljiVM> Html { get; private set; }
    }
}
#pragma warning restore 1591