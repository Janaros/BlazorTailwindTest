#pragma checksum "C:\Users\mschuer\source\repos\BlazorTailwindTest\BlazorTailwindTest\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "728964c7d8bf1b46a1a224cab37ad1401805f7ce"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTailwindTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mschuer\source\repos\BlazorTailwindTest\BlazorTailwindTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mschuer\source\repos\BlazorTailwindTest\BlazorTailwindTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mschuer\source\repos\BlazorTailwindTest\BlazorTailwindTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mschuer\source\repos\BlazorTailwindTest\BlazorTailwindTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mschuer\source\repos\BlazorTailwindTest\BlazorTailwindTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mschuer\source\repos\BlazorTailwindTest\BlazorTailwindTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mschuer\source\repos\BlazorTailwindTest\BlazorTailwindTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mschuer\source\repos\BlazorTailwindTest\BlazorTailwindTest\_Imports.razor"
using BlazorTailwindTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mschuer\source\repos\BlazorTailwindTest\BlazorTailwindTest\_Imports.razor"
using BlazorTailwindTest.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""max-w-screen-lg rounded overflow-hidden shadow-lg"">

	<div class=""flex mb-4"">
		<div class=""w-1/4 bg-gray-500 h-12""></div>
		<div class=""w-1/4 bg-gray-400 h-12""></div>
		<div class=""w-1/4 bg-gray-500 h-12""></div>
		<div class=""w-1/4 bg-gray-400 h-12""></div>
	</div>


</div>
");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "flex flex-wrap -mx-3 mb-2");
            __builder.AddMarkupContent(3, "\r\n\t");
            __builder.AddMarkupContent(4, @"<div class=""w-full md:w-1/3 px-3 mb-6 md:mb-0"">
		<label class=""block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2"" for=""grid-city"">
			City
		</label>
		<input class=""appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-1 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500"" id=""grid-city"" type=""text"" placeholder=""Albuquerque"">
	</div>
	");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "w-full md:w-1/3 px-3 mb-6 md:mb-0");
            __builder.AddMarkupContent(7, "\r\n\t\t");
            __builder.AddMarkupContent(8, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"grid-state\">\r\n\t\t\tState\r\n\t\t</label>\r\n\t\t");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "relative");
            __builder.AddMarkupContent(11, "\r\n\t\t\t");
            __builder.OpenElement(12, "select");
            __builder.AddAttribute(13, "class", "block appearance-none w-full bg-gray-200 border border-gray-200 text-gray-700 py-1 px-4 pr-8 rounded leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
            __builder.AddAttribute(14, "id", "grid-state");
            __builder.AddMarkupContent(15, "\r\n\t\t\t\t");
            __builder.OpenElement(16, "option");
            __builder.AddContent(17, "New Mexico");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\t\t\t\t");
            __builder.OpenElement(19, "option");
            __builder.AddContent(20, "Missouri");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\t\t\t\t");
            __builder.OpenElement(22, "option");
            __builder.AddContent(23, "Texas");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\t\t\t");
            __builder.AddMarkupContent(26, @"<div class=""pointer-events-none absolute inset-y-0 right-0 flex items-center px-2 text-gray-700"">
				<svg class=""fill-current h-4 w-4"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 20 20""><path d=""M9.293 12.95l.707.707L15.657 8l-1.414-1.414L10 10.828 5.757 6.586 4.343 8z""></path></svg>
			</div>
		");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\t");
            __builder.AddMarkupContent(29, @"<div class=""w-full md:w-1/3 px-3 mb-6 md:mb-0"">
		<label class=""block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2"" for=""grid-zip"">
			Zip
		</label>
		<input class=""appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-1 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500"" id=""grid-zip"" type=""text"" placeholder=""90210"">
	</div>

");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.AddMarkupContent(31, "<button class=\"bg-blue-500 hover:bg-blue-600 text-white font-bold py-2 px-4 rounded\">\r\n\tButton\r\n</button>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591