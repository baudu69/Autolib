using System;
using System.Collections.Generic;
using Autolib.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Autolib.Controllers
{
    public class VehiculeController : Controller
    {
        // GET
        public IActionResult Index(int id)
        {
            AutolibContext context = HttpContext.RequestServices.GetService(typeof(AutolibContext)) as AutolibContext;
            List<Vehicule> lesVehicules = context.getLesVehiculesByIdStation(id);
            return View(lesVehicules);
        }

        public IActionResult ListeStation()
        {
            AutolibContext context = HttpContext.RequestServices.GetService(typeof(AutolibContext)) as AutolibContext;
            List<Station> lesStations = context.getLesStations();
            return View(lesStations);
        }

        public IActionResult Reserver(int id)
        {
            int intIdVehicule = id;
            string idSession = HttpContext.Session.GetString("idSession");
            DateTime theDate = DateTime.Now;
            AutolibContext context = HttpContext.RequestServices.GetService(typeof(AutolibContext)) as AutolibContext;
            context.reserver(intIdVehicule, Convert.ToInt32(idSession), theDate.ToString("yyyy-MM-dd H:mm:ss"));
            context.changeEtatVehicule(intIdVehicule, "Reserve en ligne");
            return RedirectToRoute(new {controller = "Client", action="DetailsReservation"});
        } 
    }
}