using OrganizatorDAL;
using OrganizatorENTİTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizatorBLL
{
    public static class CommentBLL
    {

        static DataContext datacontext = new DataContext();
        
        public static int InsertComment(Comment co)
        {
            datacontext.Comment.Add(co);
            datacontext.SaveChanges();
            return co.ID;
        }


        public static void InsertComment_Organizasyon(Comment_Organizasyon co)
        {
            datacontext.Comment_Organizasyon.Add(co);
            datacontext.SaveChanges();

        }
        public static List<Comment_Organizasyon> getComment(int id)
        {
            return datacontext.Comment_Organizasyon.Where(x => x.OrganizasyonID == id).ToList();
        }




    }
}
