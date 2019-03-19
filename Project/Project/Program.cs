using Project.Controlers;
using Project.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new AddClients());

          //ConsoleControler controler = new ConsoleControler();
        }
    }
}
