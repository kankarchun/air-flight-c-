using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace Air_flight
{
    public partial class frmAdminUpdateAttract : Form
    {
        private string[] attract_details;
        private string attractconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=attraction.accdb";

        public frmAdminUpdateAttract()
        {
            InitializeComponent();
        }

        public frmAdminUpdateAttract(string[] attract_details)
        {
            InitializeComponent();
            this.attract_details = attract_details;
        }

        private void frmAdminUpdateAttract_Load(object sender, EventArgs e)
        {
            textBox1.Text = attract_details[0];
            textBox2.Text = attract_details[1];
            textBox4.Text = attract_details[2];
            if (attract_details[3].Equals("Charged"))
            {
                radioButton3.Checked = true;
            }
            else
            {
                radioButton4.Checked = true;
            }
            if (attract_details[4].Equals("Adult"))
            {
                radioButton1.Checked = true;
                radioButton2.Enabled = false;
            }
            else
            {
                radioButton2.Checked = true;
                radioButton1.Enabled = false;
            }
            numericUpDown1.Value = Decimal.Parse(attract_details[5]);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Duration cannot be empty");
                textBox2.Text = attract_details[1];
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("City cannot be empty");
                textBox4.Text = attract_details[3];
            }
        }

        private void numericUpDown1_Leave(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0m)
            {
                MessageBox.Show("Visitor Price cannot be $0");
                numericUpDown1.Value = Decimal.Parse(attract_details[5]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update this record?", "Update record",
MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Regex checkDuration = new Regex(@"^(?:[01]?[1-9]|1[0-9]|2[0-9])h([0-5][0-9]m)?$");
                Regex checkCity = new Regex(@"^[A-za-z]+$");
                string duration, city, cancellation = "", visitor = "";

                if (checkDuration.IsMatch(textBox2.Text))
                {
                    duration = textBox2.Text;
                }
                else
                {
                    MessageBox.Show("The valid values of duration is  1h to 29h or 1h01m to 29h59m");
                    textBox2.Clear();
                    return;
                }
                if (checkCity.IsMatch(textBox4.Text))
                {
                    city = textBox4.Text;
                }
                else
                {
                    MessageBox.Show("The city should be upper case letter or lower case letter");
                    textBox4.Clear();
                    return;
                }
                if (radioButton1.Checked)
                    visitor = "Adult";
                if (radioButton2.Checked)
                    visitor = "Child";
                if (radioButton3.Checked)
                    cancellation = "Charged";
                if (radioButton4.Checked)
                    cancellation = "Free";

                OleDbCommand cmd_attract = new OleDbCommand();
                OleDbConnection con = new OleDbConnection(attractconnStr);
                cmd_attract.CommandType = CommandType.Text;
                cmd_attract.CommandText = "Update Attraction set duration=@duration,cancellation=@cancellation,city=@city "
                    + "where attractname=@name";
                cmd_attract.Parameters.AddWithValue("@duration", duration);
                cmd_attract.Parameters.AddWithValue("@cancellation", cancellation);
                cmd_attract.Parameters.AddWithValue("@city", city);
                cmd_attract.Parameters.AddWithValue("@name", textBox1.Text);

                OleDbCommand cmd_price = new OleDbCommand();
                cmd_price.CommandType = CommandType.Text;
                cmd_price.CommandText = "Update AttractPrice set price=@price "
                    + "where attractname=@attractname and visitor=@visitor";
                cmd_price.Parameters.AddWithValue("@price", Convert.ToDouble(numericUpDown1.Value));
                cmd_price.Parameters.AddWithValue("@attractname", textBox1.Text);
                cmd_price.Parameters.AddWithValue("@visitor", visitor);
                cmd_price.Connection = con;
                cmd_attract.Connection = con;
                con.Open();

                cmd_attract.ExecuteNonQuery();
                cmd_price.ExecuteNonQuery();

                MessageBox.Show("Attraction record updated successfully.");
                con.Close();
                this.Close();
            }
        }
    }
}

