#pragma checksum "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/Components/PostPreview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3325ace2b25013b6b7ed77351dbb8f45154d2e1"
// <auto-generated/>
#pragma warning disable 1591
namespace GWBlazor.Client.Components
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
#line 1 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/Components/PostPreview.razor"
using GWBlazor.Shared;

#line default
#line hidden
#nullable disable
    public partial class PostPreview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "post-preview");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(2);
            __builder.AddAttribute(3, "href", 
#nullable restore
#line 4 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/Components/PostPreview.razor"
                     $"viewpost/{post.PostID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(5, "h2");
                __builder2.AddAttribute(6, "class", "post-title");
                __builder2.AddContent(7, 
#nullable restore
#line 6 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/Components/PostPreview.razor"
             post.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\n        ");
                __builder2.OpenElement(9, "h3");
                __builder2.AddAttribute(10, "class", "post-subtitle");
                __builder2.AddContent(11, 
#nullable restore
#line 9 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/Components/PostPreview.razor"
             post.PostSummary

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\n    ");
            __builder.OpenElement(13, "p");
            __builder.AddAttribute(14, "class", "post-meta");
            __builder.AddMarkupContent(15, "\n        Posted by\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(16);
            __builder.AddAttribute(17, "href", "/");
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(19, 
#nullable restore
#line 14 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/Components/PostPreview.razor"
                           post.Author

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\n        on ");
            __builder.AddContent(21, 
#nullable restore
#line 15 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/Components/PostPreview.razor"
            post.Posted

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/Components/PostPreview.razor"
       
    [Parameter] public Post post { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
