#pragma checksum "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cf68e2b5c6368bcd54454867b2167f61339657d"
// <auto-generated/>
#pragma warning disable 1591
namespace ShadowsWebsite.Client.Shared
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
#line 1 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\Shared\NavMenu.razor"
using ShadowsWebsite.Client.Pages;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar-dark");
            __builder.AddAttribute(2, "b-slm01povej");
            __builder.AddMarkupContent(3, "<a class=\"btn btn-dark navbar-brand\" href b-slm01povej>CyberDragon Studios</a>\r\n\t");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-slm01povej");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-slm01povej></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\t");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", (
#nullable restore
#line 8 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\Shared\NavMenu.razor"
                 NavMenuCssClass

#line default
#line hidden
#nullable disable
            ) + " navbar-collapse");
            __builder.AddAttribute(12, "b-slm01povej");
            __builder.OpenElement(13, "ul");
            __builder.AddAttribute(14, "class", "navbar-nav mr-auto");
            __builder.AddAttribute(15, "b-slm01povej");
            __builder.OpenElement(16, "li");
            __builder.AddAttribute(17, "class", "nav-link");
            __builder.AddAttribute(18, "b-slm01povej");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(19);
            __builder.AddAttribute(20, "class", "btn btn-dark nav-link");
            __builder.AddAttribute(21, "href", "");
            __builder.AddAttribute(22, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 12 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\Shared\NavMenu.razor"
                                                                      NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "<span class=\"oi oi-home\" aria-hidden=\"true\" style=\"cursor:pointer\" b-slm01povej></span> Home\r\n\t\t\t\t");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\t\t\t");
            __builder.OpenElement(26, "li");
            __builder.AddAttribute(27, "class", "nav-link");
            __builder.AddAttribute(28, "b-slm01povej");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "class", "btn btn-dark nav-link");
            __builder.AddAttribute(31, "href", "Content");
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(33, "<span class=\"oi oi-arrow-right\" aria-hidden=\"true\" style=\"cursor:pointer\" b-slm01povej></span> Content\r\n\t\t\t\t");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\t\t\t");
            __builder.OpenElement(35, "li");
            __builder.AddAttribute(36, "class", "nav-link");
            __builder.AddAttribute(37, "b-slm01povej");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(38);
            __builder.AddAttribute(39, "class", "btn btn-dark nav-link");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\Shared\NavMenu.razor"
                                                                   () => Modal.Show<ContactModel>("My Modal")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(42, "<span class=\"oi oi-book\" aria-hidden=\"true\" style=\"cursor:pointer\" b-slm01povej></span> Contact Info\r\n\t\t\t\t");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
	[CascadingParameter] public IModalService Modal { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
