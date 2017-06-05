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
    public partial class frmTransport : Form
    {
        public static string staffname;
        private int first = 0, second = 0, third = 0, forth = 0;
        private double equip1 = 0,subtotal;
        private string custconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=customerBooking.accdb";
        public string custid = "";
        private string custname;
        private string attractbookid;
        private string getvehicleid, getequipid;
        private DateTime attractDate;
        private DateTime? start=null, end=null;
        private bool equipmentorder=false;
        public frmTransport()
        {
            InitializeComponent();

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void vehicleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.vehicleBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.vehicleDataSet);
        }

        private void frmTransport_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'customerBookingDataSet.AttractionBooking' 資料表。您可以視需要進行移動或移除。
            this.attractionBookingTableAdapter.Fill(this.customerBookingDataSet.AttractionBooking);
            attractionBookingBindingSource.Filter = "attractname='a'";
            pictureBox2.Image = Properties.Resources.TT_Transport;
            // TODO: 這行程式碼會將資料載入 'vehicleDataSet.Equipment' 資料表。您可以視需要進行移動或移除。
            this.equipmentTableAdapter.Fill(this.vehicleDataSet.Equipment);
            // TODO: 這行程式碼會將資料載入 'vehicleDataSet.Vehicle' 資料表。您可以視需要進行移動或移除。
            this.vehicleTableAdapter.Fill(this.vehicleDataSet.Vehicle);
            label12.Text = "Staff: " + staffname;
            timer1.Start();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MM-dd-yyyy";
            equipmentDataGridView.Columns["equipID"].Visible = false;
            equipmentDataGridView.Visible = false;
            //textBox1.Enabled = false;
            numericUpDown1.Enabled = false;
            //textBox3.Enabled = false;
            //textBox4.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button1.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            using (OleDbConnection con = new OleDbConnection(custconnStr))
            {
                string Sql = "select surname,givenname from customer,attractionbooking where attractionbooking.custid=customer.custid and vehiclestatus='not ordered'";
                OleDbCommand cmd = new OleDbCommand(Sql, con);
                con.Open();
                OleDbDataReader DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    comboBox1.Items.Add(DR[0] + " " + DR[1]);
                }
                con.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ucSlideMenu1.Location = new Point(ucSlideMenu1.Location.X, -175);
            do
            {
                ucSlideMenu1.Location = new Point(ucSlideMenu1.Location.X, ucSlideMenu1.Location.Y + 1);
            } while (ucSlideMenu1.Location.Y < 0);
            ucSlideMenu1.button5.Enabled = false;
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox2.SelectedItem.Equals("car"))
            {
                vehicleBindingSource.Filter = "vehicle_type = 'car'";
            }
            else if (comboBox2.SelectedItem.Equals("coach"))
            {
                vehicleBindingSource.Filter = "vehicle_type = 'coach'";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Please select a payment method in the combo box");
                return;
            }
            if (numericUpDown1.Enabled == true && numericUpDown1.Value < 1)
            {
                MessageBox.Show("Please order at least one equipment or cancel it");
                return;
            }
            if (start==null)
                MessageBox.Show("Please choose pickup date");
            else if(end==null){
                MessageBox.Show("Please choose drop-off date");
            }
            else {
                label29.Text = "Confirming";
                button5.Enabled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(1);
            if (dateTimePicker1.Value < attractDate)
            {
                MessageBox.Show("Pickup date cannot smaller than attraction booking date, attraction booking date is " + attractDate.ToShortDateString());
                dateTimePicker1.Value = attractDate;
                return;
            }
            dateTimePicker2.Enabled = true;
            if (dateTimePicker2.Enabled == true)
            {
                DateTime d1 = dateTimePicker1.Value;
                DateTime d2 = dateTimePicker2.Value;
                if (dateTimePicker1.Value > dateTimePicker2.Value)
                {
                    MessageBox.Show("Drop-off date cannot higher than pickup date");
                    label36.Text = "1";
                    d1 = d2;
                }
                else
                {
                    label36.Text = ((int)(d2 - d1).TotalDays + 1).ToString();
                    d1 = dateTimePicker1.Value;
                    
                }
                double vehicletotal = Double.Parse(label38.Text) * Double.Parse(label36.Text);
                label31.Text = vehicletotal.ToString();
                start = d1;
                button4.Enabled = true;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime d1 = dateTimePicker1.Value;
            DateTime d2 = dateTimePicker2.Value;
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Drop-off date cannot higher than pickup date");
                label36.Text = "1";
                d1 = d2;
            }
            else
            {
                label36.Text = ((int)(d2 - d1).TotalDays + 1).ToString();
                d2 = dateTimePicker2.Value;
            }
            double vehicletotal = Double.Parse(label38.Text) * Double.Parse(label36.Text);
            label31.Text = vehicletotal.ToString();
            end = d2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTransport vehicle = new frmTransport();
            vehicle.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (textBox2.Enabled == true)
            //    equip1 = Double.Parse(label46.Text);
            //equip2 = Double.Parse(label45.Text);
            //if (textBox3.Enabled == true)
            //    equip3 = Double.Parse(label44.Text);
            //if (textBox4.Enabled == true)
            //    equip4 = Double.Parse(label43.Text);
            //int equip1_num = 0, equip3_num = 0, equip4_num = 0;
            //if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text.Equals("0"))
            //{
            //    equip2 = 0;
            //    textBox1.Text = "0";
            //}
            //if (string.IsNullOrEmpty(textBox2.Text) || textBox2.Text.Equals("0"))
            //{
            //    equip1 = 0;
            //}
            //else
            //{
            //    equip1_num = Int32.Parse(textBox2.Text);
            //}
            //if (string.IsNullOrEmpty(textBox3.Text) || textBox3.Text.Equals("0"))
            //{
            //    equip3 = 0;
            //}
            //else
            //{
            //    equip3_num = Int32.Parse(textBox3.Text);
            //}
            //if (string.IsNullOrEmpty(textBox4.Text) || textBox4.Text.Equals("0"))
            //{
            //    equip4 = 0;
            //}
            //else
            //{
            //    equip4_num = Int32.Parse(textBox4.Text);
            //}

            //if (!string.IsNullOrEmpty(textBox1.Text))
            //{
            //    int equip2_num = Int32.Parse(textBox1.Text);
            //    subtotal = (equip1 * equip1_num) + (equip2 * equip2_num) + (equip3 * equip3_num) + (equip4 * equip4_num);
            //    label32.Text = subtotal.ToString();
            //    double grandtotal = subtotal + Double.Parse(label31.Text);
            //    label33.Text = grandtotal.ToString();
            //}
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //if (textBox2.Enabled == true)
            //    equip1 = Double.Parse(label46.Text);
            //if (textBox1.Enabled == true)
            //    equip2 = Double.Parse(label45.Text);
            //equip3 = Double.Parse(label44.Text);
            //if (textBox4.Enabled == true)
            //    equip4 = Double.Parse(label43.Text);
            //int equip2_num = 0, equip1_num = 0, equip4_num = 0;
            //if (string.IsNullOrEmpty(textBox3.Text) || textBox3.Text.Equals("0"))
            //{
            //    equip3 = 0;
            //    textBox3.Text = "0";
            //}
            //if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text.Equals("0"))
            //{
            //    equip2 = 0;
            //}
            //else
            //{
            //    equip2_num = Int32.Parse(textBox1.Text);
            //}
            //if (string.IsNullOrEmpty(textBox2.Text) || textBox2.Text.Equals("0"))
            //{
            //    equip1 = 0;
            //}
            //else
            //{
            //    equip1_num = Int32.Parse(textBox2.Text);
            //}
            //if (string.IsNullOrEmpty(textBox4.Text) || textBox4.Text.Equals("0"))
            //{
            //    equip4 = 0;
            //}
            //else
            //{
            //    equip4_num = Int32.Parse(textBox4.Text);
            //}

            //if (!string.IsNullOrEmpty(textBox3.Text))
            //{
            //    int equip3_num = Int32.Parse(textBox3.Text);
            //    subtotal = (equip1 * equip1_num) + (equip2 * equip2_num) + (equip3 * equip3_num) + (equip4 * equip4_num);
            //    label32.Text = subtotal.ToString();
            //    double grandtotal = subtotal + Double.Parse(label31.Text);
            //    label33.Text = grandtotal.ToString();
            //}
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //if (textBox2.Enabled == true)
            //    equip1 = Double.Parse(label46.Text);
            //if (textBox1.Enabled == true)
            //    equip2 = Double.Parse(label45.Text);
            //if (textBox3.Enabled == true)
            //    equip3 = Double.Parse(label44.Text);
            //equip4 = Double.Parse(label43.Text);
            //int equip2_num = 0, equip3_num = 0, equip1_num = 0;
            //if (string.IsNullOrEmpty(textBox2.Text) || textBox4.Text.Equals("0"))
            //{
            //    equip1 = 0;
            //    textBox4.Text = "0";
            //}
            //if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text.Equals("0"))
            //{
            //    equip2 = 0;
            //}
            //else
            //{
            //    equip2_num = Int32.Parse(textBox1.Text);
            //}
            //if (string.IsNullOrEmpty(textBox3.Text) || textBox3.Text.Equals("0"))
            //{
            //    equip3 = 0;
            //}
            //else
            //{
            //    equip3_num = Int32.Parse(textBox3.Text);
            //}
            //if (string.IsNullOrEmpty(textBox2.Text) || textBox2.Text.Equals("0"))
            //{
            //    equip1 = 0;
            //}
            //else
            //{
            //    equip1_num = Int32.Parse(textBox2.Text);
            //}

            //if (!string.IsNullOrEmpty(textBox4.Text))
            //{
            //    int equip4_num = Int32.Parse(textBox4.Text);
            //    subtotal = (equip1 * equip1_num) + (equip2 * equip2_num) + (equip3 * equip3_num) + (equip4 * equip4_num);
            //    label32.Text = subtotal.ToString();
            //    double grandtotal = subtotal + Double.Parse(label31.Text);
            //    label33.Text = grandtotal.ToString();
            //}
        }

        private void attractionBookingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == attractionBookingDataGridView.Columns[11].Index && e.RowIndex >= 0)
            {
                attractbookid= attractionBookingDataGridView.CurrentRow.Cells["AttractID"].Value.ToString();
                label30.Text = attractionBookingDataGridView.CurrentRow.Cells["AttractName"].Value.ToString();
                label1.Text = attractionBookingDataGridView.CurrentRow.Cells["VehicleStatus"].Value.ToString();
                attractDate = DateTime.Parse(attractionBookingDataGridView.CurrentRow.Cells["attractionDate"].Value.ToString());
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void airFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAir air = new frmAir();
            air.Show();
            this.Hide();
        }

        private void vehicleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (label30.Text.Equals("-----"))
            {
                MessageBox.Show("Please choose an attraction of customer to order attraction vehicle");
                return;
            }
            if (e.ColumnIndex == vehicleDataGridView.Columns[7].Index && e.RowIndex >= 0)
            {
                if (vehicleDataGridView.CurrentRow.Cells["VehicleID"].Value.ToString() == "car01")
                    pictureBox1.Image = Properties.Resources.car01;
                else if (vehicleDataGridView.CurrentRow.Cells["VehicleID"].Value.ToString() == "car02")
                    pictureBox1.Image = Properties.Resources.car02;
                else if (vehicleDataGridView.CurrentRow.Cells["VehicleID"].Value.ToString() == "car03")
                    pictureBox1.Image = Properties.Resources.car03;
                else if (vehicleDataGridView.CurrentRow.Cells["VehicleID"].Value.ToString() == "car04")
                    pictureBox1.Image = Properties.Resources.car04;
                else if (vehicleDataGridView.CurrentRow.Cells["VehicleID"].Value.ToString() == "car05")
                    pictureBox1.Image = Properties.Resources.car05;
                else if (vehicleDataGridView.CurrentRow.Cells["VehicleID"].Value.ToString() == "car06")
                    pictureBox1.Image = Properties.Resources.car06;
                else if (vehicleDataGridView.CurrentRow.Cells["VehicleID"].Value.ToString() == "car07")
                    pictureBox1.Image = Properties.Resources.car07;
                else if (vehicleDataGridView.CurrentRow.Cells["VehicleID"].Value.ToString() == "car08")
                    pictureBox1.Image = Properties.Resources.car08;
                else if (vehicleDataGridView.CurrentRow.Cells["VehicleID"].Value.ToString() == "car09")
                    pictureBox1.Image = Properties.Resources.car09;
                else if (vehicleDataGridView.CurrentRow.Cells["VehicleID"].Value.ToString() == "car10")
                    pictureBox1.Image = Properties.Resources.car10;
                else if (vehicleDataGridView.CurrentRow.Cells["VehicleID"].Value.ToString() == "car11")
                    pictureBox1.Image = Properties.Resources.car11;
                else
                    pictureBox1.Image = Properties.Resources.car12;
                label26.Text = vehicleDataGridView.CurrentRow.Cells["Vehicle_Name"].Value.ToString();
                label31.Text = vehicleDataGridView.CurrentRow.Cells["VehiclePrice"].Value.ToString();
                label27.Text = vehicleDataGridView.CurrentRow.Cells["Vehicle_Type"].Value.ToString();
                label28.Text = vehicleDataGridView.CurrentRow.Cells["Capacity"].Value.ToString();
                label35.Text = vehicleDataGridView.CurrentRow.Cells["Gear"].Value.ToString();
                label34.Text = vehicleDataGridView.CurrentRow.Cells["Color"].Value.ToString();
                label38.Text = vehicleDataGridView.CurrentRow.Cells["VehiclePrice"].Value.ToString();
                label36.Text = "1";
                getvehicleid = vehicleDataGridView.CurrentRow.Cells["VehicleID"].Value.ToString();
                tabControl1.SelectedIndex = 1;
                equipmentDataGridView.Visible = true;
                button1.Enabled = true;
                comboBox3.Enabled = true;
                dateTimePicker1.Enabled = true;
                equipmentBindingSource.Filter = "suitable='" + vehicleDataGridView.CurrentRow.Cells["Vehicle_Type"].Value.ToString() + "'";
            }
        }
        //label37.Text = equipmentDataGridView.CurrentRow.Cells["equipment"].Value.ToString();
        private void equipmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            equipmentorder = true;
            if (equipmentDataGridView.CurrentRow.Cells[0].Value.ToString() == "e01")
                pictureBox3.Image = Properties.Resources.e01;
            else if (equipmentDataGridView.CurrentRow.Cells[0].Value.ToString() == "e02")
                pictureBox3.Image = Properties.Resources.e02;
            else if (equipmentDataGridView.CurrentRow.Cells[0].Value.ToString() == "e03")
                pictureBox3.Image = Properties.Resources.e03;
            else if (equipmentDataGridView.CurrentRow.Cells[0].Value.ToString() == "e04")
                pictureBox3.Image = Properties.Resources.e04;
            else if (equipmentDataGridView.CurrentRow.Cells[1].Value.ToString() == "e05")
                pictureBox3.Image = Properties.Resources.e05;
            if (e.ColumnIndex == vehicleDataGridView.Columns[4].Index && e.RowIndex >= 0)
            {
                //if (e.RowIndex == 0)
                //{
                    if (first == 0)
                    {
                        label37.Text = equipmentDataGridView.CurrentRow.Cells["equipment"].Value.ToString();
                        label46.Text = equipmentDataGridView.CurrentRow.Cells["equipPrice"].Value.ToString();
                        getequipid = equipmentDataGridView.CurrentRow.Cells["EquipID"].Value.ToString();
                        numericUpDown1.Enabled = true;
                        first++;
                    }
                    else
                    {
                        label37.Text = "-----";
                        label46.Text = "-----";
                        getequipid = "";
                        numericUpDown1.Enabled = false;
                        first--;
                    }
                //}
                //if (e.RowIndex == 1)
                //{
                //    if (second == 0)
                //    {
                //        label39.Text = equipmentDataGridView.CurrentRow.Cells["equipment"].Value.ToString();
                //        label45.Text = equipmentDataGridView.CurrentRow.Cells["equipPrice"].Value.ToString();
                //        textBox1.Enabled = true;
                //        second++;
                //    }
                //    else
                //    {
                //        label39.Text = "-----";
                //        label45.Text = "-----";
                //        textBox1.Enabled = false;
                //        second--;
                //    }
                //}
                //if (e.RowIndex == 2)
                //{
                //    if (third == 0)
                //    {
                //        label40.Text = equipmentDataGridView.CurrentRow.Cells["equipment"].Value.ToString();
                //        label44.Text = equipmentDataGridView.CurrentRow.Cells["equipPrice"].Value.ToString();
                //        textBox3.Enabled = true;
                //        third++;
                //    }
                //    else
                //    {
                //        label40.Text = "-----";
                //        label44.Text = "-----";
                //        textBox3.Enabled = false;
                //        third--;
                //    }
                //}
                //if (e.RowIndex == 3)
                //{
                //    if (forth == 0)
                //    {
                //        label41.Text = equipmentDataGridView.CurrentRow.Cells["equipment"].Value.ToString();
                //        label43.Text = equipmentDataGridView.CurrentRow.Cells["equipPrice"].Value.ToString();
                //        textBox4.Enabled = true;
                //        forth++;
                //    }
                //    else
                //    {
                //        label41.Text = "-----";
                //        label43.Text = "-----";
                //        textBox4.Enabled = false;
                //        forth--;
                //    }
                //}
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd_attract = new OleDbCommand();
            OleDbConnection con_attract = new OleDbConnection(custconnStr);
            cmd_attract.CommandType = CommandType.Text;
            cmd_attract.CommandText = "Update attractionbooking set vehiclestatus=@status where attractbookid=@id";
            cmd_attract.Parameters.AddWithValue("@status", "Confirmed");
            cmd_attract.Parameters.AddWithValue("@id", Int32.Parse(attractbookid));
            cmd_attract.Connection = con_attract;
            con_attract.Open();
            cmd_attract.ExecuteNonQuery();
            con_attract.Close();

            label29.Text = "Confirmed";
            //else if (textBox2.Enabled == true && textBox2.Text.Equals("0"))
            //{
            //    MessageBox.Show("Please order at least one equipment if choose one equipment ");
            //    return;
            //}
            //else if (textBox2.Enabled == true && textBox2.Text.Equals("0"))
            //{
            //    MessageBox.Show("Please order at least one equipment if choose one equipment ");
            //    return;
            //}
            //else if (textBox2.Enabled == true && textBox2.Text.Equals("0"))
            //{
            //    MessageBox.Show("Please order at least one equipment if choose one equipment ");
            //    return;
            //}
            if (equipmentorder == true)
            {
                OleDbCommand cmd = new OleDbCommand();
                OleDbConnection con = new OleDbConnection(custconnStr);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO VehicleBooking(AttractionBookID,VehicleID,EquipID,BookDay,VehicleBookPrice,EquipNum,EquipBookPrice,OrderDate,OrderBy,CustID,PickupDate,DropoffDate,payment) "
                    + "VALUES (@bookid,@vehicleID,@equipID,@bookday,@vehiclebookprice,@equipnum,@equipbookprice,@orderdate,@orderby,@custid,@pickupdate,@dropoffdate,@payment)";
                cmd.Parameters.AddWithValue("@bookid", Int32.Parse(attractbookid));
                cmd.Parameters.AddWithValue("@vehicleID", getvehicleid);
                cmd.Parameters.AddWithValue("@equipID", getequipid);
                cmd.Parameters.AddWithValue("@bookday", Int32.Parse(label36.Text));
                cmd.Parameters.AddWithValue("@vehiclebookprice", Double.Parse(label31.Text));
                cmd.Parameters.AddWithValue("@equipnum", Convert.ToInt32(numericUpDown1.Value));
                cmd.Parameters.AddWithValue("@equipbookprice", Double.Parse(label32.Text));
                cmd.Parameters.AddWithValue("@orderdate", DateTime.Now.ToShortDateString());
                cmd.Parameters.AddWithValue("@orderBy", frmLogin.staffid);
                cmd.Parameters.AddWithValue("@custid", custid);
                cmd.Parameters.AddWithValue("@pickupdate", dateTimePicker1.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@dropoffdate", dateTimePicker2.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@payment", comboBox3.GetItemText(comboBox3.SelectedItem));
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Transport ordered successfully.");
                con.Close();
            }else if (equipmentorder == false)
            {
                OleDbCommand cmd = new OleDbCommand();
                OleDbConnection con = new OleDbConnection(custconnStr);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO VehicleBooking(AttractionBookID,VehicleID,EquipID,BookDay,VehicleBookPrice,EquipNum,EquipBookPrice,OrderDate,OrderBy,CustID,PickupDate,DropoffDate,payment) "
                    + "VALUES (@bookid,@vehicleID,@equipID,@bookday,@vehiclebookprice,@equipnum,@equipbookprice,@orderdate,@orderby,@custid,@pickupdate,@dropoffdate,@payment)";
                cmd.Parameters.AddWithValue("@bookid", Int32.Parse(attractbookid));
                cmd.Parameters.AddWithValue("@vehicleID", getvehicleid);
                cmd.Parameters.AddWithValue("@equipID", "");
                cmd.Parameters.AddWithValue("@bookday", Int32.Parse(label36.Text));
                cmd.Parameters.AddWithValue("@vehiclebookprice", Double.Parse(label31.Text));
                cmd.Parameters.AddWithValue("@equipnum", 0);
                cmd.Parameters.AddWithValue("@equipbookprice", 0);
                cmd.Parameters.AddWithValue("@orderdate", DateTime.Now.ToShortDateString());
                cmd.Parameters.AddWithValue("@orderBy", frmLogin.staffid);
                cmd.Parameters.AddWithValue("@custid", custid);
                cmd.Parameters.AddWithValue("@pickupdate", dateTimePicker1.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@dropoffdate", dateTimePicker2.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@payment", comboBox3.GetItemText(comboBox3.SelectedItem));
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Transport ordered successfully.");
                con.Close();
            }
            frmModuleSelection menu = new frmModuleSelection();
            menu.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            custname = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            using (OleDbConnection con = new OleDbConnection(custconnStr))
            {
                string Sql = "select customer.surname,customer.givenname,customer.custid,attractionbooking.attractname,attractionbooking.AttractBookID from customer,attractionbooking where attractionbooking.custid=customer.custid and attractionbooking.vehiclestatus='not ordered'";
                OleDbCommand cmd = new OleDbCommand(Sql, con);
                con.Open();
                OleDbDataReader DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    if ((DR[0] + " " + DR[1]).Equals(custname))
                    {
                        custid = DR[2].ToString();
                        attractionBookingBindingSource.Filter = "custid='" + DR[2].ToString() + "' and vehiclestatus='not ordered'";
                    }
                }
                con.Close();
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            equip1 = Double.Parse(label46.Text);
                int equip1_num = Convert.ToInt32(numericUpDown1.Value);
                subtotal = (equip1 * equip1_num);
                label32.Text = subtotal.ToString();
                double grandtotal = subtotal + Double.Parse(label31.Text);
                label33.Text = grandtotal.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label47.Text = "Time : " + DateTime.Now.ToString();
        }
    }
}
