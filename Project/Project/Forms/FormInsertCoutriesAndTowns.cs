using Project;
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

namespace ProjectHotelsReservation.Forms
{
    public partial class FormInsertCoutriesAndTowns : Form
    {
        public FormInsertCoutriesAndTowns()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HotelReservationContext context = new HotelReservationContext();
            InsertControler controler = new InsertControler();
            MessageApp message = new MessageApp();

            if (radioButton1.Checked)
            {
                if (textBox1.Text != string.Empty)
                {
                    bool isAdd = controler.InsertIntoCoutries(textBox1.Text);
                    if (isAdd)
                    {
                        MessageBox.Show(message.MessageInsertCoutryTrue(textBox1.Text));
                    }
                    else
                    {
                        MessageBox.Show(message.MessageInsertCoutryFalse(textBox1.Text));
                    }
                }
                else
                {
                    MessageBox.Show(MessageApp.EnterCorrectValues);
                }
                Clear();
            }
            else if (radioButton2.Checked)
            {
                if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
                {
                    bool isAdd = controler.InsertIntoTowns(textBox2.Text, textBox1.Text);
                    if (isAdd)
                    {
                        MessageBox.Show(message.MessageInsertTownTrue(textBox1.Text, textBox2.Text));
                    }
                    else
                    {
                        MessageBox.Show(message.MessageInsertTownFalse(textBox1.Text, textBox2.Text));
                    }
                }
                else
                {
                    MessageBox.Show(MessageApp.EnterCorrectValues);
                }
                Clear();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            Clear();
        }
        private void Clear()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }
    }
}
