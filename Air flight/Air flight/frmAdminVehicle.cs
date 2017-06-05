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
    public partial class frmAdminVehicle : Form
    {
        private int rowindex;
        private bool update;
        private int vehicleid,equipid;
        private string vehicleconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=vehicle.accdb";

        public frmAdminVehicle()
        {
            InitializeComponent();
        }

        public frmAdminVehicle(int rowindex, bool update)
        {
            InitializeComponent();
            this.rowindex = rowindex;
            this.update = update;
        }


        private void frmAdminVehicle_Load(object sender, EventArgs e)
        {
            string stmt_vehicle = "SELECT COUNT(*) FROM vehicle";
            vehicleid = 0;

            using (OleDbConnection thisConnection = new OleDbConnection(vehicleconnStr))
            {
                using (OleDbCommand cmdCount = new OleDbCommand(stmt_vehicle, thisConnection))
                {
                    thisConnection.Open();
                    vehicleid = (int)cmdCount.ExecuteScalar();
                    thisConnection.Close();
                }
            }
            vehicleid++;
            textBox1.Text = vehicleid.ToString();
            string stmt_equip = "SELECT COUNT(*) FROM equipment";
            equipid = 0;

            using (OleDbConnection thisConnection = new OleDbConnection(vehicleconnStr))
            {
                using (OleDbCommand cmdCount = new OleDbCommand(stmt_equip, thisConnection))
                {
                    thisConnection.Open();
                    equipid = (int)cmdCount.ExecuteScalar();
                    thisConnection.Close();
                }
            }
            equipid++;
            textBox4.Text = equipid.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to add this record?", "Add record",
MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if(!checkBox1.Checked&&!checkBox2.Checked)
                {
                    MessageBox.Show("Please choose at least one checkbox to add record to database");
                    return;
                }
                else if (checkBox1.Checked && checkBox2.Checked)
                {
                    if (numericUpDown2.Value == 0.00m)
                    {
                        MessageBox.Show("Vehicle Price cannot be $0");
                        return;
                    }
                    if (numericUpDown5.Value == 0.00m)
                    {
                        MessageBox.Show("Equipment Price cannot be $0");
                        return;
                    }
                    else if (!string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) &&
                       !string.IsNullOrWhiteSpace(textBox7.Text) && (radioButton3.Checked || radioButton4.Checked) && !string.IsNullOrWhiteSpace(textBox9.Text) && (radioButton1.Checked || radioButton2.Checked))
                    {
                        string type = "";
                        if (radioButton3.Checked)
                            type = "car";
                        if (radioButton4.Checked)
                            type = "coach";
                        OleDbCommand cmd_vehicle = new OleDbCommand();
                        OleDbConnection con = new OleDbConnection(vehicleconnStr);
                        cmd_vehicle.CommandType = CommandType.Text;
                        cmd_vehicle.CommandText = "INSERT INTO vehicle(vehicle_name,price,vehicle_type,capacity,gear,color,vehicleID) "
                            + "VALUES (@name,@price,@type,@capacity,@gear,@color,@id)";
                        cmd_vehicle.Parameters.AddWithValue("@name", textBox2.Text);
                        cmd_vehicle.Parameters.AddWithValue("@price", Convert.ToDouble(numericUpDown2.Value));
                        cmd_vehicle.Parameters.AddWithValue("@type", type);
                        cmd_vehicle.Parameters.AddWithValue("@capacity", Convert.ToDouble(numericUpDown1.Value));
                        cmd_vehicle.Parameters.AddWithValue("@gear", textBox7.Text);
                        cmd_vehicle.Parameters.AddWithValue("@color", textBox3.Text);
                        cmd_vehicle.Parameters.AddWithValue("@id", "car" + vehicleid);

                        cmd_vehicle.Connection = con;
                        con.Open();
                        cmd_vehicle.ExecuteNonQuery();
                        MessageBox.Show("Vehicle record added successfully.");

                        string suitable = "";
                        if (radioButton1.Checked)
                            suitable = "car";
                        if (radioButton2.Checked)
                            suitable = "coach";
                        OleDbCommand cmd_equip = new OleDbCommand();
                        cmd_equip.CommandType = CommandType.Text;
                        cmd_equip.CommandText = "INSERT INTO equipment(equipid,equipment,suitable,price) "
                            + "VALUES (@id,@equip,@suitable,@price)";
                        cmd_equip.Parameters.AddWithValue("@id", "e" + equipid);
                        cmd_equip.Parameters.AddWithValue("@equip", textBox9.Text);
                        cmd_equip.Parameters.AddWithValue("@suitable", suitable);
                        cmd_equip.Parameters.AddWithValue("@price", Convert.ToDouble(numericUpDown5.Value));

                        cmd_equip.Connection = con;

                        cmd_equip.ExecuteNonQuery();
                        MessageBox.Show("Equipment record added successfully.");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("All field must be enter");
                        return;
                    }
                }
                else if (checkBox1.Checked)
            {
                if (numericUpDown2.Value == 0.00m)
                {
                    MessageBox.Show("Vehicle Price cannot be $0");
                    return;
                }else if(!string.IsNullOrWhiteSpace(textBox2.Text)&& !string.IsNullOrWhiteSpace(textBox3.Text)&&
                    !string.IsNullOrWhiteSpace(textBox7.Text) && (radioButton3.Checked || radioButton4.Checked))
                {
                    string type = "";
                    if (radioButton3.Checked)
                        type = "car";
                    if (radioButton4.Checked)
                        type = "coach";
                    OleDbCommand cmd_vehicle = new OleDbCommand();
                    OleDbConnection con = new OleDbConnection(vehicleconnStr);
                    cmd_vehicle.CommandType = CommandType.Text;
                    cmd_vehicle.CommandText = "INSERT INTO vehicle(vehicle_name,price,vehicle_type,capacity,gear,color,vehicleID) "
                        + "VALUES (@name,@price,@type,@capacity,@gear,@color,@id)";
                    cmd_vehicle.Parameters.AddWithValue("@name", textBox2.Text);
                    cmd_vehicle.Parameters.AddWithValue("@price", Convert.ToDouble(numericUpDown2.Value));
                    cmd_vehicle.Parameters.AddWithValue("@type", type);
                    cmd_vehicle.Parameters.AddWithValue("@capacity", Convert.ToDouble(numericUpDown1.Value));
                    cmd_vehicle.Parameters.AddWithValue("@gear", textBox7.Text);
                    cmd_vehicle.Parameters.AddWithValue("@color", textBox3.Text);
                    cmd_vehicle.Parameters.AddWithValue("@id", "car" + vehicleid);

                    cmd_vehicle.Connection = con;
                    con.Open();
                    cmd_vehicle.ExecuteNonQuery();
                    MessageBox.Show("Vehicle record added successfully.");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("All field must be enter");
                    return;
                }
            }
                else if (checkBox2.Checked)
                {
                    if (numericUpDown5.Value == 0.00m)
                    {
                        MessageBox.Show("Equipment Price cannot be $0");
                        return;
                    }
                    else if (!string.IsNullOrWhiteSpace(textBox9.Text) && (radioButton1.Checked || radioButton2.Checked))
                    {
                        string suitable = "";
                        if (radioButton1.Checked)
                            suitable = "car";
                        if (radioButton2.Checked)
                            suitable = "coach";
                        OleDbCommand cmd_equip = new OleDbCommand();
                        OleDbConnection con = new OleDbConnection(vehicleconnStr);
                        cmd_equip.CommandType = CommandType.Text;
                        cmd_equip.CommandText = "INSERT INTO equipment(equipid,equipment,suitable,price) "
                            + "VALUES (@id,@equip,@suitable,@price)";
                        cmd_equip.Parameters.AddWithValue("@id", "e" + equipid);
                        cmd_equip.Parameters.AddWithValue("@equip", textBox9.Text);
                        cmd_equip.Parameters.AddWithValue("@suitable", suitable);
                        cmd_equip.Parameters.AddWithValue("@price", Convert.ToDouble(numericUpDown5.Value));

                        cmd_equip.Connection = con;
                        con.Open();
                        cmd_equip.ExecuteNonQuery();
                        MessageBox.Show("Equipment record added successfully.");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("All field must be enter");
                        return;
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.ReadOnly = false;
                numericUpDown1.ReadOnly = false;
                numericUpDown2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox7.ReadOnly = false;
                groupBox3.Enabled = true;
            }
            else
            {
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                numericUpDown1.ReadOnly = true;
                numericUpDown2.ReadOnly = true;
                textBox7.ReadOnly = true;
                groupBox3.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox9.ReadOnly = false;
                numericUpDown5.ReadOnly = false;
                groupBox4.Enabled = true;
            }
            else
            {
                textBox9.ReadOnly = true;
                numericUpDown5.ReadOnly = true;
                groupBox4.Enabled = false;
            }
        }
    }
}
