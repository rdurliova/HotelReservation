
using Project.Forms;
using Project.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            MainMenu();
        }

        public void MainMenu()
        {
            while (true)
            {
                try
                {
                    switch (menu.MainMenu())
                    {

                        case "1":
                            Add();
                            break;
                        case "2":
                            Read();
                            break;
                        case "3":
                            Application.EnableVisualStyles();
                            Application.Run(new FormSystemOfHotelsReservation(context, insert, read, message));
                            break;

                        default: return;
                            //  break;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
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
                    case "5":
                        InsertIntoReservation();
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
               inOut.PrintMessage( message.MessageInsertRoomFalse(type));
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
                inOut.PrintMessage(MessageApp.EnterCorrectValues);
            }
        }
        public void InsertIntoReservation()
        {
            string egnClient = inOut.ReadEgnClient();
            string roomNumber = inOut.ReadRoomNumber();
            DateTime startDate = inOut.ReadStartDate();
            DateTime finishDate = inOut.ReadEndDate();
            decimal pay = inOut.ReadPayment();
            string payType = inOut.ReadPaymentType();

            bool isAdd = insert.InsertIntoReservation(egnClient, roomNumber, startDate, finishDate, pay, payType);
            if (isAdd)
            {
                inOut.PrintMessage(message.MessageInsertReservationTrue());

                    
            }
            else
            {
                inOut.PrintMessage(message.MessageInsertReservationFalse());
            }

        }



    }
}
