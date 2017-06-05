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
    public partial class frmAdminUpdateHotel : Form
    {
        private string[] hotel_details;
        private string[] hotel_room;
        private string hotelconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=hotel.accdb";

        public frmAdminUpdateHotel()
        {
            InitializeComponent();
        }

        public frmAdminUpdateHotel(string[] hotel_details,string[] hotel_room)
        {
            InitializeComponent();
            this.hotel_room = hotel_room;
            this.hotel_details = hotel_details;
        }

        private void frmAdminUpdateHotel_Load(object sender, EventArgs e)
        {
            textBox1.Text = hotel_details[0];
            textBox2.Text = hotel_details[1];
            textBox3.Text = hotel_details[2];
            numericUpDown1.Value = Decimal.Parse(hotel_details[3]);
            numericUpDown2.Value = Decimal.Parse(hotel_details[4]);
            textBox6.Text = hotel_details[5];
            textBox7.Text = hotel_details[6];
            textBox8.Text = hotel_details[7];

            textBox9.Text = hotel_room[1];
            textBox10.Text = hotel_room[2];
            textBox11.Text = hotel_room[3];
            numericUpDown3.Value = Decimal.Parse(hotel_room[4]);
            numericUpDown4.Value = Decimal.Parse(hotel_room[5]);
            textBox13.Text = hotel_room[6];
            numericUpDown5.Value = Decimal.Parse(hotel_room[7]);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox9.Text = textBox2.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox9.Text;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Hotel Chinese name cannot be empty");
                textBox2.Text = hotel_details[0];
                textBox9.Text = textBox2.Text;
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox9.Text))
            {
                MessageBox.Show("Hotel Chinese name cannot be empty");
                textBox9.Text = hotel_room[1];
                textBox2.Text = textBox9.Text;
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox10.Text))
            {
                MessageBox.Show("Hotel room name cannot be empty");
                textBox10.Text = hotel_room[2];
            }
        }

        private void numericUpDown5_Leave(object sender, EventArgs e)
        {

        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Hotel region cannot be empty");
                textBox6.Text = hotel_details[5];
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Hotel address cannot be empty");
                textBox7.Text = hotel_details[6];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update this record?", "Update record",
MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string address;
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
                cmd_hotel.CommandText = "Update Hotel set hotel_en_name=@en,star=@star,rating=@rating,region=@region,address=@address,tel=@tel "
                    + "where hotelid=@hotelid";
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
                cmd_hotel.Parameters.AddWithValue("@hotelid", textBox1.Text);
                cmd_hotel.Connection = con;
                con.Open();
                cmd_hotel.ExecuteNonQuery();
                MessageBox.Show("Hotel record added successfully.");
                con.Close();
                OleDbCommand cmd_hotel_room = new OleDbCommand();
                OleDbConnection con_room = new OleDbConnection(hotelconnStr);
                cmd_hotel_room.CommandType = CommandType.Text;
                cmd_hotel_room.CommandText = "Update Hotel_room set Hotel_room_size=@size,max_adults=@adult,max_child=@child,hotel_room_description=@description,fare=@fare "
                    + "where hotel_chi_name=@chi and hotel_room_name=@room";
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
                cmd_hotel_room.Parameters.AddWithValue("@chi", textBox9.Text);
                cmd_hotel_room.Parameters.AddWithValue("@room", textBox10.Text);

                cmd_hotel_room.Connection = con_room;
                con_room.Open();
                cmd_hotel_room.ExecuteNonQuery();
                MessageBox.Show("Hotel room record updated successfully.");
                con_room.Close();
                this.Close();
            }
        }

        private void numericUpDown5_Leave_1(object sender, EventArgs e)
        {
            if (numericUpDown5.Value == 0.00m)
            {
                MessageBox.Show("Fare cannot be $0.00");
                numericUpDown5.Value = Decimal.Parse(hotel_room[7]);
            }
        }
    }
}
