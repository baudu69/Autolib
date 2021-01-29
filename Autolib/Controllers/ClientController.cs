using System;
using System.Collections.Generic;
using System.Text;
using Autolib.Form;
using Autolib.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SshNet.Security.Cryptography;

namespace Autolib.Controllers
{
    

    public class ClientController : Controller
    {
        
        
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        
        
        // GET
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Deco()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Details(FormConnexion formConnexion)
        {
            AutolibContext context = HttpContext.RequestServices.GetService(typeof(AutolibContext)) as AutolibContext;
            Client unClient = context.getUnClient(Convert.ToInt32(formConnexion.idClient));
            if (unClient != null  && unClient.Password == CreateMD5(formConnexion.mdpClient))
            {
                HttpContext.Session.SetString("idSession", unClient.IdClient.ToString());
                return View(unClient);
            }
            else
                return RedirectToAction("Index");
        }
        
        public IActionResult Details()
        {
            string idSession = HttpContext.Session.GetString("idSession");
            AutolibContext context = HttpContext.RequestServices.GetService(typeof(AutolibContext)) as AutolibContext;
            Client unClient = context.getUnClient(Convert.ToInt32(idSession));
            if (unClient != null)
            {
                HttpContext.Session.SetString("idSession", unClient.IdClient.ToString());
                return View(unClient);
            }
            else
                return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult updateInfo(FormModifDetailsClient form)
        {
            string idSession = HttpContext.Session.GetString("idSession");
            AutolibContext context = HttpContext.RequestServices.GetService(typeof(AutolibContext)) as AutolibContext;
            context.updateInfoClient(Convert.ToInt32(idSession), form.nomClient, form.prenomClient);
            return RedirectToAction("Details");
        }

        public IActionResult formInscription()
        {
            return View();
        }

        [HttpPost]
        public IActionResult inscription(FormModifDetailsClient form)
        {
            string mdpHash = CreateMD5(form.mdpClient);
            AutolibContext context = HttpContext.RequestServices.GetService(typeof(AutolibContext)) as AutolibContext;
            context.insertClient(form.nomClient, form.prenomClient, form.naissanceClient, mdpHash);
            return RedirectToAction("Index");
        }

        public IActionResult DetailsReservation()
        {
            string idSession = HttpContext.Session.GetString("idSession");
            AutolibContext context = HttpContext.RequestServices.GetService(typeof(AutolibContext)) as AutolibContext;
            List<Reservation> lesReservations = context.GetReservationByUser(Convert.ToInt32(idSession));
            return View(lesReservations);
        }
        
    }
}