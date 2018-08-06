using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lesson9.Middleware.Models;
using System.Threading;

namespace Lesson9.Middleware.Controllers
{
    public class HomeController : Controller
    {
        public  IActionResult Index()
        {
            var typeAn = new { x = 15 , y=20 };
            var number = typeAn.x;

            dynamic d = 25;
            d = "yh";


            Guid guid = Guid.NewGuid();
            var s= guid.ToString();

            var date = DateTime.Now.ToString("yyyy-mm--dd");

            var dec = 2532.13543d;
            dec.ToString("##.###");
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
