using OrganizatorDAL;
using OrganizatorENTİTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizatorBLL
{
    public static class RegisterBLL
    {
        static DataContext datacontext = new DataContext();

        public static void Register(People people)
        {
            datacontext.People.Add(people);
            datacontext.SaveChanges();
        }


    }
}
