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
    public partial class FormManageRooms : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["HotelReservationConStr"].ConnectionString;
        RoomRepository roomRepository = new RoomRepository(connectionString);
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


        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidationService.ValidateIsNumber(textBoxNumber.Text) && ValidationService.ValidateIsNumber(textBoxCapability.Text) &&
                ValidationService.ValidateIsPrice(textBoxPrice.Text))
            {
                var newRoom = new Room()
                {
                    Number = Convert.ToInt32(textBoxNumber.Text),
                    Price = Convert.ToDouble(textBoxPrice.Text),
                    Capability = Convert.ToInt16(textBoxCapability.Text),
                    ComfortLevel = Convert.ToInt16(comboBoxComfortLvl.Text),
                    HotelId = Convert.ToInt32(hotelId.ToString()),
                    AddDate = DateTime.Now

                };
                using (var context = ContextResolver.GetContext())
                {
                    var roomService = new RoomService(context);
                    roomService.AddRoom(newRoom);
                }
                MessageBox.Show("New record has added");
                this.Close();
            }
            else
                labelValidationMessage.Visible = true;
        }

        private void FormManageRooms_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (ValidationService.ValidateIsNumber(textBoxCapability.Text))
            {

                roomRepository.DeleteRoomById(textBoxCapability.Text);
                using (var context = ContextResolver.GetContext())
                {
                    var roomService = new RoomService(context);
                    roomService.DeleteRoom(Convert.ToInt32(textBoxCapability.Text));
                }
                MessageBox.Show("The record has been deleted!");
                this.Close();
            }
            else
                labelValidationMessage.Visible = true;

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (ValidationService.ValidateIsNumber(textBoxNumber.Text) && ValidationService.ValidateIsNumber(textBoxCapability.Text) &&
                ValidationService.ValidateIsPrice(textBoxPrice.Text))
            {
                var room = new Room()
                {
                    Number = Convert.ToInt32(textBoxNumber.Text),
                    Price = Convert.ToDouble(textBoxPrice.Text),
                    Capability = Convert.ToInt16(textBoxCapability.Text),
                    ComfortLevel = Convert.ToInt16(comboBoxComfortLvl.Text),
                    UpdateDate = DateTime.Now

                };
                using (var context = ContextResolver.GetContext())
                {
                    var roomService = new RoomService(context);
                    roomService.UpdateRoom(room);
                }
                MessageBox.Show("The record has been updated!");
                this.Close();
            }
            else
                labelValidationMessage.Visible = true;
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            buttonFind.Enabled = true;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {

            if (ValidationService.ValidateIsNumber(textBoxNumber.Text))
            {
                textBoxPrice.ReadOnly = false;
                textBoxCapability.ReadOnly = false;
                comboBoxComfortLvl.Enabled = true;
                buttonUpdate.Enabled = true;

                var room = new Room();
                using (var context = ContextResolver.GetContext())
                {
                    var roomService = new RoomService(context);
                    room = roomService.FindRoomByRoomNumber(Convert.ToInt32(textBoxNumber.Text));
                }

                textBoxPrice.Text = room.Price.ToString();
                textBoxCapability.Text = room.Capability.ToString();
                comboBoxComfortLvl.Text = room.ComfortLevel.ToString();

            }
            else
                labelValidationMessage.Visible = true;
        }

        private void FormManageRooms_Load(object sender, EventArgs e)
        {
            this.comboBoxComfortLvl.DropDownStyle = ComboBoxStyle.DropDownList;

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
    }
}
