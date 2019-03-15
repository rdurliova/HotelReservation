using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Views
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
        public string ReadRoomNumber()
        {
            Console.Write("Въведи номер на стая: ");
            return Console.ReadLine();
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintCountryInfo(List<Country> countries)
        {
            Console.WriteLine($"{"ID",-5}{"Country name,-15"}");
            foreach (var c in countries)
            {
                Console.WriteLine($"{c.Id,-4} {c.Name,-15}");
            }
        }
    }
}
