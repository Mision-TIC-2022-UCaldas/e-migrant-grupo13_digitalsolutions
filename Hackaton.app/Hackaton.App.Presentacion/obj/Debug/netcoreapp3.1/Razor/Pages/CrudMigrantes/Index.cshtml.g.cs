#pragma checksum "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d30f903124e4dc32ae904522256d128bc46e46d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Hackaton.App.Presentacion.Pages.CrudMigrantes.Pages_CrudMigrantes_Index), @"mvc.1.0.razor-page", @"/Pages/CrudMigrantes/Index.cshtml")]
namespace Hackaton.App.Presentacion.Pages.CrudMigrantes
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
#line 1 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\_ViewImports.cshtml"
using Hackaton.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d30f903124e4dc32ae904522256d128bc46e46d", @"/Pages/CrudMigrantes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56ce1be3429ee796df4077a097c07d1ca754c448", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CrudMigrantes_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d30f903124e4dc32ae904522256d128bc46e46d4686", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Migrante[0].Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Migrante[0].Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Migrante[0].TipoDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Migrante[0].NumeroDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Migrante[0].PaisOrigen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Migrante[0].FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Migrante[0].DireccionElectronica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Migrante[0].NumeroTelefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Migrante[0].DireccionActual));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Migrante[0].Ciudad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Migrante[0].SituacionLaboral));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 53 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
 foreach (var item in Model.Migrante) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TipoDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumeroDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PaisOrigen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DireccionElectronica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumeroTelefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DireccionActual));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ciudad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 86 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SituacionLaboral));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d30f903124e4dc32ae904522256d128bc46e46d15259", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
                                       WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d30f903124e4dc32ae904522256d128bc46e46d17500", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
                                          WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d30f903124e4dc32ae904522256d128bc46e46d19747", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
                                         WriteLiteral(item.Id);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 94 "C:\Users\willi\OneDrive\Documents\GitHub\Hackaton\e-migrant-grupo13_digitalsolutions\Hackaton.app\Hackaton.App.Presentacion\Pages\CrudMigrantes\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hackaton.App.Presentacion.Pages.CrudMigrantes.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Hackaton.App.Presentacion.Pages.CrudMigrantes.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Hackaton.App.Presentacion.Pages.CrudMigrantes.IndexModel>)PageContext?.ViewData;
        public Hackaton.App.Presentacion.Pages.CrudMigrantes.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
