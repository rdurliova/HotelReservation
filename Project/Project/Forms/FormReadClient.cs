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
    public partial class FormReadClient : Form
    {
        private static HotelReservationContext context = new HotelReservationContext();
        List<Client> clients = context.Clients.OrderBy(c => c.FirstName).ThenBy(c => c.LastName).ToList();
        public FormReadClient()
        {
            InitializeComponent();
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

        }
    }
}
