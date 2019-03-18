using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controlers
{
    public class InsertControler
    {
        private static HotelReservationContext context = new HotelReservationContext();
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

        public bool InsertIntoRooms(string roomType, string roomNumber)
        {
            RoomType findType = find.FindType(roomType);
            if (findType != null)
            {
                Room newRoom = new Room
                {
                    RoomNumebr = roomNumber,
                    TypeId = findType.Id,
                    isFree = true
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
        public bool InsertIntoClients(string firstName, string lastName, string egn, int age, string townName, string countryName, string gsm, string email)
        {
            var town = find.FindTown(countryName, townName);
            if (town!=null)
            {
                Client newClient = new Client(firstName, lastName, egn, age, town.Id, gsm, email);
                context.Clients.Add(newClient);
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
