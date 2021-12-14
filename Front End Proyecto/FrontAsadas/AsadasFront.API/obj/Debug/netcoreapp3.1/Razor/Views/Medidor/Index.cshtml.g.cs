#pragma checksum "/Users/michaelsevilla/Documents/GitHub/SC_701_ProyectoFinal/Front End Proyecto/FrontAsadas/AsadasFront.API/Views/Medidor/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af8bb3099ad745e2f96d8c4be864176ccec79627"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medidor_Index), @"mvc.1.0.view", @"/Views/Medidor/Index.cshtml")]
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
#line 1 "/Users/michaelsevilla/Documents/GitHub/SC_701_ProyectoFinal/Front End Proyecto/FrontAsadas/AsadasFront.API/Views/_ViewImports.cshtml"
using AsadasFront.API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/michaelsevilla/Documents/GitHub/SC_701_ProyectoFinal/Front End Proyecto/FrontAsadas/AsadasFront.API/Views/_ViewImports.cshtml"
using AsadasFront.API.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af8bb3099ad745e2f96d8c4be864176ccec79627", @"/Views/Medidor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6441913e0f582e64d7887ef079b5c7917093274f", @"/Views/_ViewImports.cshtml")]
    public class Views_Medidor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AsadasFront.API.Models.Medidor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success ml-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/michaelsevilla/Documents/GitHub/SC_701_ProyectoFinal/Front End Proyecto/FrontAsadas/AsadasFront.API/Views/Medidor/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- DataTable -->\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/v/bs5/dt-1.11.3/datatables.min.css"" />
    <script type=""text/javascript"" src=""https://cdn.datatables.net/v/bs5/dt-1.11.3/datatables.min.js""></script>

    <script>$(document).ready(function () {
            $('#table').DataTable({
                ""columnDefs"": [
                    { ""orderable"": false, ""targets"": -1 }
                ],
                ""info"": false,
                ""searching"": false,
                ""paging"": false
            });
    });</script>
");
            }
            );
            WriteLiteral(@"<!-- Breadcrumb, Encabezado y Añadir -->
<div class=""container-fluid page__heading-container"">
    <div class=""page__heading d-flex align-items-center"">
        <div class=""flex"">
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb mb-0"">
                    <li class=""breadcrumb-item""><a href=""#""><i class=""material-icons icon-20pt"">home</i></a></li>
                    <li class=""breadcrumb-item active"">Medidores</li>
                </ol>
            </nav>
            <h1 class=""m-0"">Lista</h1>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af8bb3099ad745e2f96d8c4be864176ccec796276787", async() => {
                WriteLiteral(" Agregar ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>
<!-- Container blanco -->
<div class=""container-fluid page__container"">
    <div class=""card"">
        <div class=""table-responsive"">
            <!-- Tabla -->
            <table class=""table mb-0 thead-border-top-0 table-striped table-hover"" id=""table"">
                <thead>
                    <tr>
                        <th>Código</th>
                        <th><i class=""material-icons icon-16pt mr-1"">pin_drop</i>Dirección</th>
                        <th><i class=""material-icons icon-16pt text-muted mr-1"">account_circle</i>Cliente</th>
                        <th>Acciones</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 53 "/Users/michaelsevilla/Documents/GitHub/SC_701_ProyectoFinal/Front End Proyecto/FrontAsadas/AsadasFront.API/Views/Medidor/Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td><div class=\"badge badge-soft-dark\"> ");
#nullable restore
#line 56 "/Users/michaelsevilla/Documents/GitHub/SC_701_ProyectoFinal/Front End Proyecto/FrontAsadas/AsadasFront.API/Views/Medidor/Index.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.IdMedidor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div></td>\n                        <td>");
#nullable restore
#line 57 "/Users/michaelsevilla/Documents/GitHub/SC_701_ProyectoFinal/Front End Proyecto/FrontAsadas/AsadasFront.API/Views/Medidor/Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 58 "/Users/michaelsevilla/Documents/GitHub/SC_701_ProyectoFinal/Front End Proyecto/FrontAsadas/AsadasFront.API/Views/Medidor/Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CedulaNavigation.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 58 "/Users/michaelsevilla/Documents/GitHub/SC_701_ProyectoFinal/Front End Proyecto/FrontAsadas/AsadasFront.API/Views/Medidor/Index.cshtml"
                                                                                   Write(Html.DisplayFor(modelItem => item.CedulaNavigation.PrimerApellido));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 58 "/Users/michaelsevilla/Documents/GitHub/SC_701_ProyectoFinal/Front End Proyecto/FrontAsadas/AsadasFront.API/Views/Medidor/Index.cshtml"
                                                                                                                                                       Write(Html.DisplayFor(modelItem => item.CedulaNavigation.SegundoApellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af8bb3099ad745e2f96d8c4be864176ccec7962711113", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "/Users/michaelsevilla/Documents/GitHub/SC_701_ProyectoFinal/Front End Proyecto/FrontAsadas/AsadasFront.API/Views/Medidor/Index.cshtml"
                                                                                  WriteLiteral(item.IdMedidor);

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
            WriteLiteral("\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af8bb3099ad745e2f96d8c4be864176ccec7962713444", async() => {
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "/Users/michaelsevilla/Documents/GitHub/SC_701_ProyectoFinal/Front End Proyecto/FrontAsadas/AsadasFront.API/Views/Medidor/Index.cshtml"
                                                                                   WriteLiteral(item.IdMedidor);

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
            WriteLiteral("\n                        </td>\n                    </tr>\n");
#nullable restore
#line 64 "/Users/michaelsevilla/Documents/GitHub/SC_701_ProyectoFinal/Front End Proyecto/FrontAsadas/AsadasFront.API/Views/Medidor/Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AsadasFront.API.Models.Medidor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
