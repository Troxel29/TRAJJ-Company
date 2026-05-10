using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAJJ_Company;

namespace CARRENTALBUSINESS
{
    public partial class MDIadmin : Form
    {
        
        private string currentUserRole;
        private string currentUsername;
        private Timer clockTimer;

       
        private FrmBooking existingBooking = null;
        private FrmHomePage existingHomePage = null;
        private FrmCarListings existingCarListings = null;
        private FrmBookingListings existingBookingListings = null;


        public MDIadmin(string userRole, string username)
        {
            InitializeComponent();
            currentUserRole = userRole;
            currentUsername = username;
            this.Load += MDIadmin_Load;
            notifyIcon1.MouseDoubleClick += notifyIcon_MouseDoubleClick;
        }

        protected override void OnResize(EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
            base.OnResize(e);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void MDIadmin_Load(object sender, EventArgs e)
        {
            UpdateStatusDisplay();
            StartClock();
        }

        private void UpdateStatusDisplay()
        {
            
            lblUserInfo.Text = $"Logged in as: {currentUsername}";
            lblUserRole.Text = $"Role: {currentUserRole}";

            
            if (currentUserRole == "Admin")
            {
                lblUserRole.ForeColor = Color.Green;
            }
            else if (currentUserRole == "Customer")
            {
                lblUserRole.ForeColor = Color.Blue;
            }
        }

        private void StartClock()
        {
            clockTimer = new Timer();
            clockTimer.Interval = 1000;
            clockTimer.Tick += (s, e) =>
            {
                if (lblDateTime != null)
                {
                    lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                }
            };
            clockTimer.Start();
        }

        private void bOOKINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (existingBooking == null || existingBooking.IsDisposed)
            {
                
                existingBooking = new FrmBooking();
                existingBooking.MdiParent = this;
                existingBooking.Show();

                
                existingBooking.FormClosed += (s, args) => existingBooking = null;
            }
            else
            {
                
                existingBooking.BringToFront();
                existingBooking.WindowState = FormWindowState.Normal;
            }
        }

        // HOME PAGE Form - Prevents multiple instances
        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (existingHomePage == null || existingHomePage.IsDisposed)
            {
                
                existingHomePage = new FrmHomePage();
                existingHomePage.MdiParent = this;
                existingHomePage.Show();

                
                existingHomePage.FormClosed += (s, args) => existingHomePage = null;
            }
            else
            {
                
                existingHomePage.BringToFront();
                existingHomePage.WindowState = FormWindowState.Normal;
            }
        }

        // VEHICLES/CAR LISTINGS Form - Prevents multiple instances
        private void vEHICLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (existingCarListings == null || existingCarListings.IsDisposed)
            {
               
                existingCarListings = new FrmCarListings();
                existingCarListings.MdiParent = this;
                existingCarListings.Show();

                
                existingCarListings.FormClosed += (s, args) => existingCarListings = null;
            }
            else
            {
                
                existingCarListings.BringToFront();
                existingCarListings.WindowState = FormWindowState.Normal;
            }
        }

        // BOOKING LIST Form - Prevents multiple instances
        private void bOOKINGLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (existingBookingListings == null || existingBookingListings.IsDisposed)
            {
                
                existingBookingListings = new FrmBookingListings();
                existingBookingListings.MdiParent = this;
                existingBookingListings.Show();

               
                existingBookingListings.FormClosed += (s, args) => existingBookingListings = null;
            }
            else
            {
                
                existingBookingListings.BringToFront();
                existingBookingListings.WindowState = FormWindowState.Normal;
            }
        }

        
        private void mnuLogout_Click_1(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                this.Close();

             
                FrmLogin login = new FrmLogin();
                login.Show();
            }
        }

        
        private void mnuExit_Click_1(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               
                Application.Exit();
            }
        }
    }
}