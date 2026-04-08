namespace CARRENTALBUSINESS
{
    partial class FrmBooking
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
			this.GbxIdentification = new System.Windows.Forms.GroupBox();
			this.rbtnPassport = new System.Windows.Forms.RadioButton();
			this.rbtnId = new System.Windows.Forms.RadioButton();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.txtDriverslicense = new System.Windows.Forms.TextBox();
			this.cbxVehiclerenting = new System.Windows.Forms.ComboBox();
			this.dateTimePickerdropoffdate = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerPickupdate = new System.Windows.Forms.DateTimePicker();
			this.cbxResidence = new System.Windows.Forms.ComboBox();
			this.txtIdentification = new System.Windows.Forms.TextBox();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.txtLastname = new System.Windows.Forms.TextBox();
			this.lblVehicle = new System.Windows.Forms.Label();
			this.lblResidence = new System.Windows.Forms.Label();
			this.lblDriverslicense = new System.Windows.Forms.Label();
			this.lblDropoff = new System.Windows.Forms.Label();
			this.lblPickup = new System.Windows.Forms.Label();
			this.lblAge = new System.Windows.Forms.Label();
			this.lblFirstname = new System.Windows.Forms.Label();
			this.lblLastname = new System.Windows.Forms.Label();
			this.txtFirstname = new System.Windows.Forms.TextBox();
			this.lblTrajjRentalCompany = new System.Windows.Forms.Label();
			this.GbxIdentification.SuspendLayout();
			this.SuspendLayout();
			// 
			// GbxIdentification
			// 
			this.GbxIdentification.Controls.Add(this.rbtnPassport);
			this.GbxIdentification.Controls.Add(this.rbtnId);
			this.GbxIdentification.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GbxIdentification.Location = new System.Drawing.Point(38, 163);
			this.GbxIdentification.Name = "GbxIdentification";
			this.GbxIdentification.Size = new System.Drawing.Size(298, 68);
			this.GbxIdentification.TabIndex = 69;
			this.GbxIdentification.TabStop = false;
			this.GbxIdentification.Text = "Identification";
			// 
			// rbtnPassport
			// 
			this.rbtnPassport.AutoSize = true;
			this.rbtnPassport.Location = new System.Drawing.Point(162, 29);
			this.rbtnPassport.Name = "rbtnPassport";
			this.rbtnPassport.Size = new System.Drawing.Size(84, 23);
			this.rbtnPassport.TabIndex = 1;
			this.rbtnPassport.TabStop = true;
			this.rbtnPassport.Text = "Passport";
			this.rbtnPassport.UseVisualStyleBackColor = true;
			// 
			// rbtnId
			// 
			this.rbtnId.AutoSize = true;
			this.rbtnId.Location = new System.Drawing.Point(0, 29);
			this.rbtnId.Name = "rbtnId";
			this.rbtnId.Size = new System.Drawing.Size(41, 23);
			this.rbtnId.TabIndex = 0;
			this.rbtnId.TabStop = true;
			this.rbtnId.Text = "Id";
			this.rbtnId.UseVisualStyleBackColor = true;
			// 
			// txtEmail
			// 
			this.txtEmail.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtEmail.Location = new System.Drawing.Point(169, 356);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(200, 20);
			this.txtEmail.TabIndex = 68;
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(39, 356);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(50, 19);
			this.lblEmail.TabIndex = 67;
			this.lblEmail.Text = "Email";
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(582, 392);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(75, 23);
			this.btnBack.TabIndex = 66;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(692, 392);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(75, 23);
			this.btnSubmit.TabIndex = 65;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// txtDriverslicense
			// 
			this.txtDriverslicense.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtDriverslicense.Location = new System.Drawing.Point(569, 306);
			this.txtDriverslicense.Name = "txtDriverslicense";
			this.txtDriverslicense.Size = new System.Drawing.Size(198, 20);
			this.txtDriverslicense.TabIndex = 64;
			// 
			// cbxVehiclerenting
			// 
			this.cbxVehiclerenting.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.cbxVehiclerenting.FormattingEnabled = true;
			this.cbxVehiclerenting.Items.AddRange(new object[] {
            "Toyota Corolla",
            "Kia Sportage",
            "Honda HR-V",
            "Honda CR-V",
            "Jeep Wrangler",
            "Honda Accord",
            "Toyota WISH"});
			this.cbxVehiclerenting.Location = new System.Drawing.Point(569, 246);
			this.cbxVehiclerenting.Name = "cbxVehiclerenting";
			this.cbxVehiclerenting.Size = new System.Drawing.Size(198, 21);
			this.cbxVehiclerenting.TabIndex = 63;
			// 
			// dateTimePickerdropoffdate
			// 
			this.dateTimePickerdropoffdate.Location = new System.Drawing.Point(169, 307);
			this.dateTimePickerdropoffdate.Name = "dateTimePickerdropoffdate";
			this.dateTimePickerdropoffdate.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerdropoffdate.TabIndex = 62;
			// 
			// dateTimePickerPickupdate
			// 
			this.dateTimePickerPickupdate.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
			this.dateTimePickerPickupdate.Location = new System.Drawing.Point(169, 246);
			this.dateTimePickerPickupdate.Name = "dateTimePickerPickupdate";
			this.dateTimePickerPickupdate.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerPickupdate.TabIndex = 61;
			// 
			// cbxResidence
			// 
			this.cbxResidence.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.cbxResidence.FormattingEnabled = true;
			this.cbxResidence.Items.AddRange(new object[] {
            "Hanover\t",
            "St. Ann\t",
            "Portland",
            "St. James\t",
            "St. Mary\t",
            "St. Thomas",
            "Trelawny\t",
            "Manchester\t",
            "St. Andrew",
            "Westmoreland\t",
            "Clarendon",
            "Kingston",
            "St Elizabeth\t",
            "St. Catherine"});
			this.cbxResidence.Location = new System.Drawing.Point(656, 186);
			this.cbxResidence.Name = "cbxResidence";
			this.cbxResidence.Size = new System.Drawing.Size(111, 21);
			this.cbxResidence.TabIndex = 60;
			// 
			// txtIdentification
			// 
			this.txtIdentification.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtIdentification.Location = new System.Drawing.Point(362, 186);
			this.txtIdentification.Name = "txtIdentification";
			this.txtIdentification.Size = new System.Drawing.Size(173, 20);
			this.txtIdentification.TabIndex = 59;
			// 
			// txtAge
			// 
			this.txtAge.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtAge.Location = new System.Drawing.Point(656, 118);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(111, 20);
			this.txtAge.TabIndex = 58;
			// 
			// txtLastname
			// 
			this.txtLastname.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtLastname.Location = new System.Drawing.Point(384, 127);
			this.txtLastname.Name = "txtLastname";
			this.txtLastname.Size = new System.Drawing.Size(173, 20);
			this.txtLastname.TabIndex = 57;
			// 
			// lblVehicle
			// 
			this.lblVehicle.AutoSize = true;
			this.lblVehicle.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVehicle.Location = new System.Drawing.Point(417, 246);
			this.lblVehicle.Name = "lblVehicle";
			this.lblVehicle.Size = new System.Drawing.Size(116, 19);
			this.lblVehicle.TabIndex = 56;
			this.lblVehicle.Text = "Vehicle Renting";
			// 
			// lblResidence
			// 
			this.lblResidence.AutoSize = true;
			this.lblResidence.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResidence.Location = new System.Drawing.Point(565, 184);
			this.lblResidence.Name = "lblResidence";
			this.lblResidence.Size = new System.Drawing.Size(76, 19);
			this.lblResidence.TabIndex = 55;
			this.lblResidence.Text = "Residence";
			// 
			// lblDriverslicense
			// 
			this.lblDriverslicense.AutoSize = true;
			this.lblDriverslicense.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDriverslicense.Location = new System.Drawing.Point(417, 307);
			this.lblDriverslicense.Name = "lblDriverslicense";
			this.lblDriverslicense.Size = new System.Drawing.Size(113, 19);
			this.lblDriverslicense.TabIndex = 54;
			this.lblDriverslicense.Text = "Drivers License";
			// 
			// lblDropoff
			// 
			this.lblDropoff.AutoSize = true;
			this.lblDropoff.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDropoff.Location = new System.Drawing.Point(35, 307);
			this.lblDropoff.Name = "lblDropoff";
			this.lblDropoff.Size = new System.Drawing.Size(105, 19);
			this.lblDropoff.TabIndex = 53;
			this.lblDropoff.Text = "Drop Off Date";
			// 
			// lblPickup
			// 
			this.lblPickup.AutoSize = true;
			this.lblPickup.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPickup.Location = new System.Drawing.Point(35, 246);
			this.lblPickup.Name = "lblPickup";
			this.lblPickup.Size = new System.Drawing.Size(100, 19);
			this.lblPickup.TabIndex = 52;
			this.lblPickup.Text = "Pick-Up Date";
			// 
			// lblAge
			// 
			this.lblAge.AutoSize = true;
			this.lblAge.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAge.Location = new System.Drawing.Point(578, 126);
			this.lblAge.Name = "lblAge";
			this.lblAge.Size = new System.Drawing.Size(35, 19);
			this.lblAge.TabIndex = 51;
			this.lblAge.Text = "Age";
			// 
			// lblFirstname
			// 
			this.lblFirstname.AutoSize = true;
			this.lblFirstname.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFirstname.Location = new System.Drawing.Point(34, 121);
			this.lblFirstname.Name = "lblFirstname";
			this.lblFirstname.Size = new System.Drawing.Size(85, 19);
			this.lblFirstname.TabIndex = 50;
			this.lblFirstname.Text = "First Name";
			// 
			// lblLastname
			// 
			this.lblLastname.AutoSize = true;
			this.lblLastname.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLastname.Location = new System.Drawing.Point(288, 121);
			this.lblLastname.Name = "lblLastname";
			this.lblLastname.Size = new System.Drawing.Size(81, 19);
			this.lblLastname.TabIndex = 49;
			this.lblLastname.Text = "Last Name";
			// 
			// txtFirstname
			// 
			this.txtFirstname.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtFirstname.Location = new System.Drawing.Point(135, 122);
			this.txtFirstname.Name = "txtFirstname";
			this.txtFirstname.Size = new System.Drawing.Size(137, 20);
			this.txtFirstname.TabIndex = 48;
			// 
			// lblTrajjRentalCompany
			// 
			this.lblTrajjRentalCompany.AutoSize = true;
			this.lblTrajjRentalCompany.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTrajjRentalCompany.Location = new System.Drawing.Point(153, 36);
			this.lblTrajjRentalCompany.Name = "lblTrajjRentalCompany";
			this.lblTrajjRentalCompany.Size = new System.Drawing.Size(488, 49);
			this.lblTrajjRentalCompany.TabIndex = 47;
			this.lblTrajjRentalCompany.Text = "TRAJJ RENTAL COMPANY";
			// 
			// FrmBooking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.GbxIdentification);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.txtDriverslicense);
			this.Controls.Add(this.cbxVehiclerenting);
			this.Controls.Add(this.dateTimePickerdropoffdate);
			this.Controls.Add(this.dateTimePickerPickupdate);
			this.Controls.Add(this.cbxResidence);
			this.Controls.Add(this.txtIdentification);
			this.Controls.Add(this.txtAge);
			this.Controls.Add(this.txtLastname);
			this.Controls.Add(this.lblVehicle);
			this.Controls.Add(this.lblResidence);
			this.Controls.Add(this.lblDriverslicense);
			this.Controls.Add(this.lblDropoff);
			this.Controls.Add(this.lblPickup);
			this.Controls.Add(this.lblAge);
			this.Controls.Add(this.lblFirstname);
			this.Controls.Add(this.lblLastname);
			this.Controls.Add(this.txtFirstname);
			this.Controls.Add(this.lblTrajjRentalCompany);
			this.Name = "FrmBooking";
			this.GbxIdentification.ResumeLayout(false);
			this.GbxIdentification.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxIdentification;
        private System.Windows.Forms.RadioButton rbtnPassport;
        private System.Windows.Forms.RadioButton rbtnId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtDriverslicense;
        private System.Windows.Forms.ComboBox cbxVehiclerenting;
        private System.Windows.Forms.DateTimePicker dateTimePickerdropoffdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPickupdate;
        private System.Windows.Forms.ComboBox cbxResidence;
        private System.Windows.Forms.TextBox txtIdentification;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblResidence;
        private System.Windows.Forms.Label lblDriverslicense;
        private System.Windows.Forms.Label lblDropoff;
        private System.Windows.Forms.Label lblPickup;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblTrajjRentalCompany;
    }
}