#pragma checksum "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Map\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94e52fd3ec0dcf062fc6feb33b906ae11fbcd99c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Map_Index), @"mvc.1.0.view", @"/Views/Map/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94e52fd3ec0dcf062fc6feb33b906ae11fbcd99c", @"/Views/Map/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d5aa5348c20faa1dc5ea7f3bf220d0a17b61218", @"/Views/_ViewImports.cshtml")]
    public class Views_Map_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Station>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Map\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Points";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h2>Liste points</h2>


<script
      src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyDOtN6TTt0MrnmRwPv2FUApW4LQ7MIK8oI&callback=initMap&libraries=&v=weekly""
      defer
    ></script>
    <style type=""text/css"">
      /* Set the size of the div element that contains the map */
      #map {
        height: 400px;
        /* The height is 400 pixels */
        width: 100%;
        /* The width is the width of the web page */
      }
    </style>
<script>
      // Initialize and add the map
      function initMap() {
        // The location of Uluru
        const uluru = { lat: 45.747440, lng: 4.877112};
        // The map, centered at Uluru
        const map = new google.maps.Map(document.getElementById(""map""), {
          zoom: 12,
          center: uluru,
        });
        // The marker, positioned at Uluru
        /*const marker = new google.maps.Marker({
          position: uluru,
          map: map,
        });*/
        var latitudePoint = [];
        var long");
            WriteLiteral("itudePoint = [];\r\n        var voituresDispo = [];\r\n        var voituresTot = [];\r\n        \r\n");
#nullable restore
#line 44 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Map\Index.cshtml"
         foreach (var d in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("latitudePoint.push(\"");
#nullable restore
#line 46 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Map\Index.cshtml"
                             Write(d.Latitude);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n            ");
            WriteLiteral("longitudePoint.push(\"");
#nullable restore
#line 47 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Map\Index.cshtml"
                              Write(d.Longitude);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n            ");
            WriteLiteral("voituresDispo.push(\"");
#nullable restore
#line 48 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Map\Index.cshtml"
                             Write(d.nbVoituresLibres);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n            ");
            WriteLiteral("voituresTot.push(\"");
#nullable restore
#line 49 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Map\Index.cshtml"
                           Write(d.nbPlaces);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n");
#nullable restore
#line 50 "C:\Users\Bastien Audu\Documents\OneDrive - etu.univ-lyon1.fr\Polytech 3A\ISI\Autolib\Autolib\Views\Map\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        
       
        var latitudePointDec = [];
        var longitudePointDec = [];
        for (var i=0; i<latitudePoint.length; i++) {
            latitudePointDec.push(parseFloat(latitudePoint[i].replace(',', '.')));
            longitudePointDec.push(parseFloat(longitudePoint[i].replace(',', '.')));
        }
        console.log(latitudePoint)
        console.log(latitudePointDec)
        
        for (var i=0; i<latitudePoint.length; i++) {
            var unePosition= {lat: latitudePointDec[i], lng: longitudePointDec[i]}
            new google.maps.Marker({
                      position: unePosition,
                      map: map,
                      label: { color: '#00aaff', fontWeight: 'bold', fontSize: '14px', text: voituresDispo[i]+'/'+voituresTot[i]}
                    });
        }
        
        
        
      }
    </script>
<div id=""map""></div>");
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
