#pragma checksum "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\Kursevi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "329d2768cde1cdc4b347e9fd2e098c1a03fcdf52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kursevi_Kursevi), @"mvc.1.0.view", @"/Views/Kursevi/Kursevi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Kursevi/Kursevi.cshtml", typeof(AspNetCore.Views_Kursevi_Kursevi))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"329d2768cde1cdc4b347e9fd2e098c1a03fcdf52", @"/Views/Kursevi/Kursevi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Kursevi_Kursevi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.VM.KurseviVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Prikaz/KurseviPrikaz.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Poruke_Span.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "329d2768cde1cdc4b347e9fd2e098c1a03fcdf524257", async() => {
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
            EndContext();
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(65, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "329d2768cde1cdc4b347e9fd2e098c1a03fcdf525507", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(119, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\Kursevi.cshtml"
  
    ViewData["Title"] = "Kursevi";

    string porukaUspjeh = (string)TempData["uspjesno"];

    string porukaGreska = (string)TempData["greska"];

#line default
#line hidden
            BeginContext(326, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\Kursevi.cshtml"
 if (porukaGreska != null)
{

#line default
#line hidden
            BeginContext(357, 35, true);
            WriteLiteral("<center>\r\n        <div id=\"poruka\">");
            EndContext();
            BeginContext(393, 12, false);
#line 15 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\Kursevi.cshtml"
                    Write(porukaGreska);

#line default
#line hidden
            EndContext();
            BeginContext(405, 197, true);
            WriteLiteral("</div>\r\n    </center>\r\n    <script>\r\n        $(\"#poruka\").slideUp(1);\r\n        $(\"#poruka\").slideDown(1500);\r\n        $(\"#poruka\").delay(2000);\r\n        $(\"#poruka\").slideUp(1500);\r\n    </script>\r\n");
            EndContext();
#line 23 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\Kursevi.cshtml"
}

#line default
#line hidden
#line 24 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\Kursevi.cshtml"
 if (porukaUspjeh != null)
{

#line default
#line hidden
            BeginContext(636, 40, true);
            WriteLiteral("    <center>\r\n        <div id=\"poruka2\">");
            EndContext();
            BeginContext(677, 12, false);
#line 27 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\Kursevi.cshtml"
                     Write(porukaUspjeh);

#line default
#line hidden
            EndContext();
            BeginContext(689, 201, true);
            WriteLiteral("</div>\r\n    </center>\r\n    <script>\r\n        $(\"#poruka2\").slideUp(1);\r\n        $(\"#poruka2\").slideDown(1500);\r\n        $(\"#poruka2\").delay(2000);\r\n        $(\"#poruka2\").slideUp(1500);\r\n    </script>\r\n");
            EndContext();
#line 35 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\Kursevi.cshtml"
}

#line default
#line hidden
            BeginContext(893, 409, true);
            WriteLiteral(@"
<h2 style=""text-align:center; font-family:Consolas"">Kursevi</h2>
<br />
<table class=""table  courses-table"" style=""font-family:Consolas"">
    <thead>
        <tr>
            <th>Naziv</th>
            <th>ECTS</th>
            <th>Cijena</th>
            <th>Trajanje</th>
            <th>Trazenost</th>
            <th>Cilj</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 52 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\Kursevi.cshtml"
         foreach (var x in Model.kursevi)
        {

#line default
#line hidden
            BeginContext(1356, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1395, 7, false);
#line 55 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\Kursevi.cshtml"
               Write(x.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(1402, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1430, 6, false);
#line 56 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\Kursevi.cshtml"
               Write(x.ECTS);

#line default
#line hidden
            EndContext();
            BeginContext(1436, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1464, 8, false);
#line 57 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\Kursevi.cshtml"
               Write(x.Cijena);

#line default
#line hidden
            EndContext();
            BeginContext(1472, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1500, 10, false);
#line 58 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\Kursevi.cshtml"
               Write(x.Trajanje);

#line default
#line hidden
            EndContext();
            BeginContext(1510, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1538, 11, false);
#line 59 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\Kursevi.cshtml"
               Write(x.Trazenost);

#line default
#line hidden
            EndContext();
            BeginContext(1549, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1577, 6, false);
#line 60 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\Kursevi.cshtml"
               Write(x.Cilj);

#line default
#line hidden
            EndContext();
            BeginContext(1583, 72, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1655, "\"", 1697, 2);
            WriteAttributeValue("", 1662, "/Kursevi/UrediKurs?KursID=", 1662, 26, true);
#line 62 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\Kursevi.cshtml"
WriteAttributeValue("", 1688, x.KursID, 1688, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1698, 66, true);
            WriteLiteral(">Uredi</a>\r\n                    <a class=\"btn btn-warning detalji\"");
            EndContext();
            BeginWriteAttribute("idkursa", " idkursa=\"", 1764, "\"", 1783, 1);
#line 63 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\Kursevi.cshtml"
WriteAttributeValue("", 1774, x.KursID, 1774, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1784, 636, true);
            WriteLiteral(@"> Detalji</a>
                    <script>
                        $(function (event) {
                            $("".detalji"").click(function (event) {
                                var id = $(this).attr(""idkursa"");
                                $.get(""/Ajax/DetaljiKursa?KursID="" + parseInt(id),
                                    function (rezultat, status) {
                                        $(""#ajaxDivKursevi"").html(rezultat);
                                    });
                            });

                        });
                    </script>
                    <a class=""btn btn-danger""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2420, "\"", 2463, 2);
            WriteAttributeValue("", 2427, "/Kursevi/DeleteKurs?KursID=", 2427, 27, true);
#line 76 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\Kursevi.cshtml"
WriteAttributeValue("", 2454, x.KursID, 2454, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2464, 55, true);
            WriteLiteral(">Ukloni</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 79 "C:\Users\User\Desktop\seminarski_rad\webapp\WebApplication1\Views\Kursevi\Kursevi.cshtml"
        }

#line default
#line hidden
            BeginContext(2530, 164, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<center>\r\n    <a class=\"btn btn-success\" href=\"/Kursevi/DodajKurs\">Dodaj novi kurs</a>\r\n</center>\r\n<strong id=\"ajaxDivKursevi\"></strong>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.VM.KurseviVM> Html { get; private set; }
    }
}
#pragma warning restore 1591