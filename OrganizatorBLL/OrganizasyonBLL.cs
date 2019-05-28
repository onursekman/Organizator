using OrganizatorENTİTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizatorBLL
{
   public static class OrganizasyonBLL
    {

        static DataContext datacontext = new DataContext();

        public static void insertOrganizasyon(Organizasyon organizasyon)
        {
            datacontext.Organizasyon.Add(organizasyon);
            datacontext.SaveChanges();
        }
        public static List<Organizasyon> organizasyons()
        {
            return datacontext.Organizasyon.ToList();
        }
        public static Organizasyon GetOrganizasyon()
        {
            int id = datacontext.Organizasyon.Max(x=>x.ID);
            return datacontext.Organizasyon.Where(u => u.ID == id).FirstOrDefault();
        }

        public static void Insert_People_Organizasyon(People_Organizayson po)
        {
            datacontext.People_Organizayson.Add(po);
            datacontext.SaveChanges();
        }
        public static Organizasyon GetOrganizasyon_linq(int id)
        {
            return datacontext.Organizasyon.Where(u => u.ID == id).FirstOrDefault();
        }

        public static List<People_Organizayson> organiz_linq(int id)
        {
            return datacontext.People_Organizayson.Where(x => x.OrganizasyonID == id).ToList();
        }

    }
}
