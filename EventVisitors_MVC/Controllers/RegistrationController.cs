using EventVisitors_MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EventVisitors_MVC.Controllers
{
    public class RegistrationController : Controller
    {


        public ActionResult Index()
        {

                return View();
            }

        public ActionResult RegistrationUser()
        {

            return View();
        }
        
        [HttpPost] //Skickar värderna som användaren skriver in
        public ActionResult RegistrationUser(ProfilesClass registration)
        {
            registration.Profile_Role = "Besökare"; // Besökare blir standardroll för alla som registrerar sig
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:19779/api/PostProfile");

                //HTTP POST
                var postTask = client.PostAsJsonAsync("PostProfile", registration); // Kolla med grupp1 att det är rätt metod
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("LoginUser", "Login");
                }
                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

                return View(registration);
            }

            
        }
    }
}



