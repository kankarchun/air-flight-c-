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

namespace Air_flight
{
    public partial class frmAdminUpdateCruise : Form
    {
        private string[] cruise_details;
        private string cruiseconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=cruise.accdb";

        public frmAdminUpdateCruise()
        {
            InitializeComponent();
        }

        public frmAdminUpdateCruise(string[] cruise_details)
        {
            InitializeComponent();
            this.cruise_details = cruise_details;
        }

        private void frmAdminUpdateCruise_Load(object sender, EventArgs e)
        {
            textBox1.Text = cruise_details[0];
            textBox2.Text = cruise_details[1];
            textBox3.Text = cruise_details[2];
            numericUpDown1.Value = Decimal.Parse(cruise_details[3]);
            numericUpDown2.Value = Decimal.Parse(cruise_details[4]);
            dateTimePicker1.Value = DateTime.Parse(cruise_details[5]);
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Cruise name cannot be empty");
                textBox3.Text = cruise_details[2];
            }
        }

        private void numericUpDown1_Leave(object sender, EventArgs e)
        {
            if (numericUpDown1.Value==0m)
            {
                MessageBox.Show("Reference price cannot be $0");
                numericUpDown1.Value = Decimal.Parse(cruise_details[3]);
            }
        }

        private void numericUpDown2_Leave(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == 0m)
            {
                MessageBox.Show("Tour day cannot be 0");
                numericUpDown2.Value = Decimal.Parse(cruise_details[4]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update this record?", "Update record",
MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string startdateFormat;
                DateTime startDate;
                startdateFormat = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                startDate = DateTime.Parse(startdateFormat);

                OleDbCommand cmd_cruise = new OleDbCommand();
                OleDbConnection con = new OleDbConnection(cruiseconnStr);
                cmd_cruise.CommandType = CommandType.Text;
                cmd_cruise.CommandText = "Update cruise set cruisename=@name,refprice=@price,tourday=@day,startdate=@startdate "
                    + "where cruiseno=@no";
                cmd_cruise.Parameters.AddWithValue("@name", textBox3.Text);
                cmd_cruise.Parameters.AddWithValue("@price", Convert.ToDouble(numericUpDown1.Value));
                cmd_cruise.Parameters.AddWithValue("@day", Convert.ToDouble(numericUpDown2.Value));
                cmd_cruise.Parameters.AddWithValue("@startdate", startDate);
                cmd_cruise.Parameters.AddWithValue("@no", textBox2.Text);

                cmd_cruise.Connection = con;
                con.Open();

                cmd_cruise.ExecuteNonQuery();

                MessageBox.Show("Cruise record updated successfully.");
                con.Close();
                this.Close();
            }
        }
    }
}
