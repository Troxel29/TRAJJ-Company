using CARRENTALBUSINESS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrajjRentalFrm;

namespace TRAJJ_Company
{
    public partial class FrmLogin : Form
    {
        private Timer animationTimer;
        private int direction = 1;
        private int carX = 0;
        private int carSpeed = 4;

        public FrmLogin()
        {
            InitializeComponent();
            animationTimer = new Timer();
            animationTimer.Interval = 50;
            animationTimer.Tick += AnimationTimer_Tick;
            this.Load += FrmLogin_Load;
            this.Paint += FrmLogin_Paint;
            this.DoubleBuffered = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;


            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Login successful!");
                
                MDIadmin MDIadmin = new MDIadmin();
                MDIadmin.Show();

                this.Hide();


            }
            else
            {
                MessageBox.Show("Please enter both username and password.");

                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

            txtUsername.Focus();
        }

        // Animation: Starts the timer when the form loads to begin animations
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            carX = -80;
            animationTimer.Start();
        }

        // Animation: Moves the welcome label and car across the screen
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            lblTrajRentalsJa.Left += 5 * direction;
            if (lblTrajRentalsJa.Right >= this.ClientSize.Width || lblTrajRentalsJa.Left <= 0)
            {
                direction = -direction;
            }

            carX += carSpeed;
            if (carX > this.ClientSize.Width)
            {
                carX = -80;
            }
            this.Invalidate();
        }

        // Draw car and shadow
        private void FrmLogin_Paint(object sender, PaintEventArgs e)
        {
            DrawCar(e.Graphics, carX, this.ClientSize.Height - 120);
        }

        private void DrawCar(Graphics g, int x, int y)
        {
            // Shadow
            using (Brush shadowBrush = new SolidBrush(Color.FromArgb(60, 0, 0, 0)))
            {
                g.FillEllipse(shadowBrush, x + 5, y + 55, 60, 12);
            }

            // Car body
            using (Pen bodyPen = new Pen(Color.DimGray, 2))
            using (Brush bodyBrush = new SolidBrush(Color.FromArgb(220, 50, 50)))
            {
                g.FillRectangle(bodyBrush, x + 10, y + 30, 50, 20);
                g.DrawRectangle(bodyPen, x + 10, y + 30, 50, 20);
            }

            // Cabin/Windshield
            using (Brush cabinBrush = new SolidBrush(Color.FromArgb(150, 200, 220)))
            using (Pen cabinPen = new Pen(Color.FromArgb(100, 150, 180), 1))
            {
                g.FillRectangle(cabinBrush, x + 30, y + 18, 20, 12);
                g.DrawRectangle(cabinPen, x + 30, y + 18, 20, 12);
            }

            // Wheels
            using (Brush wheelBrush = new SolidBrush(Color.Black))
            {
                g.FillEllipse(wheelBrush, x + 15, y + 48, 10, 10);
                g.FillEllipse(wheelBrush, x + 45, y + 48, 10, 10);
            }

            // Wheel rims
            using (Pen rimPen = new Pen(Color.DarkGray, 1))
            {
                g.DrawEllipse(rimPen, x + 15, y + 48, 10, 10);
                g.DrawEllipse(rimPen, x + 45, y + 48, 10, 10);
            }
        }
    }
}
