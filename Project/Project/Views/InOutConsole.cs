﻿using System;
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
        public string ReadFirstName()
        {
            Console.Write("Въведи име: ");
            return Console.ReadLine();
        }
        public string ReadLastName()
        {
            Console.Write("Въведи фамилия: ");
            return Console.ReadLine();
        }
        public string ReadEGN()
        {
            Console.Write("Въведи ЕГН: ");
            return Console.ReadLine();
        }
        public int ReadAge()
        {
            Console.Write("Въведи възраст: ");
            return int.Parse(Console.ReadLine());
        }
        public string ReadGsm()
        {
            Console.Write("Въведи тел.номер: ");
            return Console.ReadLine();
        }
        public string ReadEmail()
        {
            Console.Write("Въведи имейл адрес: ");
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
        public string ReadIdClient()
        {
            Console.Write("Въведи номер на клиент: ");
            return Console.ReadLine();
        }
        public string ReadIdRoom()
        {
            Console.Write("Въведи тип на стая: ");
            return Console.ReadLine();

        }
        public string ReadStartDate()
        {
            Console.Write("Въведи начална дата: ");
            return Console.ReadLine();
        }
        public string ReadFinishDate()
        {
            Console.Write("въведи крайна дата: ");
            return Console.ReadLine();

        }
        public string ReadPayment()
        {
            Console.Write("Въведи сума: ")
                return Console.ReadLine(); 
      
        }
        public string ReadPaymentType()
        {
            Console.Write("Въведи начин на плащане: ");
            return Console.ReadLine();

        }
    
  

    }
}
