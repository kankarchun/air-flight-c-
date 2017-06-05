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
    public partial class frmCruiseBooking : Form
    {
        public static string staffname;
        private string custconnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=customerBooking.accdb";
        public string custid = "";

        public frmCruiseBooking()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void frmCruiseBooking_Load(object sender, EventArgs e)
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

            pictureBox1.Image = Properties.Resources.TT_Cruise;
            label18.Text = "Staff: " + staffname;
            timer1.Start();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCruiseTour cruise = new frmCruiseTour();
            cruise.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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

            if (label22.Text.Equals("0"))
            {
                MessageBox.Show("Please order at least one person");
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
            int totalPrice = Int32.Parse(label20.Text) * Convert.ToInt32(numericUpDown1.Value);
            if (confirm.ShowDialog() == DialogResult.OK)
            {
                OleDbCommand cmd = new OleDbCommand();
                OleDbConnection con = new OleDbConnection(custconnStr);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CruiseBooking(CruiseNo,PersonNum,PersonPrice,OrderDate,OrderBy,CustID,payment) "
                    + "VALUES (@no,@person,@price,@orderdate,@orderby,@custid,@payment)";
                cmd.Parameters.AddWithValue("@no", label25.Text);
                cmd.Parameters.AddWithValue("@person", Convert.ToInt32(numericUpDown1.Value));
                cmd.Parameters.AddWithValue("@price", totalPrice);
                cmd.Parameters.AddWithValue("@orderdate", DateTime.Now.ToShortDateString());
                cmd.Parameters.AddWithValue("@orderBy", frmLogin.staffid);
                cmd.Parameters.AddWithValue("@custid", custid);
                cmd.Parameters.AddWithValue("@payment", comboBox1.GetItemText(comboBox1.SelectedItem));
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cruise ordered successfully.");
                con.Close();
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

        private void textBox5_Leave(object sender, EventArgs e)
        {
            textBox5.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox5.Text.ToLower());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int price = Int32.Parse(label20.Text);
            int person = Convert.ToInt32(numericUpDown1.Value);
            int grandtotal = (price * person);
            label22.Text = grandtotal.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label9.Text = "Time : " + DateTime.Now.ToString();
        }
    }
}
