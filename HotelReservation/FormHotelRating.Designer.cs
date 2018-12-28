namespace HotelReservation
{
    partial class FormHotelRating
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
            this.listViewHotelsRating = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.buttonShowRating = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewHotelsRating
            // 
            this.listViewHotelsRating.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewHotelsRating.Location = new System.Drawing.Point(21, 20);
            this.listViewHotelsRating.Margin = new System.Windows.Forms.Padding(2);
            this.listViewHotelsRating.Name = "listViewHotelsRating";
            this.listViewHotelsRating.Size = new System.Drawing.Size(346, 338);
            this.listViewHotelsRating.TabIndex = 0;
            this.listViewHotelsRating.UseCompatibleStateImageBehavior = false;
            this.listViewHotelsRating.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CountofReservations";
            this.columnHeader1.Width = 127;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "RoomNumber";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "HotelName";
            this.columnHeader3.Width = 119;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(468, 142);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerStartDate.TabIndex = 1;
            this.dateTimePickerStartDate.Value = new System.DateTime(2015, 2, 1, 0, 0, 0, 0);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(468, 204);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerEndDate.TabIndex = 2;
            this.dateTimePickerEndDate.Value = new System.DateTime(2019, 1, 23, 0, 0, 0, 0);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(411, 86);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(208, 18);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Choose the range of dates";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartDate.Location = new System.Drawing.Point(402, 146);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(61, 15);
            this.labelStartDate.TabIndex = 5;
            this.labelStartDate.Text = "Start Date";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEndDate.Location = new System.Drawing.Point(402, 209);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(58, 15);
            this.labelEndDate.TabIndex = 6;
            this.labelEndDate.Text = "End Date";
            // 
            // buttonShowRating
            // 
            this.buttonShowRating.Location = new System.Drawing.Point(468, 282);
            this.buttonShowRating.Name = "buttonShowRating";
            this.buttonShowRating.Size = new System.Drawing.Size(75, 23);
            this.buttonShowRating.TabIndex = 7;
            this.buttonShowRating.Text = "Show";
            this.buttonShowRating.UseVisualStyleBackColor = true;
            this.buttonShowRating.Click += new System.EventHandler(this.buttonShowRating_Click);
            // 
            // FormHotelRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(644, 405);
            this.Controls.Add(this.buttonShowRating);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.listViewHotelsRating);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHotelRating";
            this.Text = "FormHotelRating";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHotelRating_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewHotelsRating;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Button buttonShowRating;
    }
}