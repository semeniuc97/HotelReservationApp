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
using DataAccessLayer;
using Models;

namespace HotelReservation
{
    public partial class ManageHotelsForm : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["HotelReservationConStr"].ConnectionString;
        HotelRepository hotelRepository = new HotelRepository(connectionString);
        public ManageHotelsForm()
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

            int num;
            bool isNumeric = int.TryParse(textBoxFyndById.Text, out num);
            if (textBoxFyndById.Text != "" && isNumeric)
            {
                var hotel = hotelRepository.FindHotelById(textBoxFyndById.Text);
                textBoxHotelName.Text = hotel.HotelName;
                textBoxAdress.Text = hotel.Adress;
                dateTimePickerFYear.Value = hotel.FoundationYear;
                comboBoxIsActive.Text = hotel.IsActive;
            }
            else
                MessageBox.Show("Input the id!");
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        var foundationYear = dateTimePickerFYear.Value;
            //        SqlCommand command = new SqlCommand("Insert into Hotels(HotelName,Adress,FoundationYear,IsActive) Values(" + "'" + textBoxHotelName.Text + "'" + "," +
            //           "'" + textBoxAdress.Text + "'" + "," + "'" + foundationYear.ToString("u") + "','" + comboBoxIsActive.Text + "');", sqlConnection);
            //        sqlConnection.Open();
            //        command.ExecuteNonQuery();
            //        sqlConnection.Close();
            //        MessageBox.Show("New record has added");
            //        this.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            var hotel = new Hotel()
            {
                HotelName = textBoxHotelName.Text,
                Adress = textBoxAdress.Text,
                FoundationYear = dateTimePickerFYear.Value,
                IsActive = comboBoxIsActive.Text
            };
            hotelRepository.AddHotel(hotel);
            MessageBox.Show("New record has been added");
            this.Close();

        }

        private void ManageHotelsForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("Delete From Hotels Where HotelId=" + textBoxAdress.Text, sqlConnection);
                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("The record has been deleted!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void textBoxFyndById_TextChanged(object sender, EventArgs e)
        {
            buttonFind.Enabled = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        var foundationYear = dateTimePickerFYear.Value;
            //        SqlCommand command = new SqlCommand("Update Hotels Set HotelName='" + textBoxHotelName.Text + "',Adress='" + textBoxAdress.Text +
            //            "',FoundationYear='" + foundationYear + "','IsActive=" + comboBoxIsActive.Text + "' where HotelId=" + textBoxFyndById.Text + ";", sqlConnection);
            //        sqlConnection.Open();
            //        command.ExecuteNonQuery();
            //        sqlConnection.Close();
            //        MessageBox.Show("The record has been updated!");
            //        this.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            var hotel = new Hotel()
            {
                HotelId = textBoxFyndById.Text,
                HotelName = textBoxHotelName.Text,
                Adress = textBoxAdress.Text,
                FoundationYear=dateTimePickerFYear.Value,
                IsActive=comboBoxIsActive.Text
            };
            hotelRepository.UpdateHotel(hotel);
            MessageBox.Show("The record has been updated!");
            this.Close();
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
            labelIsActive.Enabled = false;
            comboBoxIsActive.Enabled = false;

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
