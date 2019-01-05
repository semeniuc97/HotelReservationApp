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
using BusinessAccessLayer.Services;
using DataAccessLayer;
using Models;

namespace HotelReservation
{
    public partial class FormManageHotels : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["HotelReservationEF"].ConnectionString;
       
        public FormManageHotels()
        {
            InitializeComponent();
            
        }

        private void ManageHotelsForm_Shown(object sender, EventArgs e)
        {
            radioButtonAdd.Checked = true;
        }


        private void RadioButtonAdd_CheckedChanged(object sender, EventArgs e)
        {
            buttonDelete.Text = "Add";
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            textBoxHotelName.ReadOnly = false;
            textBoxAdress.ReadOnly = false;
            dateTimePickerFYear.Enabled = true;
            buttonUpdate.Enabled = true;
            comboBoxIsActive.Enabled = true;

       
            if (ValidationService.ValidateIsNumber(textBoxFyndById.Text))
            {
                var hotel = new Hotel();
                using (var context = ContextResolver.GetContext(connectionString))
                {
                    var hotelService = new HotelService(context);
                    hotel = hotelService.Get(Convert.ToInt32(textBoxFyndById.Text));
                }

                textBoxHotelName.Text = hotel.HotelName;
                textBoxAdress.Text = hotel.Adress;
                dateTimePickerFYear.Value = hotel.FoundationYear;
                comboBoxIsActive.Text = hotel.IsActive.ToString();
                comboBoxIsActive.Text = hotel.IsActive.ToString();
            }
            else
                labelValidationMessage.Visible = true;
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidationService.ValidateHotelName(textBoxHotelName.Text) && ValidationService.ValidateFoundationYear(dateTimePickerFYear.Value))
            {
                var hotel = new Hotel()
                {
                    HotelName = textBoxHotelName.Text,
                    Adress = textBoxAdress.Text,
                    FoundationYear = dateTimePickerFYear.Value,
                    IsActive = Convert.ToBoolean(comboBoxIsActive.Text),
                    Created= DateTime.Now
                    
                };

                using (var context = ContextResolver.GetContext(connectionString))
                {
                    var hotelService = new HotelService(context);
                    hotelService.Add(hotel);
                }
                    MessageBox.Show("New record has been added");
                this.Close();
            }
            else
                labelValidationMessage.Visible = true;

        }

        private void ManageHotelsForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (ValidationService.ValidateIsNumber(textBoxAdress.Text))
            {
                using (var context = ContextResolver.GetContext(connectionString))
                {
                    var hotelService = new HotelService(context);
                    hotelService.Delete(Convert.ToInt16(textBoxAdress.Text));
                }
                MessageBox.Show("The record has been deleted!");
                this.Close();
            }
            else
                labelValidationMessage.Visible = true;
        }

        private void textBoxFyndById_TextChanged(object sender, EventArgs e)
        {
            buttonFind.Enabled = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (ValidationService.ValidateHotelName(textBoxHotelName.Text) && ValidationService.ValidateIsNumber(textBoxFyndById.Text) && 
                ValidationService.ValidateFoundationYear(dateTimePickerFYear.Value))
            {
                var hotel = new Hotel()
                {
                    Id = Convert.ToInt32(textBoxFyndById.Text),
                    HotelName = textBoxHotelName.Text,
                    Adress = textBoxAdress.Text,
                    FoundationYear = dateTimePickerFYear.Value,
                    IsActive = Convert.ToBoolean(comboBoxIsActive.Text),
                    Modified=DateTime.Now
                };

                using (var context = ContextResolver.GetContext(connectionString))
                {
                    var hotelService = new HotelService(context);
                    hotelService.Update(hotel);
                }
                MessageBox.Show("The record has been updated!");
                this.Close();
            }
            else
                labelValidationMessage.Visible = true;

        }

        private void ManageHotelsForm_Load(object sender, EventArgs e)
        {
            this.comboBoxIsActive.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void radioButtonDelete_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHotelName.ReadOnly = false;
            textBoxAdress.ReadOnly = false;
            dateTimePickerFYear.Enabled = true;
            buttonUpdate.Enabled = true;
            labelFindById.Visible = false;
            textBoxFyndById.Visible = false;
            labelHotelName.Visible = false;
            textBoxHotelName.Visible = false;
            labelFoundationYear.Visible = false;
            dateTimePickerFYear.Visible = false;
            labelAdress.Text = "Delete by Id";
            buttonFind.Visible = false;
            buttonUpdate.Visible = false;
            buttonDelete.Visible = true;
            buttonDelete.Text = "Delete";
            buttonAdd.Visible = false;
            labelIsActive.Visible = false;
            comboBoxIsActive.Visible = false;
        }

        private void radioButtonUpdate_CheckedChanged(object sender, EventArgs e)
        {
            labelFindById.Visible = true;
            textBoxFyndById.Visible = true;
            labelHotelName.Visible = true;
            textBoxHotelName.Visible = true;
            labelFoundationYear.Visible = true;
            dateTimePickerFYear.Visible = true;
            dateTimePickerFYear.Enabled = false;
            buttonFind.Visible = true;
            buttonUpdate.Visible = true;
            buttonDelete.Visible = false;
            buttonAdd.Visible = false;
            labelAdress.Text = "Adress";
            textBoxHotelName.ReadOnly = true;
            textBoxAdress.ReadOnly = true;
            buttonUpdate.Enabled = false;
            buttonFind.Enabled = false;
            comboBoxIsActive.Enabled = false;
            comboBoxIsActive.Visible = true;
            labelIsActive.Visible = true;

        }

        private void radioButtonAdd_CheckedChanged_1(object sender, EventArgs e)
        {
            textBoxHotelName.ReadOnly = false;
            textBoxAdress.ReadOnly = false;
            dateTimePickerFYear.Enabled = true;
            buttonUpdate.Enabled = true;
            labelFindById.Visible = false;
            textBoxFyndById.Visible = false;
            labelHotelName.Visible = true;
            textBoxHotelName.Visible = true;
            labelFoundationYear.Visible = true;
            dateTimePickerFYear.Visible = true;
            buttonFind.Visible = false;
            buttonUpdate.Visible = false;
            buttonDelete.Visible = false;
            buttonAdd.Visible = true;
            buttonAdd.Location = new Point(130, 204);
            labelAdress.Text = "Adress";
            labelIsActive.Visible = true;
            comboBoxIsActive.Visible = true;
            labelIsActive.Enabled = true;
            comboBoxIsActive.Enabled = true;
        }


    }
}
