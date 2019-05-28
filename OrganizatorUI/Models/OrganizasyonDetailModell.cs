using OrganizatorENTİTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrganizatorUI.Models
{
    public class OrganizasyonDetailModell
    {

        public string OrganizasyonName { get; set; }
        public string Picture { get; set; }
        public DateTime Application_date { get; set; }
        public int  sayi{ get; set; }

        public People_Organizayson people_Organizayson { get; set; }
    }
}