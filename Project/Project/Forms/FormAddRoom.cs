using Project.Controlers;
using Project.Views;
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
    public partial class FormAddRoom : Form
    {
        HotelReservationContext context = new HotelReservationContext();
        Find find = new Find();
        public FormAddRoom()
        {
            InitializeComponent();
            List<RoomType> listTypes = find.AllTypes();
            foreach (var t in listTypes)
            {
                comboBox1.Items.Add(t.Type);
            }
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void FormAddRoom_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertControler insert = new InsertControler();
            MessageApp message = new MessageApp();
            if (textBox1.Text.Length==3)
            
            {
                bool isAdd = insert.InsertIntoRooms(comboBox1.Text, textBox1.Text);
                if (isAdd)
                {
                    MessageBox.Show(message.MessageInsertRoomTrue(comboBox1.Text));

                }
                else
                {
                    MessageBox.Show(MessageApp.EnterCorrectValues);
                }
                
            }
            else
            {

                MessageBox.Show(MessageApp.EnterCorrectValues);
            }
            
        }
    }
}
