using modelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modelBinding.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        //This is use for primitive data

        //[HttpPost]
        //public ActionResult Login(string username, string password)
        //{
        //    return Content(username + " " + password);
        //}


        //This is using for complex data
        [HttpPost]
        public ActionResult Login(User us)
        {
            if(us.username == "admin" && us.password == "123")
            {
                return RedirectToAction("WithViewModel", "Student");
            }
            return Content("Login Failed");
        }
    }
}