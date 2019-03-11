using HotelManagmentSystem_v0.Controlers;
using HotelManagmentSystem_v0.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagmentSystem_v0.Forms
{
    public partial class FormAddNewRoom : Form
    {
        HotelsReservationContext context = new HotelsReservationContext();
        Find find = new Find();
        public FormAddNewRoom()
        {
            InitializeComponent();
            List<Type> listTypes = find.AllTypes();
            foreach (var t in listTypes)
            {
                comboBox1.Items.Add(t.Type1);
            }
            comboBox1.Text = comboBox1.Items[0].ToString();

        }

        private void FormAddNewRoom_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertControler insert = new InsertControler();
            MessageApp message = new MessageApp();
            bool isAdd = insert.InsertIntoRooms(comboBox1.Text);
            if (isAdd)
            {
                MessageBox.Show(message.MessageInsertRoomTrue(comboBox1.Text));

            }
            else
            {
                MessageBox.Show(MessageApp.EnterCorrectValues);
            }
 
        }
    }
}
