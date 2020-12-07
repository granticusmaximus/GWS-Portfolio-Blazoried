#pragma checksum "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/Components/AddPost.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35fe7abb07dc28e7ad1af780f4fde2a69d702569"
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
#line 4 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/Components/AddPost.razor"
using GWBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/addpost")]
    public partial class AddPost : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<GWBlazor.Client.Components.Header>(0);
            __builder.AddAttribute(1, "Heading", "GWS Articles");
            __builder.AddAttribute(2, "SubHeading", "Add Post");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-md-12");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "editor");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "placeholder", "Title");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/Components/AddPost.razor"
                              Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Title = __value, Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, @"
                <textarea cols=""250"" asp-for=""Description"" class=""textarea"" placeholder=""Place some text here"" style=""height: 550px; font-size: 14px; line-height: 18px; border: 1px solid #dddddd; border-radius:3px; padding: 10px;""></textarea>
                ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-primary float-right");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/Components/AddPost.razor"
                                                                       SavePost

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Post");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "/Users/grantwatson/Desktop/Dev/GWBlazor/GWS-Portfolio-Blazoried/GWBlazor/Client/Components/AddPost.razor"
       

    protected string Post { get; set; }
    protected string Title { get; set; }
    [Parameter] public int Id { get; set; }

    public async Task SavePost()
    {
        var newPost = new Post()
        {
            PostID = Id,
            Title = Title,
            Author = "Grant Watson",
            Content = Post,
            Posted = DateTime.Now
        };

        var savedPost = await _httpClient.PostAsJsonAsync<Post>(Urls.AddBlogPost, newPost);

        _uriHelper.NavigateTo($"viewpost/{savedPost}/{Id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _httpClient { get; set; }
    }
}
#pragma warning restore 1591
