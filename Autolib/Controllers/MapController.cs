using System.Collections.Generic;
using Autolib.Models;
using Microsoft.AspNetCore.Mvc;

namespace Autolib.Controllers
{
    public class MapController : Controller
    {
        // GET
        public IActionResult Index()
        {
            AutolibContext context = HttpContext.RequestServices.GetService(typeof(AutolibContext)) as AutolibContext;
            List<Station> lesStations = context.getLesStations();
            return View(lesStations);
        }
    }
}