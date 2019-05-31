using OrganizatorBLL;
using OrganizatorENTİTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrganizatorUI.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Comment_()
        //{
        //    return View();
        //}
        [HttpPost]
        public ActionResult Comment_(string Email,string Detail,int id)
        {
            People people = PeopleBLL.GetPeople(Email);
            Comment cmd = new Comment();
            cmd.PeopleID = people.ID;
            cmd.Comment_detail = Detail;
            Comment_Organizasyon co = new Comment_Organizasyon();
            co.OrganizasyonID = id;
            int commentID = CommentBLL.InsertComment(cmd);
            co.ComentID = commentID;
            CommentBLL.InsertComment_Organizasyon(co);

            return RedirectToAction("Index","Home");
        }
        public ActionResult ListMessaj()
        {


            return View();
        }
      
    }
}