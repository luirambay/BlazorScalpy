#pragma checksum "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Shared\MenuNav.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab1cf62ab95157f37cd8e81e6f2650f5fd9e4a29"
// <auto-generated/>
#pragma warning disable 1591
namespace Scalpy.Shared
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
    public partial class MenuNav : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"MenuNav\">\r\n    <nav class=\"MenuNavList\">\r\n        <h2 class=\"MenuNavList__title\">Reportes</h2>\r\n        <ul>\r\n            <li class=\"MenuNavList__item\">\r\n                <a class=\"MenuNavList__link\" href=\"/projects\">\r\n                    <i class=\"fa fa-archive MenuNavList__link__icon\"></i>\r\n                    Proyectos\r\n                </a>\r\n            </li>\r\n\r\n            <li class=\"MenuNavList__item\">\r\n                <a class=\"MenuNavList__link\" href=\"/fetchdata\">\r\n                    <i class=\"fa fa-code-branch MenuNavList__link__icon\"></i>\r\n                    Repositorios\r\n                </a>\r\n            </li>\r\n\r\n            <li class=\"MenuNavList__item\">\r\n                <a class=\"MenuNavList__link dropdown\" href=\"/graphics\">\r\n                    <i class=\"fa fa-chart-line MenuNavList__link__icon\"></i>\r\n                    Gráficos\r\n                </a>\r\n            </li>\r\n\r\n            <li class=\"MenuNavList__item\">\r\n                <a class=\"MenuNavList__link\" href=\"/bui\">\r\n                    <i class=\"fa fa-clipboard-list MenuNavList__link__icon\"></i>\r\n                    BUI\r\n                </a>\r\n            </li>\r\n        </ul>\r\n    </nav>\r\n\r\n    <nav class=\"MenuNavList\">\r\n        <h3 class=\"MenuNavList__title\">Extras</h3>\r\n\r\n        <ul>\r\n            <li class=\"MenuNavList__item\">\r\n                <a class=\"MenuNavList__link\" href=\"/documents\">\r\n                    <i class=\"fa fa-file MenuNavList__link__icon\"></i>\r\n                    Documentos\r\n                </a>\r\n            </li>\r\n\r\n            <li class=\"MenuNavList__item\">\r\n                <a class=\"MenuNavList__link\" href=\"/ingestas\">\r\n                    <i class=\"fa fa-bullhorn MenuNavList__link__icon\"></i>\r\n                    Validar ingestas\r\n                </a>\r\n            </li>\r\n        </ul>\r\n    </nav>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
