#pragma checksum "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Pages\Blog\CreatePost.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c4db1496ae1a0268a9cace603ecbdfebe0f8936"
// <auto-generated/>
#pragma warning disable 1591
namespace GWBlazor.Client.Pages.Blog
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
#line 2 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Pages\Blog\CreatePost.razor"
using GWBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Pages\Blog\CreatePost.razor"
using GWBlazor.Client.Component.Blog;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Blog/create")]
    public partial class CreatePost : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add New Post</h3>\r\n\r\n");
            __builder.OpenComponent<GWBlazor.Client.Component.Blog.Form>(1);
            __builder.AddAttribute(2, "ButtonText", "Create Post");
            __builder.AddAttribute(3, "dev", 
#nullable restore
#line 9 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Pages\Blog\CreatePost.razor"
                                     post

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 10 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Pages\Blog\CreatePost.razor"
                      CreateNewPost

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Pages\Blog\CreatePost.razor"
       
    Post post = new Post();
    async Task CreateNewPost()
    {
        await http.PostAsJsonAsync("api/Blog/AddPost", post);
        uriHelper.NavigateTo("/Blog");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591