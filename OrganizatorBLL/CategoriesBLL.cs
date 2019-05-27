using OrganizatorENTİTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizatorBLL
{
   public static class CategoriesBLL
    {

        static DataContext datacontext = new DataContext();

        public static void insertCategories(Categories cat)
        {
            datacontext.Categories.Add(cat);
            datacontext.SaveChanges();
        }
    }
}
