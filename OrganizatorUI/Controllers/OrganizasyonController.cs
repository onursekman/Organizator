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
    public class OrganizasyonController : Controller
    {
        // GET: Organizasyon
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult InsertOrganizasyon()
        {
            List<SelectListItem> category = new List<SelectListItem>();

            foreach (var item in CategoriesBLL.getCategories())
            {
                category.Add(new SelectListItem { Text = item.CategoriesName, Value = item.ID.ToString() });
            }

            ViewBag.Category = category;

            return View();
        }
        [HttpPost]
        public ActionResult InsertOrganizasyon(Organizasyon organizasyon,CategoriesModel model)
        {
            People people = Session["People"] as People;

            Organizasyon o = new Organizasyon();
            o.OrganizasyonName = organizasyon.OrganizasyonName;
            o.Time = DateTime.Now;
            o.Application_date = organizasyon.Application_date;
            o.CategoriesID = model.ID;
            o.PeopleID = people.ID;
            o.Number_of_Participants = organizasyon.Number_of_Participants;
            o.Picture = organizasyon.Picture;

            OrganizasyonBLL.insertOrganizasyon(o);

            return RedirectToAction("Index", "Home");
        }

        public ActionResult organizationrecord()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult organizationrecord(OrganizationRecordModell model)
        {
            People_Organizayson po = new People_Organizayson();

            People people = Session["People"] as People;
            po.OrganizasyonID = model.id;
            po.PeopleID = people.ID;
            po.Number_of_People = model.kisi;
            OrganizasyonBLL.Insert_People_Organizasyon(po);

            return RedirectToAction("Index","Home");
        }

 
        public ActionResult OrganizasyonDetail(int id)
        {
            //OrganizasyonDetailModell modell = new OrganizasyonDetailModell();
           Organizasyon organizasyon= OrganizasyonBLL.GetOrganizasyon_linq(id);
            //modell.OrganizasyonName = organizasyon.OrganizasyonName;
            //modell.Picture = organizasyon.Picture;
            //modell.Application_date = organizasyon.Application_date;

            return View(organizasyon);
        }

        public ActionResult RegisteredOrganizations()
        {
            People people = Session["People"] as People;
            List<People_Organizayson> organizasyons = OrganizasyonBLL.organiz_linq(people.ID);

            return View(organizasyons);
            
        }

        public ActionResult ExitOrganization()
        {

            return View();
        }
        [HttpPost]
        public ActionResult ExitOrganization(int id)
        {

        Organizasyon org=OrganizasyonBLL.GetOrganizasyon_linq(id);
            OrganizasyonBLL.removeOrganizasyon(org);

            return RedirectToAction("RegisteredOrganizations");
        }


    }
}