#pragma checksum "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Client\DetailsReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d010a494a08ecc6e424b96dfff3f0d8673f4feaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_DetailsReservation), @"mvc.1.0.view", @"/Views/Client/DetailsReservation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d010a494a08ecc6e424b96dfff3f0d8673f4feaa", @"/Views/Client/DetailsReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d5aa5348c20faa1dc5ea7f3bf220d0a17b61218", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_DetailsReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("       \r\n");
#nullable restore
#line 3 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Client\DetailsReservation.cshtml"
  
   Layout = "~/Views/Shared/_Layout.cshtml";
   ViewData["Title"] = "Historique des réservations";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Historique des réservations</h2>
<table class=""table"">
    <thead class=""thead-dark"">
    <tr>
        <th scope=""col"">Id Véhicule</th>
        <th scope=""col"">Type véhicule</th>
        <th scope=""col"">Catégorie</th>
        <th scope=""col"">Date de réservation</th>
        <th scope=""col"">Date échéance</th>
    </tr>
    </thead>
   <tbody>
");
#nullable restore
#line 20 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Client\DetailsReservation.cshtml"
    foreach (var item in Model)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <tr>\r\n           <th scope=\"row\">\r\n               ");
#nullable restore
#line 24 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Client\DetailsReservation.cshtml"
          Write(Html.DisplayTextFor(modelItem => item.leVehicule.IdVehicule));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           </th>\r\n           <td>\r\n               ");
#nullable restore
#line 27 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Client\DetailsReservation.cshtml"
          Write(Html.DisplayTextFor(modelItem => item.leVehicule.Type.Type_vehicule));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           </td>\r\n           <td>\r\n               ");
#nullable restore
#line 30 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Client\DetailsReservation.cshtml"
          Write(Html.DisplayTextFor(modelItem => item.leVehicule.Type.Categorie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           </td>\r\n           <td>\r\n               ");
#nullable restore
#line 33 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Client\DetailsReservation.cshtml"
          Write(Html.DisplayTextFor(modelItem => item.Date_reservation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           </td>\r\n           <td>\r\n               ");
#nullable restore
#line 36 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Client\DetailsReservation.cshtml"
          Write(Html.DisplayTextFor(modelItem => item.Date_echeance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           </td>\r\n       </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Client\DetailsReservation.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
