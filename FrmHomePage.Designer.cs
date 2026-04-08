namespace CARRENTALBUSINESS
{
    partial class FrmHomePage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomePage));
			this.lblTrajjRentalCompany = new System.Windows.Forms.Label();
			this.HomePagePicture = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.HomePagePicture)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTrajjRentalCompany
			// 
			this.lblTrajjRentalCompany.AutoSize = true;
			this.lblTrajjRentalCompany.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTrajjRentalCompany.Location = new System.Drawing.Point(144, 26);
			this.lblTrajjRentalCompany.Name = "lblTrajjRentalCompany";
			this.lblTrajjRentalCompany.Size = new System.Drawing.Size(488, 49);
			this.lblTrajjRentalCompany.TabIndex = 48;
			this.lblTrajjRentalCompany.Text = "TRAJJ RENTAL COMPANY";
			// 
			// HomePagePicture
			// 
			this.HomePagePicture.Image = ((System.Drawing.Image)(resources.GetObject("HomePagePicture.Image")));
			this.HomePagePicture.Location = new System.Drawing.Point(195, 90);
			this.HomePagePicture.Name = "HomePagePicture";
			this.HomePagePicture.Size = new System.Drawing.Size(379, 287);
			this.HomePagePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.HomePagePicture.TabIndex = 49;
			this.HomePagePicture.TabStop = false;
			// 
			// FrmHomePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Turquoise;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.HomePagePicture);
			this.Controls.Add(this.lblTrajjRentalCompany);
			this.Name = "FrmHomePage";
			this.Text = "FrmHomePage";
			((System.ComponentModel.ISupportInitialize)(this.HomePagePicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrajjRentalCompany;
        private System.Windows.Forms.PictureBox HomePagePicture;
    }
}