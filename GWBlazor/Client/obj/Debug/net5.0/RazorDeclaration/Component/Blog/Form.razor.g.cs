// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GWBlazor.Client.Component.Blog
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\_Imports.razor"
using GWBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\_Imports.razor"
using GWBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Component\Blog\Form.razor"
using GWBlazor.Shared;

#line default
#line hidden
#nullable disable
    public partial class Form : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Component\Blog\Form.razor"
       
    [Parameter] public Post post { get; set; }
    [Parameter] public string ButtonText { get; set; } = "Save";
    [Parameter] public EventCallback OnValidSubmit { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591