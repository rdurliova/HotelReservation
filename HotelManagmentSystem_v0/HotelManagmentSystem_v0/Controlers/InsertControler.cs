using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotelsReservation.Controlers
{
    public class InsertControler
    {
        private static HotelsReservationContext context = new HotelsReservationContext();
        private static Find find = new Find();

        public bool InsertIntoCoutries(string coutryName)
        {
            if (find.FindCountry(coutryName) == null)
            {
                context.Countries.Add(
                    new Country() { Name = coutryName });
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertIntoTowns(string townName, string countryName)
        {
            Town findTown = find.FindTown(countryName, townName);
            if (findTown == null)
            {
                InsertIntoCoutries(countryName);
                Town newTown = new Town()
                {
                    Name = townName,
                    CountryId = find.FindCountry(countryName).Id
                };
                context.Towns.Add(newTown);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertIntoRooms(string roomType)
        {
            Type findType = find.FindType(roomType);
            if (findType != null)
            {
                Room newRoom = new Room
                {
                    TypeId = findType.Id
                };
                context.Rooms.Add(newRoom);
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
