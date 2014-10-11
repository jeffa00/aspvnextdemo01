using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.Framework.ConfigurationModel;

namespace WebApplication003.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            // Setup configuration sources
            var configuration = new Configuration();
            configuration.AddJsonFile("config.json");
            configuration.AddEnvironmentVariables();

            var greeting = configuration.Get("AppSettings:Greeting");

            ViewBag.Greeting = greeting;

            ViewBag.Message = "Your AWESOME application description page.";

            ViewBag.Path = configuration.Get("PATH");

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}