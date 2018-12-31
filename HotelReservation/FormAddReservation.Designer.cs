namespace HotelReservation
{
    partial class FormAddReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.buttonAddReservation = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelDatesValidation = new System.Windows.Forms.Label();
            this.monthCalendarBookedDays = new System.Windows.Forms.MonthCalendar();
            this.radioButtonStartDate = new System.Windows.Forms.RadioButton();
            this.radioButtonEndDate = new System.Windows.Forms.RadioButton();
            this.labelErrorBookedRoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Enabled = false;
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(366, 19);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(118, 20);
            this.dateTimePickerStart.TabIndex = 1;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Enabled = false;
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(366, 80);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(118, 20);
            this.dateTimePickerEnd.TabIndex = 2;
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listViewUsers.Location = new System.Drawing.Point(517, 6);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(133, 182);
            this.listViewUsers.TabIndex = 3;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            this.listViewUsers.SelectedIndexChanged += new System.EventHandler(this.listViewUsers_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Id";
            this.columnHeader2.Width = 35;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "User";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 75;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(313, 84);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(49, 13);
            this.labelEndDate.TabIndex = 5;
            this.labelEndDate.Text = "EndDate";
            this.labelEndDate.Click += new System.EventHandler(this.labelEndDate_Click);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(313, 23);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(52, 13);
            this.labelStartDate.TabIndex = 6;
            this.labelStartDate.Text = "StartDate";
            this.labelStartDate.Click += new System.EventHandler(this.labelStartDate_Click);
            // 
            // buttonAddReservation
            // 
            this.buttonAddReservation.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddReservation.Location = new System.Drawing.Point(307, 149);
            this.buttonAddReservation.Name = "buttonAddReservation";
            this.buttonAddReservation.Size = new System.Drawing.Size(177, 40);
            this.buttonAddReservation.TabIndex = 7;
            this.buttonAddReservation.Text = "Add Reservation";
            this.buttonAddReservation.UseVisualStyleBackColor = true;
            this.buttonAddReservation.Click += new System.EventHandler(this.buttonAddReservation_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(336, 132);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(137, 13);
            this.labelError.TabIndex = 9;
            this.labelError.Text = "Error!Must choose the user!";
            this.labelError.Visible = false;
            // 
            // labelDatesValidation
            // 
            this.labelDatesValidation.AutoSize = true;
            this.labelDatesValidation.ForeColor = System.Drawing.Color.Red;
            this.labelDatesValidation.Location = new System.Drawing.Point(336, 119);
            this.labelDatesValidation.Name = "labelDatesValidation";
            this.labelDatesValidation.Size = new System.Drawing.Size(139, 13);
            this.labelDatesValidation.TabIndex = 10;
            this.labelDatesValidation.Text = "Error!Select another dates...";
            this.labelDatesValidation.Visible = false;
            // 
            // monthCalendarBookedDays
            // 
            this.monthCalendarBookedDays.BackColor = System.Drawing.SystemColors.HighlightText;
            this.monthCalendarBookedDays.ForeColor = System.Drawing.Color.Black;
            this.monthCalendarBookedDays.Location = new System.Drawing.Point(16, 16);
            this.monthCalendarBookedDays.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendarBookedDays.Name = "monthCalendarBookedDays";
            this.monthCalendarBookedDays.ShowToday = false;
            this.monthCalendarBookedDays.TabIndex = 11;
            this.monthCalendarBookedDays.TitleForeColor = System.Drawing.Color.Black;
            this.monthCalendarBookedDays.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarBookedDays_DateSelected);
            // 
            // radioButtonStartDate
            // 
            this.radioButtonStartDate.AutoSize = true;
            this.radioButtonStartDate.Checked = true;
            this.radioButtonStartDate.Location = new System.Drawing.Point(294, 23);
            this.radioButtonStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonStartDate.Name = "radioButtonStartDate";
            this.radioButtonStartDate.Size = new System.Drawing.Size(14, 13);
            this.radioButtonStartDate.TabIndex = 12;
            this.radioButtonStartDate.TabStop = true;
            this.radioButtonStartDate.UseVisualStyleBackColor = true;
            // 
            // radioButtonEndDate
            // 
            this.radioButtonEndDate.AutoSize = true;
            this.radioButtonEndDate.Location = new System.Drawing.Point(294, 84);
            this.radioButtonEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonEndDate.Name = "radioButtonEndDate";
            this.radioButtonEndDate.Size = new System.Drawing.Size(14, 13);
            this.radioButtonEndDate.TabIndex = 13;
            this.radioButtonEndDate.UseVisualStyleBackColor = true;
            // 
            // labelErrorBookedRoom
            // 
            this.labelErrorBookedRoom.AutoSize = true;
            this.labelErrorBookedRoom.ForeColor = System.Drawing.Color.Red;
            this.labelErrorBookedRoom.Location = new System.Drawing.Point(313, 106);
            this.labelErrorBookedRoom.Name = "labelErrorBookedRoom";
            this.labelErrorBookedRoom.Size = new System.Drawing.Size(199, 13);
            this.labelErrorBookedRoom.TabIndex = 14;
            this.labelErrorBookedRoom.Text = "The room is booked.Choose other dates!";
            this.labelErrorBookedRoom.Visible = false;
            // 
            // FormAddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(662, 230);
            this.Controls.Add(this.labelErrorBookedRoom);
            this.Controls.Add(this.radioButtonEndDate);
            this.Controls.Add(this.radioButtonStartDate);
            this.Controls.Add(this.monthCalendarBookedDays);
            this.Controls.Add(this.labelDatesValidation);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonAddReservation);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.listViewUsers);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.MaximizeBox = false;
            this.Name = "FormAddReservation";
            this.Text = "FormAddReservation";
            this.Shown += new System.EventHandler(this.FormAddReservation_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Button buttonAddReservation;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelDatesValidation;
        private System.Windows.Forms.MonthCalendar monthCalendarBookedDays;
        private System.Windows.Forms.RadioButton radioButtonStartDate;
        private System.Windows.Forms.RadioButton radioButtonEndDate;
        private System.Windows.Forms.Label labelErrorBookedRoom;
    }
}