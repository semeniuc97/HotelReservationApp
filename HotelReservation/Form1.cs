using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelReservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
            if (textBox1.Text == "Admin" && textBox2.Text=="admin" )
            {
                FormAdmin userForm = new FormAdmin();
                userForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You cannot login.The incorrect data");
            }
        }
    }
}
