using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JumpToASPNETcore.Models;
using Newtonsoft.Json;

namespace JumpToASPNETcore.Controllers
{
    public class HomeController : Controller
    {
        static List<People> peoples = new List<People>();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            //ViewData["Message"] = "Your application description page.";
            var list = new List<string>();
            for (int i = 1; i < 10; i++)
            {
                list.Add($"I am {i * 10} year old");
            }
            ViewData["MyList"] = list;
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

        public IActionResult GetPeople()
        {

            peoples.Add(new People
            {
                Pid = 1,
                FirstName = "John",
                LastName = "Champion",
                Age = 25
            });
            peoples.Add(new People
            {
                Pid = 2,
                FirstName = "Leo",
                LastName = "Messi",
                Age = 31
            });
            return View(peoples);
        }
        public IActionResult Edit(int Pid)
        {
            var people = peoples.FirstOrDefault(x => x.Pid == Pid);
            if (people != null)
                people.FirstName = "Edit";
            return View(peoples);
        }

        //[HttpDelete]
        public IActionResult Delete(int id)
        {
            peoples.Remove(peoples.FirstOrDefault(x => x.Pid == id));
            return Json(peoples,new JsonSerializerSettings());
        }
        public IActionResult GetPeopleJson()
        {
            return Json(peoples);
        }
    }
}
