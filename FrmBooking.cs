using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARRENTALBUSINESS
{
	public partial class FrmBooking : Form
	{
		public FrmBooking()
		{
			InitializeComponent();
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			string Firstname = txtFirstname.Text;
			string Lastname = txtLastname.Text;
			int Age = int.Parse(txtAge.Text);
			string Identification = txtIdentification.Text;
			string Driverslicense = txtDriverslicense.Text;
			string Email = txtEmail.Text;



			if (txtFirstname.Text == "")
			{
				MessageBox.Show("Please enter your first name!", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (txtLastname.Text == "")
			{
				MessageBox.Show("Please enter your last name!", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			else if (txtAge.Text == "")
			{
				MessageBox.Show("You must be at least 18 years old to make a reservation!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if ((rbtnId.Checked == false) && (rbtnPassport.Checked == false))
			{
				MessageBox.Show("Please select", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (dateTimePickerPickupdate == null)
			{
				MessageBox.Show("Please select your pick up date.", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				dateTimePickerPickupdate.Focus();
			}
			else if (dateTimePickerdropoffdate == null)
			{
				MessageBox.Show("Please select your drop off date.", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				dateTimePickerdropoffdate.Focus();
			}
			else if (txtIdentification.Text == "")
			{
				MessageBox.Show("Please enter your identification number!", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (txtDriverslicense.Text == "")
			{
				MessageBox.Show("Please enter your driver's license number!", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (txtEmail.Text == "")
			{
				MessageBox.Show("Please enter your email address.", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtEmail.Focus();
			}

			else
			{
				BookingClass booking = new BookingClass(Firstname, Lastname, Age, Identification, Driverslicense, Email);
				MessageBox.Show("Your reservation has been successfully submitted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
		}

			private void btnBack_Click(object sender, EventArgs e)
			{
				if (MessageBox.Show("Returning to the previous page.", "Back", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.Yes)
				{
					this.Close();
				}
			}
		
    }
}
