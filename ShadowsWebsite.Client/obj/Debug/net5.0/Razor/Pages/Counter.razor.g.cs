#pragma checksum "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "098fa3539c3e0931802abf55d1cc8c909ad0a9f8"
// <auto-generated/>
#pragma warning disable 1591
namespace ShadowsWebsite.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\_Imports.razor"
using ShadowsWebsite.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\_Imports.razor"
using ShadowsWebsite.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\Pages\Counter.razor"
using ShadowsWebsite.Common.StateManagement;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 9 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\Pages\Counter.razor"
                   _cs.Counter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\Pages\Counter.razor"
       
   // private int currentCount = 0;

    protected override void OnInitialized()
    {
        _cs.OnChange += StateHasChanged;
    }

    private void IncrementCount()
    {
        //currentCount++;
        _cs.IncrementCount();
    }

    public void Dispose()
    {
        _cs.OnChange -= StateHasChanged;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CounterState _cs { get; set; }
    }
}
#pragma warning restore 1591
