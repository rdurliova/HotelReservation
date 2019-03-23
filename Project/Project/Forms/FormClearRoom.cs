using Project.Controlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class FormClearRoom : Form
    {
       private static HotelReservationContext context = new HotelReservationContext();
        ReadControler read = new ReadControler(context);
        public FormClearRoom()
        {
            InitializeComponent();
        }

        private void FormClearRoom_Load(object sender, EventArgs e)
        {
            var rooms = read.BusyRooms();
            if (rooms.Count==0)
            {
                listBox1.Items.Add("Няма заети стаи!");
                listBox1.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                foreach (var r in rooms)
                {
                    listBox1.Items.Add(r.RoomNumebr);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            context.Rooms.FirstOrDefault(r => r.RoomNumebr == listBox1.SelectedItem.ToString()).isFree=true;
            context.SaveChanges();
            var rooms = read.BusyRooms();
            listBox1.Items.Clear();

            if (rooms.Count == 0)
            {
                listBox1.Items.Add("Няма заети стаи!");
                listBox1.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                foreach (var r in rooms)
                {
                    listBox1.Items.Add(r.RoomNumebr);
                }
            }
        }
    }
}
