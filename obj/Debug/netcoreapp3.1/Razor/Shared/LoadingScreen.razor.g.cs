#pragma checksum "E:\Horeac App\VMP.Dashboard\Shared\LoadingScreen.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f251fa15d5bedfd71411c331f1b1808a8a081d13"
// <auto-generated/>
#pragma warning disable 1591
namespace VMP.Dashboard.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using VMP.Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using VMP.Dashboard.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Syncfusion.Blazor.Maps;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Horeac App\VMP.Dashboard\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
    public partial class LoadingScreen : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "E:\Horeac App\VMP.Dashboard\Shared\LoadingScreen.razor"
 if (isLoaded)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 3 "E:\Horeac App\VMP.Dashboard\Shared\LoadingScreen.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 3 "E:\Horeac App\VMP.Dashboard\Shared\LoadingScreen.razor"
                 
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<div style=\"position:absolute; top:30vh; width:100%; text-align:center\">\r\n        <h1>Dashboard</h1>\r\n        <p> &#x231B; The application is loading...\r\n        </p>\r\n    </div>\r\n");
#nullable restore
#line 12 "E:\Horeac App\VMP.Dashboard\Shared\LoadingScreen.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "E:\Horeac App\VMP.Dashboard\Shared\LoadingScreen.razor"
       
    bool isLoaded;

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await Task.Delay(4000); // TODO actual initialization job
        isLoaded = true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
