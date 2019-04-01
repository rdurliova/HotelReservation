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
    public partial class FormSystemOfHotelsReservation : Form
    {
        private HotelReservationContext context;
        private InsertControler insert;
        private ReadControler read;
        private MessageApp message;

        public FormSystemOfHotelsReservation(HotelReservationContext context, InsertControler insert,ReadControler read, MessageApp message)
        {
            InitializeComponent();
            this.context = context;
            this.insert = insert;
            this.read = read;
            this.message = message;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddClients form = new AddClients(context);
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBoxSpravki.Text = button4.Text;
            var clients = context.Clients.OrderBy(c => c.FirstName).ThenBy(c => c.LastName).ToList();
            foreach (var c in clients)
            {
                string fullName = string.Format($"{c.FirstName} {c.LastName}");
                listBox1.Items.Add(fullName);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReservation form = new FormReservation(context,read,insert);
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBoxSpravki.Text = button8.Text;
            var clients = context.Clients.Where(c => c.Town.Country.Name == "Bulgaria").OrderBy(c => c.FirstName).ThenBy(c => c.LastName).ToList();
            foreach (var c in clients)
            {
                string fullName = string.Format($"{c.FirstName} {c.LastName}");
                listBox1.Items.Add(fullName);
            }
        }

        private void buttonAddCountryAndTown_Click(object sender, EventArgs e)
        {
            FormInsertCoutriesAndTowns form = new FormInsertCoutriesAndTowns(context, insert, message);
            form.Show();
        }

        private void FormSystemOfHotelsReservation_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormAddRoom form = new FormAddRoom(context,read);
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormReadClient form = new FormReadClient(context);
            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormClearRoom form = new FormClearRoom(context);
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBoxSpravki.Text = button9.Text;
            var rooms = context.Rooms.Where(r => r.isFree == true).ToList();
            foreach (var r in rooms)
            {
                string room = string.Format($"{r.RoomNumebr} - {r.RoomType.Type}");
                listBox1.Items.Add(room);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
