using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace Air_flight
{
    public partial class frmLogin : Form
    {
        private DataTable dt = new DataTable();
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=customerbooking.accdb";
        public static string staffname;
        public static string staffid;
        public static bool customerLogin=false;

        public frmLogin()
        {
            InitializeComponent();
            lblShowStaff.Hide();
        }

        private void Table(string sqlStr)
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
            dt.Clear();
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            lblError.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
                if (txtUsername.Text == dt.Rows[i]["StaffID"].ToString() || txtUsername.Text == dt.Rows[i]["Email"].ToString())
                {
                    if (dt.Rows[i]["Gender"].ToString() == "M")
                    {
                        lblShowStaff.Text = dt.Rows[i]["Position"].ToString() + " Mr." + dt.Rows[i]["StaffName"].ToString();
                    }
                    else {
                        lblShowStaff.Text = dt.Rows[i]["Position"].ToString() + " Ms." + dt.Rows[i]["StaffName"].ToString();
                    }
                    lblShowStaff.Show();
                }
            if (txtUsername.Text == "cheong1")
                pictureBox1.Image = Properties.Resources.Cheong;
            else if (txtUsername.Text == "fai1")
                pictureBox1.Image = Properties.Resources.Fai;
            else if (txtUsername.Text == "fan1")
                pictureBox1.Image = Properties.Resources.Fan;
            else if (txtUsername.Text == "han1")
                pictureBox1.Image = Properties.Resources.Han;
            else if (txtUsername.Text == "kam1")
                pictureBox1.Image = Properties.Resources.Kam;
            else if (txtUsername.Text == "kuen1")
                pictureBox1.Image = Properties.Resources.Kuen;
            else if (txtUsername.Text == "lung1")
                pictureBox1.Image = Properties.Resources.Lung;
            else if (txtUsername.Text == "ming1")
                pictureBox1.Image = Properties.Resources.Ming;
            else if (txtUsername.Text == "ning1")
                pictureBox1.Image = Properties.Resources.Ning;
            else if (txtUsername.Text == "on1")
                pictureBox1.Image = Properties.Resources.On;
            else if (txtUsername.Text == "shun1")
                pictureBox1.Image = Properties.Resources.Shun;
            else if (txtUsername.Text == "tak1")
                pictureBox1.Image = Properties.Resources.Tak;
            else if (txtUsername.Text == "yum1")
                pictureBox1.Image = Properties.Resources.yum;
            else
                pictureBox1.Image = null;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Table("Select * from staff");
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtUsername.Text) && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblError.Text = "Please input username and password";
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                lblError.Text = "Please input username";
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblError.Text = "Please input password";
                return;
            }
            frmModuleSelection menu = new frmModuleSelection();
            Boolean login = false;
            if (txtUsername.Text.Substring(0, 1).Equals("C"))
            {
                Regex checkphone = new Regex(@"^[2-35-69]{1}[0-9]{7}$");
                if (!checkphone.IsMatch(txtPassword.Text))
                {
                    MessageBox.Show("Customer login password should be contact number and not include 0,1,4,7,8 in first number and 8digit");
                    return;
                }
                string Sql = "select custid,surname,givenname,gender,contact from customer where custid='" + txtUsername.Text + "' and contact=" + txtPassword.Text;
                OleDbConnection con = new OleDbConnection(connStr);
                OleDbCommand cmd = new OleDbCommand(Sql, con);
                con.Open();
                OleDbDataReader DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    if (DR[0].ToString().Equals(txtUsername.Text) && DR[4].ToString().Equals(txtPassword.Text))
                    {
                        string loginName = DR[1].ToString() + " " + DR[2].ToString();
                        string position = "";
                        if (DR[3].Equals("M"))
                        {
                            position = "Mr ";
                        }
                        else
                        {
                            position = "Mrs ";
                        }
                        frmHotelSchedule.staffname = loginName;
                        frmAir.staffname = loginName;
                        frmAdmin.staffname = loginName;
                        frmAllBookings.staffname = loginName;
                        frmAttraction.staffname = loginName;
                        frmAttractionBooking.staffname = loginName;
                        frmCruiseBooking.staffname = loginName;
                        frmCruiseTour.staffname = loginName;
                        frmHotelOrder.staffname = loginName;
                        frmOrder.staffname = loginName;
                        frmTransport.staffname = loginName;
                        frmModuleSelection.staffname = loginName;
                        frmModuleSelection.position = position;
                        login = true;
                        staffid = DR[0].ToString();
                        customerLogin = true;
                        this.Hide();
                        menu.Show();
                        txtUsername.Clear();
                        txtPassword.Clear();
                        break;
                    }
                }
                con.Close();
            }
            for (int i = 0; i < dt.Rows.Count; i++)
                if ((txtUsername.Text == dt.Rows[i]["StaffID"].ToString() || txtUsername.Text==dt.Rows[i]["Email"].ToString())&& txtPassword.Text==dt.Rows[i]["Pass"].ToString())
                {
                    string loginName = dt.Rows[i]["StaffName"].ToString();
                    string position = dt.Rows[i]["Position"].ToString();
                    frmHotelSchedule.staffname = loginName;
                    frmAir.staffname = loginName;
                    frmAdmin.staffname = loginName;
                    frmAllBookings.staffname = loginName;
                    frmAttraction.staffname = loginName;
                    frmAttractionBooking.staffname = loginName;
                    frmCruiseBooking.staffname = loginName;
                    frmCruiseTour.staffname = loginName;
                    frmHotelOrder.staffname = loginName;
                    frmOrder.staffname = loginName;
                    frmTransport.staffname = loginName;
                    frmModuleSelection.staffname = loginName;
                    frmModuleSelection.position = position;
                    login = true;
                    customerLogin = false;
                    staffid = dt.Rows[i]["StaffID"].ToString();
                    this.Hide();
                    menu.Show();
                    txtUsername.Clear();
                    txtPassword.Clear();
                    break;
                }
            if (!login)
                lblError.Text = "Incorrect username or password";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblShowStaff_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = "Time : " + DateTime.Now.ToString();
        }
    }
}
