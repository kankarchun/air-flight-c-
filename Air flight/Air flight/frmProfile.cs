using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_flight
{
    public partial class frmProfile : Form
    {
        private string custconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=customerBooking.accdb";
        private string[] staff_details;

        public frmProfile()
        {
            InitializeComponent();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox5.Text))
            {
                Regex checkEmail = new Regex(@"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$");
                if (checkEmail.IsMatch(textBox4.Text))
                {
                    textBox4.Text = textBox4.Text;
                }
                else
                {
                    MessageBox.Show("Email address format is not correct, abc123_@abc.com");
                    return;
                }
                OleDbCommand cmd_staff = new OleDbCommand();
                OleDbConnection con = new OleDbConnection(custconnStr);
                cmd_staff.CommandType = CommandType.Text;
                cmd_staff.CommandText = "Update staff set [email]=@email,[pass]=@pass "
                    + "where [staffid]=@id";
                cmd_staff.Parameters.AddWithValue("@email", textBox4.Text);
                cmd_staff.Parameters.AddWithValue("@pass", textBox5.Text);
                cmd_staff.Parameters.AddWithValue("@id", textBox1.Text);
                cmd_staff.Connection = con;
                con.Open();
                cmd_staff.ExecuteNonQuery();

                MessageBox.Show("Profile updated successfully.");
                con.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Email or password cannot be empty");
            }
        }

        private void frmProfile_Load_1(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(custconnStr))
            {
                string Sql = "select * from staff where staffid='"+frmLogin.staffid+"'";
                label1.Text = frmLogin.staffid;
                OleDbCommand cmd = new OleDbCommand(Sql, con);
                con.Open();
                OleDbDataReader DR = cmd.ExecuteReader();
                while (DR.Read())
                {

                    textBox1.Text = DR[0].ToString();
                    textBox2.Text = DR[1].ToString();
                    if (DR[2].ToString().Equals("M"))
                    {
                        radioButton3.Checked = true;
                    }
                    else if (DR[2].ToString().Equals("F"))
                    {
                        radioButton4.Checked = true;
                    }
                    textBox4.Text = DR[4].ToString();
                    textBox3.Text = DR[3].ToString();
                    textBox5.Text = DR[5].ToString();
                    if (DR[6].ToString().Equals("Customer Service Officer"))
                    {
                        radioButton1.Checked = true;
                    }
                    else if (DR[6].ToString().Equals("Center Manager"))
                    {
                        radioButton2.Checked = true;
                    }
                    numericUpDown1.Value = Decimal.Parse(DR[7].ToString());
                    textBox7.Text = DR[8].ToString();
                    numericUpDown2.Value = Decimal.Parse(DR[9].ToString());

                    con.Close();
                }
            }
        }
    }
}
