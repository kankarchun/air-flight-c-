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
    public partial class frmAdminHotel : Form
    {
        private int rowindex;
        private bool update;
        private int hotelid;
        private string hotelconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=hotel.accdb";

        public frmAdminHotel()
        {
            InitializeComponent();
        }

        public frmAdminHotel(int rowindex, bool update)
        {
            InitializeComponent();
            this.rowindex = rowindex;
            this.update = update;
        }

        private void frmAdminHotel_Load(object sender, EventArgs e)
        {
            string stmt = "SELECT COUNT(*) FROM hotel";
            hotelid = 0;

            using (OleDbConnection thisConnection = new OleDbConnection(hotelconnStr))
            {
                using (OleDbCommand cmdCount = new OleDbCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    hotelid = (int)cmdCount.ExecuteScalar();
                    thisConnection.Close();
                }
            }
            hotelid++;
            textBox1.Text = hotelid.ToString();
        }

        private void hotel_roomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                numericUpDown1.ReadOnly = false;
                numericUpDown2.ReadOnly = false;
                textBox6.ReadOnly = false;
                textBox7.ReadOnly = false;
                textBox8.ReadOnly = false;
            }
            else
            {
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                numericUpDown1.ReadOnly = true;
                numericUpDown2.ReadOnly = true;
                textBox6.ReadOnly = true;
                textBox7.ReadOnly = true;
                textBox8.ReadOnly = true;
            }
            if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox2.Text = textBox9.Text;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox9.ReadOnly = false;
                textBox10.ReadOnly = false;
                textBox11.ReadOnly = false;
                numericUpDown3.ReadOnly = false;
                textBox13.ReadOnly = false;
                numericUpDown5.ReadOnly = false;
                numericUpDown4.ReadOnly = false;
            }
            else
            {
                textBox9.ReadOnly = true;
                textBox10.ReadOnly = true;
                textBox11.ReadOnly = true;
                numericUpDown3.ReadOnly = true;
                textBox13.ReadOnly = true;
                numericUpDown5.ReadOnly = true;
                numericUpDown4.ReadOnly = true;
            }
            if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox9.Text = textBox2.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to add this record?", "Add record",
MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string address;
                if (checkBox1.Checked && checkBox2.Checked)
                {
                    if (string.IsNullOrWhiteSpace(textBox2.Text))
                    {
                        MessageBox.Show("Hotel Chinese name cannot be empty");
                        return;
                    }
                    else if (!string.IsNullOrWhiteSpace(textBox2.Text))
                    {
                        using (OleDbConnection con = new OleDbConnection(hotelconnStr))
                        {
                            string Sql = "select hotel_chi_name from hotel";
                            OleDbCommand cmd = new OleDbCommand(Sql, con);
                            con.Open();
                            OleDbDataReader DR = cmd.ExecuteReader();
                            while (DR.Read())
                            {
                                if (DR[0].ToString().Equals(textBox2.Text) || DR[0].ToString().Equals(textBox9.Text))
                                {
                                    MessageBox.Show("This hotel chinese name is assigned,Please input another hotel name");
                                    return;
                                }
                            }
                            con.Close();
                        }
                    }
                    else if (string.IsNullOrWhiteSpace(textBox6.Text))
                    {
                        MessageBox.Show("Region cannot be empty");
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(textBox7.Text))
                    {
                        MessageBox.Show("Address cannot be empty");
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(textBox10.Text))
                    {
                        MessageBox.Show("Hotel room name cannot be empty");
                        return;
                    }
                    else if (numericUpDown5.Value == 0.00m)
                    {
                        MessageBox.Show("Fare cannot be $0.00");
                        return;
                    }
                    else
                    {
                        Regex checkAddress = new Regex(@"\d{1,3}.?\d{0,3}\s[a-zA-Z]{2,30}(\s[a-zA-Z]{ 2,15})?([#\.0-9a-zA-Z]*)?");
                        if (checkAddress.IsMatch(textBox7.Text))
                        {
                            address = textBox7.Text;
                        }
                        else
                        {
                            MessageBox.Show("Please enter the correct address");
                            return;
                        }
                        OleDbCommand cmd_hotel = new OleDbCommand();
                        OleDbConnection con = new OleDbConnection(hotelconnStr);
                        cmd_hotel.CommandType = CommandType.Text;
                        cmd_hotel.CommandText = "INSERT INTO Hotel(Hotelid,hotel_chi_name,hotel_en_name,star,rating,region,address,tel) "
                            + "VALUES (@hotelid,@chi,@en,@star,@rating,@region,@address,@tel)";
                        cmd_hotel.Parameters.AddWithValue("@hotelid", hotelid);
                        cmd_hotel.Parameters.AddWithValue("@chi", textBox2.Text);
                        if (string.IsNullOrWhiteSpace(textBox3.Text))
                        {
                            cmd_hotel.Parameters.AddWithValue("@en", DBNull.Value);
                        }
                        else
                        {
                            cmd_hotel.Parameters.AddWithValue("@en", textBox3.Text);
                        }
                        cmd_hotel.Parameters.AddWithValue("@star", Convert.ToDouble(numericUpDown1.Value));
                        cmd_hotel.Parameters.AddWithValue("@rating", Convert.ToDouble(numericUpDown2.Value));
                        cmd_hotel.Parameters.AddWithValue("@region", textBox6.Text);
                        cmd_hotel.Parameters.AddWithValue("@address", textBox7.Text);

                        if (string.IsNullOrWhiteSpace(textBox8.Text))
                        {
                            cmd_hotel.Parameters.AddWithValue("@tel", DBNull.Value);
                        }
                        else
                        {
                            cmd_hotel.Parameters.AddWithValue("@tel", Int32.Parse(textBox8.Text));
                        }
                        cmd_hotel.Connection = con;
                        con.Open();
                        cmd_hotel.ExecuteNonQuery();
                        con.Close();
                            OleDbCommand cmd_hotel_room = new OleDbCommand();
                            OleDbConnection con_room = new OleDbConnection(hotelconnStr);
                            cmd_hotel_room.CommandType = CommandType.Text;
                            cmd_hotel_room.CommandText = "INSERT INTO Hotel_room(Hotelid,hotel_chi_name,hotel_room_name,Hotel_room_size,max_adults,max_child,hotel_room_description,fare) "
                                + "VALUES (@hotelid,@chi,@room,@size,@adult,@child,@description,@fare)";
                            cmd_hotel_room.Parameters.AddWithValue("@hotelid", hotelid);
                            cmd_hotel_room.Parameters.AddWithValue("@chi", textBox9.Text);
                            cmd_hotel_room.Parameters.AddWithValue("@room", textBox10.Text);
                            if (string.IsNullOrWhiteSpace(textBox11.Text))
                            {
                                cmd_hotel_room.Parameters.AddWithValue("@size", DBNull.Value);
                            }
                            else
                            {
                                cmd_hotel_room.Parameters.AddWithValue("@size", textBox11.Text);
                            }
                            cmd_hotel_room.Parameters.AddWithValue("@adult", numericUpDown3.Value);
                            cmd_hotel_room.Parameters.AddWithValue("@child", numericUpDown4.Value);
                            if (string.IsNullOrWhiteSpace(textBox13.Text))
                            {
                                cmd_hotel_room.Parameters.AddWithValue("@description", DBNull.Value);
                            }
                            else
                            {
                                cmd_hotel_room.Parameters.AddWithValue("@description", textBox13.Text);
                            }
                            cmd_hotel_room.Parameters.AddWithValue("@fare", numericUpDown5.Value);


                            cmd_hotel_room.Connection = con_room;
                            con_room.Open();
                            cmd_hotel_room.ExecuteNonQuery();
                            MessageBox.Show("Hotel room and Hotel record added successfully.");
                            con_room.Close();
                            this.Close();
                    }

                }
                else if (checkBox1.Checked)
                {
                    if (string.IsNullOrWhiteSpace(textBox2.Text))
                    {
                        MessageBox.Show("Hotel Chinese name cannot be empty");
                        return;
                    }
                    else if (!string.IsNullOrWhiteSpace(textBox2.Text))
                    {
                        using (OleDbConnection con = new OleDbConnection(hotelconnStr))
                        {
                            string Sql = "select hotel_chi_name from hotel";
                            OleDbCommand cmd = new OleDbCommand(Sql, con);
                            con.Open();
                            OleDbDataReader DR = cmd.ExecuteReader();
                            while (DR.Read())
                            {
                                if (DR[0].ToString().Equals(textBox2.Text) || DR[0].ToString().Equals(textBox9.Text))
                                {
                                    MessageBox.Show("This hotel chinese name is assigned,Please input another hotel name");
                                    return;
                                }
                            }
                            con.Close();
                        }
                    }
                    else if (string.IsNullOrWhiteSpace(textBox6.Text))
                    {
                        MessageBox.Show("Region cannot be empty");
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(textBox7.Text))
                    {
                        MessageBox.Show("Address cannot be empty");
                        return;
                    }
                    else
                    {
                        Regex checkAddress = new Regex(@"\d{1,3}.?\d{0,3}\s[a-zA-Z]{2,30}(\s[a-zA-Z]{ 2,15})?([#\.0-9a-zA-Z]*)?");
                        if (checkAddress.IsMatch(textBox7.Text))
                        {
                            address = textBox7.Text;
                        }
                        else {
                            MessageBox.Show("Please enter the correct address");
                            return;
                        }
                        OleDbCommand cmd_hotel = new OleDbCommand();
                        OleDbConnection con = new OleDbConnection(hotelconnStr);
                        cmd_hotel.CommandType = CommandType.Text;
                        cmd_hotel.CommandText = "INSERT INTO Hotel(Hotelid,hotel_chi_name,hotel_en_name,star,rating,region,address,tel) "
                            + "VALUES (@hotelid,@chi,@en,@star,@rating,@region,@address,@tel)";
                        cmd_hotel.Parameters.AddWithValue("@hotelid", hotelid);
                        cmd_hotel.Parameters.AddWithValue("@chi", textBox2.Text);
                        if (string.IsNullOrWhiteSpace(textBox3.Text))
                        {
                            cmd_hotel.Parameters.AddWithValue("@en", DBNull.Value);
                        }
                        else
                        {
                            cmd_hotel.Parameters.AddWithValue("@en", textBox3.Text);
                        }
                        cmd_hotel.Parameters.AddWithValue("@star", Convert.ToDouble(numericUpDown1.Value));
                        cmd_hotel.Parameters.AddWithValue("@rating", Convert.ToDouble(numericUpDown2.Value));
                        cmd_hotel.Parameters.AddWithValue("@region", textBox6.Text);
                        cmd_hotel.Parameters.AddWithValue("@address", textBox7.Text);

                        if (string.IsNullOrWhiteSpace(textBox8.Text))
                        {
                            cmd_hotel.Parameters.AddWithValue("@tel", DBNull.Value);
                        }
                        else
                        {
                            cmd_hotel.Parameters.AddWithValue("@tel", Int32.Parse(textBox8.Text));
                        }
                        cmd_hotel.Connection = con;
                        con.Open();
                        cmd_hotel.ExecuteNonQuery();
                        MessageBox.Show("Hotel record added successfully.");
                        con.Close();
                        this.Close();
                    }
                }
                else if (checkBox2.Checked)
                {
                    if (string.IsNullOrWhiteSpace(textBox9.Text))
                    {
                        MessageBox.Show("Hotel Chinese name cannot be empty");
                        return;
                    }
                    else if (!string.IsNullOrWhiteSpace(textBox2.Text))
                    {
                        using (OleDbConnection con = new OleDbConnection(hotelconnStr))
                        {
                            string Sql = "select hotel_chi_name from hotel";
                            OleDbCommand cmd = new OleDbCommand(Sql, con);
                            con.Open();
                            OleDbDataReader DR = cmd.ExecuteReader();
                            while (DR.Read())
                            {
                                if (DR[0].ToString().Equals(textBox2.Text) || DR[0].ToString().Equals(textBox9.Text))
                                {
                                    MessageBox.Show("This hotel chinese name is assigned,Please input another hotel name");
                                    return;
                                }
                            }
                            con.Close();
                        }
                    }
                    else if (string.IsNullOrWhiteSpace(textBox10.Text))
                    {
                        MessageBox.Show("Hotel room name cannot be empty");
                        return;
                    }
                    else if (numericUpDown5.Value == 0.00m)
                    {
                        MessageBox.Show("Fare cannot be $0.00");
                        return;
                    }
                    else
                    {
                        OleDbCommand cmd_hotel = new OleDbCommand();
                        OleDbConnection con = new OleDbConnection(hotelconnStr);
                        cmd_hotel.CommandType = CommandType.Text;
                        cmd_hotel.CommandText = "INSERT INTO Hotel_room(Hotelid,hotel_chi_name,hotel_room_name,Hotel_room_size,max_adults,max_child,hotel_room_description,fare) "
                            + "VALUES (@hotelid,@chi,@room,@size,@adult,@child,@description,@fare)";
                        cmd_hotel.Parameters.AddWithValue("@hotelid", hotelid);
                        cmd_hotel.Parameters.AddWithValue("@chi", textBox9.Text);
                        cmd_hotel.Parameters.AddWithValue("@room", textBox10.Text);
                        if (string.IsNullOrWhiteSpace(textBox11.Text))
                        {
                            cmd_hotel.Parameters.AddWithValue("@size", DBNull.Value);
                        }
                        else
                        {
                            cmd_hotel.Parameters.AddWithValue("@size", textBox11.Text);
                        }
                        cmd_hotel.Parameters.AddWithValue("@adult", numericUpDown3.Value);
                        cmd_hotel.Parameters.AddWithValue("@child", numericUpDown4.Value);
                        if (string.IsNullOrWhiteSpace(textBox13.Text))
                        {
                            cmd_hotel.Parameters.AddWithValue("@description", DBNull.Value);
                        }
                        else
                        {
                            cmd_hotel.Parameters.AddWithValue("@description", textBox13.Text);
                        }
                        cmd_hotel.Parameters.AddWithValue("@fare", numericUpDown5.Value);
                        cmd_hotel.Connection = con;
                        con.Open();
                        cmd_hotel.ExecuteNonQuery();
                        MessageBox.Show("Hotel room record added successfully.");
                        con.Close();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please choose at least one checkbox to add record to database");
                    return;
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox2.Text = textBox9.Text;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox9.Text = textBox2.Text;
            }
        }

        private void hotel_roomDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
