using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_flight
{
    public partial class ucSlideMenu : UserControl
    {
        public ucSlideMenu()
        {
            InitializeComponent();
        }

        private void lblSlideIn_Click(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X, 0);
            do
            {
                this.Location = new Point(this.Location.X, this.Location.Y - 180);
            } while (this.Location.Y > -180);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmHotelSchedule hotel = new frmHotelSchedule();
            hotel.Show();
            this.Parent.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmAir air = new frmAir();
            air.Show();
            this.Parent.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmCruiseTour cruise = new frmCruiseTour();
            cruise.Show();
            this.Parent.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmAttraction attraction = new frmAttraction();
            attraction.Show();
            this.Parent.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frmTransport transport = new frmTransport();
            transport.Show();
            this.Parent.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            frmAllBookings booking = new frmAllBookings();
            booking.Show();
            this.Parent.Hide();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            frmModuleSelection module = new frmModuleSelection();
            module.Show();
            this.Parent.Hide();
        }
    }
}
