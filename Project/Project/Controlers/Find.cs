using System.Collections.Generic;
using System.Linq;

namespace Project.Controlers
{
    public class Find
    {
        private static HotelReservationContext context = new HotelReservationContext();

        public Country FindCountry(string coutryName)
        {
            Country find = context.Countries
                .FirstOrDefault(x => x.Name == coutryName);
            return find;
        }

        public Town FindTown(string countryName, string townName)
        {
            Country findCoutry = FindCountry(countryName);
            if (findCoutry == null)
            {
                return null;
            }
            else
            {
                Town find = context.Towns
                    .Where(x => x.Name == townName && x.Country.Name == countryName)
                    .FirstOrDefault();
                return find;
            }
        }

        public RoomType FindType(string roomType)
        {
            RoomType findType = context.RoomTypes
                .FirstOrDefault(t => t.Type == roomType);
            return findType;
        }
        public List<RoomType> AllTypes()
        {
           return context.RoomTypes.ToList();
           
        }
    }
}
