﻿namespace Project.Forms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class FormReadClient : Form
    {
        private HotelReservationContext context;
        private List<Client> clients;
        public FormReadClient(HotelReservationContext context)
        {
            InitializeComponent();
            this.context = context;
            clients = context.Clients.OrderBy(c => c.FirstName).ThenBy(c => c.LastName).ToList();
        }

        private void FormReadClient_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var c in clients)
            {
                string fullName = string.Format($"{c.FirstName} {c.LastName}");
                listBox1.Items.Add(fullName);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            labelName.Text = clients[index].FirstName + " " + clients[index].LastName;
            labelEgn.Text = clients[index].EGN;
            labelTown.Text = clients[index].Town.Name;
            labelCountry.Text = clients[index].Town.Country.Name;
            labelAge.Text = clients[index].Age.ToString();
            labelGsm.Text = clients[index].Gsm;
            labelEmail.Text = clients[index].Email;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client client = clients.FirstOrDefault(c => c.EGN == textBox1.Text);
            if (client != null)
            {
                labelName.Text = client.FirstName + " " + client.LastName;
                labelEgn.Text = client.EGN;
                labelTown.Text = client.Town.Name;
                labelCountry.Text = client.Town.Country.Name;
                labelAge.Text = client.Age.ToString();
                labelGsm.Text = client.Gsm;
                labelEmail.Text = client.Email;
            }
            else
            {
                MessageBox.Show("Клиент с търсеното ЕГН не съществува!");

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
