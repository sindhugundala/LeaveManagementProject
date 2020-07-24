using LeaveManagementProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveManagementProject.Controllers
{
    public class HomeController : Controller
    {
        LMSEntities lmsentities = new LMSEntities();
     
        public ActionResult Index()
        {
            return View("_Login");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Signin(Signin login)
        {
           
            if (ModelState.IsValid)
            {
                var user = lmsentities.tblLogins.SingleOrDefault(x => (x.UserName == login.UserName) & (x.Password == login.Password));
                if (user != null)
                {
                    ViewBag.Message = "Login Successful";
                    return View("_Signin");
                }
            }
            return View("Error");

        }
    }
}