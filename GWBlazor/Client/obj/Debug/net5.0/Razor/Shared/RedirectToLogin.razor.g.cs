#pragma checksum "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/Shared/RedirectToLogin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "717de28ffcbf3764338ce2bc14609901eaf80029"
// <auto-generated/>
#pragma warning disable 1591
namespace GWBlazor.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/_Imports.razor"
using GWBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/_Imports.razor"
using GWBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/Shared/RedirectToLogin.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    public partial class RedirectToLogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/Shared/RedirectToLogin.razor"
       
    protected override void OnInitialized()
    {
        Navigation.NavigateTo($"authentication/login?returnUrl={Uri.EscapeDataString(Navigation.Uri)}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
