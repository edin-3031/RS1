#pragma checksum "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Uplate\UrediForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57d6e49c36dbbdc76c8ca807e10149b27bb9e004"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Uplate_UrediForm), @"mvc.1.0.view", @"/Views/Uplate/UrediForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Uplate/UrediForm.cshtml", typeof(AspNetCore.Views_Uplate_UrediForm))]
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
#line 2 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Uplate\UrediForm.cshtml"
using WebApplication1.Models.VM;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57d6e49c36dbbdc76c8ca807e10149b27bb9e004", @"/Views/Uplate/UrediForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Uplate_UrediForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UrediFormVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Uređivanje/UrediUplata.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("disabled", new global::Microsoft.AspNetCore.Html.HtmlString("disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "DA", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "NE", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Uplate/Uredi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "160832986e684d01b24afaa1ddfeabd6", async() => {
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
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Uplate\UrediForm.cshtml"
  
    Uplata podaci = (Uplata)ViewData["Uredi"];

#line default
#line hidden
            BeginContext(176, 59, true);
            WriteLiteral("\r\n<h1>Uredi podatke uplate</h1>\r\n\r\n    <center>\r\n\r\n        ");
            EndContext();
            BeginContext(235, 3048, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c8388ae42b54d71bb6045b7ba5e4989", async() => {
                BeginContext(264, 42, true);
                WriteLiteral("\r\n            <input type=\"text\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 306, "\"", 330, 1);
#line 13 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Uplate\UrediForm.cshtml"
WriteAttributeValue("", 314, podaci.UplataID, 314, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(331, 244, true);
                WriteLiteral(" hidden=\"hidden\" />\r\n            <table>\r\n                <tr>\r\n                    <td>\r\n                        <label>Svrha</label>\r\n                    </td>\r\n                    <td>\r\n                        <input name=\"svrha\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 575, "\"", 596, 1);
#line 20 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Uplate\UrediForm.cshtml"
WriteAttributeValue("", 583, podaci.Svrha, 583, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(597, 257, true);
                WriteLiteral(@" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Iznos</label>
                    </td>
                    <td>
                        <input name=""iznos"" type=""text""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 854, "\"", 875, 1);
#line 28 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Uplate\UrediForm.cshtml"
WriteAttributeValue("", 862, podaci.Iznos, 862, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(876, 275, true);
                WriteLiteral(@" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Datum uplate</label>
                    </td>
                    <td>
                        <input name=""datum_uplate"" type=""datetime""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1151, "\"", 1179, 1);
#line 36 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Uplate\UrediForm.cshtml"
WriteAttributeValue("", 1159, podaci.Datum_uplate, 1159, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1180, 283, true);
                WriteLiteral(@" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Ovjereno</label>
                    </td>
                    <td>
                        <select name=""ovjereno"">
                            ");
                EndContext();
                BeginContext(1463, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eaa5194c01044bd897becf7f2f5f1a4", async() => {
                    BeginContext(1495, 15, false);
#line 45 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Uplate\UrediForm.cshtml"
                                                      Write(podaci.Ovjereno);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 45 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Uplate\UrediForm.cshtml"
                              WriteLiteral(podaci.Ovjereno);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1519, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1549, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4256355c71f4606860a6e221633e744", async() => {
                    BeginContext(1577, 4, true);
                    WriteLiteral("----");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1590, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1620, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3245b841cbc94a4c9a0cfa9ed18bb761", async() => {
                    BeginContext(1639, 2, true);
                    WriteLiteral("DA");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1650, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1680, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a83e61a0ad04d209e413888cc7a5a05", async() => {
                    BeginContext(1699, 2, true);
                    WriteLiteral("NE");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1710, 315, true);
                WriteLiteral(@"
                        </select>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Polaznik</label>
                    </td>
                    <td>
                        <input type=""text"" readonly=""readonly"" name=""polaznik""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2025, "\"", 2055, 1);
#line 57 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Uplate\UrediForm.cshtml"
WriteAttributeValue("", 2033, podaci.Polaznik_ID_FK, 2033, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2056, 83, true);
                WriteLiteral(" hidden=\"hidden\" />\r\n                        <input type=\"text\" readonly=\"readonly\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2139, "\"", 2198, 2);
#line 58 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Uplate\UrediForm.cshtml"
WriteAttributeValue("", 2147, podaci.Polaznik_ID.Ime, 2147, 23, false);

#line default
#line hidden
#line 58 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Uplate\UrediForm.cshtml"
WriteAttributeValue(" ", 2170, podaci.Polaznik_ID.Prezime, 2171, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2199, 310, true);
                WriteLiteral(@" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <label id=""adminName"">Administracija</label>
                    </td>
                    <td>
                        <select name=""administracija"">
                            ");
                EndContext();
                BeginContext(2509, 117, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62c33a4b23304ec9b1fcd43f5a6f36da", async() => {
                    BeginContext(2555, 28, false);
#line 67 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Uplate\UrediForm.cshtml"
                                                                    Write(podaci.Administracija_ID.Ime);

#line default
#line hidden
                    EndContext();
                    BeginContext(2583, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(2585, 32, false);
#line 67 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Uplate\UrediForm.cshtml"
                                                                                                  Write(podaci.Administracija_ID.Prezime);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 67 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Uplate\UrediForm.cshtml"
                               WriteLiteral(podaci.Administracija_ID_FK);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2626, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2656, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "881d86b95b544e96999b4ec9769a3265", async() => {
                    BeginContext(2684, 22, true);
                    WriteLiteral("----------------------");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2715, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 69 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Uplate\UrediForm.cshtml"
                             foreach (var x in Model.listaAdministracije)
                            {

#line default
#line hidden
                BeginContext(2823, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(2855, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d7018d21e094fc2a6f77d8128d8d6d8", async() => {
                    BeginContext(2892, 5, false);
#line 71 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Uplate\UrediForm.cshtml"
                                                               Write(x.Ime);

#line default
#line hidden
                    EndContext();
                    BeginContext(2897, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(2899, 9, false);
#line 71 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Uplate\UrediForm.cshtml"
                                                                      Write(x.Prezime);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 71 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Uplate\UrediForm.cshtml"
                                   WriteLiteral(x.AdministracijaID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2917, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 72 "E:\Fakultet\RS I\Seminarski rad\seminarski_rad\webapp\WebApplication1\Views\Uplate\UrediForm.cshtml"
                            }

#line default
#line hidden
                BeginContext(2950, 326, true);
                WriteLiteral(@"                        </select>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <button id=""go"" class=""btn btn-primary"" type=""submit"">Snimi</button>
            <a id=""back"" class=""btn btn-default"" href=""/Uplate/PrikaziUplate"">Nazad</a>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3283, 15, true);
            WriteLiteral("\r\n    </center>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UrediFormVM> Html { get; private set; }
    }
}
#pragma warning restore 1591