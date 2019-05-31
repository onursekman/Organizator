using OrganizatorDAL;
using OrganizatorENTİTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizatorBLL
{
   public static class LoginBLL
    {
        static DataContext datacontext = new DataContext();

        public static  People Login(string email)
        {
            return datacontext.People.Where(x => x.Email == email).FirstOrDefault();
        }
    }
}
