using OrganizatorENTİTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizatorBLL
{
   public static class PeopleBLL
    {


       static DataContext datacontext = new DataContext();

        public static People GetPeople(string email)
        {
            return datacontext.People.Where(x => x.Email == email.Trim()).FirstOrDefault();
        }
        public static People GetPeople1(int id)
        {
            return datacontext.People.Where(x => x.ID == id).FirstOrDefault();
        }

        public static List<People> listPeople()
        {
            return datacontext.People.ToList();
        }
        

    }
}
