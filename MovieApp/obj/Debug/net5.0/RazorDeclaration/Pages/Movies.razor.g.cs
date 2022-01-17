// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MovieApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\A242736\source\repos\BlazorMovieApp\MovieApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\A242736\source\repos\BlazorMovieApp\MovieApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\A242736\source\repos\BlazorMovieApp\MovieApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\A242736\source\repos\BlazorMovieApp\MovieApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\A242736\source\repos\BlazorMovieApp\MovieApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\A242736\source\repos\BlazorMovieApp\MovieApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\A242736\source\repos\BlazorMovieApp\MovieApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\A242736\source\repos\BlazorMovieApp\MovieApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\A242736\source\repos\BlazorMovieApp\MovieApp\_Imports.razor"
using MovieApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\A242736\source\repos\BlazorMovieApp\MovieApp\_Imports.razor"
using MovieApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\A242736\source\repos\BlazorMovieApp\MovieApp\Pages\Movies.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\A242736\source\repos\BlazorMovieApp\MovieApp\Pages\Movies.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Movies")]
    public partial class Movies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\A242736\source\repos\BlazorMovieApp\MovieApp\Pages\Movies.razor"
       

    IEnumerable<Movie> Movie = new List<Movie>();
    string imgPath = "https://image.tmdb.org/t/p/w1280/";
    string searchValue;
    string apiName = "3/discover/movie?sort_by=popularity.desc&api_key=457eee6dbcc86ae89d88514258f022e7&page=1";

    protected override async Task OnInitializedAsync()
    {
        var httpResponse = await client.GetAsync(apiName);

        if (httpResponse.IsSuccessStatusCode)
        {
            Response responseData = JsonConvert.DeserializeObject<Response>(await httpResponse.Content.ReadAsStringAsync());
            Movie = responseData.Movies;
            StateHasChanged();
        }
    }

    private async Task SearchMovies(string searchTerm)
    {
        var httpResponse = await client.GetAsync(apiName);

        if (httpResponse.IsSuccessStatusCode)
        {
            Response responseData = JsonConvert.DeserializeObject<Response>(await httpResponse.Content.ReadAsStringAsync());
            var RawMovie = responseData.Movies;
            Movie = Search(RawMovie, searchTerm).ToArray();
            StateHasChanged();
        }
    }

    private IEnumerable<Movie> Search(IEnumerable<Movie> movies, string searchTerm)
    {
        if (string.IsNullOrWhiteSpace(searchTerm)) return movies;

        var lowerCaseSearchTerm = searchTerm.Trim().ToLower();

        return movies.Where(p => p.Title.ToLower().Contains(lowerCaseSearchTerm));
    }

    public async void Enter(KeyboardEventArgs e)
    {
        if (e.Code == "Enter" || e.Code == "NumpadEnter")
        {
            await SearchMovies(searchValue);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
