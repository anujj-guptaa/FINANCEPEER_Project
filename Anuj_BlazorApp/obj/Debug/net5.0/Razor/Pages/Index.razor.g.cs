#pragma checksum "D:\Anuj_BlazorApp\Anuj_BlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8a1874742227c474539106656295321ca616a7b"
// <auto-generated/>
#pragma warning disable 1591
namespace Anuj_BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Anuj_BlazorApp\Anuj_BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Anuj_BlazorApp\Anuj_BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Anuj_BlazorApp\Anuj_BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Anuj_BlazorApp\Anuj_BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Anuj_BlazorApp\Anuj_BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Anuj_BlazorApp\Anuj_BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Anuj_BlazorApp\Anuj_BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Anuj_BlazorApp\Anuj_BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Anuj_BlazorApp\Anuj_BlazorApp\_Imports.razor"
using Anuj_BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Anuj_BlazorApp\Anuj_BlazorApp\_Imports.razor"
using Anuj_BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Anuj_BlazorApp\Anuj_BlazorApp\Pages\Index.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : IndexBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "<h1>Blazor Server File Upload</h1>\r\n\r\n        ");
                __builder2.OpenElement(3, "h3");
                __builder2.AddContent(4, 
#nullable restore
#line 9 "D:\Anuj_BlazorApp\Anuj_BlazorApp\Pages\Index.razor"
             Message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(5, "\r\n\r\n        ");
                __builder2.OpenElement(6, "form");
                __builder2.AddAttribute(7, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 11 "D:\Anuj_BlazorApp\Anuj_BlazorApp\Pages\Index.razor"
                         OnSubmit

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(8);
                __builder2.AddAttribute(9, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 12 "D:\Anuj_BlazorApp\Anuj_BlazorApp\Pages\Index.razor"
                                 OnInputFileChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(10, "multiple", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n            <br><br>\r\n            ");
                __builder2.AddMarkupContent(12, "<button type=\"submit\">Upload Selected File(s)</button>");
                __builder2.CloseElement();
#nullable restore
#line 17 "D:\Anuj_BlazorApp\Anuj_BlazorApp\Pages\Index.razor"
         if (DataModels == null)
        { }
        else
        { 

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(13, "table");
                __builder2.AddMarkupContent(14, "<tr><th> userId</th>\r\n                    <th>\r\n                        ID\r\n                    </th>\r\n                    <th>Title</th>\r\n                    <th>Body</th></tr>");
#nullable restore
#line 30 "D:\Anuj_BlazorApp\Anuj_BlazorApp\Pages\Index.razor"
                 foreach (var item in DataModels)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(15, "tr");
                __builder2.OpenElement(16, "td");
                __builder2.AddContent(17, 
#nullable restore
#line 33 "D:\Anuj_BlazorApp\Anuj_BlazorApp\Pages\Index.razor"
                             item.userId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                        ");
                __builder2.OpenElement(19, "td");
                __builder2.AddContent(20, 
#nullable restore
#line 34 "D:\Anuj_BlazorApp\Anuj_BlazorApp\Pages\Index.razor"
                             item.id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __builder2.OpenElement(22, "td");
                __builder2.AddContent(23, 
#nullable restore
#line 35 "D:\Anuj_BlazorApp\Anuj_BlazorApp\Pages\Index.razor"
                             item.title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                        ");
                __builder2.OpenElement(25, "td");
                __builder2.AddContent(26, 
#nullable restore
#line 36 "D:\Anuj_BlazorApp\Anuj_BlazorApp\Pages\Index.razor"
                             item.body

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 38 "D:\Anuj_BlazorApp\Anuj_BlazorApp\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 40 "D:\Anuj_BlazorApp\Anuj_BlazorApp\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(27, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(28, "<h1>Hello, world!</h1>\r\n\r\n        Welcome to your new app.\r\n        ");
                __builder2.AddMarkupContent(29, "<p>You\'re not signed in.</p>\r\n        ");
                __builder2.AddMarkupContent(30, "<p>Please sign in to upload file.</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
