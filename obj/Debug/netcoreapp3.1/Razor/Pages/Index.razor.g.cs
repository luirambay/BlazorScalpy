#pragma checksum "D:\Files Luis\Proyectos\BlazorWA\Scalpy\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0d325602869f07ffcc71dbdc9277049f5cb7f8e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/alert")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"alert-warning\">Hello, world!</h1>\r\n\r\n\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<Scalpy.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
