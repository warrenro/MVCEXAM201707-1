using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEXAM201707_1.Models.ViewModels
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult LoginView()
        {
            return View();
        }

       
        public ActionResult DisplayMessage()
        {
            TempData["message"] = "register done";
            return View();
        }
    }
}