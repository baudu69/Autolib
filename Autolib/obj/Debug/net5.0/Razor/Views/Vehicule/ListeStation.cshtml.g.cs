#pragma checksum "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Vehicule\ListeStation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "429fcefe894991eb711f4e0a7a555763bf7f8e91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicule_ListeStation), @"mvc.1.0.view", @"/Views/Vehicule/ListeStation.cshtml")]
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
#line 1 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\_ViewImports.cshtml"
using Autolib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\_ViewImports.cshtml"
using Autolib.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"429fcefe894991eb711f4e0a7a555763bf7f8e91", @"/Views/Vehicule/ListeStation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d5aa5348c20faa1dc5ea7f3bf220d0a17b61218", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicule_ListeStation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Station>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("       \r\n");
#nullable restore
#line 3 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Vehicule\ListeStation.cshtml"
  
   Layout = "~/Views/Shared/_Layout.cshtml";
   ViewData["Title"] = "Stations";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Liste des stations</h2>
<table class=""table"">
    <thead class=""thead-dark"">
    <tr>
        <th scope=""col"">ID</th>
        <th scope=""col"">Adresse</th>
        <th scope=""col"">Numero</th>
        <th scope=""col"">Ville</th>
        <th scope=""col"">Code postal</th>
        <th scope=""col"">Afficher les véhicules</th>
    </tr>
    </thead>
   <tbody>
");
#nullable restore
#line 21 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Vehicule\ListeStation.cshtml"
    foreach (var item in Model)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <tr>\r\n           <th scope=\"row\">\r\n               ");
#nullable restore
#line 25 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Vehicule\ListeStation.cshtml"
          Write(Html.DisplayTextFor(modelItem => item.idStation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           </th>\r\n           <td>\r\n               ");
#nullable restore
#line 28 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Vehicule\ListeStation.cshtml"
          Write(Html.DisplayTextFor(modelItem => item.adresse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           </td>\r\n           <td>\r\n               ");
#nullable restore
#line 31 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Vehicule\ListeStation.cshtml"
          Write(Html.DisplayTextFor(modelItem => item.numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           </td>\r\n           <td>\r\n               ");
#nullable restore
#line 34 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Vehicule\ListeStation.cshtml"
          Write(Html.DisplayTextFor(modelItem => item.ville));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           </td>\r\n           <td>\r\n               ");
#nullable restore
#line 37 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Vehicule\ListeStation.cshtml"
          Write(Html.DisplayTextFor(modelItem => item.code_postal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           </td>\r\n           <td>\r\n               ");
#nullable restore
#line 40 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Vehicule\ListeStation.cshtml"
          Write(Html.ActionLink("Afficher les véhicules", "Index", "Vehicule", new { id= item.idStation }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           </td>\r\n           \r\n       </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Vehicule\ListeStation.cshtml"
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("   </tbody>\r\n</table>\r\n       ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Station>> Html { get; private set; }
    }
}
#pragma warning restore 1591
