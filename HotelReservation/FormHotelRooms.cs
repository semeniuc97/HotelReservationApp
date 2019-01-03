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
    public partial class FormHotelRooms : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["HotelReservationEF"].ConnectionString;
        ListViewItem item = new ListViewItem();
        private int hotelId;

        public int HotelId
        {
            set
            {
                hotelId = value;
            }
        }

        public FormHotelRooms()
        {
            InitializeComponent();
            listViewHotelRooms.FullRowSelect = true;
            listViewRoomReservation.FullRowSelect = true;
        }



        private void FormHotelRooms_Shown(object sender, EventArgs e)
        {
            GetAllRooms();
        }

        private void listViewHotelRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHotelRooms.SelectedItems.Count == 0)
                return;
            listViewRoomReservation.Items.Clear();

            item = listViewHotelRooms.SelectedItems[0];
            label2.Text = $"Room`s {item.SubItems[1].Text} reservations";
            GetBookings();
        }

        private void buttonManageRooms_Click(object sender, EventArgs e)
        {
            FormManageRooms formManageRooms = new FormManageRooms();
            formManageRooms.HotelId = hotelId;
            formManageRooms.Show();
        }

        private void FormHotelRooms_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetAllRooms();
        }

        private void GetAllRooms()
        {
                listViewHotelRooms.Items.Clear();
            var hotelRooms = new List<Room>();
            using (var context = ContextResolver.GetContext(connectionString))
            {
                var roomService = new RoomService(context);
                hotelRooms = roomService.GetAllByHotelId(hotelId);
            }
            foreach (var room in hotelRooms)
            {
                ListViewItem listViewItem = new ListViewItem(room.Id.ToString());
                listViewItem.SubItems.Add(room.Number.ToString());
                listViewItem.SubItems.Add(room.Price.ToString());
                listViewItem.SubItems.Add(room.Capability.ToString());
                listViewItem.SubItems.Add(room.ComfortLevel.ToString());
                listViewHotelRooms.Items.Add(listViewItem);
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listViewHotelRooms.SelectedItems.Count != 0)
            {
            FormAddReservation formAddReservation = new FormAddReservation();
            formAddReservation.RoomId = Convert.ToInt32(item.Text);
            formAddReservation.Show();
            }
            else
            {
                MessageBox.Show("Choose the room!");
            }
        }

        private void GetBookings()
        {
            listViewRoomReservation.Items.Clear();
            if (listViewHotelRooms.SelectedItems.Count != 0)
            {
                int roomId = Convert.ToInt32(item.Text);
                var roomBookings = new List<Booking>();
                using (var context = ContextResolver.GetContext(connectionString))
                {
                    BookingService bookingService = new BookingService(context);
                    roomBookings = bookingService.GetAllByRoomId(roomId);
                }
                foreach(var booking in roomBookings)
                {
                    ListViewItem listViewItem = new ListViewItem(booking.Id.ToString());
                    listViewItem.SubItems.Add(booking.User.UserName);
                    listViewItem.SubItems.Add(booking.Room.Price.ToString());
                    listViewItem.SubItems.Add(booking.StartDate.ToShortDateString());
                    listViewItem.SubItems.Add(booking.EndDate.ToShortDateString());
                    listViewItem.SubItems.Add(booking.User.Email);
                    listViewRoomReservation.Items.Add(listViewItem);               
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (listViewRoomReservation.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewRoomReservation.SelectedItems[0];
                using (var context = ContextResolver.GetContext(connectionString))
                {
                    BookingService bookingService = new BookingService(context);
                    bookingService.Delete(Convert.ToInt32(item.Text));
                }
                MessageBox.Show("The reservation has been canceled");
            }
            else
            {
                MessageBox.Show("Select the reservation!");
            }
        }
    }
}
