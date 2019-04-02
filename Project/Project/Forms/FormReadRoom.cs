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
    public partial class FormReadRoom : Form
    {
        private HotelReservationContext context;
        private ReadControler read;
        int count = 0;
        List<Room> rooms;
        public FormReadRoom(HotelReservationContext context,ReadControler read)
        {
            InitializeComponent();
            this.context = context;
            this.read = read;
            this.rooms = read.RoomsList();

        }

        private void FormReadRoom_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count--;
            if (count < 0)
            {
                count = rooms.Count - 1;
            }
            labelNumber.Text = rooms[count].RoomNumebr;
            labelType.Text = rooms[count].RoomType.Type;
            labelPrice.Text = rooms[count].RoomType.Price.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            if (count >= rooms.Count)
            {
                count = 0;
            }
            labelNumber.Text = rooms[count].RoomNumebr;
            labelType.Text = rooms[count].RoomType.Type;
            labelPrice.Text = rooms[count].RoomType.Price.ToString();
        }
    }
}
