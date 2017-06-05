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
    public partial class frmAdminStaff : Form
    {
        private int rowindex;
        private bool update;
        private string custconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=customerBooking.accdb";

        public frmAdminStaff()
        {
            InitializeComponent();
        }

        public frmAdminStaff(int rowindex, bool update)
        {
            InitializeComponent();
            this.rowindex = rowindex;
            this.update = update;
        }

        private void frmAdminStaff_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to add this record?", "Add record",
MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    using (OleDbConnection con = new OleDbConnection(custconnStr))
                    {
                        string Sql = "select staffid from staff";
                        OleDbCommand cmd = new OleDbCommand(Sql, con);
                        con.Open();
                        OleDbDataReader DR = cmd.ExecuteReader();
                        while (DR.Read())
                        {
                            if (DR[0].ToString().Equals(textBox1.Text))
                            {
                                MessageBox.Show("This staff id is assigned,Please input another staff id");
                                return;
                            }
                        }
                        con.Close();
                    }
                }
                if (numericUpDown1.Value == 0.00m)
                {
                    MessageBox.Show("Salary cannot be $0");
                    return;
                }
                string email;
                if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                    !string.IsNullOrWhiteSpace(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) &&
                    !string.IsNullOrWhiteSpace(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox5.Text) &&
                   (radioButton3.Checked || radioButton4.Checked) && (radioButton1.Checked || radioButton2.Checked))
                {
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
                    cmd_staff.CommandText = "INSERT INTO staff([staffid],[staffname],[gender],[center],[email],[pass],[position],[salary],[ctype],[late]) "
                        + "VALUES (@id,@name,@gender,@center,@email,@pass,@position,@salary,@ctype,@late)";
                    cmd_staff.Parameters.AddWithValue("@id", textBox1.Text);
                    cmd_staff.Parameters.AddWithValue("@name", textBox2.Text);
                    cmd_staff.Parameters.AddWithValue("@gender", gender);
                    cmd_staff.Parameters.AddWithValue("@center", textBox3.Text);
                    cmd_staff.Parameters.AddWithValue("@email", email);
                    cmd_staff.Parameters.AddWithValue("@pass", textBox5.Text);
                    cmd_staff.Parameters.AddWithValue("@position", position);
                    cmd_staff.Parameters.AddWithValue("@salary", Convert.ToDouble(numericUpDown1.Value));
                    cmd_staff.Parameters.AddWithValue("@ctype", textBox7.Text);
                    cmd_staff.Parameters.AddWithValue("@late", Convert.ToDouble(numericUpDown2.Value));

                    cmd_staff.Connection = con;
                    con.Open();
                    cmd_staff.ExecuteNonQuery();

                    MessageBox.Show("Staff record added successfully.");
                    con.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("All field must be enter");
                    return;
                }
            }
        }
    }
}
