using BusinessAccessLayer.Services;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class FormHotelRating : Form
    {
        BookingRepository bookingRepository = new BookingRepository(connectionString);
        static string connectionString = ConfigurationManager.ConnectionStrings["HotelReservationConStr"].ConnectionString;
        public FormHotelRating()
        {
            InitializeComponent();
            listViewHotelsRating.FullRowSelect = true;
        }

        private void FormHotelRating_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
        }


        private void buttonShowRating_Click(object sender, EventArgs e)
        {
            if (ValidationService.ValidateRatingBookingDates(dateTimePickerStartDate.Value, dateTimePickerEndDate.Value))
            {

                var roomBookings = bookingRepository.GetRoomBookingsByDatesRange(dateTimePickerStartDate.Value, dateTimePickerEndDate.Value);
                foreach (var item in roomBookings)
                {
                    ListViewItem viewItem = new ListViewItem(item.CountBookings.ToString());
                    viewItem.SubItems.Add(item.RoomNumber.ToString());
                    viewItem.SubItems.Add(item.HotelName);
                    listViewHotelsRating.Items.Add(viewItem);
                }
            }
        }
    }
}
