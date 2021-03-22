#pragma checksum "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\Components\GameContainer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86425699ceb9af42df0c3fa2ccfa97302dfd3d6c"
// <auto-generated/>
#pragma warning disable 1591
namespace FlapppBirdDemo.Web.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\_Imports.razor"
using FlapppBirdDemo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\_Imports.razor"
using FlapppBirdDemo.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\_Imports.razor"
using FlapppBirdDemo.Web.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\_Imports.razor"
using FlapppBirdDemo.Web.Models;

#line default
#line hidden
#nullable disable
    public partial class GameContainer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "game-container");
            __builder.AddAttribute(2, "tabindex", "0");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 1 "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\Components\GameContainer.razor"
                                                   _gameManager.StartGame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 1 "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\Components\GameContainer.razor"
                                                                                     HandleKeyUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "sky");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenComponent<FlapppBirdDemo.Web.Components.Bird>(9);
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<FlapppBirdDemo.Web.Components.BirdModel>(
#nullable restore
#line 3 "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\Components\GameContainer.razor"
                     _gameManager.Bird

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    <div class=\"ground\"></div>\r\n");
#nullable restore
#line 6 "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\Components\GameContainer.razor"
     foreach (var pipe in _gameManager.Pipes) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "        ");
            __builder.OpenComponent<FlapppBirdDemo.Web.Components.Pipe>(14);
            __builder.AddAttribute(15, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<FlapppBirdDemo.Web.Models.PipeModel>(
#nullable restore
#line 7 "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\Components\GameContainer.razor"
                     pipe

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 8 "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\Components\GameContainer.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\Components\GameContainer.razor"
       
    GameManager _gameManager;

    protected override void OnInitialized()
    {
        _gameManager = new GameManager();
        _gameManager.MainLoopCompleted += (o, e) => StateHasChanged();
    }

    void StartGame()
    {
        _gameManager.MainLoop();
    }

    void HandleKeyUp(KeyboardEventArgs e)
    {
        if (e.Key == " ")
            _gameManager.Jump();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
