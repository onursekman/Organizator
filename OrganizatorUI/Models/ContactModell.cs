using OrganizatorENTİTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrganizatorUI.Models
{
    public class ContactModell
    {
        public List<People> Peoples{ get; set; }
        public int ID{ get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Profile_Picture { get; set; }

    }
}