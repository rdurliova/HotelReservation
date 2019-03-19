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
    public partial class AddClients : Form
    {
       private static HotelReservationContext context = new HotelReservationContext();
        InsertControler insert = new InsertControler();
        ReadControler read = new ReadControler(context);
        MessageApp message = new MessageApp();
        public AddClients()
        {
            InitializeComponent();
            List<Town> towns = read.TownsList();
            List<Country> countries = read.CounrtiesList();
            foreach (var t in towns)
            {
                comboBox1.Items.Add(t.Name);
            }
            foreach (var c in countries)
            {
                comboBox2.Items.Add(c.Name);
            }
            for (int i = 16; i < 120; i++)
            {
                comboBox3.Items.Add(i);
            }
        }


        private void AddClients_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool isAdd = insert.InsertIntoClients(textBox1.Text,textBox2.Text,textBox3.Text,int.Parse(comboBox3.Text),comboBox1.Text,comboBox2.Text,textBox4.Text,textBox5.Text);
            if (isAdd)
            {
                MessageBox.Show(message.MessageInsertClientsTrue());
            }
            else
            {
                MessageBox.Show(MessageApp.EnterCorrectValues);
            }
        }
    }
}
