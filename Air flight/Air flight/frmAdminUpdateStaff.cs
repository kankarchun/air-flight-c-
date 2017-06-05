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
    public partial class frmAdminUpdateStaff : Form
    {
        private string[] staff_details;
        private string custconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=customerBooking.accdb";

        public frmAdminUpdateStaff()
        {
            InitializeComponent();
        }

        public frmAdminUpdateStaff(string[] staff_details)
        {
            InitializeComponent();
            this.staff_details = staff_details;
        }

        private void frmAdminUpdateStaff_Load(object sender, EventArgs e)
        {
            textBox1.Text = staff_details[0];
            textBox2.Text = staff_details[1];
            if (staff_details[2].Equals("M"))
            {
                radioButton3.Checked = true;
                radioButton4.Enabled = false;
            }
            else
            {
                radioButton4.Checked = true;
                radioButton3.Enabled = false;
            }
            textBox3.Text = staff_details[3];
            textBox4.Text = staff_details[4];
            textBox5.Text = staff_details[5];
            if(staff_details[6].Equals("Customer Service Officer"))
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            textBox7.Text = staff_details[8];
            numericUpDown1.Value = Decimal.Parse(staff_details[7]);
            numericUpDown2.Value = Decimal.Parse(staff_details[9]);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Staff name cannot be empty");
                textBox2.Text = staff_details[1];
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Email cannot be empty");
                textBox4.Text = staff_details[4];
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Center cannot be empty");
                textBox3.Text = staff_details[3];
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Staff login password cannot be empty");
                textBox5.Text = staff_details[5];
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Officer type cannot be empty");
                textBox7.Text = staff_details[8];
            }
        }

        private void numericUpDown1_Leave(object sender, EventArgs e)
        {
            if (numericUpDown1.Value==0.00m)
            {
                MessageBox.Show("Staff salary cannot be $0");
                numericUpDown1.Value = Decimal.Parse(staff_details[7]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update this record?", "Update record",
MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string email;
                Regex checkEmail = new Regex(@"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$");
                if (checkEmail.IsMatch(textBox4.Text))
                {
                    email = textBox4.Text;
                }
                else
                {
                    MessageBox.Show("Email address format is not correct, abc123_@abc.com");
                    return;
                }
                string gender = "", position = "";
                if (radioButton1.Checked)
                    position = "Customer Service Officer";
                if (radioButton2.Checked)
                    position = "Center Manager";
                if (radioButton3.Checked)
                    gender = "M";
                if (radioButton4.Checked)
                    gender = "F";

                OleDbCommand cmd_staff = new OleDbCommand();
                OleDbConnection con = new OleDbConnection(custconnStr);
                cmd_staff.CommandType = CommandType.Text;
                cmd_staff.CommandText = "Update staff set [staffname]=@name,[gender]=@gender,[center]=@center,[email]=@email,[pass]=@pass,[position]=@position,[salary]=@salary,[ctype]=@ctype,[late]=@late "
                    + "where [staffid]=@id";
                cmd_staff.Parameters.AddWithValue("@name", textBox2.Text);
                cmd_staff.Parameters.AddWithValue("@gender", gender);
                cmd_staff.Parameters.AddWithValue("@center", textBox3.Text);
                cmd_staff.Parameters.AddWithValue("@email", email);
                cmd_staff.Parameters.AddWithValue("@pass", textBox5.Text);
                cmd_staff.Parameters.AddWithValue("@position", position);
                cmd_staff.Parameters.AddWithValue("@salary", Convert.ToDouble(numericUpDown1.Value));
                cmd_staff.Parameters.AddWithValue("@ctype", textBox7.Text);
                cmd_staff.Parameters.AddWithValue("@late", Convert.ToDouble(numericUpDown2.Value));
                cmd_staff.Parameters.AddWithValue("@id", textBox1.Text);
                cmd_staff.Connection = con;
                con.Open();
                cmd_staff.ExecuteNonQuery();

                MessageBox.Show("Staff record updated successfully.");
                con.Close();
                this.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
