#pragma checksum "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fe5b10655c0754743d2de5273491eb18125e109"
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-g6x3qt3x3r");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-g6x3qt3x3r");
            __builder.OpenComponent<GWBlazor.Client.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-g6x3qt3x3r");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4 auth");
            __builder.AddAttribute(13, "b-g6x3qt3x3r");
            __builder.OpenComponent<GWBlazor.Client.Shared.LoginDisplay>(14);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "content px-4");
            __builder.AddAttribute(18, "b-g6x3qt3x3r");
            __builder.AddContent(19, 
#nullable restore
#line 14 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/Shared/MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
