#pragma checksum "/Users/d054341/Projects/blazortest/blazortest/Pages/EmployeeOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f1c759c8ed7321abccf1260735d4b2e65dd5ed3"
// <auto-generated/>
#pragma warning disable 1591
namespace blazortest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/d054341/Projects/blazortest/blazortest/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/d054341/Projects/blazortest/blazortest/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/d054341/Projects/blazortest/blazortest/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/d054341/Projects/blazortest/blazortest/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/d054341/Projects/blazortest/blazortest/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/d054341/Projects/blazortest/blazortest/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/d054341/Projects/blazortest/blazortest/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/d054341/Projects/blazortest/blazortest/_Imports.razor"
using blazortest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/d054341/Projects/blazortest/blazortest/_Imports.razor"
using blazortest.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeoverview")]
    public partial class EmployeeOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"page-title\">All employees</h1>\n\n");
#nullable restore
#line 5 "/Users/d054341/Projects/blazortest/blazortest/Pages/EmployeeOverview.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\n");
#nullable restore
#line 8 "/Users/d054341/Projects/blazortest/blazortest/Pages/EmployeeOverview.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.AddMarkupContent(7, "<thead>\n            <tr>\n                <th></th>\n                <th>Employee ID</th>\n                <th>First name</th>\n                <th>Last name</th>\n                <th></th>\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\n");
#nullable restore
#line 22 "/Users/d054341/Projects/blazortest/blazortest/Pages/EmployeeOverview.razor"
             foreach (var employee in Employees)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\n                    ");
            __builder.OpenElement(13, "td");
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "src", 
#nullable restore
#line 25 "/Users/d054341/Projects/blazortest/blazortest/Pages/EmployeeOverview.razor"
                                    $"https://gillcleerenpluralsight.blob.core.windows.net/person/{employee.EmployeeId}-small.jpg"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "class", "rounded-circle");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 26 "/Users/d054341/Projects/blazortest/blazortest/Pages/EmployeeOverview.razor"
                         employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 27 "/Users/d054341/Projects/blazortest/blazortest/Pages/EmployeeOverview.razor"
                         employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 28 "/Users/d054341/Projects/blazortest/blazortest/Pages/EmployeeOverview.razor"
                         employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n");
#nullable restore
#line 31 "/Users/d054341/Projects/blazortest/blazortest/Pages/EmployeeOverview.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n");
#nullable restore
#line 34 "/Users/d054341/Projects/blazortest/blazortest/Pages/EmployeeOverview.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
