using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class FormManageRooms : Form
    {
        string connectionString;
        private int hotelId;

        public int HotelId
        {
            set
            {
                hotelId = value;
            }
        }

        public FormManageRooms()
        {
            InitializeComponent();
        }

        public FormManageRooms(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormManageRooms_Shown(object sender, EventArgs e)
        {
            radioButtonAdd.Checked = true;

        }

        private void radioButtonDelete_CheckedChanged(object sender, EventArgs e)
        {
            labelNumber.Visible = false;
            textBoxNumber.Visible = false;
            labelPrice.Visible = false;
            textBoxPrice.Visible = false;
            labelComfortLvl.Visible = false;
            comboBoxComfortLvl.Visible = false;
            labelCapability.Text = "Delete by Id";
            buttonFind.Visible = false;
            buttonUpdate.Visible = false;
            buttonDelete.Visible = true;
            buttonAdd.Visible = false;
            textBoxPrice.Text = "";
        }

        private void radioButtonUpdate_CheckedChanged(object sender, EventArgs e)
        {
            labelNumber.Visible = true;
            textBoxNumber.Visible = true;
            labelPrice.Visible = true;
            textBoxPrice.Visible = true;
            labelComfortLvl.Visible = true;
            comboBoxComfortLvl.Visible = true;
            buttonFind.Visible = true;
            buttonUpdate.Visible = true;
            buttonDelete.Visible = false;
            buttonAdd.Visible = false;
            labelCapability.Text = "Capability";
            textBoxPrice.ReadOnly = true;
            textBoxCapability.ReadOnly = true;
            comboBoxComfortLvl.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonFind.Enabled = false;
        }

        private void radioButtonAdd_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPrice.ReadOnly = false;
            textBoxCapability.ReadOnly = false;
            comboBoxComfortLvl.Enabled = true;
            buttonUpdate.Enabled = true;
            labelNumber.Visible = true;
            textBoxNumber.Visible = true;
            labelPrice.Visible = true;
            textBoxPrice.Visible = true;
            labelComfortLvl.Visible = true;
            comboBoxComfortLvl.Visible = true;
            buttonFind.Visible = false;
            buttonUpdate.Visible = false;
            buttonDelete.Visible = false;
            buttonAdd.Visible = true;
            buttonAdd.Location = new Point(130, 164);
            labelCapability.Text = "Capability";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("Insert into Rooms(Number,Price,Capability,ComfortLevel,HotelId" +
                        ") Values('"+ textBoxNumber.Text + "','" + textBoxPrice.Text + "'," +
                       "'" + textBoxCapability.Text + "','" + comboBoxComfortLvl.SelectedItem.ToString() + "','" + hotelId.ToString() + "');", sqlConnection);
                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("New record has added");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormManageRooms_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("Delete From Rooms Where RoomId=" + textBoxCapability.Text, sqlConnection);
                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("The record has been deleted!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("Update Rooms Set Number='" + textBoxNumber.Text + "',Price='" + textBoxPrice.Text +
                        "',Capability='" + textBoxCapability.Text +"',ComfortLevel='"+ comboBoxComfortLvl.Text+"' where Number=" + textBoxNumber.Text + ";", sqlConnection);
                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("The record has been updated!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            buttonFind.Enabled = true;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            textBoxPrice.ReadOnly = false;
            textBoxCapability.ReadOnly = false;
            comboBoxComfortLvl.Enabled = true;
            buttonUpdate.Enabled = true;
            

            int num;
            bool isNumeric = int.TryParse(textBoxNumber.Text, out num);
            if (textBoxNumber.Text != "" && isNumeric)
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("Select * from Rooms Where Number=" + textBoxNumber.Text + ";", sqlConnection);
                    sqlConnection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        textBoxPrice.Text = reader["Price"].ToString();
                        textBoxCapability.Text = reader["Capability"].ToString();
                        comboBoxComfortLvl.Text = reader["ComfortLevel"].ToString();
                    }
                    reader.Close();
                    sqlConnection.Close();
                }
            }
            else
                MessageBox.Show("Input the id!");
        }

        private void FormManageRooms_Load(object sender, EventArgs e)
        {
            this.comboBoxComfortLvl.DropDownStyle = ComboBoxStyle.DropDownList;

        }
    }
}
