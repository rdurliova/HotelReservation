﻿using System;
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
        public List<Room> RoomsList()
        {
            List<Room> returnRooms = context.Rooms.ToList();
            return returnRooms;
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
        public Client GetClientByEGN(string egn)
        {
            return context.Clients.FirstOrDefault(c => c.EGN == egn);
        }
        public Room GetRoomByNumber(string roomNumber)
        {
            return context.Rooms.FirstOrDefault(r => r.RoomNumebr == roomNumber);
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


     
       
   


