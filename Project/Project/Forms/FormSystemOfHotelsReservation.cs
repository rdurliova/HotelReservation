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
        HotelReservationContext context = new HotelReservationContext();

        public FormSystemOfHotelsReservation()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddClients settingsForm = new AddClients();
            settingsForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var clients = context.Clients.OrderBy(c=>c.FirstName).ThenBy(c=>c.LastName).ToList();
            foreach (var c in clients)
            {
                string fullName = string.Format($"{c.FirstName} {c.LastName}");
                listBox1.Items.Add(fullName);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReservation settingsForm = new FormReservation();
            settingsForm.Show();
        }
    }
}
