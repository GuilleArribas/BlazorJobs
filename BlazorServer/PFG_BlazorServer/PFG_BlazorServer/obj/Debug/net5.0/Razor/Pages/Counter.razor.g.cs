#pragma checksum "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "044c3059be136a07764c1693f2033009f4766591"
// <auto-generated/>
#pragma warning disable 1591
namespace PFG_BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using PFG_BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using PFG_BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Roles", "Admin, Empresa");
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "<h1>Counter</h1>\r\n\r\n        ");
                __builder2.OpenElement(4, "p");
                __builder2.AddContent(5, "Current count: ");
#nullable restore
#line 8 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\Counter.razor"
__builder2.AddContent(6, currentCount);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(7, "\r\n\r\n        ");
                __builder2.OpenElement(8, "button");
                __builder2.AddAttribute(9, "class", "btn btn-primary");
                __builder2.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\Counter.razor"
                                                  IncrementCount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(11, "Click me");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(12, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(13, "<p role=\"status\"> You are not authorized to view this content.</p>");
            }
            ));
            __builder.AddAttribute(14, "Authorizing", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(15, "<p role=\"status\"> Authorization is in progress....</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
