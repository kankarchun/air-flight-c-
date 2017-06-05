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
    public partial class frmAdminAttraction : Form
    {
        private int rowindex;
        private bool update;
        private string attractconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=attraction.accdb";

        public frmAdminAttraction()
        {
            InitializeComponent();
        }

        public frmAdminAttraction(int rowindex, bool update)
        {
            InitializeComponent();
            this.rowindex = rowindex;
            this.update = update;
        }

        private void frmAdminAttraction_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to add this record?", "Add record",
MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Regex checkDuration = new Regex(@"^(?:[01]?[1-9]|1[0-9]|2[0-9])h([0-5][0-9]m)?$");

                if (numericUpDown1.Value == 0m)
                {
                    MessageBox.Show("Visitor Price cannot be $0");
                    return;
                }
                string duration, city, cancellation = "", visitor = "";

                if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                    (radioButton3.Checked || radioButton4.Checked) && !string.IsNullOrWhiteSpace(textBox4.Text) &&
                    (radioButton1.Checked || radioButton2.Checked))
                {
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
                    Regex checkCity = new Regex(@"^[A-za-z]+$");
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
                    cmd_attract.CommandText = "INSERT INTO Attraction(Attractname,duration,cancellation,city) "
                        + "VALUES (@name,@duration,@cancellation,@city)";
                    cmd_attract.Parameters.AddWithValue("@name", textBox1.Text);
                    cmd_attract.Parameters.AddWithValue("@duration", duration);
                    cmd_attract.Parameters.AddWithValue("@cancellation", cancellation);
                    cmd_attract.Parameters.AddWithValue("@city", city);

                    OleDbCommand cmd_price = new OleDbCommand();
                    cmd_price.CommandType = CommandType.Text;
                    cmd_price.CommandText = "INSERT INTO AttractPrice(attractname,visitor,price) "
                        + "VALUES (@attractname,@visitor,@price)";
                    cmd_price.Parameters.AddWithValue("@attractname", textBox1.Text);
                    cmd_price.Parameters.AddWithValue("@visitor", visitor);
                    cmd_price.Parameters.AddWithValue("@price", Convert.ToDouble(numericUpDown1.Value));

                    cmd_price.Connection = con;
                    cmd_attract.Connection = con;
                    con.Open();

                    cmd_attract.ExecuteNonQuery();
                    cmd_price.ExecuteNonQuery();

                    MessageBox.Show("Attraction record added successfully.");
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
