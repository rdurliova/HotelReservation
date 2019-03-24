using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
   public class UpdateControler
    {
        private HotelReservationContext context;

        public UpdateControler(HotelReservationContext context)
        {
            this.context = context;
        }
        
        public bool UpdateClientPhone(string egn, string phone)
        {
            var client=context.Clients.FirstOrDefault(c => c.EGN == egn);
            if (client!=null)
            {
                client.Gsm = phone;
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }            
        }
       public bool UpdateClientEmail(string egn, string email)
        {
            var client = context.Clients.FirstOrDefault(c => c.EGN == egn);
            if (client!=null)
            {
                client.Email = email;
                context.SaveChanges();
                return true;           
            }
            else
            {
                return false;
            }
            
        }
    }
}
