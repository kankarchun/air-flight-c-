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
    public partial class frmAdminCustomer : Form
    {
        private int rowindex;
        private bool update;
        private int custid;
        private string custconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=customerBooking.accdb";
        private DateTime? d2 = null;

        public frmAdminCustomer()
        {
            InitializeComponent();
        }

        public frmAdminCustomer(int rowindex, bool update)
        {
            InitializeComponent();
            this.rowindex = rowindex;
            this.update = update;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            textBox4.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox4.Text.ToLower());
        }

        private void frmAdminCustomer_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";

            string stmt = "SELECT COUNT(*) FROM customer";
            custid = 0;

            using (OleDbConnection thisConnection = new OleDbConnection(custconnStr))
            {
                using (OleDbCommand cmdCount = new OleDbCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    custid = (int)cmdCount.ExecuteScalar();
                    thisConnection.Close();
                }
            }
            custid++;
            textBox1.Text = "C0" + custid.ToString();

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Date of birth cannot higher than today");
                DateTime d1 = new DateTime(2000, 1, 1);
                dateTimePicker1.Value = d1;
            }
            else
            {
                d2 = dateTimePicker1.Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to add this record?", "Add record",
MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (d2 == null)
                {
                    MessageBox.Show("Please enter Date of birth");
                    return;
                }
                string passport = "", phone = "";
                if (!string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) &&
                    !string.IsNullOrWhiteSpace(textBox7.Text))
                {
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
                    cmd_staff.CommandText = "INSERT INTO customer(custid,surname,givenname,dateofbirth,gender,passport,contact,nationality) "
                        + "VALUES (@id,@surname,@givenname,@birth,@gender,passport,@contact,@nationality)";
                    cmd_staff.Parameters.AddWithValue("@id", textBox1.Text);
                    cmd_staff.Parameters.AddWithValue("@surname", textBox2.Text);
                    cmd_staff.Parameters.AddWithValue("@givenname", textBox4.Text);
                    cmd_staff.Parameters.AddWithValue("@birth", dateTimePicker1.Value.ToShortDateString());
                    if (gender.Equals(""))
                    {
                        cmd_staff.Parameters.AddWithValue("@gender", DBNull.Value);
                    }
                    else {
                        cmd_staff.Parameters.AddWithValue("@gender", gender);
                    }
                    if (string.IsNullOrWhiteSpace(textBox5.Text))
                    {
                        cmd_staff.Parameters.AddWithValue("@passport", DBNull.Value);
                    }
                    else {
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
                    cmd_staff.Connection = con;
                    con.Open();
                    cmd_staff.ExecuteNonQuery();

                    MessageBox.Show("Customer record added successfully.");
                    con.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("(*)field must be enter");
                    return;
                }
            }
        }
    }
}
