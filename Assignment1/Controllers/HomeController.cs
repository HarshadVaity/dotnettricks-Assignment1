using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        public IActionResult SignUp()
        {
            UserModel user = new UserModel();
            return View(user);
        }

        [HttpPost]
        public IActionResult SignUp(UserModel user)
        {
            if (ModelState.IsValid)
            {
                return View("UserDetails", user);
            }
            
            return View(user);
        }

        public JsonResult GetCities(string country)
        {
            List<SelectListItem> cities = new List<SelectListItem>();
            cities.Add(new SelectListItem { Value = "", Text = "" });

            if (string.IsNullOrEmpty(country))
                return Json(cities);

            switch(country)
            {
                case "India":
                    cities.Add(new SelectListItem { Value = "Pune", Text = "Pune" });
                    cities.Add(new SelectListItem { Value = "Mumbai", Text = "Mumbai" });
                    break;
                case "Australia":
                    cities.Add(new SelectListItem { Value = "Sydney", Text = "Sydney" });
                    cities.Add(new SelectListItem { Value = "Melbourne", Text = "Melbourne" });
                    break;

            }


            return Json(cities);
        }
        
    }
}
