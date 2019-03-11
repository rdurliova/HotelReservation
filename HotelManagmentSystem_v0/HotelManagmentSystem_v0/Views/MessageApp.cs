using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentSystem_v0.Views
{
    public class MessageApp
    {
        public const string EnterCorrectValues = "Въведи коректни стойности!";
        public string MessageInsertCoutryTrue(string countryName)
        {
            string message = $"{countryName} е добавена успешно в таблцита с държави!";
            return message;
        }

        public string MessageInsertCoutryFalse(string countryName)
        {
            string message = $"{countryName} вече съществува в таблцита с държави!";
            return message;
        }

        public string MessageInsertTownTrue(string countryName, string townName)
        {
            string message = $"В държавата '{countryName}' е добавен нов град с име '{townName}'";
            return message;
        }

        public string MessageInsertTownFalse(string countryName,string townName)
        {
            string message = $"В '{countryName}' вече съществува град с име '{townName}'!";
            return message;
        }


        public string MessageInsertRoomTrue(string roomType)
        {
            string message = $"Добавена е нова стая от тип '{roomType}'";
            return message;
        }

        public string MessageInsertRoomFalse(string roomType)
        {
            string message = $"{roomType} - не съществува!";
            return message;
        }

    }
}
