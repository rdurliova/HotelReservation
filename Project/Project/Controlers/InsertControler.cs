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
        private static ReadControler read = new ReadControler(context);

        public bool InsertIntoCoutries(string coutryName)
        {
            if (read.FindCountry(coutryName) == null)
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
            Town findTown = read.FindTown(countryName, townName);
            if (findTown == null)
            {
                InsertIntoCoutries(countryName);
                int countryId = read.FindCountry(countryName).Id;
                Town newTown = new Town(townName, countryId);
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
            RoomType findType = read.FindType(roomType);
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
            var town = read.FindTown(countryName, townName);
            if (town != null)
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
        public bool InsertIntoReservation(string egn, string roomNumber, DateTime startDate, DateTime endDate, decimal pay, string paymentType)
        {
            Client client = read.GetClientByEGN(egn);
            Room room = read.GetRoomByNumber(roomNumber);
            if (client != null && room != null && endDate > startDate)
            {
                Reservation newReservation = new Reservation(client.Id, room.Id, startDate, endDate, pay, paymentType);
                context.Reservations.Add(newReservation);
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
