namespace HotelReservation
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.listViewHotels = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHotelListName = new System.Windows.Forms.Label();
            this.buttonModify = new System.Windows.Forms.Button();
            this.textBoxInputHotelId = new System.Windows.Forms.TextBox();
            this.buttonCheckHotelById = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelInstruct = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonRoomsRatings = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewHotels
            // 
            this.listViewHotels.BackColor = System.Drawing.Color.Azure;
            this.listViewHotels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewHotels.Location = new System.Drawing.Point(27, 66);
            this.listViewHotels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewHotels.Name = "listViewHotels";
            this.listViewHotels.Size = new System.Drawing.Size(663, 504);
            this.listViewHotels.TabIndex = 0;
            this.listViewHotels.UseCompatibleStateImageBehavior = false;
            this.listViewHotels.View = System.Windows.Forms.View.Details;
            this.listViewHotels.SelectedIndexChanged += new System.EventHandler(this.listViewHotels_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hotel Name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Foundation Year";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adress";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Is Active";
            this.columnHeader5.Width = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.labelHotelListName);
            this.panel1.Controls.Add(this.listViewHotels);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 594);
            this.panel1.TabIndex = 1;
            // 
            // labelHotelListName
            // 
            this.labelHotelListName.AutoSize = true;
            this.labelHotelListName.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotelListName.Location = new System.Drawing.Point(221, 14);
            this.labelHotelListName.Name = "labelHotelListName";
            this.labelHotelListName.Size = new System.Drawing.Size(235, 49);
            this.labelHotelListName.TabIndex = 1;
            this.labelHotelListName.Text = "List of Hotels";
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonModify.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.Location = new System.Drawing.Point(35, 31);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(196, 60);
            this.buttonModify.TabIndex = 3;
            this.buttonModify.Text = "Modify Hotels";
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // textBoxInputHotelId
            // 
            this.textBoxInputHotelId.Enabled = false;
            this.textBoxInputHotelId.Location = new System.Drawing.Point(35, 165);
            this.textBoxInputHotelId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxInputHotelId.Name = "textBoxInputHotelId";
            this.textBoxInputHotelId.Size = new System.Drawing.Size(195, 22);
            this.textBoxInputHotelId.TabIndex = 4;
            // 
            // buttonCheckHotelById
            // 
            this.buttonCheckHotelById.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCheckHotelById.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckHotelById.Location = new System.Drawing.Point(35, 196);
            this.buttonCheckHotelById.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCheckHotelById.Name = "buttonCheckHotelById";
            this.buttonCheckHotelById.Size = new System.Drawing.Size(196, 60);
            this.buttonCheckHotelById.TabIndex = 5;
            this.buttonCheckHotelById.Text = "Check the hotel";
            this.buttonCheckHotelById.UseVisualStyleBackColor = false;
            this.buttonCheckHotelById.Click += new System.EventHandler(this.buttonCheckHotelById_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.labelInstruct);
            this.panel2.Controls.Add(this.buttonCheckHotelById);
            this.panel2.Controls.Add(this.buttonModify);
            this.panel2.Controls.Add(this.textBoxInputHotelId);
            this.panel2.Location = new System.Drawing.Point(788, 273);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 282);
            this.panel2.TabIndex = 6;
            // 
            // labelInstruct
            // 
            this.labelInstruct.AutoSize = true;
            this.labelInstruct.Location = new System.Drawing.Point(31, 145);
            this.labelInstruct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInstruct.Name = "labelInstruct";
            this.labelInstruct.Size = new System.Drawing.Size(163, 17);
            this.labelInstruct.TabIndex = 6;
            this.labelInstruct.Text = "Select the Id of the Hotel";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(823, 178);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(196, 60);
            this.buttonRefresh.TabIndex = 7;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonRoomsRatings
            // 
            this.buttonRoomsRatings.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonRoomsRatings.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoomsRatings.Location = new System.Drawing.Point(822, 69);
            this.buttonRoomsRatings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRoomsRatings.Name = "buttonRoomsRatings";
            this.buttonRoomsRatings.Size = new System.Drawing.Size(196, 60);
            this.buttonRoomsRatings.TabIndex = 8;
            this.buttonRoomsRatings.Text = "See rooms rating";
            this.buttonRoomsRatings.UseVisualStyleBackColor = false;
            this.buttonRoomsRatings.Click += new System.EventHandler(this.buttonRoomsRatings_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1093, 635);
            this.Controls.Add(this.buttonRoomsRatings);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewHotels;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHotelListName;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.TextBox textBoxInputHotelId;
        private System.Windows.Forms.Button buttonCheckHotelById;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelInstruct;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonRoomsRatings;
    }
}