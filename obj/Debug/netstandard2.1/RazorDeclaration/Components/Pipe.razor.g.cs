#pragma checksum "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\Components\Pipe.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a72a5890f9436d0d81aa81ab772a108a40606c71"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class Pipe : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\Users\natn0\source\repos\FlapppBirdDemo.Web\Components\Pipe.razor"
       

    [Parameter] public PipeModel Model { get; set; }

    string _bottomPipeCss => 
        $"left: {Model.DistanceFromLeft}px; bottom: {Model.DistanceFromBottom}px";

    string _topPipeCss => 
        $"left: {Model.DistanceFromLeft}px; bottom: {Model.DistanceFromBottom + 300 + Model.Gap}px";
    


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
