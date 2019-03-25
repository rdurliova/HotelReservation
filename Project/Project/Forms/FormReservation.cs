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
    public partial class FormReservation : Form
    {
        public static HotelReservationContext context = new HotelReservationContext();
        ReadControler read = new ReadControler(context);
        InsertControler insert = new InsertControler();
        public FormReservation()
        {
            InitializeComponent();
            LoadFreeRooms();
            ResetLabel("-");

        }

        private void LoadFreeRooms()
        {
            var freeRooms = read.FreeRooms();
            foreach (var r in freeRooms)
            {
                comboBox1.Items.Add(r.RoomNumebr);

            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = context.Clients.FirstOrDefault(c => c.EGN == textBox1.Text);
            if (client != null && comboBox2.Text != string.Empty)
            {
                bool isAdd = insert.InsertIntoReservation(textBox1.Text, comboBox1.Text, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date, decimal.Parse(comboBox2.Text), textBox3.Text);
                if (isAdd)
                {
                    context.Rooms.FirstOrDefault(r => r.RoomNumebr == comboBox1.Text).isFree = false;
                    context.SaveChanges();
                    comboBox1.Items.Clear();
                    LoadFreeRooms();
                    MessageBox.Show("Добавен");
                }
                else
                {
                    MessageBox.Show("Не");
                }

            }
            else
            {
                AddClients settingsForm = new AddClients();
                settingsForm.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var client = context.Clients.FirstOrDefault(c => c.EGN == textBox1.Text);
            if (client != null)
            {
                labelName.Text = string.Format($"{client.FirstName} {client.LastName}");
                labelTown.Text = client.Town.Name;
                labelCountry.Text = client.Town.Country.Name;
                labelAge.Text = client.Age.ToString();
                labelGsm.Text = client.Gsm;
                labelEmail.Text = client.Email;
            }
            else
            {
                ResetLabel("-");
            }


        }

        private void ResetLabel( string text)
        {
        
            labelName.Text = text;
            labelTown.Text = text;
            labelCountry.Text = text;
            labelAge.Text = text;
            labelGsm.Text = text;
            labelEmail.Text = text;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
