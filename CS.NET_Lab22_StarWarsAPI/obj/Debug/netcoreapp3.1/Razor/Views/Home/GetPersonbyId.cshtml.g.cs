#pragma checksum "C:\Users\coronele\source\repos\CS.NET_Lab22_StarWarsAPI\CS.NET_Lab22_StarWarsAPI\Views\Home\GetPersonbyId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08c3f5e7b74d74c09939c4a5ab39484a9c0e0957"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetPersonbyId), @"mvc.1.0.view", @"/Views/Home/GetPersonbyId.cshtml")]
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
#line 1 "C:\Users\coronele\source\repos\CS.NET_Lab22_StarWarsAPI\CS.NET_Lab22_StarWarsAPI\Views\_ViewImports.cshtml"
using CS.NET_Lab22_StarWarsAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\coronele\source\repos\CS.NET_Lab22_StarWarsAPI\CS.NET_Lab22_StarWarsAPI\Views\_ViewImports.cshtml"
using CS.NET_Lab22_StarWarsAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c3f5e7b74d74c09939c4a5ab39484a9c0e0957", @"/Views/Home/GetPersonbyId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b652a570579b0a4203dabd573574787741ab49e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetPersonbyId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SWCharacterRoot>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\coronele\source\repos\CS.NET_Lab22_StarWarsAPI\CS.NET_Lab22_StarWarsAPI\Views\Home\GetPersonbyId.cshtml"
  
    ViewData["Title"] = "GetPersonbyId";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "C:\Users\coronele\source\repos\CS.NET_Lab22_StarWarsAPI\CS.NET_Lab22_StarWarsAPI\Views\Home\GetPersonbyId.cshtml"
Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>Height</th>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\coronele\source\repos\CS.NET_Lab22_StarWarsAPI\CS.NET_Lab22_StarWarsAPI\Views\Home\GetPersonbyId.cshtml"
           Write(Model.height);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Birth Year</th>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\coronele\source\repos\CS.NET_Lab22_StarWarsAPI\CS.NET_Lab22_StarWarsAPI\Views\Home\GetPersonbyId.cshtml"
           Write(Model.birth_year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Gender</th>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\coronele\source\repos\CS.NET_Lab22_StarWarsAPI\CS.NET_Lab22_StarWarsAPI\Views\Home\GetPersonbyId.cshtml"
           Write(Model.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Homeworld</th>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\coronele\source\repos\CS.NET_Lab22_StarWarsAPI\CS.NET_Lab22_StarWarsAPI\Views\Home\GetPersonbyId.cshtml"
           Write(Model.homeworld);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Vehicles</th>\r\n            <td>\r\n");
#nullable restore
#line 30 "C:\Users\coronele\source\repos\CS.NET_Lab22_StarWarsAPI\CS.NET_Lab22_StarWarsAPI\Views\Home\GetPersonbyId.cshtml"
                 foreach (string vehicle in Model.vehicles)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <ol>\r\n                        <li>");
#nullable restore
#line 33 "C:\Users\coronele\source\repos\CS.NET_Lab22_StarWarsAPI\CS.NET_Lab22_StarWarsAPI\Views\Home\GetPersonbyId.cshtml"
                       Write(vehicle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ol>\r\n");
#nullable restore
#line 35 "C:\Users\coronele\source\repos\CS.NET_Lab22_StarWarsAPI\CS.NET_Lab22_StarWarsAPI\Views\Home\GetPersonbyId.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>Starships</th>\r\n            <td>\r\n");
#nullable restore
#line 41 "C:\Users\coronele\source\repos\CS.NET_Lab22_StarWarsAPI\CS.NET_Lab22_StarWarsAPI\Views\Home\GetPersonbyId.cshtml"
                 foreach (string starship in Model.starships)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <ol>\r\n                        <li>");
#nullable restore
#line 44 "C:\Users\coronele\source\repos\CS.NET_Lab22_StarWarsAPI\CS.NET_Lab22_StarWarsAPI\Views\Home\GetPersonbyId.cshtml"
                       Write(starship);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ol>\r\n");
#nullable restore
#line 46 "C:\Users\coronele\source\repos\CS.NET_Lab22_StarWarsAPI\CS.NET_Lab22_StarWarsAPI\Views\Home\GetPersonbyId.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>Films character was in</th>\r\n            <td>\r\n");
#nullable restore
#line 52 "C:\Users\coronele\source\repos\CS.NET_Lab22_StarWarsAPI\CS.NET_Lab22_StarWarsAPI\Views\Home\GetPersonbyId.cshtml"
                 foreach (string films in Model.films)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <ol>\r\n                        <li>");
#nullable restore
#line 55 "C:\Users\coronele\source\repos\CS.NET_Lab22_StarWarsAPI\CS.NET_Lab22_StarWarsAPI\Views\Home\GetPersonbyId.cshtml"
                       Write(films);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ol>\r\n");
#nullable restore
#line 57 "C:\Users\coronele\source\repos\CS.NET_Lab22_StarWarsAPI\CS.NET_Lab22_StarWarsAPI\Views\Home\GetPersonbyId.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>Link:</th>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1472, "\"", 1489, 1);
#nullable restore
#line 62 "C:\Users\coronele\source\repos\CS.NET_Lab22_StarWarsAPI\CS.NET_Lab22_StarWarsAPI\Views\Home\GetPersonbyId.cshtml"
WriteAttributeValue("", 1479, Model.url, 1479, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 62 "C:\Users\coronele\source\repos\CS.NET_Lab22_StarWarsAPI\CS.NET_Lab22_StarWarsAPI\Views\Home\GetPersonbyId.cshtml"
                                Write(Model.url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n        </tr>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SWCharacterRoot> Html { get; private set; }
    }
}
#pragma warning restore 1591