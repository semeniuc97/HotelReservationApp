namespace HotelReservation
{
    partial class FormManageHotels
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
            this.textBoxHotelName = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.labelHotelName = new System.Windows.Forms.Label();
            this.labelFoundationYear = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dateTimePickerFYear = new System.Windows.Forms.DateTimePicker();
            this.textBoxFyndById = new System.Windows.Forms.TextBox();
            this.labelFindById = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxIsActive = new System.Windows.Forms.ComboBox();
            this.labelIsActive = new System.Windows.Forms.Label();
            this.labelValidationMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxHotelName
            // 
            this.textBoxHotelName.Location = new System.Drawing.Point(142, 57);
            this.textBoxHotelName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHotelName.Name = "textBoxHotelName";
            this.textBoxHotelName.Size = new System.Drawing.Size(145, 20);
            this.textBoxHotelName.TabIndex = 0;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(142, 97);
            this.textBoxAdress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(145, 20);
            this.textBoxAdress.TabIndex = 2;
            // 
            // labelHotelName
            // 
            this.labelHotelName.AutoSize = true;
            this.labelHotelName.Location = new System.Drawing.Point(28, 57);
            this.labelHotelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHotelName.Name = "labelHotelName";
            this.labelHotelName.Size = new System.Drawing.Size(63, 13);
            this.labelHotelName.TabIndex = 3;
            this.labelHotelName.Text = "Hotel Name";
            // 
            // labelFoundationYear
            // 
            this.labelFoundationYear.AutoSize = true;
            this.labelFoundationYear.Location = new System.Drawing.Point(29, 139);
            this.labelFoundationYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFoundationYear.Name = "labelFoundationYear";
            this.labelFoundationYear.Size = new System.Drawing.Size(82, 13);
            this.labelFoundationYear.TabIndex = 4;
            this.labelFoundationYear.Text = "FoundationYear";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(29, 97);
            this.labelAdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(39, 13);
            this.labelAdress.TabIndex = 5;
            this.labelAdress.Text = "Adress";
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(31, 262);
            this.radioButtonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(56, 17);
            this.radioButtonDelete.TabIndex = 6;
            this.radioButtonDelete.TabStop = true;
            this.radioButtonDelete.Text = "Delete";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            this.radioButtonDelete.CheckedChanged += new System.EventHandler(this.radioButtonDelete_CheckedChanged);
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Location = new System.Drawing.Point(133, 262);
            this.radioButtonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(60, 17);
            this.radioButtonUpdate.TabIndex = 7;
            this.radioButtonUpdate.TabStop = true;
            this.radioButtonUpdate.Text = "Update";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            this.radioButtonUpdate.CheckedChanged += new System.EventHandler(this.radioButtonUpdate_CheckedChanged);
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(229, 262);
            this.radioButtonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(44, 17);
            this.radioButtonAdd.TabIndex = 8;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "Add";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            this.radioButtonAdd.CheckedChanged += new System.EventHandler(this.radioButtonAdd_CheckedChanged_1);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(118, 202);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(81, 45);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dateTimePickerFYear
            // 
            this.dateTimePickerFYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFYear.Location = new System.Drawing.Point(142, 135);
            this.dateTimePickerFYear.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFYear.Name = "dateTimePickerFYear";
            this.dateTimePickerFYear.Size = new System.Drawing.Size(145, 20);
            this.dateTimePickerFYear.TabIndex = 10;
            // 
            // textBoxFyndById
            // 
            this.textBoxFyndById.Location = new System.Drawing.Point(142, 22);
            this.textBoxFyndById.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFyndById.Name = "textBoxFyndById";
            this.textBoxFyndById.Size = new System.Drawing.Size(145, 20);
            this.textBoxFyndById.TabIndex = 11;
            this.textBoxFyndById.TextChanged += new System.EventHandler(this.textBoxFyndById_TextChanged);
            // 
            // labelFindById
            // 
            this.labelFindById.AutoSize = true;
            this.labelFindById.Location = new System.Drawing.Point(29, 22);
            this.labelFindById.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFindById.Name = "labelFindById";
            this.labelFindById.Size = new System.Drawing.Size(53, 13);
            this.labelFindById.TabIndex = 12;
            this.labelFindById.Text = "Find by Id";
            // 
            // buttonFind
            // 
            this.buttonFind.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFind.Location = new System.Drawing.Point(29, 202);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(81, 45);
            this.buttonFind.TabIndex = 13;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(212, 202);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(81, 45);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(118, 284);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(81, 45);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxIsActive
            // 
            this.comboBoxIsActive.FormattingEnabled = true;
            this.comboBoxIsActive.Items.AddRange(new object[] {
            "true",
            "false"});
            this.comboBoxIsActive.Location = new System.Drawing.Point(142, 170);
            this.comboBoxIsActive.Name = "comboBoxIsActive";
            this.comboBoxIsActive.Size = new System.Drawing.Size(145, 21);
            this.comboBoxIsActive.TabIndex = 33;
            this.comboBoxIsActive.Text = "false";
            // 
            // labelIsActive
            // 
            this.labelIsActive.AutoSize = true;
            this.labelIsActive.Location = new System.Drawing.Point(29, 173);
            this.labelIsActive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIsActive.Name = "labelIsActive";
            this.labelIsActive.Size = new System.Drawing.Size(48, 13);
            this.labelIsActive.TabIndex = 32;
            this.labelIsActive.Text = "Is Active";
            this.labelIsActive.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelValidationMessage
            // 
            this.labelValidationMessage.AutoSize = true;
            this.labelValidationMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValidationMessage.ForeColor = System.Drawing.Color.Red;
            this.labelValidationMessage.Location = new System.Drawing.Point(139, 4);
            this.labelValidationMessage.Name = "labelValidationMessage";
            this.labelValidationMessage.Size = new System.Drawing.Size(166, 15);
            this.labelValidationMessage.TabIndex = 34;
            this.labelValidationMessage.Text = "Incorrect data!Write another...";
            this.labelValidationMessage.Visible = false;
            // 
            // ManageHotelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(320, 340);
            this.Controls.Add(this.labelValidationMessage);
            this.Controls.Add(this.comboBoxIsActive);
            this.Controls.Add(this.labelIsActive);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.labelFindById);
            this.Controls.Add(this.textBoxFyndById);
            this.Controls.Add(this.dateTimePickerFYear);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.radioButtonAdd);
            this.Controls.Add(this.radioButtonUpdate);
            this.Controls.Add(this.radioButtonDelete);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelFoundationYear);
            this.Controls.Add(this.labelHotelName);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxHotelName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ManageHotelsForm";
            this.Text = "ManageHotelsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageHotelsForm_FormClosed);
            this.Load += new System.EventHandler(this.ManageHotelsForm_Load);
            this.Shown += new System.EventHandler(this.ManageHotelsForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHotelName;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label labelHotelName;
        private System.Windows.Forms.Label labelFoundationYear;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.RadioButton radioButtonUpdate;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DateTimePicker dateTimePickerFYear;
        private System.Windows.Forms.TextBox textBoxFyndById;
        private System.Windows.Forms.Label labelFindById;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxIsActive;
        private System.Windows.Forms.Label labelIsActive;
        private System.Windows.Forms.Label labelValidationMessage;
    }
}