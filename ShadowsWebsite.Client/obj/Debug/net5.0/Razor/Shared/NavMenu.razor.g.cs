#pragma checksum "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a7029381d58486f54568d00e944dcb87039dee3"
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
#line 13 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\_Imports.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\_Imports.razor"
using ShadowsWebsite.Client.ClientServies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\_Imports.razor"
using ShadowsWebsite.Common.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\_Imports.razor"
using ShadowsWebsite.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\_Imports.razor"
using ShadowsWebsite.Common.StateManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\_Imports.razor"
using ShadowsWebsite.Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\_Imports.razor"
using Microsoft.AspNetCore.Mvc;

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
            __builder.AddAttribute(40, "href", "counter");
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(42, "<span class=\"oi oi-arrow-right\" aria-hidden=\"true\" style=\"cursor:pointer\" b-slm01povej></span> Counter\r\n\t\t\t\t");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\t\t\t");
            __builder.OpenElement(44, "li");
            __builder.AddAttribute(45, "class", "nav-link");
            __builder.AddAttribute(46, "b-slm01povej");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(47);
            __builder.AddAttribute(48, "class", "btn btn-dark nav-link");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\Shared\NavMenu.razor"
                                                                   () => Modal.Show<ContactModel>("My Modal")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(51, "<span class=\"oi oi-book\" aria-hidden=\"true\" style=\"cursor:pointer\" b-slm01povej></span> Contact Info\r\n\t\t\t\t");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\t\t\t");
            __builder.OpenElement(53, "li");
            __builder.AddAttribute(54, "class", "nav-link");
            __builder.AddAttribute(55, "b-slm01povej");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(56);
            __builder.AddAttribute(57, "class", "btn btn-dark nav-link");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\Shared\NavMenu.razor"
                                                                   async () => await Agecheck()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(60, "<span class=\"oi oi-book\" aria-hidden=\"true\" style=\"cursor:pointer\" b-slm01povej></span>  18+ Content\r\n\t\t\t\t");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\t\t\t ");
            __builder.OpenElement(62, "li");
            __builder.AddAttribute(63, "class", "nav-item px-3");
            __builder.AddAttribute(64, "b-slm01povej");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(65);
            __builder.AddAttribute(66, "class", "nav-link");
            __builder.AddAttribute(67, "href", "view-logs");
            __builder.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(69, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-slm01povej></span> view Errorlogs\r\n                        ");
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
#line 47 "C:\Users\verdoa\source\repos\ShadowsWebsite\ShadowsWebsite.Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
	[CascadingParameter] public IModalService Modal { get; set; }
	
	
	
	async Task Agecheck()
	{
		try
		{
			if (_cs.Age is 0 or < 18)
			{
				 Modal.Show<AgeCheckModel>("Age Check");
				await Task.Delay(20000).ContinueWith(t => NavigationManager.NavigateTo("/"));
			}
			else
			{
				NavigationManager.NavigateTo("/AdultContent");
			}
		}
		catch (Exception e)
		{
			Console.WriteLine(e);
			throw;
		}
		
		
	}
	

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AgeCheck _cs { get; set; }
    }
}
#pragma warning restore 1591
