#pragma checksum "C:\Users\Jesse\source\repos\Lab 21  Movie Registration Lab 25\Lab 21  Movie Registration Lab 25\Views\Movie\ShowTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fae0e3b6d3c0566a2bdf576b508b12257c778e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_ShowTable), @"mvc.1.0.view", @"/Views/Movie/ShowTable.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Jesse\source\repos\Lab 21  Movie Registration Lab 25\Lab 21  Movie Registration Lab 25\Views\_ViewImports.cshtml"
using Lab_21__Movie_Registration_Lab_25;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jesse\source\repos\Lab 21  Movie Registration Lab 25\Lab 21  Movie Registration Lab 25\Views\_ViewImports.cshtml"
using Lab_21__Movie_Registration_Lab_25.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fae0e3b6d3c0566a2bdf576b508b12257c778e2", @"/Views/Movie/ShowTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7723f65ccb6bbd33850fa2a5f0dbc9295b7675", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_ShowTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RentMovie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Jesse\source\repos\Lab 21  Movie Registration Lab 25\Lab 21  Movie Registration Lab 25\Views\Movie\ShowTable.cshtml"
  
    ViewData["Title"] = "ShowTable";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ShowTable</h1>\r\n\r\n<table class=\"table table-dark table-bordered\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Title</th>\r\n        <th>Genre</th>\r\n        <th>Year</th>\r\n        <th>RunTime</th>\r\n        <th>Rental Cost</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\Jesse\source\repos\Lab 21  Movie Registration Lab 25\Lab 21  Movie Registration Lab 25\Views\Movie\ShowTable.cshtml"
     foreach (RentMovie Movies in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Jesse\source\repos\Lab 21  Movie Registration Lab 25\Lab 21  Movie Registration Lab 25\Views\Movie\ShowTable.cshtml"
           Write(Movies.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Jesse\source\repos\Lab 21  Movie Registration Lab 25\Lab 21  Movie Registration Lab 25\Views\Movie\ShowTable.cshtml"
           Write(Movies.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Jesse\source\repos\Lab 21  Movie Registration Lab 25\Lab 21  Movie Registration Lab 25\Views\Movie\ShowTable.cshtml"
           Write(Movies.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Jesse\source\repos\Lab 21  Movie Registration Lab 25\Lab 21  Movie Registration Lab 25\Views\Movie\ShowTable.cshtml"
           Write(Movies.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Jesse\source\repos\Lab 21  Movie Registration Lab 25\Lab 21  Movie Registration Lab 25\Views\Movie\ShowTable.cshtml"
           Write(Movies.RunTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Jesse\source\repos\Lab 21  Movie Registration Lab 25\Lab 21  Movie Registration Lab 25\Views\Movie\ShowTable.cshtml"
           Write(Movies.RentalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 611, "\"", 762, 12);
            WriteAttributeValue("", 618, "../Movie/AddToCart?id=", 618, 22, true);
#nullable restore
#line 26 "C:\Users\Jesse\source\repos\Lab 21  Movie Registration Lab 25\Lab 21  Movie Registration Lab 25\Views\Movie\ShowTable.cshtml"
WriteAttributeValue("", 640, Movies.ID, 640, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 650, "&title=", 650, 7, true);
#nullable restore
#line 26 "C:\Users\Jesse\source\repos\Lab 21  Movie Registration Lab 25\Lab 21  Movie Registration Lab 25\Views\Movie\ShowTable.cshtml"
WriteAttributeValue("", 657, Movies.Title, 657, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 670, "&genre=", 670, 7, true);
#nullable restore
#line 26 "C:\Users\Jesse\source\repos\Lab 21  Movie Registration Lab 25\Lab 21  Movie Registration Lab 25\Views\Movie\ShowTable.cshtml"
WriteAttributeValue("", 677, Movies.Genre, 677, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 690, "&year=", 690, 6, true);
#nullable restore
#line 26 "C:\Users\Jesse\source\repos\Lab 21  Movie Registration Lab 25\Lab 21  Movie Registration Lab 25\Views\Movie\ShowTable.cshtml"
WriteAttributeValue("", 696, Movies.Year, 696, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 708, "&runtime=", 708, 9, true);
#nullable restore
#line 26 "C:\Users\Jesse\source\repos\Lab 21  Movie Registration Lab 25\Lab 21  Movie Registration Lab 25\Views\Movie\ShowTable.cshtml"
WriteAttributeValue("", 717, Movies.RunTime, 717, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 732, "&rentalcost=", 732, 12, true);
#nullable restore
#line 26 "C:\Users\Jesse\source\repos\Lab 21  Movie Registration Lab 25\Lab 21  Movie Registration Lab 25\Views\Movie\ShowTable.cshtml"
WriteAttributeValue("", 744, Movies.RentalCost, 744, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Rent</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\Jesse\source\repos\Lab 21  Movie Registration Lab 25\Lab 21  Movie Registration Lab 25\Views\Movie\ShowTable.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RentMovie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
