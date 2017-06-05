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
    public partial class frmAdminUpdateVehicle : Form
    {
        private string[] vehicle_details;
        private string[] equip_details;
        private bool boolvehicle, boolequip;
        private string vehicleconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=vehicle.accdb";

        public frmAdminUpdateVehicle()
        {
            InitializeComponent();
        }

        public frmAdminUpdateVehicle(string[] vehicle_details,string[] equip_details,bool boolvehicle,bool boolequip)
        {
            InitializeComponent();
            this.vehicle_details = vehicle_details;
            this.equip_details = equip_details;
            this.boolvehicle = boolvehicle;
            this.boolequip = boolequip;
        }

        private void frmAdminUpdateVehicle_Load(object sender, EventArgs e)
        {
            if (boolvehicle==false)
            {
                groupBox1.Visible = false;
            }
            if (boolequip == false)
            {
                groupBox2.Visible = false;
            }
            if (boolvehicle)
            {
                textBox1.Text = vehicle_details[0];
                textBox2.Text = vehicle_details[1];
                textBox3.Text = vehicle_details[6];
                numericUpDown1.Value = Decimal.Parse(vehicle_details[4]);
                numericUpDown2.Value = Decimal.Parse(vehicle_details[2]);
                if (vehicle_details[3].Equals("car")){
                    radioButton3.Checked = true;
                    radioButton4.Enabled = false;
                }
                else
                {
                    radioButton4.Checked = true;
                    radioButton3.Enabled = false;
                }
                textBox7.Text = vehicle_details[5];
            }
            if (boolequip)
            {
                textBox4.Text = equip_details[0];
                textBox9.Text = equip_details[1];
                if (equip_details[2].Equals("car"))
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                numericUpDown5.Value = Decimal.Parse(equip_details[3]);
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Vehicle name cannot be empty");
                textBox2.Text = vehicle_details[1];
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Vehicle color cannot be empty");
                textBox3.Text = vehicle_details[6];
            }
        }

        private void numericUpDown2_Leave(object sender, EventArgs e)
        {
            if (numericUpDown2.Value==0.00m)
            {
                MessageBox.Show("Vehicle price cannot be $0.00");
                numericUpDown2.Value = Decimal.Parse(vehicle_details[2]);
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Equipment name cannot be empty");
                textBox7.Text = equip_details[0];
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox9.Text))
            {
                MessageBox.Show("Vehicle color cannot be empty");
                textBox9.Text = equip_details[1];
            }
        }

        private void numericUpDown5_Leave(object sender, EventArgs e)
        {
            if (numericUpDown5.Value==0.00m)
            {
                MessageBox.Show("Equipment price cannot be $0.00");
                numericUpDown5.Value = Decimal.Parse(equip_details[3]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update this record?", "Update record",
MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (boolvehicle)
                {
                    string type = "";
                    if (radioButton3.Checked)
                        type = "car";
                    if (radioButton4.Checked)
                        type = "coach";
                    OleDbCommand cmd_vehicle = new OleDbCommand();
                    OleDbConnection con = new OleDbConnection(vehicleconnStr);
                    cmd_vehicle.CommandType = CommandType.Text;
                    cmd_vehicle.CommandText = "Update vehicle set vehicle_name=@name,price=@price,vehicle_type=@type,capacity=@capacity,gear=@gear,color=@color "
                        + "where vehicleID=@id";
                    cmd_vehicle.Parameters.AddWithValue("@name", textBox2.Text);
                    cmd_vehicle.Parameters.AddWithValue("@price", Convert.ToDouble(numericUpDown2.Value));
                    cmd_vehicle.Parameters.AddWithValue("@type", type);
                    cmd_vehicle.Parameters.AddWithValue("@capacity", Convert.ToDouble(numericUpDown1.Value));
                    cmd_vehicle.Parameters.AddWithValue("@gear", textBox7.Text);
                    cmd_vehicle.Parameters.AddWithValue("@color", textBox3.Text);
                    cmd_vehicle.Parameters.AddWithValue("@id", textBox1.Text);

                    cmd_vehicle.Connection = con;
                    con.Open();
                    cmd_vehicle.ExecuteNonQuery();
                    MessageBox.Show("Vehicle record updated successfully.");
                    con.Close();
                    if (boolequip == false)
                    {
                        this.Close();
                    }
                }
                if (boolequip)
                {
                    string suitable = "";
                    if (radioButton1.Checked)
                        suitable = "car";
                    if (radioButton2.Checked)
                        suitable = "coach";
                    OleDbCommand cmd_equip = new OleDbCommand();
                    OleDbConnection con = new OleDbConnection(vehicleconnStr);
                    cmd_equip.CommandType = CommandType.Text;
                    cmd_equip.CommandText = "Update equipment set equipment=@equip,suitable=@suitable,price=@price "
                        + "where equipid=@id";
                    cmd_equip.Parameters.AddWithValue("@equip", textBox9.Text);
                    cmd_equip.Parameters.AddWithValue("@suitable", suitable);
                    cmd_equip.Parameters.AddWithValue("@price", Convert.ToDouble(numericUpDown5.Value));
                    cmd_equip.Parameters.AddWithValue("@id", textBox4.Text);

                    cmd_equip.Connection = con;
                    con.Open();
                    cmd_equip.ExecuteNonQuery();
                    MessageBox.Show("Equipment record updated successfully.");
                    con.Close();
                    this.Close();
                }
            }
        }
    }
}
