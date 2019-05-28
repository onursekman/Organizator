using OrganizatorENTİTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrganizatorUI.Models
{
    public class CategoriesModel
    {

        public List<Categories> Categories{ get; set; }
        public int ID { get; set; }
        public string CategoriesName { get; set; }
        public string Picture { get; set; }

        //public int CategoriesID { get; set; }
        //public int PeopleID { get; set; }
        //public int Number_of_Participants { get; set; }
        //public DateTime Time{ get; set; }
        //public string Picture { get; set; }
        //public DateTime Application_date { get; set; }

    }
}