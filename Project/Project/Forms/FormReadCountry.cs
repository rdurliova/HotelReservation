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
    public partial class FormReadCountry : Form
    {
        private  HotelReservationContext context ;
        private  ReadControler read ;
        int count = 0;
        List<Country> countries;
        public FormReadCountry(HotelReservationContext context, ReadControler read)
        {
            InitializeComponent();
            this.context = context;
            this.read = read;
            countries = read.CounrtiesList();
        }

        private void FormReadCountry_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            textBox1.Enabled = false;
            label3.Text = countries.First().Id.ToString();
            label4.Text = countries.First().Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count--;
            if (count<0)
            {
                count = countries.Count-1;
            }
            label3.Text = countries[count].Id.ToString();
            label4.Text = countries[count].Name;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            if (count >= countries.Count)
            {
                count = 0;
            }
            label3.Text = countries[count].Id.ToString();
            label4.Text = countries[count].Name;
            
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
            Country findCountry = read.FindCountry(textBox1.Text);
            if (findCountry!=null)
            {
                count = 0;
                label3.Text = findCountry.Id.ToString();
                label4.Text =findCountry.Name;
            }
            else
            {
                count = 0;
                MessageBox.Show(MessageApp.ObjectNotFound);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
