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
    public partial class frmOrder : Form
    {
        public static string staffname;
        private int adult ;
        private int child ;
        private int infant ;
        private int backadult, backchild, backinfant;
        private frmAir a;
        public frmOrder place;
        public static bool _back;
        private int subtotal=0,backsubtotal=0;
        public string custid="";
        private string custconnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=customerBooking.accdb";

        public frmOrder()
        {
            InitializeComponent();
        }

        public frmOrder(frmAir air)
        {
            InitializeComponent();
            a = air;
        }

        public frmOrder(frmOrder place)
        {
            InitializeComponent();
            this.place = place;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {
            
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'customerBookingDataSet.FlightBooking' 資料表。您可以視需要進行移動或移除。
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

            pictureBox1.Image = Properties.Resources.TT_Air;
            if (_back == false)
            {
                numericUpDown6.ReadOnly = true;
                numericUpDown5.ReadOnly = true;
                numericUpDown4.ReadOnly = true;
                adult = Int32.Parse(label75.Text);
                child = Int32.Parse(label69.Text);
                infant = Int32.Parse(label63.Text);
                int adult_person = Convert.ToInt32(numericUpDown1.Value);
                int child_person = Convert.ToInt32(numericUpDown2.Value);
                int infant_person = Convert.ToInt32(numericUpDown3.Value);
                label77.Text = (adult * adult_person).ToString();
                subtotal = (adult * adult_person) + (child * child_person) + (infant * infant_person);
                label54.Text = subtotal.ToString();
                int grandtotal = subtotal;
                label57.Text = grandtotal.ToString();
            }
            timer1.Start();
            label12.Text = "Staff: " + staffname;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAir.back = true;
            _back = true;
            frmAir a = new frmAir(this);
            a.Show();
            this.Visible = false;
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
            Regex checkCity = new Regex(@"^[A-za-z]+$");
            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {
                if (checkCity.IsMatch(textBox4.Text))
                {
                    textBox4.Text = textBox4.Text;
                }
                else
                {
                    MessageBox.Show("The nationality should be upper case letter or lower case letter");
                    textBox4.Clear();
                    return;
                }
            }
            Regex checkPassport = new Regex(@"^[A-PR-WY][1-9]\d\s?\d{4}[1-9]$");
            if (!string.IsNullOrWhiteSpace(textBox11.Text))
            {
                if (checkPassport.IsMatch(textBox11.Text))
                {
                    textBox11.Text = textBox11.Text;
                }
                else
                {
                    MessageBox.Show("Passport number is not correct format, first character cannot be Q, X and Z and 8digit");
                    return;
                }
            }
            if (label54.Text.Equals("0") && _back==false)
            {
                MessageBox.Show("Please order at least one flight ticket");
                return;
            }else if(label10.Text.Equals("0") && _back == true)
            {
                MessageBox.Show("Please order at least one return ticket");
                return;
            }
            else if (label54.Text.Equals("0") && _back == true && label10.Text.Equals("0"))
            {
                MessageBox.Show("Please order at least one return ticket and one flight ticket");
                return;
            }
            frmBookConfirm confirm = new frmBookConfirm();
            
            if (confirm.ShowDialog() == DialogResult.OK)
            {
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
                    cmd.CommandText = "INSERT INTO Customer(CustID,Surname,GivenName,Contact,Nationality,Passport) VALUES (@id,@surname,@givenName,@contact,@nation,@passport)";
                    cmd.Parameters.AddWithValue("@id", "C0" + (count + 1));
                    cmd.Parameters.AddWithValue("@surname", textBox6.Text);
                    cmd.Parameters.AddWithValue("@givenName", textBox5.Text);
                    cmd.Parameters.AddWithValue("@contact", textBox7.Text);
                    if (!string.IsNullOrWhiteSpace(textBox4.Text))
                        cmd.Parameters.AddWithValue("@nation", textBox4.Text);
                    else
                        cmd.Parameters.AddWithValue("@nation", "");
                    if (!string.IsNullOrWhiteSpace(textBox11.Text))
                        cmd.Parameters.AddWithValue("@passport", textBox11.Text);
                    else
                        cmd.Parameters.AddWithValue("@passport", "");
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
            int adultsub = adult * Convert.ToInt32(numericUpDown1.Value);
            int childsub = child * Convert.ToInt32(numericUpDown2.Value);
            int infantsub = infant * Convert.ToInt32(numericUpDown3.Value);
            int adultnum = Convert.ToInt32(numericUpDown1.Value);
            int childnum = Convert.ToInt32(numericUpDown2.Value);
            int infantnum = Convert.ToInt32(numericUpDown3.Value);
            int adultsub_back = adult * Convert.ToInt32(numericUpDown6.Value);
            int childsub_back = child * Convert.ToInt32(numericUpDown5.Value);
            int infantsub_back = infant * Convert.ToInt32(numericUpDown4.Value);
            int adultnum_back = Convert.ToInt32(numericUpDown6.Value);
            int childnum_back = Convert.ToInt32(numericUpDown5.Value);
            int infantnum_back = Convert.ToInt32(numericUpDown4.Value);
                if (_back == false)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    OleDbConnection con = new OleDbConnection(custconnStr);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO FlightBooking(FlightID,flightNo,flightClass,AdultNum,ChildNum,InfantNum,AdultPrice,ChildPrice,InfantPrice,OrderDate,OrderBy,custID,payment) "
                        + "VALUES (@id,@no,@class,@adultnum,@childnum,@infantnum,@adultprice,@childprice,@infantprice,@orderdate,@orderby,@custid,@payment)";
                    cmd.Parameters.AddWithValue("@id", Int32.Parse(label51.Text));
                    cmd.Parameters.AddWithValue("@no", label73.Text);
                    cmd.Parameters.AddWithValue("@class", label49.Text);
                    cmd.Parameters.AddWithValue("@adultnum", adultnum);
                    cmd.Parameters.AddWithValue("@childnum", childnum);
                    cmd.Parameters.AddWithValue("@infantnum", infantnum);
                    cmd.Parameters.AddWithValue("@adultprice", adultsub);
                    cmd.Parameters.AddWithValue("@childprice", childsub);
                    cmd.Parameters.AddWithValue("@infantprice", infantsub);
                    cmd.Parameters.AddWithValue("@orderdate", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("@orderby", frmLogin.staffid);
                    cmd.Parameters.AddWithValue("@custid", custid);
                    cmd.Parameters.AddWithValue("@payment", comboBox1.GetItemText(comboBox1.SelectedItem));
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket ordered successfully.");
                    con.Close();
                }
                else
                {
                    OleDbCommand cmd = new OleDbCommand();
                    OleDbConnection con = new OleDbConnection(custconnStr);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO FlightBooking(FlightID,flightNo,flightClass,AdultNum,ChildNum,InfantNum,AdultPrice,ChildPrice,InfantPrice,OrderDate,OrderBy,custID,payment) "
                        + "VALUES (@id,@no,@class,@adultnum,@childnum,@infantnum,@adultprice,@childprice,@infantprice,@orderdate,@orderby,@custid,@payment)";
                    cmd.Parameters.AddWithValue("@id", Int32.Parse(label51.Text));
                    cmd.Parameters.AddWithValue("@no", label73.Text);
                    cmd.Parameters.AddWithValue("@class", label49.Text);
                    cmd.Parameters.AddWithValue("@adultnum", adultnum);
                    cmd.Parameters.AddWithValue("@childnum", childnum);
                    cmd.Parameters.AddWithValue("@infantnum", infantnum);
                    cmd.Parameters.AddWithValue("@adultprice", adultsub);
                    cmd.Parameters.AddWithValue("@childprice", childsub);
                    cmd.Parameters.AddWithValue("@infantprice", infantsub);
                    cmd.Parameters.AddWithValue("@orderdate", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("@orderby", frmLogin.staffid);
                    cmd.Parameters.AddWithValue("@custid", custid);
                    cmd.Parameters.AddWithValue("@payment", comboBox1.GetItemText(comboBox1.SelectedItem));
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    OleDbCommand cmd_back = new OleDbCommand();
                    OleDbConnection con_back = new OleDbConnection(custconnStr);
                    cmd_back.CommandType = CommandType.Text;
                    cmd_back.CommandText = "INSERT INTO FlightBooking(FlightID,flightNo,flightClass,AdultNum,ChildNum,InfantNum,AdultPrice,ChildPrice,InfantPrice,OrderDate,OrderBy,custID,payment) "
                        + "VALUES (@id,@no,@class,@adultnum,@childnum,@infantnum,@adultprice,@childprice,@infantprice,@orderdate,@orderby,@custid,@payment)";
                    cmd_back.Parameters.AddWithValue("@id", Int32.Parse(label45.Text));
                    cmd_back.Parameters.AddWithValue("@no", label33.Text);
                    cmd_back.Parameters.AddWithValue("@class", label47.Text);
                    cmd_back.Parameters.AddWithValue("@adultnum", adultnum_back);
                    cmd_back.Parameters.AddWithValue("@childnum", childnum_back);
                    cmd_back.Parameters.AddWithValue("@infantnum", infantnum_back);
                    cmd_back.Parameters.AddWithValue("@adultprice", adultsub_back);
                    cmd_back.Parameters.AddWithValue("@childprice", childsub_back);
                    cmd_back.Parameters.AddWithValue("@infantprice", infantsub_back);
                    cmd_back.Parameters.AddWithValue("@orderdate", DateTime.Now.ToShortDateString());
                    cmd_back.Parameters.AddWithValue("@orderby", frmLogin.staffid);
                    cmd_back.Parameters.AddWithValue("@custid", custid);
                    cmd_back.Parameters.AddWithValue("@payment", comboBox1.GetItemText(comboBox1.SelectedItem));
                    cmd_back.Connection = con_back;
                    con_back.Open();
                    cmd_back.ExecuteNonQuery();
                    MessageBox.Show("Ticket ordered successfully.");
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

        private void button2_Click(object sender, EventArgs e)
        {
            //string sql = "INSERT INTO FlightBooking(FlightID,OrderBy,CustID)"+ "VALUES ("+textBox6.Text+",'"+textBox5.Text+"','"+textBox7.Text+"')";
            //OleDbCommand cmd = new OleDbCommand();
            //OleDbConnection con = new OleDbConnection(custconnStr);
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "INSERT INTO FlightBooking(FlightID,OrderBy,CustID)" + "VALUES (@id,@order,@cust)";
            //cmd.Parameters.AddWithValue("@id", textBox6.Text);
            //cmd.Parameters.AddWithValue("@order", textBox5.Text);
            //cmd.Parameters.AddWithValue("@cust", textBox7.Text);
            //cmd.Connection = con;
            //con.Open();
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Ticket ordered successfully.");
            //con.Close();
            //string cmdstr = "SELECT COUNT(*) FROM customer";
            //using (OleDbConnection conn = new OleDbConnection(custconnStr))
            //using (OleDbCommand command = new OleDbCommand(cmdstr, conn))
            //{
            //    conn.Open();
            //    int count = (int)command.ExecuteScalar();
            //    MessageBox.Show("C0"+(count+1));
            //}

        }

        private void flightBookingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            textBox5.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox5.Text.ToLower());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            adult = Int32.Parse(label75.Text);
            child = Int32.Parse(label69.Text);
            infant = Int32.Parse(label63.Text);
            int adult_person = Convert.ToInt32(numericUpDown1.Value);
            int child_person = Convert.ToInt32(numericUpDown2.Value);
            int infant_person = Convert.ToInt32(numericUpDown3.Value);
            label77.Text = (adult * adult_person).ToString();
            subtotal = (adult * adult_person) + (child * child_person) + (infant * infant_person);
            label54.Text = subtotal.ToString();
            int grandtotal = subtotal;
            label57.Text = grandtotal.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            adult = Int32.Parse(label75.Text);
            child = Int32.Parse(label69.Text);
            infant = Int32.Parse(label63.Text);
            int adult_person = Convert.ToInt32(numericUpDown1.Value);
            int child_person = Convert.ToInt32(numericUpDown2.Value);
            int infant_person = Convert.ToInt32(numericUpDown3.Value);
            label77.Text = (adult * adult_person).ToString();
            subtotal = (adult * adult_person) + (child * child_person) + (infant * infant_person);
            label54.Text = subtotal.ToString();
            int grandtotal = subtotal;
            label57.Text = grandtotal.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            adult = Int32.Parse(label75.Text);
            child = Int32.Parse(label69.Text);
            infant = Int32.Parse(label63.Text);
            int adult_person = Convert.ToInt32(numericUpDown1.Value);
            int child_person = Convert.ToInt32(numericUpDown2.Value);
            int infant_person = Convert.ToInt32(numericUpDown3.Value);
            label77.Text = (adult * adult_person).ToString();
            subtotal = (adult * adult_person) + (child * child_person) + (infant * infant_person);
            label54.Text = subtotal.ToString();
            int grandtotal = subtotal;
            label57.Text = grandtotal.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmAir.back = false;
            frmAir air = new frmAir();
            air.Show();
            this.Hide();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            backadult = Int32.Parse(label35.Text);
            backchild = Int32.Parse(label29.Text);
            backinfant = Int32.Parse(label17.Text);
            int backadult_person = Convert.ToInt32(numericUpDown6.Value);
            int backchild_person = Convert.ToInt32(numericUpDown5.Value);
            int backinfant_person = Convert.ToInt32(numericUpDown4.Value);
            label82.Text = (backadult * backadult_person).ToString();
            backsubtotal = (backadult * backadult_person) + (backchild * backchild_person) + (backinfant * backinfant_person);
            label10.Text = backsubtotal.ToString();
            int grandtotal = backsubtotal + subtotal;
            label57.Text = grandtotal.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            backadult = Int32.Parse(label35.Text);
            backchild = Int32.Parse(label29.Text);
            backinfant = Int32.Parse(label17.Text);
            int backadult_person = Convert.ToInt32(numericUpDown6.Value);
            int backchild_person = Convert.ToInt32(numericUpDown5.Value);
            int backinfant_person = Convert.ToInt32(numericUpDown4.Value);
            label82.Text = (backadult * backadult_person).ToString();
            backsubtotal = (backadult * backadult_person) + (backchild * backchild_person) + (backinfant * backinfant_person);
            label10.Text = backsubtotal.ToString();
            int grandtotal = backsubtotal + subtotal;
            label57.Text = grandtotal.ToString();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            backadult = Int32.Parse(label35.Text);
            backchild = Int32.Parse(label29.Text);
            backinfant = Int32.Parse(label17.Text);
            int backadult_person = Convert.ToInt32(numericUpDown6.Value);
            int backchild_person = Convert.ToInt32(numericUpDown5.Value);
            int backinfant_person = Convert.ToInt32(numericUpDown4.Value);
            label82.Text = (backadult * backadult_person).ToString();
            backsubtotal = (backadult * backadult_person) + (backchild * backchild_person) + (backinfant * backinfant_person);
            label10.Text = backsubtotal.ToString();
            int grandtotal = backsubtotal + subtotal;
            label57.Text = grandtotal.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label37.Text = "Time : " + DateTime.Now.ToString();
        }
    }
}
