using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentSystem_v0.Views
{
    public class InOutConsole
    {
        public string ReadCoutryName()
        {
            Console.Write("Въведи име на държава: ");
            return Console.ReadLine();
        }
        public string ReadTownName()
        {
            Console.Write("Въведи име на град: ");
            return Console.ReadLine();
        }

        public string ReadRoomType()
        {
            Console.Write("Въведи тип на стая: ");
            return Console.ReadLine();
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
