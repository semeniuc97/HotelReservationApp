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
using Models;
using BusinessAccessLayer.Services;

namespace HotelReservation
{
    public partial class FormAdmin : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["HotelReservationEF"].ConnectionString;
        public FormAdmin()
        {
            InitializeComponent();
            listViewHotels.FullRowSelect = true;
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
            var hotels = new List<Hotel>();
            using (var context = ContextResolver.GetContext(connectionString))
            {
                HotelService hotelService = new HotelService(context);
                hotels = hotelService.GetAll();
            }
            
            foreach(var hotel in hotels)
            {
                ListViewItem listViewItem = new ListViewItem(hotel.Id.ToString());
                listViewItem.SubItems.Add(hotel.HotelName);
                listViewItem.SubItems.Add(hotel.FoundationYear.ToShortDateString());
                listViewItem.SubItems.Add(hotel.Adress);
                listViewItem.SubItems.Add(hotel.IsActive.ToString());
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
            FormManageHotels manageHotelsForm = new FormManageHotels();
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
                MessageBox.Show("Select the Hotel!");
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetAllHotels();
        }

        private void buttonRoomsRatings_Click(object sender, EventArgs e)
        {
            FormHotelRating formHotelRating = new FormHotelRating();
            this.Close();
            formHotelRating.Show();
        }
    }
}
