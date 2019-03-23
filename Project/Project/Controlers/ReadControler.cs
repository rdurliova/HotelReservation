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

        public List<Room>  FreeRooms()
        {
            var freeRooms = context.Rooms.Where(r => r.isFree == true).ToList();
            return freeRooms;
        }
        public List<Room> BusyRooms()
        {
            var busyRooms = context.Rooms.Where(r => r.isFree == false).ToList();
            return busyRooms;
        }


    }
}


     
       
   


