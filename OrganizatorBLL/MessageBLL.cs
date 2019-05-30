using OrganizatorENTİTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizatorBLL
{
    public static  class MessageBLL
    {

        static DataContext datacontext = new DataContext();



        public static void SenderMessage(Message msj)
        {
            datacontext.Message.Add(msj);
            datacontext.SaveChanges();
        }
        public static List<Message> gelenMessage(int id)
        {
            return datacontext.Message.Where(x => x.ReceiverID == id).ToList();
        }



    }
}
