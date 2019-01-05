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
        static string connectionString = ConfigurationManager.ConnectionStrings["HotelReservationEF"].ConnectionString;
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
                    Created = DateTime.Now

                };
                using (var context = ContextResolver.GetContext(connectionString))
                {
                    var roomService = new RoomService(context);
                    roomService.Add(newRoom);
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

                using (var context = ContextResolver.GetContext(connectionString))
                {
                    var roomService = new RoomService(context);
                    roomService.Delete(Convert.ToInt32(textBoxCapability.Text));
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
                    Id= Convert.ToInt32(textBoxId.Text),
                    Number = Convert.ToInt32(textBoxNumber.Text),
                    Price = Convert.ToDouble(textBoxPrice.Text),
                    Capability = Convert.ToInt16(textBoxCapability.Text),
                    ComfortLevel = Convert.ToInt16(comboBoxComfortLvl.Text),
                    HotelId = hotelId,
                    Modified = DateTime.Now

                };
                using (var context = ContextResolver.GetContext(connectionString))
                {
                    var roomService = new RoomService(context);
                    roomService.Update(room);
                }
                MessageBox.Show("The record has been updated!");
                this.Close();
            }
            else
                labelValidationMessage.Visible = true;
        }


        private void buttonFind_Click(object sender, EventArgs e)
        {

            if (ValidationService.ValidateIsNumber(textBoxId.Text))
            {
                textBoxPrice.ReadOnly = false;
                textBoxCapability.ReadOnly = false;
                comboBoxComfortLvl.Enabled = true;
                buttonUpdate.Enabled = true;
                textBoxNumber.Enabled = true;

                var room = new Room();
                using (var context = ContextResolver.GetContext(connectionString))
                {
                    var roomService = new RoomService(context);
                    room = roomService.GetById(Convert.ToInt32(textBoxId.Text));
                }
                textBoxId.Text = room.Id.ToString();
                textBoxPrice.Text = room.Price.ToString();
                textBoxCapability.Text = room.Capability.ToString();
                comboBoxComfortLvl.Text = room.ComfortLevel.ToString();
                textBoxNumber.Text = room.Number.ToString();

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
            labelId.Visible = false;
            textBoxId.Visible = false;
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
            labelId.Visible = true;
            textBoxId.Visible = true;
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
            textBoxNumber.Enabled = false;
            
        }

        private void radioButtonAdd_CheckedChanged(object sender, EventArgs e)
        {
            labelId.Visible = false;
            textBoxId.Visible = false;
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
            buttonAdd.Location = new Point(130, 204);
            labelCapability.Text = "Capability";
            textBoxId.Enabled = true;
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonFind.Enabled = true;
        }
    }
}
