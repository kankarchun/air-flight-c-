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
using System.Globalization;
using System.Text.RegularExpressions;

namespace Air_flight
{
    public partial class frmHotelOrder : Form
    {
        public static string staffname;
        public double firstsubtotal=0,secondsubtotal=0;
        public double firstprice = 0,secondprice=0;
        public frmHotelOrder order;
        private frmHotelSchedule hotel;
        public static bool _second;
        private string custconnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=customerBooking.accdb";
        public string custid = "";
        public int numRoom_first, numRoom_second;

        public frmHotelOrder()
        {
            InitializeComponent();
        }
        public frmHotelOrder(frmHotelOrder hotelorder)
        {
            InitializeComponent();
            order = hotelorder;
        }
        public frmHotelOrder(frmHotelSchedule HotelSchedule)
        {
            InitializeComponent();
            hotel = HotelSchedule;
        }

        private void frmHotelOrder_Load(object sender, EventArgs e)
        {
            string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=CustomerBooking.accdb";
            using (OleDbConnection con = new OleDbConnection(connStr))
            {
                OleDbCommand cmd = new OleDbCommand("Select surname,givenname from customer", con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection surnameCollection = new AutoCompleteStringCollection();
                AutoCompleteStringCollection givennameCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    surnameCollection.Add(reader.GetString(0));
                    givennameCollection.Add(reader.GetString(1));
                }
                textBox6.AutoCompleteCustomSource = surnameCollection;
                textBox5.AutoCompleteCustomSource = givennameCollection;
                con.Close();
            }
            DateTime d1 = DateTime.Parse(label48.Text);
            DateTime d2 = DateTime.Parse(label49.Text);
            label37.Text = ((d2 - d1).TotalDays).ToString();
            label38.Text = ((d2 - d1).TotalDays).ToString();

            if (_second == false)
            {
                numericUpDown4.Enabled = false;
                firstprice = Double.Parse(label51.Text);
                numRoom_first = Convert.ToInt32(numericUpDown2.Value);
                int firstnight = Int32.Parse(label37.Text);
                firstsubtotal = (firstprice * firstnight * numRoom_first);
                double grandTotal = firstsubtotal + secondsubtotal;
                label57.Text = grandTotal.ToString();
            }

            pictureBox1.Image = Properties.Resources.TT_Hotel;
            label12.Text = "Staff: " + staffname;
            timer1.Start();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmHotelSchedule.second = true;
            frmHotelSchedule a = new frmHotelSchedule(this);
            DateTime dt1 = Convert.ToDateTime(label48.Text);
            DateTime dt2 = Convert.ToDateTime(label49.Text);
            _second = true;
            a.dateTimePicker1.Value = dt1;
            a.dateTimePicker2.Value = dt2;
            a.dateTimePicker1.Enabled = false;
            a.dateTimePicker2.Enabled = false;
            a.informationBindingSource.Filter = "hotel_chi_name='" +label46.Text+ "'";
            a.Show();
            this.Visible = false;
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmHotelSchedule.second = false;
            frmHotelSchedule hotel = new frmHotelSchedule();
            hotel.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            firstprice = Double.Parse(label51.Text);
            numRoom_first = Convert.ToInt32(numericUpDown2.Value);
            int firstnight = Int32.Parse(label37.Text);
            firstsubtotal = (firstprice * firstnight * numRoom_first);
            double grandTotal = firstsubtotal + secondsubtotal;
            label57.Text = grandTotal.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            textBox5.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox5.Text.ToLower());
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            secondprice = Double.Parse(label7.Text);
            numRoom_second = Convert.ToInt32(numericUpDown4.Value);
            int secondnight = Int32.Parse(label38.Text);
            secondsubtotal = (secondprice * secondnight * numRoom_second);
            double grandTotal = firstsubtotal + secondsubtotal;
            label57.Text = grandTotal.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string phone = "";
            Regex checkphone = new Regex(@"^[2-35-69]{1}[0-9]{7}$");
            if (string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Please enter customer surname, given name, and contact");
                return;
            }
            if (checkphone.IsMatch(textBox7.Text))
            {
                phone = textBox7.Text;
            }
            else
            {
                MessageBox.Show("Contact number should not include 0,1,4,7,8 in first number and 8digit");
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a payment method in the combo box");
                return;
            }



            DataTable dt = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select * from customer", custconnStr);
            dt.Clear();
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (textBox6.Text == dt.Rows[i]["Surname"].ToString() && textBox5.Text == dt.Rows[i]["GivenName"].ToString() && textBox7.Text == dt.Rows[i]["Contact"].ToString())
                {
                    custid = dt.Rows[i]["CustID"].ToString();
                    break;
                }
            }
            if (custid == "")
            {
                string cmdstr = "SELECT COUNT(*) FROM customer";
                using (OleDbConnection conn = new OleDbConnection(custconnStr))
                using (OleDbCommand command = new OleDbCommand(cmdstr, conn))
                {
                    conn.Open();
                    int count = (int)command.ExecuteScalar();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Customer(CustID,Surname,GivenName,Contact) VALUES (@id,@surname,@givenName,@contact)";
                    cmd.Parameters.AddWithValue("@id", "C0" + (count + 1));
                    cmd.Parameters.AddWithValue("@surname", textBox6.Text);
                    cmd.Parameters.AddWithValue("@givenName", textBox5.Text);
                    cmd.Parameters.AddWithValue("@contact", textBox7.Text);
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                DataTable dt1 = new DataTable();
                OleDbDataAdapter dataAdapter1 = new OleDbDataAdapter("Select * from customer", custconnStr);
                dt1.Clear();
                dataAdapter1.Fill(dt1);
                dataAdapter1.Dispose();
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    if (textBox6.Text == dt1.Rows[i]["Surname"].ToString() && textBox5.Text == dt1.Rows[i]["GivenName"].ToString() && textBox7.Text == dt1.Rows[i]["Contact"].ToString())
                    {
                        custid = dt1.Rows[i]["CustID"].ToString();
                        break;
                    }
                }
            }
            frmBookConfirm confirm = new frmBookConfirm();
            double priceFirst = firstsubtotal;
            double priceSecond = secondsubtotal;
            DateTime checkindate= DateTime.Parse(label48.Text);
            DateTime checkoutdate= DateTime.Parse(label49.Text);
            if (confirm.ShowDialog() == DialogResult.OK)
            {
                if (_second == false)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    OleDbConnection con = new OleDbConnection(custconnStr);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO HotelBooking(HotelRoomID,HotelRoomName,NumNight,NumRoom,Price,OrderDate,orderBy,CustID,Checkin,Checkout,payment) "
                        + "VALUES (@id,@roomname,@numNight,@numRoom,@price,@orderdate,@orderBy,@custid,@checkin,@checkout,@payment)";
                    cmd.Parameters.AddWithValue("@id", Int32.Parse(label33.Text));
                    cmd.Parameters.AddWithValue("@roomname", label50.Text);
                    cmd.Parameters.AddWithValue("@numNight", Int32.Parse(label37.Text));
                    cmd.Parameters.AddWithValue("@numRoom", Convert.ToInt32(numericUpDown2.Value));
                    cmd.Parameters.AddWithValue("@price", priceFirst);
                    cmd.Parameters.AddWithValue("@orderdate", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("@orderBy", frmLogin.staffid);
                    cmd.Parameters.AddWithValue("@custid", custid);
                    cmd.Parameters.AddWithValue("@checkin", checkindate);
                    cmd.Parameters.AddWithValue("@checkout", checkoutdate);
                    cmd.Parameters.AddWithValue("@payment", comboBox1.GetItemText(comboBox1.SelectedItem));
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hotel room ordered successfully.");
                    con.Close();
                }
                else
                {
                    OleDbCommand cmd = new OleDbCommand();
                    OleDbConnection con = new OleDbConnection(custconnStr);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO HotelBooking(HotelRoomID,HotelRoomName,NumNight,NumRoom,Price,OrderDate,orderBy,CustID,Checkin,Checkout,payment) "
                        + "VALUES (@id,@roomname,@numNight,@numRoom,@price,@orderdate,@orderBy,@custid,@checkin,@checkout,@payment)";
                    cmd.Parameters.AddWithValue("@id", Int32.Parse(label33.Text));
                    cmd.Parameters.AddWithValue("@roomname", label50.Text);
                    cmd.Parameters.AddWithValue("@numNight", Int32.Parse(label37.Text));
                    cmd.Parameters.AddWithValue("@numRoom", Convert.ToInt32(numericUpDown2.Value));
                    cmd.Parameters.AddWithValue("@price", priceFirst);
                    cmd.Parameters.AddWithValue("@orderdate", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("@orderBy", frmLogin.staffid);
                    cmd.Parameters.AddWithValue("@custid", custid);
                    cmd.Parameters.AddWithValue("@checkin", checkindate);
                    cmd.Parameters.AddWithValue("@checkout", checkoutdate);
                    cmd.Parameters.AddWithValue("@payment", comboBox1.GetItemText(comboBox1.SelectedItem));
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    OleDbCommand cmd_back = new OleDbCommand();
                    OleDbConnection con_back = new OleDbConnection(custconnStr);
                    cmd_back.CommandType = CommandType.Text;
                    cmd_back.CommandText = "INSERT INTO HotelBooking(HotelRoomID,NumNight,NumRoom,Price,OrderDate,orderBy,CustID,Checkin,Checkout,payment) "
                        + "VALUES (@id,@numNight,@numRoom,@price,@orderdate,@orderBy,@custid,@checkin,@checkout,@payment)";
                    cmd_back.Parameters.AddWithValue("@id", Int32.Parse(label22.Text));
                    cmd_back.Parameters.AddWithValue("@numNight", Int32.Parse(label38.Text));
                    cmd_back.Parameters.AddWithValue("@numRoom", Convert.ToInt32(numericUpDown4.Value));
                    cmd_back.Parameters.AddWithValue("@price", priceSecond);
                    cmd_back.Parameters.AddWithValue("@orderdate", DateTime.Now.ToShortDateString());
                    cmd_back.Parameters.AddWithValue("@orderBy", frmLogin.staffid);
                    cmd_back.Parameters.AddWithValue("@custid", custid);
                    cmd_back.Parameters.AddWithValue("@checkin", checkindate);
                    cmd_back.Parameters.AddWithValue("@checkout", checkoutdate);
                    cmd_back.Parameters.AddWithValue("@payment", comboBox1.GetItemText(comboBox1.SelectedItem));
                    cmd_back.Connection = con_back;
                    con_back.Open();
                    cmd_back.ExecuteNonQuery();
                    MessageBox.Show("Hotel room ordered successfully.");
                    con_back.Close();
                }
            }
            else
            {
                confirm.Close();
                return;
            }
            frmModuleSelection menu = new frmModuleSelection();
            menu.Show();
            this.Close();
        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label19.Text = "Time : " + DateTime.Now.ToString();
        }
    }
}
