using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreConfigurationLesson5.Models;
using Microsoft.Extensions.Configuration;

namespace DotNetCoreConfigurationLesson5.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration _configuration;
        public IActionResult Index()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            _configuration = builder.Build();

            #region Indexer

            var firstName = _configuration["People:FirstName"];
            var lastName = _configuration["People:LastName"];
            var age = _configuration["People:Age"];
            ViewBag.FirstName = firstName;
            ViewBag.LastName = lastName;
            ViewBag.Age = age;

            #endregion

            #region Section

            var people = _configuration.GetSection("People").GetChildren().ToDictionary(x=>x.Key,y=>y.Value);
            ViewBag.People = people;
            #endregion

            #region conString

            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            ViewBag.Cs = connectionString;
            #endregion

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
