#pragma checksum "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Component\Blog\List.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bd344e2355f1ce5d21fa13a0dbafd8ae398c75c"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Component\Blog\List.razor"
using GWBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Component\Blog\List.razor"
using GWBlazor.Client.Component.Blog;

#line default
#line hidden
#nullable disable
    public partial class List : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Posts</h3>\r\n");
            __builder.AddMarkupContent(1, "<div class=\"form-group\"><a class=\"btn btn-success\" href=\"Blog/create\"><i class=\"oi oi-plus\"></i> Create New</a></div>\r\n<br>");
#nullable restore
#line 12 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Component\Blog\List.razor"
 if (posts == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "Loading...");
#nullable restore
#line 14 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Component\Blog\List.razor"
                           
}
else if (posts.Length == 0)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "No Records Found.");
#nullable restore
#line 18 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Component\Blog\List.razor"
                                  
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table table-striped");
            __builder.AddMarkupContent(6, "<thead><tr><th>Title</th>\r\n                <th>Content</th>\r\n                <th>Date Posted</th>\r\n                <th>Author</th></tr></thead>\r\n        ");
            __builder.OpenElement(7, "tbody");
#nullable restore
#line 32 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Component\Blog\List.razor"
             foreach (Post dev in posts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tr");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 35 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Component\Blog\List.razor"
                         dev.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 36 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Component\Blog\List.razor"
                         dev.Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 37 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Component\Blog\List.razor"
                         dev.DateUpdated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 38 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Component\Blog\List.razor"
                         dev.Author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Component\Blog\List.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Component\Blog\List.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "\\Mac\Home\Desktop\Dev\Blazor\GWSBlazored\GWBlazor\Client\Component\Blog\List.razor"
       
    Post[] posts { get; set; }
    protected override async Task OnInitializedAsync()
    {
        posts = await client.GetFromJsonAsync<Post[]>("api/Blog/GetAllPosts");
    }

    async Task Delete(int postID)
    {
        var post = posts.First(x => x.PostID == postID);
        if (await js.InvokeAsync<bool>("confirm", $"Do you want to delete {post.Title}'s ({post.PostID}) Record?"))
        {
            await client.DeleteAsync($"api/developer/{postID}");
            await OnInitializedAsync();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
