using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JumpToASPNETcore.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public void FormTwo(string textBoxStringData, string textBoxIntData, bool? checkboxData)
        {
            
            //Do something
        }
        [HttpPost]
        public ActionResult Login(Models.User user)
        {
            if (ModelState.IsValid)
            {
                if (user.IsValid(user.Email, user.Password))
                {
                   return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Login data is incorrect!");
                }
            }
            return View();
        }
    }
}