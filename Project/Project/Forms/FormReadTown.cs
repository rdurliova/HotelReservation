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
    public partial class FormReadTown : Form
    {
        private HotelReservationContext context;
        private ReadControler read;
        private int count = 0;
        private List<Town> towns;
        private List<Country> countries;

        public FormReadTown(HotelReservationContext context, ReadControler read)
        {
            InitializeComponent();
            this.context = context;
            this.read = read;
            towns = read.TownsList();
            countries = read.CounrtiesList();
        }

        private void FormReadTown_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            textBox1.Enabled = false;
            label3.Text = towns.First().Id.ToString();
            label4.Text = towns.First().Name;
            label8.Text = towns[count].Country.Name;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            count--;
            if (count < 0)
            {
                count = towns.Count - 1;
            }
            label3.Text = towns[count].Id.ToString();
            label4.Text = towns[count].Name;
            label8.Text = towns[count].Country.Name;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            if (count >= towns.Count)
            {
                count = 0;
            }
            label3.Text = towns[count].Id.ToString();
            label4.Text = towns[count].Name;
            label8.Text = towns[count].Country.Name;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button3.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
                textBox1.Enabled = true;
            }
            else
            {
                count = 0;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
                textBox1.Enabled = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Town findTown = read.FindTown(textBox1.Text, textBox2.Text);
            if (findTown != null)
            {
                count = 0;
                label3.Text = findTown.Id.ToString();
                label4.Text = findTown.Name;
            }
            else
            {
                count = 0;
                MessageBox.Show(MessageApp.ObjectNotFound);
            }
        }


    }
}
