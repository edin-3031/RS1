#pragma checksum "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3307763cae81b979511284dc6460c27c5850a46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kursevi_ViewKurseve), @"mvc.1.0.view", @"/Views/Kursevi/ViewKurseve.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Kursevi/ViewKurseve.cshtml", typeof(AspNetCore.Views_Kursevi_ViewKurseve))]
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
#line 1 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3307763cae81b979511284dc6460c27c5850a46", @"/Views/Kursevi/ViewKurseve.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Kursevi_ViewKurseve : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1307897f42c4690b251ab8050ee7d8b", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0d33faae496140e7864a58722d045c18", async() => {
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
            BeginContext(119, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
  
    ViewData["Title"] = "ViewKurseve";

    List<PrikazKurseva> podaci = (List<PrikazKurseva>)ViewData["kurs_id"];

    int b = 1;

    string porukaUspjeh = (string)TempData["uspjesno"];

    string porukaGreska = (string)TempData["greska"];

#line default
#line hidden
            BeginContext(380, 22, true);
            WriteLiteral("\r\n<h1>Kursevi</h1>\r\n\r\n");
            EndContext();
#line 17 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
 if (porukaGreska != null)
{

#line default
#line hidden
            BeginContext(431, 35, true);
            WriteLiteral("<center>\r\n        <div id=\"poruka\">");
            EndContext();
            BeginContext(467, 12, false);
#line 19 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
                    Write(porukaGreska);

#line default
#line hidden
            EndContext();
            BeginContext(479, 197, true);
            WriteLiteral("</div>\r\n    </center>\r\n    <script>\r\n        $(\"#poruka\").slideUp(1);\r\n        $(\"#poruka\").slideDown(1500);\r\n        $(\"#poruka\").delay(2000);\r\n        $(\"#poruka\").slideUp(1500);\r\n    </script>\r\n");
            EndContext();
#line 27 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
}

#line default
#line hidden
#line 28 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
 if (porukaUspjeh != null)
{

#line default
#line hidden
            BeginContext(710, 40, true);
            WriteLiteral("    <center>\r\n        <div id=\"poruka2\">");
            EndContext();
            BeginContext(751, 12, false);
#line 31 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
                     Write(porukaUspjeh);

#line default
#line hidden
            EndContext();
            BeginContext(763, 201, true);
            WriteLiteral("</div>\r\n    </center>\r\n    <script>\r\n        $(\"#poruka2\").slideUp(1);\r\n        $(\"#poruka2\").slideDown(1500);\r\n        $(\"#poruka2\").delay(2000);\r\n        $(\"#poruka2\").slideUp(1500);\r\n    </script>\r\n");
            EndContext();
#line 39 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
}

#line default
#line hidden
            BeginContext(967, 333, true);
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th>RB</th>
            <th>Naziv</th>
            <th>Studijski program</th>
            <th>ECTS</th>
            <th>Cijena</th>
            <th>Trajanje</th>
            <th>Traženost</th>
            <th>Cilj</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 55 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
         foreach (var x in podaci)
        {

#line default
#line hidden
            BeginContext(1347, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1387, 3, false);
#line 58 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
                Write(b++);

#line default
#line hidden
            EndContext();
            BeginContext(1391, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1419, 7, false);
#line 59 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
               Write(x.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(1426, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1454, 19, false);
#line 60 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
               Write(x.Studijski_program);

#line default
#line hidden
            EndContext();
            BeginContext(1473, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1501, 6, false);
#line 61 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
               Write(x.ECTS);

#line default
#line hidden
            EndContext();
            BeginContext(1507, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1535, 8, false);
#line 62 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
               Write(x.Cijena);

#line default
#line hidden
            EndContext();
            BeginContext(1543, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1571, 10, false);
#line 63 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
               Write(x.Trajanje);

#line default
#line hidden
            EndContext();
            BeginContext(1581, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1609, 11, false);
#line 64 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
               Write(x.Trazenost);

#line default
#line hidden
            EndContext();
            BeginContext(1620, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1648, 6, false);
#line 65 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
               Write(x.Cilj);

#line default
#line hidden
            EndContext();
            BeginContext(1654, 72, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1726, "\"", 1755, 2);
            WriteAttributeValue("", 1733, "UrediForm?id=", 1733, 13, true);
#line 67 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
WriteAttributeValue("", 1746, x.KursID, 1746, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1756, 58, true);
            WriteLiteral(">Uredi</a>\r\n                    <a class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1814, "\"", 1836, 2);
            WriteAttributeValue("", 1819, "Detalji_", 1819, 8, true);
#line 68 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
WriteAttributeValue("", 1827, x.KursID, 1827, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1837, 80, true);
            WriteLiteral(">Detalji</a>\r\n                    <script>\r\n                        $(\"#Detalji_");
            EndContext();
            BeginContext(1918, 8, false);
#line 70 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
                               Write(x.KursID);

#line default
#line hidden
            EndContext();
            BeginContext(1926, 81, true);
            WriteLiteral("\").click(function(){\r\n                            $.get(\"/Ajax/DetaljiKurs?SP_id=");
            EndContext();
            BeginContext(2008, 7, false);
#line 71 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
                                                      Write(x.SP_id);

#line default
#line hidden
            EndContext();
            BeginContext(2015, 8, true);
            WriteLiteral("&kursId=");
            EndContext();
            BeginContext(2024, 8, false);
#line 71 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
                                                                      Write(x.KursID);

#line default
#line hidden
            EndContext();
            BeginContext(2032, 295, true);
            WriteLiteral(@""", function (result) {
                                $(""#box"").html(result);
                                $(""#box"").css(""border"",""5px solid black"");
                            });
                        });
                    </script>
                    <a class=""btn btn-danger""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2327, "\"", 2350, 2);
            WriteAttributeValue("", 2332, "brisanje_", 2332, 9, true);
#line 77 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
WriteAttributeValue("", 2341, x.KursID, 2341, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2351, "\"", 2389, 2);
            WriteAttributeValue("", 2358, "UkoniKurs?TrazeniKurs=", 2358, 22, true);
#line 77 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
WriteAttributeValue("", 2380, x.KursID, 2380, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2390, 83, true);
            WriteLiteral(">Ukloni</a>\r\n                </td>\r\n                <td>\r\n                    <span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2473, "\"", 2494, 2);
            WriteAttributeValue("", 2478, "poruka_", 2478, 7, true);
#line 80 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
WriteAttributeValue("", 2485, x.KursID, 2485, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2495, 92, true);
            WriteLiteral("></span>\r\n                </td>\r\n                <script>\r\n                    $(\"#brisanje_");
            EndContext();
            BeginContext(2588, 8, false);
#line 83 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
                            Write(x.KursID);

#line default
#line hidden
            EndContext();
            BeginContext(2596, 63, true);
            WriteLiteral("\").mouseover(function () {\r\n                        $(\"#poruka_");
            EndContext();
            BeginContext(2660, 8, false);
#line 84 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
                              Write(x.KursID);

#line default
#line hidden
            EndContext();
            BeginContext(2668, 130, true);
            WriteLiteral("\").html(\"PRVO UKLONITE KURS IZ DETALJA PROFESORA, POLAZNIKA I TESTA\");\r\n                    });\r\n                    $(\"#brisanje_");
            EndContext();
            BeginContext(2799, 8, false);
#line 86 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
                            Write(x.KursID);

#line default
#line hidden
            EndContext();
            BeginContext(2807, 64, true);
            WriteLiteral("\").mouseleave(function () {\r\n                        $(\"#poruka_");
            EndContext();
            BeginContext(2872, 8, false);
#line 87 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
                              Write(x.KursID);

#line default
#line hidden
            EndContext();
            BeginContext(2880, 85, true);
            WriteLiteral("\").html(\"\");\r\n                    });\r\n                </script>\r\n            </tr>\r\n");
            EndContext();
#line 91 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Kursevi\ViewKurseve.cshtml"
        }

#line default
#line hidden
            BeginContext(2976, 158, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<center>\r\n    <a class=\"btn btn-success\" href=\"/Kursevi/DodajKursForm\">Dodaj kurs</a><br /><br />\r\n</center>\r\n<div id=\"box\">\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591