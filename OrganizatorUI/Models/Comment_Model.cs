using OrganizatorENTİTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrganizatorUI.Models
{
    public class Comment_Model
    {

        public List<Comment> Comment{ get; set; }
        public List<Comment_Organizasyon> Comment_Organizasyon{ get; set; }


    }
}