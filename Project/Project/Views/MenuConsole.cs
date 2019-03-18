using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Views
{
    public class MenuConsole
    {
        public string MenuInsert()
        {
            Console.WriteLine("1 - Добави държава");
            Console.WriteLine("2 - Добави град");
            Console.WriteLine("3 - Добави стая");
            Console.WriteLine("4 - Добави клиент");
            Console.WriteLine("5 - Резервация");
            Console.Write("Избери команда: ");
            return Console.ReadLine();
        }
        public string MenuRead()
        {
            Console.WriteLine("1 - Списък с държави");
            Console.WriteLine("2 - ");
            Console.WriteLine("3 - ");
            Console.Write("Избери команда: ");
            return Console.ReadLine();
        }
        
    }
}
