using OrganizatorBLL;
using OrganizatorENTİTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrganizatorUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email,string password)
        {
            People people= LoginBLL.Login(email);
            if (people.Password == password.Trim())
            {

                Session["People"] = people;
            }


            return RedirectToAction("Index");
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(People people)
        {
            People p = new People();
            p.Name = people.Name;
            p.Surname = people.Surname;
            p.Email = people.Email;
            p.Password = people.Password;
            RegisterBLL.Register(p);

            return RedirectToAction("Login");
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}