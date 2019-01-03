using BusinessAccessLayer.Services;
using DataAccessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        static string connectionString = ConfigurationManager.ConnectionStrings["HotelReservationEF"].ConnectionString;
        BookingService bookingService = new BookingService();
        BookedDatesService bookedDatesService = new BookedDatesService(); 
        int roomId;
        public FormAddReservation()
        {
            InitializeComponent();
            listViewUsers.FullRowSelect = true;
        }
        public int RoomId
        {
            set
            {
                roomId = value;
            }
        }

        private void FormAddReservation_Shown(object sender, EventArgs e)
        {
            var bookings = new List<Booking>();
            using (var context = ContextResolver.GetContext(connectionString))
            {
                BookingService bookingService = new BookingService(context);
                bookings = bookingService.GetAllByRoomId(roomId);
            }
            monthCalendarBookedDays.BoldedDates = bookedDatesService.GetAllBookedDays(bookings).ToArray();
            listViewUsers.Items.Clear();
            var allUsers = new List<User>();
            using (var context = ContextResolver.GetContext(connectionString))
            {
                UserService userService = new UserService(context);
                allUsers = userService.GetAll();
            }
            foreach (var user in allUsers)
            {
                ListViewItem listViewUserRecord = new ListViewItem(user.Id.ToString());
                listViewUserRecord.SubItems.Add(user.UserName);
                listViewUsers.Items.Add(listViewUserRecord);
            }
        }



        private void buttonAddReservation_Click(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count != 0)
            {
                if (ValidationService.ValidateBookingDates(dateTimePickerStart.Value, dateTimePickerEnd.Value))
                {
                    var bookedDates = new List<DateTime>();
                    using (var context = ContextResolver.GetContext(connectionString))
                    {
                        BookingService bookingService = new BookingService(context);
                        bookedDates = bookedDatesService.GetAllBookedDays(bookingService.GetAllByRoomId(roomId));
                    }

                    if (bookedDatesService.CheckIsBookedDates(dateTimePickerStart.Value, dateTimePickerEnd.Value,bookedDates))
                    {

                        ListViewItem item = listViewUsers.SelectedItems[0];
                        Booking booking = new Booking()
                        {
                            StartDate = dateTimePickerStart.Value,
                            EndDate = dateTimePickerEnd.Value,
                            UserId = Convert.ToInt32(item.Text),
                            RoomId = roomId
                        };
                        using (var context = ContextResolver.GetContext(connectionString))
                        {
                            BookingService bookingService = new BookingService(context);
                            bookingService.Add(booking);
                        }
                        MessageBox.Show("New record has added");
                        this.Close();
                    }
                    else
                        labelErrorBookedRoom.Visible = true;
            }
            else
                labelDatesValidation.Visible = true;
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewUsers.SelectedItems[0];
                using (var context = ContextResolver.GetContext(connectionString))
                {
                    BookingService bookingService = new BookingService(context);
                    bookingService.Delete(Convert.ToInt32(item.Text));
                }
                MessageBox.Show("The reservation has been canceled");
                this.Close();
            }
            else
            {
                labelError.Visible = true;
            }

        }

        private void monthCalendarBookedDays_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (radioButtonStartDate.Checked == true)
            {
                dateTimePickerStart.Value = monthCalendarBookedDays.SelectionStart;
            }
            else
            {
                if (radioButtonEndDate.Checked == true)
                    dateTimePickerEnd.Value = monthCalendarBookedDays.SelectionStart;
            }
        }

        private void labelStartDate_Click(object sender, EventArgs e)
        {
            radioButtonStartDate.Checked = true;
        }

        private void labelEndDate_Click(object sender, EventArgs e)
        {
            radioButtonEndDate.Checked = true;
        }
    }
}
