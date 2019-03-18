using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controlers
{
    public class ReadControler
    {
        private HotelReservationContext context;

        public ReadControler(HotelReservationContext context)
        {
            this.context = context;
        }

        public List<Country> CounrtiesList()
        {
            List<Country> returnCountries = context.Countries.ToList();
            return returnCountries;
        }
        public List<Town> TownsList()
        {
            List<Town> returnTowns = context.Towns.ToList();
            return returnTowns;
        }
        

        }
}


     
       
   


