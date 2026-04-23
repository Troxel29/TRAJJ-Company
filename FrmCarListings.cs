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
    public partial class FrmCarListings : Form
    {
        public FrmCarListings()
        {
            InitializeComponent();
            LoadCars();
            StartFadeIn();
        }

        private void LoadCars()
        {
            var cars = Database.GetCars();
            dataGridView1.DataSource = cars;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["ImagePath"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.LightBlue;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private Timer fadeTimer;
        private float opacity = 0;

        private void StartFadeIn()
        {
            fadeTimer = new Timer { Interval = 50 };
            fadeTimer.Tick += (s, e) =>
            {
                opacity += 0.05f;
                if (opacity >= 1) { fadeTimer.Stop(); opacity = 1; }
                this.Opacity = opacity;
            };
            fadeTimer.Start();
        }
    }
}