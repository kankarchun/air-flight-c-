using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace Air_flight
{
    public partial class frmAdminUpdateCustomer : Form
    {
        private string[] cust_details;
        private string custconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=customerBooking.accdb";

        public frmAdminUpdateCustomer()
        {
            InitializeComponent();
        }

        public frmAdminUpdateCustomer(string[] cust_details)
        {
            InitializeComponent();
            this.cust_details = cust_details;
        }

        private void frmAdminUpdateCustomer_Load(object sender, EventArgs e)
        {
            textBox1.Text = cust_details[0];
            textBox2.Text = cust_details[1];
            textBox4.Text = cust_details[2];
            if (cust_details[3].Equals("M"))
            {
                radioButton3.Checked = true;
            }
            else
            {
                radioButton4.Checked = true;
            }
            dateTimePicker1.Value = DateTime.Parse(cust_details[4]);
            textBox5.Text = cust_details[5];
            textBox7.Text = cust_details[6];
            textBox6.Text = cust_details[7];
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Customer Surname cannot be empty");
                textBox2.Text = cust_details[1];
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Customer Given name be empty");
                textBox4.Text = cust_details[2];
            }
            else {
                textBox4.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox4.Text.ToLower());
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Customer Contact be empty");
                textBox7.Text = cust_details[6];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update this record?", "Update record",
MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string passport = "", phone = "";
                Regex checkPassport = new Regex(@"^[A-PR-WY][1-9]\d\s?\d{4}[1-9]$");
                Regex checkphone = new Regex(@"^[2-35-69]{1}[0-9]{7}$");
                if (!string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    if (checkPassport.IsMatch(textBox5.Text))
                    {
                        passport = textBox5.Text;
                    }
                    else
                    {
                        MessageBox.Show("Passport number is not correct format, first character cannot be Q, X and Z and 8digit");
                        return;
                    }
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

                string gender = "";
                if (radioButton3.Checked)
                    gender = "M";
                if (radioButton4.Checked)
                    gender = "F";

                OleDbCommand cmd_staff = new OleDbCommand();
                OleDbConnection con = new OleDbConnection(custconnStr);
                cmd_staff.CommandType = CommandType.Text;
                cmd_staff.CommandText = "Update customer set surname=@surname,givenname=@givenname,gender=@gender,passport=@passport,contact=@contact,nationality=@nationality,dateofbirth=@birth "
                    + "where custid=@id";
                cmd_staff.Parameters.AddWithValue("@surname", textBox2.Text);
                cmd_staff.Parameters.AddWithValue("@givenname", textBox4.Text);
                if (gender.Equals(""))
                {
                    cmd_staff.Parameters.AddWithValue("@gender", DBNull.Value);
                }
                else
                {
                    cmd_staff.Parameters.AddWithValue("@gender", gender);
                }
                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    cmd_staff.Parameters.AddWithValue("@passport", DBNull.Value);
                }
                else
                {
                    cmd_staff.Parameters.AddWithValue("@passport", passport);
                }

                cmd_staff.Parameters.AddWithValue("@contact", phone);

                if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    cmd_staff.Parameters.AddWithValue("@nationality", DBNull.Value);
                }
                else {
                    cmd_staff.Parameters.AddWithValue("@nationality", textBox6.Text);
                }
                cmd_staff.Parameters.AddWithValue("@birth", dateTimePicker1.Value.ToShortDateString());
                cmd_staff.Parameters.AddWithValue("@id", textBox1.Text);
                cmd_staff.Connection = con;
                con.Open();
                cmd_staff.ExecuteNonQuery();

                MessageBox.Show("Customer record updated successfully.");
                con.Close();
                this.Close();
            }
        }
    }
}
