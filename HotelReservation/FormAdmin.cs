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
using DataAccessLayer;
using System.Configuration;

namespace HotelReservation
{
    public partial class FormAdmin : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["HotelReservationConStr"].ConnectionString;
        HotelRepository hotelRepository = new HotelRepository(connectionString);
        public FormAdmin()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void Form2_Shown(object sender, EventArgs e)
        {
            GetAllHotels();
        }

        private void GetAllHotels()
        {
                listViewHotels.Items.Clear();
            var HotelsList = hotelRepository.GetHotels();
            foreach(var hotel in HotelsList)
            {
                ListViewItem listViewItem = new ListViewItem(hotel.HotelId);
                listViewItem.SubItems.Add(hotel.HotelName);
                listViewItem.SubItems.Add(hotel.FoundationYear.ToShortDateString());
                listViewItem.SubItems.Add(hotel.Adress);
                listViewItem.SubItems.Add(hotel.IsActive);
                listViewHotels.Items.Add(listViewItem);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void listViewHotels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHotels.SelectedItems.Count == 0)
                return;

            ListViewItem item = listViewHotels.SelectedItems[0];
            textBoxInputHotelId.Text = item.Text;

        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            ManageHotelsForm manageHotelsForm = new ManageHotelsForm();
            manageHotelsForm.Show();
        }

        private void buttonCheckHotelById_Click(object sender, EventArgs e)
        {
            if (textBoxInputHotelId.Text != "")
            {
                FormHotelRooms formHotelRooms = new FormHotelRooms();
                formHotelRooms.HotelId = Convert.ToInt32(textBoxInputHotelId.Text);
                formHotelRooms.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Input the Id!");
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetAllHotels();
        }
    }
}
