namespace HotelReservation
{
    partial class FormManageRooms
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.labelCapability = new System.Windows.Forms.Label();
            this.labelComfortLvl = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxCapability = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxComfortLvl = new System.Windows.Forms.ComboBox();
            this.labelValidationMessage = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(102, 285);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(81, 45);
            this.buttonAdd.TabIndex = 30;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(196, 203);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(81, 45);
            this.buttonUpdate.TabIndex = 29;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFind.Location = new System.Drawing.Point(13, 203);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(81, 45);
            this.buttonFind.TabIndex = 28;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(12, 58);
            this.labelNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 13);
            this.labelNumber.TabIndex = 27;
            this.labelNumber.Text = "Number";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(125, 58);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(145, 20);
            this.textBoxNumber.TabIndex = 26;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(102, 203);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(81, 45);
            this.buttonDelete.TabIndex = 24;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(213, 263);
            this.radioButtonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(44, 17);
            this.radioButtonAdd.TabIndex = 23;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "Add";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            this.radioButtonAdd.CheckedChanged += new System.EventHandler(this.radioButtonAdd_CheckedChanged);
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Location = new System.Drawing.Point(117, 263);
            this.radioButtonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(60, 17);
            this.radioButtonUpdate.TabIndex = 22;
            this.radioButtonUpdate.TabStop = true;
            this.radioButtonUpdate.Text = "Update";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            this.radioButtonUpdate.CheckedChanged += new System.EventHandler(this.radioButtonUpdate_CheckedChanged);
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(15, 263);
            this.radioButtonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(56, 17);
            this.radioButtonDelete.TabIndex = 21;
            this.radioButtonDelete.TabStop = true;
            this.radioButtonDelete.Text = "Delete";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            this.radioButtonDelete.CheckedChanged += new System.EventHandler(this.radioButtonDelete_CheckedChanged);
            // 
            // labelCapability
            // 
            this.labelCapability.AutoSize = true;
            this.labelCapability.Location = new System.Drawing.Point(12, 133);
            this.labelCapability.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCapability.Name = "labelCapability";
            this.labelCapability.Size = new System.Drawing.Size(52, 13);
            this.labelCapability.TabIndex = 20;
            this.labelCapability.Text = "Capability";
            // 
            // labelComfortLvl
            // 
            this.labelComfortLvl.AutoSize = true;
            this.labelComfortLvl.Location = new System.Drawing.Point(12, 175);
            this.labelComfortLvl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComfortLvl.Name = "labelComfortLvl";
            this.labelComfortLvl.Size = new System.Drawing.Size(69, 13);
            this.labelComfortLvl.TabIndex = 19;
            this.labelComfortLvl.Text = "ComfortLevel";
            this.labelComfortLvl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(11, 93);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 18;
            this.labelPrice.Text = "Price";
            // 
            // textBoxCapability
            // 
            this.textBoxCapability.Location = new System.Drawing.Point(125, 133);
            this.textBoxCapability.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCapability.Name = "textBoxCapability";
            this.textBoxCapability.Size = new System.Drawing.Size(145, 20);
            this.textBoxCapability.TabIndex = 17;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(125, 93);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(145, 20);
            this.textBoxPrice.TabIndex = 16;
            // 
            // comboBoxComfortLvl
            // 
            this.comboBoxComfortLvl.FormattingEnabled = true;
            this.comboBoxComfortLvl.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxComfortLvl.Location = new System.Drawing.Point(125, 172);
            this.comboBoxComfortLvl.Name = "comboBoxComfortLvl";
            this.comboBoxComfortLvl.Size = new System.Drawing.Size(145, 21);
            this.comboBoxComfortLvl.TabIndex = 31;
            this.comboBoxComfortLvl.Text = "2";
            // 
            // labelValidationMessage
            // 
            this.labelValidationMessage.AutoSize = true;
            this.labelValidationMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValidationMessage.ForeColor = System.Drawing.Color.Red;
            this.labelValidationMessage.Location = new System.Drawing.Point(122, 5);
            this.labelValidationMessage.Name = "labelValidationMessage";
            this.labelValidationMessage.Size = new System.Drawing.Size(166, 15);
            this.labelValidationMessage.TabIndex = 35;
            this.labelValidationMessage.Text = "Incorrect data!Write another...";
            this.labelValidationMessage.Visible = false;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(125, 22);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(145, 20);
            this.textBoxId.TabIndex = 36;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(12, 22);
            this.labelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 37;
            this.labelId.Text = "Id";
            // 
            // FormManageRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(289, 335);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelValidationMessage);
            this.Controls.Add(this.comboBoxComfortLvl);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.radioButtonAdd);
            this.Controls.Add(this.radioButtonUpdate);
            this.Controls.Add(this.radioButtonDelete);
            this.Controls.Add(this.labelCapability);
            this.Controls.Add(this.labelComfortLvl);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxCapability);
            this.Controls.Add(this.textBoxPrice);
            this.MaximizeBox = false;
            this.Name = "FormManageRooms";
            this.Text = "FormManageRooms";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormManageRooms_FormClosed);
            this.Load += new System.EventHandler(this.FormManageRooms_Load);
            this.Shown += new System.EventHandler(this.FormManageRooms_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.RadioButton radioButtonUpdate;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.Label labelCapability;
        private System.Windows.Forms.Label labelComfortLvl;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxCapability;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxComfortLvl;
        private System.Windows.Forms.Label labelValidationMessage;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
    }
}