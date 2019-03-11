using HotelManagmentSystem_v0.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagmentSystem_v0
{
    class Startup
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new FormAddNewRoom());
        }
    }
}
