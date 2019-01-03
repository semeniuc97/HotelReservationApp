using BusinessAccessLayer.Services;
using DataAccessLayer;
using Models;
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
        static string connectionString = ConfigurationManager.ConnectionStrings["HotelReservationEF"].ConnectionString;
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

                var roomsBookings = new List<Booking>();
                var roomsRating = new List<RoomBookings>();
                using (var context = ContextResolver.GetContext(connectionString))
                {
                    BookingService bookingService = new BookingService(context);
                    roomsBookings = bookingService.GetRoomReservationsByDatesRange(dateTimePickerStartDate.Value, dateTimePickerEndDate.Value);
                    RoomsRatingService roomsRatingService = new RoomsRatingService();
                    roomsRating = roomsRatingService.GetRoomBookingsRating(roomsBookings);
                }
                
                foreach (var item in roomsRating)
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
