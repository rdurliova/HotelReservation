using ProjectHotelsReservation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotelsReservation.Controlers
{
    public class ConsoleControler
    {
        public static InsertControler insert = new InsertControler();
        public static InOutConsole inOut = new InOutConsole();
        public static MessageApp message = new MessageApp();
        public static MenuConsole menu = new MenuConsole();

        public ConsoleControler()
        {
            Start();
        }

        public void Start()
        {
            while (true)
            {
                switch (menu.MenuInsert())
                {
                    case "1":
                        InsertIntoCoutries();
                        break;
                    case "2":
                        InsertIntoTowns();
                        break;
                    case "3":
                        InsertIntoRooms();
                        break;
                    default: return;
                        //  break;
                }
            }
        }

        public void InsertIntoCoutries()
        {
            string coutryName = inOut.ReadCoutryName();
            bool isAdd = insert.InsertIntoCoutries(coutryName);
            if (isAdd == true)
            {
                inOut.PrintMessage(message.MessageInsertCoutryTrue(coutryName));
            }
            else
            {
                inOut.PrintMessage(message.MessageInsertCoutryFalse(coutryName));
            }
        }

        public void InsertIntoTowns()
        {
            string countryName = inOut.ReadCoutryName();
            string townName = inOut.ReadTownName();
            bool isAdd=insert.InsertIntoTowns(townName, countryName);

            if (isAdd==true)
            {
                inOut.PrintMessage(message.MessageInsertTownTrue(countryName, townName));
            }
            else
            {
                inOut.PrintMessage(message.MessageInsertTownFalse(countryName, townName));
            }
        }

        public void InsertIntoRooms()
        {
            string type = inOut.ReadRoomType();
            bool isAdd = insert.InsertIntoRooms(type);
            if (isAdd==true)
            {
               inOut.PrintMessage(message.MessageInsertRoomTrue(type));
            }
            else
            {
                message.MessageInsertRoomFalse(type);
            }
        }
    }
}
