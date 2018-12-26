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
    public partial class FormAddReservation : Form
    {
        string connectionString;
        string roomId;
        public FormAddReservation()
        {
            InitializeComponent();
        }
        public FormAddReservation(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }
        public string RoomId
        {
            set
            {
                roomId = value;
            }
        }

        private void FormAddReservation_Shown(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                listViewUsers.Items.Clear();
                SqlCommand command = new SqlCommand("Select * from Users; ", sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem listViewUserRecord = new ListViewItem(reader["UserId"].ToString());
                    listViewUserRecord.SubItems.Add(reader["UserName"].ToString());
                    listViewUsers.Items.Add(listViewUserRecord);
                }
                reader.Close();
                sqlConnection.Close();
            }
        }



        private void buttonAddReservation_Click(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewUsers.SelectedItems[0];
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlCommand command = new SqlCommand("Insert Into Bookings Values('" + dateTimePickerStart.Value.ToString("u") + "','" +
                            dateTimePickerEnd.Value.ToString("u") + "','" + item.Text + "','" + roomId + "');", sqlConnection);
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
            else
            {
                labelError.Visible = true;
            }
        }

        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelError.Visible = false;

        }
    }
}
