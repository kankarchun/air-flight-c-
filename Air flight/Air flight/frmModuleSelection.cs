using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_flight
{
    public partial class frmModuleSelection : Form
    {
        public static string staffname,position;

        public frmModuleSelection()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void frmModuleSelection_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.TT_General;
            label2.Text = "Time : " + DateTime.Now;
            label1.Text = "Welcome! " + position + " , " + staffname;
            if (frmLogin.staffid == "cheong1")
                picStaffIcon.Image = Properties.Resources.Cheong;
            else if (frmLogin.staffid == "fai1")
                picStaffIcon.Image = Properties.Resources.Fai;
            else if (frmLogin.staffid == "fan1")
                picStaffIcon.Image = Properties.Resources.Fan;
            else if (frmLogin.staffid == "han1")
                picStaffIcon.Image = Properties.Resources.Han;
            else if (frmLogin.staffid == "kam1")
                picStaffIcon.Image = Properties.Resources.Kam;
            else if (frmLogin.staffid == "kuen1")
                picStaffIcon.Image = Properties.Resources.Kuen;
            else if (frmLogin.staffid == "lung1")
                picStaffIcon.Image = Properties.Resources.Lung;
            else if (frmLogin.staffid == "ming1")
                picStaffIcon.Image = Properties.Resources.Ming;
            else if (frmLogin.staffid == "ning1")
                picStaffIcon.Image = Properties.Resources.Ning;
            else if (frmLogin.staffid == "on1")
                picStaffIcon.Image = Properties.Resources.On;
            else if (frmLogin.staffid == "shun1")
                picStaffIcon.Image = Properties.Resources.Shun;
            else if (frmLogin.staffid == "tak1")
                picStaffIcon.Image = Properties.Resources.Tak;
            else if (frmLogin.staffid == "yum1")
                picStaffIcon.Image = Properties.Resources.yum;
            else
                picStaffIcon.Image = null;

            if (frmLogin.customerLogin)
            {
                button8.Visible = false;
                button5.Visible = false;
                picStaffIcon.Visible = false;
                label11.Visible = false;
                label9.Visible = false;
                label13.Visible = false;

            }
            if (position.Equals("Center Manager"))
                button8.Visible = true;
            else
            {
                button8.Visible = false;
                label11.Visible = false;
            }
            timer1.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAir air = new frmAir();
            air.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCruiseTour cruise = new frmCruiseTour();
            cruise.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAttraction attraction = new frmAttraction();
            attraction.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmAllBookings booking = new frmAllBookings();
            booking.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmHotelSchedule hotel = new frmHotelSchedule();
            hotel.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmTransport transport = new frmTransport();
            transport.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            admin.Show();
            this.Hide();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Gold;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Transparent;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = System.Drawing.Color.Aqua;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.Color.Transparent;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = System.Drawing.Color.LightBlue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = System.Drawing.Color.Transparent;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackColor = System.Drawing.Color.LightGreen;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = System.Drawing.Color.Transparent;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.BackColor = System.Drawing.Color.LightGreen;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = System.Drawing.Color.Transparent;
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            button7.BackColor = System.Drawing.Color.Silver;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = System.Drawing.Color.Transparent;
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            button6.BackColor = System.Drawing.Color.YellowGreen;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = System.Drawing.Color.Transparent;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmProfile profile = new frmProfile();
            profile.Show();
        }

        private void picStaffIcon_Click(object sender, EventArgs e)
        {
            frmProfile profile = new frmProfile();
            profile.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Text = "Time : " + DateTime.Now.ToString();
        }
    }
}
