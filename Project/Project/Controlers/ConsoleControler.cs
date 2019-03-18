
using Project.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controlers
{
    public class ConsoleControler
    {
        private static HotelReservationContext context = new HotelReservationContext();

        public static InsertControler insert = new InsertControler();
        public static InOutConsole inOut = new InOutConsole();
        public static MessageApp message = new MessageApp();
        public static MenuConsole menu = new MenuConsole();
        public static ReadControler read = new ReadControler(context);

        public ConsoleControler()
        {
            Read();
        }

        public void Add()
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
                    case "4":
                        InsertIntoClients();
                        break;
                    default: return;
                        //  break;
                }
            }
        }
        public void Read()
        {
            while (true)
            {
                switch (menu.MenuRead())
                {
                    case "1":
                        ReadCountry();
                        break;
                    case "2":
                        InsertIntoTowns();
                        return;
                        break;
                    case "3":
                        return;
                        break;
                    default: return;
                        //  break;
                }
            }
        }

        private void ReadCountry()
        {
            inOut.PrintCountryInfo(read.CounrtiesList());
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
            string number = inOut.ReadRoomNumber();
            bool isAdd = insert.InsertIntoRooms(type,number);
            if (isAdd==true)
            {
               inOut.PrintMessage(message.MessageInsertRoomTrue(type));
            }
            else
            {
                message.MessageInsertRoomFalse(type);
            }
        }
        public void InsertIntoClients()
        {
            string fName = inOut.ReadFirstName();
            string lName = inOut.ReadLastName();
            int age = inOut.ReadAge();
            string gsm = inOut.ReadGsm();
            string egn = inOut.ReadEGN();
            string email = inOut.ReadEmail();
            string townName = inOut.ReadTownName();
            string countryName = inOut.ReadCoutryName();
            bool isAdd = insert.InsertIntoClients(fName,lName, egn,age,townName,countryName,gsm,email);
            if (isAdd == true)
            {
                inOut.PrintMessage(MessageApp.ClientIsAdd);
            }
            else
            {
                message.MessageInsertRoomFalse(MessageApp.EnterCorrectValues);
            }
        }
    }
}
