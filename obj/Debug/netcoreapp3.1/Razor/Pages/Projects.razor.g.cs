#pragma checksum "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1a92003ab3c4ad05b7e4b85663ae3f8a9a72c80"
// <auto-generated/>
#pragma warning disable 1591
namespace Scalpy.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\_Imports.razor"
using Scalpy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\_Imports.razor"
using Scalpy.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
using Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/projects")]
    public partial class Projects : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "Projects PageView");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "Projects__content");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<h1 class=\"MainContent__title\">Projects</h1>\r\n        ");
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, "Current count: ");
            __builder.AddContent(9, 
#nullable restore
#line 8 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                           currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n        ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-primary");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                  IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n        ");
            __builder.OpenElement(16, "p");
            __builder.AddContent(17, "Element: ");
            __builder.AddContent(18, 
#nullable restore
#line 12 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                     myelement

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "p");
            __builder.AddContent(21, "Element: ");
            __builder.AddContent(22, 
#nullable restore
#line 13 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                     message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n        ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                                CategoryChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                      message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => message = __value, message));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n   \r\n\r\n    ");
            __builder.OpenElement(30, "table");
            __builder.AddAttribute(31, "class", "TableData");
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.AddMarkupContent(33, @"<thead class=""TableDataHead"">
            <tr class=""TableDataHead__row"">
                <th class=""TableDataHead__col"">Folio Datahub</th>
                <th class=""TableDataHead__col"">Caso de Uso</th>
                <th class=""TableDataHead__col"">Estatus de Resolución</th>
                <th class=""TableDataHead__col"">Resolucion</th>
                <th class=""TableDataHead__col"">Fecha de Resolución</th>
                <th class=""TableDataHead__col"">Tipo de Origen</th>
                <th class=""TableDataHead__col"">ID de Tabla</th>
                <th class=""TableDataHead__col"">UUAA Raw</th>
                <th class=""TableDataHead__col"">UUAA Master</th>
                <th class=""TableDataHead__col"">URL de Documentación</th>
                <th class=""TableDataHead__col"">Proyecto</th>
                <th class=""TableDataHead__col"">Pasa a Ingesta</th>
                <th class=""TableDataHead__col"">Q-Sprint de Termino</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(34, "tbody");
            __builder.AddAttribute(35, "class", "TableDataBody");
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 39 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
             foreach (var row in bui)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "                ");
            __builder.OpenElement(38, "tr");
            __builder.AddAttribute(39, "class", "TableDataBody__row");
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "td");
            __builder.AddAttribute(42, "class", "TableDataBody__col");
            __builder.AddContent(43, 
#nullable restore
#line 42 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.FolioDatahub

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenElement(45, "td");
            __builder.AddAttribute(46, "class", "TableDataBody__col");
            __builder.AddContent(47, 
#nullable restore
#line 43 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.CasoUso

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "td");
            __builder.AddAttribute(50, "class", "TableDataBody__col");
            __builder.AddContent(51, 
#nullable restore
#line 44 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.EstatusResolucion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenElement(53, "td");
            __builder.AddAttribute(54, "class", "TableDataBody__col");
            __builder.AddContent(55, 
#nullable restore
#line 45 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.Resolucion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenElement(57, "td");
            __builder.AddAttribute(58, "class", "TableDataBody__col");
            __builder.AddContent(59, 
#nullable restore
#line 46 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.FechaResolucion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.OpenElement(61, "td");
            __builder.AddAttribute(62, "class", "TableDataBody__col");
            __builder.AddContent(63, 
#nullable restore
#line 47 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.TipoOrigen

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenElement(65, "td");
            __builder.AddAttribute(66, "class", "TableDataBody__col");
            __builder.AddContent(67, 
#nullable restore
#line 48 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.IdTabla

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.OpenElement(69, "td");
            __builder.AddAttribute(70, "class", "TableDataBody__col");
            __builder.AddContent(71, 
#nullable restore
#line 49 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.UUAARaw

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.OpenElement(73, "td");
            __builder.AddAttribute(74, "class", "TableDataBody__col");
            __builder.AddContent(75, 
#nullable restore
#line 50 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.UUAAMaster

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.OpenElement(77, "td");
            __builder.AddAttribute(78, "class", "TableDataBody__col");
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.OpenElement(80, "a");
            __builder.AddAttribute(81, "href", 
#nullable restore
#line 52 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                  row.URLDocumentacion

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(82, "rel", "noopener noreferrer");
            __builder.AddAttribute(83, "target", "_blank");
            __builder.AddMarkupContent(84, "\r\n                            Link\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                    ");
            __builder.OpenElement(87, "td");
            __builder.AddAttribute(88, "class", "TableDataBody__col");
            __builder.AddContent(89, 
#nullable restore
#line 56 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.Proyecto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                    ");
            __builder.OpenElement(91, "td");
            __builder.AddAttribute(92, "class", "TableDataBody__col");
            __builder.AddContent(93, 
#nullable restore
#line 57 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.PasaIngesta

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                    ");
            __builder.OpenElement(95, "td");
            __builder.AddAttribute(96, "class", "TableDataBody__col");
            __builder.AddContent(97, 
#nullable restore
#line 58 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.QSprintTermino

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "                    \r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 60 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n\r\n    ");
            __builder.OpenElement(103, "table");
            __builder.AddAttribute(104, "class", "TableData");
            __builder.AddMarkupContent(105, "\r\n        ");
            __builder.AddMarkupContent(106, @"<thead class=""TableDataHead"">
            <tr class=""TableDataHead__row"">
                <th class=""TableDataHead__col"">Folio Datahub</th>
                <th class=""TableDataHead__col"">ID de Tabla</th>
                <th class=""TableDataHead__col"">Tipo de Ingesta</th>
                <th class=""TableDataHead__col"">Q-Año-SP Inicio de Ingesta</th>
                <th class=""TableDataHead__col"">Q-Año Inicio de Ingesta</th>
                <th class=""TableDataHead__col"">Scrum</th>
                <th class=""TableDataHead__col"">Nombre de la Tabla Raw</th>
                <th class=""TableDataHead__col"">Nombre de la Tabla Master</th>
                <th class=""TableDataHead__col"">#campos de la Tabla</th>
                <th class=""TableDataHead__col"">UUAA Raw</th>
                <th class=""TableDataHead__col"">UUAA Master</th>
                <th class=""TableDataHead__col"">Ruta Master</th>
                <th class=""TableDataHead__col"">URL de Documentación</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(107, "tbody");
            __builder.AddAttribute(108, "class", "TableDataBody");
            __builder.AddMarkupContent(109, "\r\n");
#nullable restore
#line 83 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
             foreach (var row in ingestBoard)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(110, "                ");
            __builder.OpenElement(111, "tr");
            __builder.AddAttribute(112, "class", "TableDataBody__row");
            __builder.AddMarkupContent(113, "\r\n                    ");
            __builder.OpenElement(114, "td");
            __builder.AddAttribute(115, "class", "TableDataBody__col");
            __builder.AddContent(116, 
#nullable restore
#line 86 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.FolioDatahub

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                    ");
            __builder.OpenElement(118, "td");
            __builder.AddAttribute(119, "class", "TableDataBody__col");
            __builder.AddContent(120, 
#nullable restore
#line 87 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.IdTabla

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                    ");
            __builder.OpenElement(122, "td");
            __builder.AddAttribute(123, "class", "TableDataBody__col");
            __builder.AddContent(124, 
#nullable restore
#line 88 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.TipoIngesta

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                    ");
            __builder.OpenElement(126, "td");
            __builder.AddAttribute(127, "class", "TableDataBody__col");
            __builder.AddContent(128, 
#nullable restore
#line 89 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.QAñoSprintInicioIngesta

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                    ");
            __builder.OpenElement(130, "td");
            __builder.AddAttribute(131, "class", "TableDataBody__col");
            __builder.AddContent(132, 
#nullable restore
#line 90 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.QAñoInicioIngesta

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n                    ");
            __builder.OpenElement(134, "td");
            __builder.AddAttribute(135, "class", "TableDataBody__col");
            __builder.AddContent(136, 
#nullable restore
#line 91 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.Scrum

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                    ");
            __builder.OpenElement(138, "td");
            __builder.AddAttribute(139, "class", "TableDataBody__col");
            __builder.AddContent(140, 
#nullable restore
#line 92 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.NombreTablaRaw

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                    ");
            __builder.OpenElement(142, "td");
            __builder.AddAttribute(143, "class", "TableDataBody__col");
            __builder.AddContent(144, 
#nullable restore
#line 93 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.NombreTablaMaster

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                    ");
            __builder.OpenElement(146, "td");
            __builder.AddAttribute(147, "class", "TableDataBody__col");
            __builder.AddContent(148, 
#nullable restore
#line 94 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.NumeroCamposTabla

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n                    ");
            __builder.OpenElement(150, "td");
            __builder.AddAttribute(151, "class", "TableDataBody__col");
            __builder.AddContent(152, 
#nullable restore
#line 95 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.UUAARaw

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n                    ");
            __builder.OpenElement(154, "td");
            __builder.AddAttribute(155, "class", "TableDataBody__col");
            __builder.AddContent(156, 
#nullable restore
#line 96 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.UUAAMaster

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n                    ");
            __builder.OpenElement(158, "td");
            __builder.AddAttribute(159, "class", "TableDataBody__col");
            __builder.AddContent(160, 
#nullable restore
#line 97 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.RutaMaster

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n                    ");
            __builder.OpenElement(162, "td");
            __builder.AddAttribute(163, "class", "TableDataBody__col");
            __builder.AddContent(164, 
#nullable restore
#line 98 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
                                                    row.ReglaUsuarioIngesta

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n");
#nullable restore
#line 100 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(167, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Projects.razor"
       
    string myelement;

    string message;

    List<BUIEntity> bui = new List<BUIEntity>();
    List<IngestBoardEntity> ingestBoard = new List<IngestBoardEntity>();
    //List<BUIEntity> tempUsers = new List<BUIEntity>();

    protected override async Task OnInitializedAsync()
    {
        bui = new GSheets().getDataBUI();
    }

    private void CategoryChanged()
    {
        bui = new GSheets().getDataBUI();
        ingestBoard = new GSheets().getDataIngestBoard();

        if (message != null && message != "")
        {
            bui = bui.Where(x => x.IdTabla == message).ToList();
            ingestBoard = ingestBoard.Where(y => y.IdTabla == message).ToList();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
