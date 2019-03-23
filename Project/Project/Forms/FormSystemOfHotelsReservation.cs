﻿using System;
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
            AddClients form = new AddClients();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBoxSpravki.Text = button4.Text;
            var clients = context.Clients.OrderBy(c=>c.FirstName).ThenBy(c=>c.LastName).ToList();
            foreach (var c in clients)
            {
                string fullName = string.Format($"{c.FirstName} {c.LastName}");
                listBox1.Items.Add(fullName);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReservation form = new FormReservation();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBoxSpravki.Text = button8.Text;
            var clients = context.Clients.Where(c=>c.Town.Country.Name=="Bulgaria").OrderBy(c => c.FirstName).ThenBy(c => c.LastName).ToList();
            foreach (var c in clients)
            {
                string fullName = string.Format($"{c.FirstName} {c.LastName}");
                listBox1.Items.Add(fullName);
            }
        }

        private void buttonAddCountryAndTown_Click(object sender, EventArgs e)
        {
            FormInsertCoutriesAndTowns form = new FormInsertCoutriesAndTowns();
            form.Show();
        }

        private void FormSystemOfHotelsReservation_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
