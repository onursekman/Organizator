using OrganizatorBLL;
using OrganizatorENTİTY;
using OrganizatorUI.Models;
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
            if (people.Password.Trim() == password.Trim())
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
            p.Profile_Picture = "http://c12.incisozluk.com.tr/res/incisozluk//11509/8/2613948_ob5cd.jpg";
            RegisterBLL.Register(p);

            return RedirectToAction("Login");
        }
        public ActionResult Index()
        {
            OrganizasyonModell modell = new OrganizasyonModell();
            modell.organizasyons = OrganizasyonBLL.organizasyons();
            return View(modell);
        }
    }
}