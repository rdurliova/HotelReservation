using HotelManagmentSystem_v0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentSystem_v0.Controlers
{
    public class Find
    {
        private static HotelsReservationContext context = new HotelsReservationContext();

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

        public Type FindType(string roomType)
        {
            Type findType = context.Types
                .FirstOrDefault(t => t.Type1 == roomType);
            return findType;
        }
        public List<Type> AllTypes()
        {
           return context.Types.ToList();
           
        }
    }
}
