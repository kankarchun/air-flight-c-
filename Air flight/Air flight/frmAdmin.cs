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
    public partial class frmAdmin : Form
    {
        private int rowindex=-1;
        private int rowindex2 = -1;
        public static string staffname;
        private string custconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=customerBooking.accdb";
        private string flightconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=ticketTailor_db.accdb";
        private string hotelconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=hotel.accdb";
        private string cruiseconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=cruise.accdb";
        private string attractconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=attraction.accdb";
        private string vehicleconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=vehicle.accdb";
        private bool vehicleClick = false, equipClick = false;

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'cruiseDataSet.Default' 資料表。您可以視需要進行移動或移除。
            this.cruiseTableAdapter.Fill(this.cruiseDataSet.Default);
            // TODO: 這行程式碼會將資料載入 'hotelDataSet.Hotel_room' 資料表。您可以視需要進行移動或移除。
            this.hotel_roomTableAdapter.Fill(this.hotelDataSet.Hotel_room);
            // TODO: 這行程式碼會將資料載入 'hotelDataSet.Hotel' 資料表。您可以視需要進行移動或移除。
            this.hotelTableAdapter.Fill(this.hotelDataSet.Hotel);
            // TODO: 這行程式碼會將資料載入 'customerBookingDataSet.Customer' 資料表。您可以視需要進行移動或移除。
            this.customerTableAdapter.Fill(this.customerBookingDataSet.Customer);
            // TODO: 這行程式碼會將資料載入 'customerBookingDataSet.Staff' 資料表。您可以視需要進行移動或移除。
            this.staffTableAdapter.Fill(this.customerBookingDataSet.Staff);
            // TODO: 這行程式碼會將資料載入 'vehicleDataSet.Equipment' 資料表。您可以視需要進行移動或移除。
            this.equipmentTableAdapter.Fill(this.vehicleDataSet.Equipment);
            // TODO: 這行程式碼會將資料載入 'vehicleDataSet.Vehicle' 資料表。您可以視需要進行移動或移除。
            this.vehicleTableAdapter.Fill(this.vehicleDataSet.Vehicle);
            // TODO: 這行程式碼會將資料載入 'attractionDataSet.Default' 資料表。您可以視需要進行移動或移除。
            this.attractTableAdapter.Fill(this.attractionDataSet.Default);
            // TODO: 這行程式碼會將資料載入 'cruiseDataSet.Default' 資料表。您可以視需要進行移動或移除。
            this.cruiseTableAdapter.Fill(this.cruiseDataSet.Default);
            // TODO: 這行程式碼會將資料載入 'hotelDataSet.Hotel' 資料表。您可以視需要進行移動或移除。
            this.hotelTableAdapter.Fill(this.hotelDataSet.Hotel);
            // TODO: 這行程式碼會將資料載入 'ticketDataSet.DirectDefault' 資料表。您可以視需要進行移動或移除。
            this.directDefaultTableAdapter.Fill(this.ticketDataSet.DirectDefault);
            directDefaultDataGridView.Columns[9].DefaultCellStyle.Format = "HH:mm";
            directDefaultDataGridView.Columns[10].DefaultCellStyle.Format = "HH:mm";
            label12.Text = "Staff: " + staffname;
            timer1.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmModuleSelection menu = new frmModuleSelection();
            menu.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void directDefaultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAdminFlight flight = new frmAdminFlight();
            frmAdminHotel hotel = new frmAdminHotel();
            frmAdminCruise cruise = new frmAdminCruise();
            frmAdminAttraction attraction = new frmAdminAttraction();
            frmAdminVehicle vehicle = new frmAdminVehicle();
            frmAdminStaff staff = new frmAdminStaff();
            frmAdminCustomer cust = new frmAdminCustomer();

            if (tabControl1.SelectedIndex == 0)
            {
                flight.Show();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                hotel.Show();
            }else if (tabControl1.SelectedIndex == 2)
            {
                cruise.Show();
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                attraction.Show();
            }
            else if (tabControl1.SelectedIndex == 4)
            {
                vehicle.Show();
            }
            else if (tabControl1.SelectedIndex == 5)
            {
                staff.Show();
            }
            else if (tabControl1.SelectedIndex == 6)
            {
                cust.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 0)
            {
                if (rowindex == -1)
                {
                    MessageBox.Show("Please select a air flight record to update");
                    return;
                }
                int currFlightid = Int32.Parse(directDefaultDataGridView.CurrentRow.Cells["Flightid"].Value.ToString());
                string currClass = directDefaultDataGridView.CurrentRow.Cells["ClassType"].Value.ToString();
                string sql="";
                string[] currRow = new string[17];
                string[] currRowIndriect = new string[4];
                bool indirect = false;

                using (OleDbConnection con = new OleDbConnection(flightconnStr))
                {

                    if (directDefaultDataGridView.CurrentRow.Cells["FlightType"].Value.ToString().Equals("Direct"))
                    {
                         sql = "select fs.flightid,fs.carrier,fs.edd,fs.eda,fs.etd,fs.eta,fs.origin,fs.dest,fs.aircraft,"
                            + "fs.travelTime,fs.flightno,fc.class,fc.price_adult,fc.price_children,fc.price_infant,fc.tax,fs.flighttype "
                            + "from flightschedule fs,flightclass fc "
                            + "where fs.flightid = fc.flightid and fs.flightid = "+currFlightid+" and fc.class='"+currClass+"'";
                    }
                    else
                    {
                        sql = "select fs.flightid,fs.carrier,fs.edd,fs.eda,fs.etd,fs.eta,fs.origin,fs.dest,fs.aircraft,"
                           + "fs.travelTime,fs.flightno,fc.class,fc.price_adult,fc.price_children,fc.price_infant,fc.tax,fs.flighttype,in.stopno,in.stop,in.eda,in.eta "
                           + "from flightschedule fs,flightclass fc, indirect in "
                           + "where fs.flightid = fc.flightid and fs.flightid = " + currFlightid + " and fc.class='" + currClass + "' and fs.flightid=in.flightid";
                    }
                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    con.Open();
                    OleDbDataReader DR = cmd.ExecuteReader();
                    while (DR.Read())
                    {
                        for(int i = 0; i < 17; i++)
                        {
                            currRow[i] = DR[i].ToString();
                        }
                        if (directDefaultDataGridView.CurrentRow.Cells["FlightType"].Value.ToString().Equals("Indirect"))
                        {
                            indirect = true;
                            for (int a = 0; a < 4; a++)
                            {
                                currRowIndriect[a] = DR[a + 17].ToString();
                            }
                        }
                    }
                    con.Close();
                }
                DateTime depTime = DateTime.Parse(currRow[4]);
                string depTimeFormate = depTime.ToString("HH:mm");
                currRow[4] = depTimeFormate;
                DateTime arrTime = DateTime.Parse(currRow[5]);
                string arrTimeFormate = arrTime.ToString("HH:mm");
                currRow[5] = arrTimeFormate;
                if (indirect)
                {
                    DateTime stopArrTime = DateTime.Parse(currRowIndriect[3]);
                    string stopArrTimeFormate = depTime.ToString("HH:mm");
                    currRowIndriect[3] = stopArrTimeFormate;
                }
                frmAdminUpdateFlight flight = new frmAdminUpdateFlight(currRow, true, indirect, currRowIndriect);
                flight.Show();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                if (rowindex == -1 || rowindex2 == -1)
                {
                    MessageBox.Show("Please select a hotel record and hotel room record to update");
                    return;
                }
                string[] hotel_details = new string[8];
                string[] hotel_room = new string[8];
                hotel_details[0] = hotelDataGridView.Rows[rowindex2].Cells[0].Value.ToString();
                hotel_details[1] = hotelDataGridView.Rows[rowindex2].Cells[1].Value.ToString();
                hotel_details[2] = hotelDataGridView.Rows[rowindex2].Cells[2].Value.ToString();
                hotel_details[3] = hotelDataGridView.Rows[rowindex2].Cells[3].Value.ToString();
                hotel_details[4] = hotelDataGridView.Rows[rowindex2].Cells[4].Value.ToString();
                hotel_details[5] = hotelDataGridView.Rows[rowindex2].Cells[5].Value.ToString();
                hotel_details[6] = hotelDataGridView.Rows[rowindex2].Cells[6].Value.ToString();
                hotel_details[7] = hotelDataGridView.Rows[rowindex2].Cells[7].Value.ToString();

                hotel_room[0] = hotel_roomDataGridView.Rows[rowindex].Cells[0].Value.ToString();
                hotel_room[1] = hotel_roomDataGridView.Rows[rowindex].Cells[1].Value.ToString();
                hotel_room[2] = hotel_roomDataGridView.Rows[rowindex].Cells[2].Value.ToString();
                hotel_room[3] = hotel_roomDataGridView.Rows[rowindex].Cells[3].Value.ToString();
                hotel_room[4] = hotel_roomDataGridView.Rows[rowindex].Cells[4].Value.ToString();
                hotel_room[5] = hotel_roomDataGridView.Rows[rowindex].Cells[5].Value.ToString();
                hotel_room[6] = hotel_roomDataGridView.Rows[rowindex].Cells[6].Value.ToString();
                hotel_room[7] = hotel_roomDataGridView.Rows[rowindex].Cells[7].Value.ToString();

                frmAdminUpdateHotel hotel = new frmAdminUpdateHotel(hotel_details,hotel_room);
                hotel.Show();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                if (rowindex == -1)
                {
                    MessageBox.Show("Please select a cruise record to update");
                    return;
                }
                string[] cruise_details = new string[6];
                cruise_details[0] = cruiseDataGridView.Rows[rowindex].Cells[0].Value.ToString();
                cruise_details[1] = cruiseDataGridView.Rows[rowindex].Cells[1].Value.ToString();
                cruise_details[2] = cruiseDataGridView.Rows[rowindex].Cells[2].Value.ToString();
                cruise_details[3] = cruiseDataGridView.Rows[rowindex].Cells[4].Value.ToString();
                cruise_details[4] = cruiseDataGridView.Rows[rowindex].Cells[3].Value.ToString();
                cruise_details[5] = cruiseDataGridView.Rows[rowindex].Cells[5].Value.ToString();

                frmAdminUpdateCruise cruise = new frmAdminUpdateCruise(cruise_details);
                cruise.Show();
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                if (rowindex == -1)
                {
                    MessageBox.Show("Please select a attraction record to update");
                    return;
                }
                string[] attract_details = new string[6];
                attract_details[0] = attractionDataGridView.Rows[rowindex].Cells[0].Value.ToString();
                attract_details[1] = attractionDataGridView.Rows[rowindex].Cells[1].Value.ToString();
                attract_details[2] = attractionDataGridView.Rows[rowindex].Cells[2].Value.ToString();
                attract_details[3] = attractionDataGridView.Rows[rowindex].Cells[3].Value.ToString();
                attract_details[4] = attractionDataGridView.Rows[rowindex].Cells[4].Value.ToString();
                attract_details[5] = attractionDataGridView.Rows[rowindex].Cells[5].Value.ToString();

                frmAdminUpdateAttract attraction = new frmAdminUpdateAttract(attract_details);
                attraction.Show();
            }
            else if (tabControl1.SelectedIndex == 4)
            {
                if (rowindex == -1 && rowindex2 == -1)
                {
                    MessageBox.Show("Please select a vehicle record or equipment record to update");
                    return;
                }
                string[] vehicle_details = new string[7];
                string[] equip_details = new string[4];
                bool boolvehicle = false, boolequip = false;
                if (rowindex2 >= 0)
                {
                    vehicle_details[0] = vehicleDataGridView.Rows[rowindex2].Cells[0].Value.ToString();
                    vehicle_details[1] = vehicleDataGridView.Rows[rowindex2].Cells[1].Value.ToString();
                    vehicle_details[2] = vehicleDataGridView.Rows[rowindex2].Cells[2].Value.ToString();
                    vehicle_details[3] = vehicleDataGridView.Rows[rowindex2].Cells[3].Value.ToString();
                    vehicle_details[4] = vehicleDataGridView.Rows[rowindex2].Cells[4].Value.ToString();
                    vehicle_details[5] = vehicleDataGridView.Rows[rowindex2].Cells[5].Value.ToString();
                    vehicle_details[6] = vehicleDataGridView.Rows[rowindex2].Cells[6].Value.ToString();
                    boolvehicle = true;
                }
                if (rowindex >= 0)
                {
                    equip_details[0] = equipmentDataGridView.Rows[rowindex].Cells[0].Value.ToString();
                    equip_details[1] = equipmentDataGridView.Rows[rowindex].Cells[1].Value.ToString();
                    equip_details[2] = equipmentDataGridView.Rows[rowindex].Cells[2].Value.ToString();
                    equip_details[3] = equipmentDataGridView.Rows[rowindex].Cells[3].Value.ToString();
                    boolequip = true;
                }
                frmAdminUpdateVehicle vehicle = new frmAdminUpdateVehicle(vehicle_details, equip_details, boolvehicle, boolequip);
                vehicle.Show();
            }
            else if (tabControl1.SelectedIndex == 5)
            {
                if (rowindex == -1)
                {
                    MessageBox.Show("Please select a staff record to update");
                    return;
                }
                string[] staff_details = new string[10];
                staff_details[0] = staffDataGridView.Rows[rowindex].Cells[0].Value.ToString();
                staff_details[1] = staffDataGridView.Rows[rowindex].Cells[1].Value.ToString();
                staff_details[2] = staffDataGridView.Rows[rowindex].Cells[2].Value.ToString();
                staff_details[3] = staffDataGridView.Rows[rowindex].Cells[3].Value.ToString();
                staff_details[4] = staffDataGridView.Rows[rowindex].Cells[4].Value.ToString();
                staff_details[5] = staffDataGridView.Rows[rowindex].Cells[5].Value.ToString();
                staff_details[6] = staffDataGridView.Rows[rowindex].Cells[6].Value.ToString();
                staff_details[7] = staffDataGridView.Rows[rowindex].Cells[7].Value.ToString();
                staff_details[8] = staffDataGridView.Rows[rowindex].Cells[8].Value.ToString();
                staff_details[9] = staffDataGridView.Rows[rowindex].Cells[9].Value.ToString();
                frmAdminUpdateStaff staff = new frmAdminUpdateStaff(staff_details);
                staff.Show();
            }
            else if (tabControl1.SelectedIndex == 6)
            {
                if (rowindex == -1)
                {
                    MessageBox.Show("Please select a customer record to update");
                    return;
                }
                string[] cust_details = new string[8];
                cust_details[0] = customerDataGridView.Rows[rowindex].Cells[0].Value.ToString();
                cust_details[1] = customerDataGridView.Rows[rowindex].Cells[1].Value.ToString();
                cust_details[2] = customerDataGridView.Rows[rowindex].Cells[2].Value.ToString();
                cust_details[3] = customerDataGridView.Rows[rowindex].Cells[3].Value.ToString();
                cust_details[4] = customerDataGridView.Rows[rowindex].Cells[4].Value.ToString();
                cust_details[5] = customerDataGridView.Rows[rowindex].Cells[5].Value.ToString();
                cust_details[6] = customerDataGridView.Rows[rowindex].Cells[6].Value.ToString();
                cust_details[7] = customerDataGridView.Rows[rowindex].Cells[7].Value.ToString();
                frmAdminUpdateCustomer cust = new frmAdminUpdateCustomer(cust_details);
                cust.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {

                if (rowindex == -1)
                {
                    MessageBox.Show("Please select a record to delete");
                    return;
                }
                string flightno = directDefaultDataGridView.Rows[rowindex].Cells["FlightNo"].Value.ToString();
                string classType = directDefaultDataGridView.Rows[rowindex].Cells["ClassType"].Value.ToString();
                int flightid = Int32.Parse(directDefaultDataGridView.Rows[rowindex].Cells["FlightID"].Value.ToString());
                if (MessageBox.Show("Do you want to delete this record? Flightid: " + flightid + " Flightno: " + flightno + " Class: " + classType, "Delete record",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {


                    OleDbCommand command_this = new OleDbCommand();
                    OleDbConnection conn_this = new OleDbConnection(flightconnStr);
                    command_this.CommandType = CommandType.Text;
                    command_this.CommandText = "delete from flightclass where flightid=@id and class=@class";
                    command_this.Parameters.AddWithValue("@id", flightid);
                    command_this.Parameters.AddWithValue("@class", classType);
                    command_this.Connection = conn_this;
                    conn_this.Open();
                    command_this.ExecuteNonQuery();
                    conn_this.Close();

                    int count = -1;
                    string stmt = "SELECT COUNT(*) FROM flightclass where flightid="+flightid;
                    using (OleDbConnection thisConnection = new OleDbConnection(flightconnStr))
                    {
                        using (OleDbCommand cmdCount = new OleDbCommand(stmt, thisConnection))
                        {
                            thisConnection.Open();
                            count = (int)cmdCount.ExecuteScalar();
                            thisConnection.Close();
                        }
                    }
                    if (count == 0)
                    {
                        OleDbCommand command_in = new OleDbCommand();
                        OleDbConnection conn_in = new OleDbConnection(flightconnStr);
                        command_in.CommandType = CommandType.Text;
                        command_in.CommandText = "delete from indirect where flightid=@id";
                        command_in.Parameters.AddWithValue("@id", flightid);
                        command_in.Parameters.AddWithValue("@class", classType);
                        command_in.Connection = conn_in;
                        conn_in.Open();
                        command_in.ExecuteNonQuery();
                        conn_in.Close();

                        OleDbCommand command_schedule = new OleDbCommand();
                        OleDbConnection conn_schedule = new OleDbConnection(flightconnStr);
                        command_schedule.CommandType = CommandType.Text;
                        command_schedule.CommandText = "delete from flightschedule where flightid=@id";
                        command_schedule.Parameters.AddWithValue("@id", flightid);
                        command_schedule.Connection = conn_schedule;
                        conn_schedule.Open();
                        command_schedule.ExecuteNonQuery();
                        conn_schedule.Close();
                    }
                    directDefaultDataGridView.Rows.RemoveAt(rowindex);
                }
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                if (rowindex == -1)
                {
                    MessageBox.Show("Please select hotel room record to delete");
                    return;
                }
                string hotel_room_name = hotel_roomDataGridView.Rows[rowindex].Cells["hotelRoom"].Value.ToString();
                string hotel_chi_name = hotel_roomDataGridView.Rows[rowindex].Cells["hotelChiName"].Value.ToString();
                if (MessageBox.Show("Do you want to delete this record? Hotel Chinese name: " + hotel_chi_name + " Hotel room name: " + hotel_room_name,"Delete record",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    OleDbCommand command_this = new OleDbCommand();
                    OleDbConnection conn_this = new OleDbConnection(hotelconnStr);
                    command_this.CommandType = CommandType.Text;
                    command_this.CommandText = "delete from hotel_room where hotel_chi_name=@chiname and hotel_room_name=@roomname";
                    command_this.Parameters.AddWithValue("@chiname", hotel_chi_name);
                    command_this.Parameters.AddWithValue("@roomname", hotel_room_name);
                    command_this.Connection = conn_this;
                    conn_this.Open();
                    command_this.ExecuteNonQuery();
                    conn_this.Close();
                    hotel_roomDataGridView.Rows.RemoveAt(rowindex);
                }
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                if (rowindex == -1)
                {
                    MessageBox.Show("Please select a record to delete");
                    return;
                }
                string cruiseNo = cruiseDataGridView.Rows[rowindex].Cells["cruiseNo_admin"].Value.ToString();
                string cruiseName = cruiseDataGridView.Rows[rowindex].Cells["CruiseName"].Value.ToString();
                if (MessageBox.Show("Do you want to delete this record? Cruise No: " + cruiseNo + " Cruise Name: " + cruiseName , "Delete record",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    OleDbCommand command_this = new OleDbCommand();
                    OleDbConnection conn_this = new OleDbConnection(cruiseconnStr);
                    command_this.CommandType = CommandType.Text;
                    command_this.CommandText = "delete from cruise where cruiseNo=@no";
                    command_this.Parameters.AddWithValue("@no", cruiseNo);
                    command_this.Connection = conn_this;
                    conn_this.Open();
                    command_this.ExecuteNonQuery();
                    conn_this.Close();
                    cruiseDataGridView.Rows.RemoveAt(rowindex);
                }
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                if (rowindex == -1)
                {
                    MessageBox.Show("Please select a record to delete");
                    return;
                }
                string attractname = attractionDataGridView.Rows[rowindex].Cells["AttractName"].Value.ToString();
                string visit = attractionDataGridView.Rows[rowindex].Cells["Visitor"].Value.ToString();
                if (MessageBox.Show("Do you want to delete this record? Attraction Name: " + attractname + " Visitor: " + visit, "Delete record",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    OleDbCommand command_this = new OleDbCommand();
                    OleDbConnection conn_this = new OleDbConnection(attractconnStr);
                    command_this.CommandType = CommandType.Text;
                    command_this.CommandText = "delete from attractprice where attractname=@name and visitor=@visitor";
                    command_this.Parameters.AddWithValue("@name", attractname);
                    command_this.Parameters.AddWithValue("@visitor", visit);
                    command_this.Connection = conn_this;
                    conn_this.Open();
                    command_this.ExecuteNonQuery();
                    conn_this.Close();

                    int count = -1;
                    string stmt = "SELECT COUNT(*) FROM attractprice where attractname='"+attractname+"'";
                    using (OleDbConnection thisConnection = new OleDbConnection(attractconnStr))
                    {
                        using (OleDbCommand cmdCount = new OleDbCommand(stmt, thisConnection))
                        {
                            thisConnection.Open();
                            count = (int)cmdCount.ExecuteScalar();
                            thisConnection.Close();
                        }
                    }
                    if (count == 0)
                    {
                        OleDbCommand command_attract = new OleDbCommand();
                        OleDbConnection conn_attract = new OleDbConnection(attractconnStr);
                        command_attract.CommandType = CommandType.Text;
                        command_attract.CommandText = "delete from attraction where attractname=@name";
                        command_attract.Parameters.AddWithValue("@name", attractname);
                        command_attract.Connection = conn_attract;
                        conn_attract.Open();
                        command_attract.ExecuteNonQuery();
                        conn_attract.Close();
                    }
                    attractionDataGridView.Rows.RemoveAt(rowindex);
                }
            }
            else if (tabControl1.SelectedIndex == 4)
            {
                if (rowindex == -1)
                {
                    MessageBox.Show("Please select a record to delete");
                    return;
                }

                if (vehicleClick== true) {
                    string vehicleName = vehicleDataGridView.Rows[rowindex].Cells["Vehicle_Name"].Value.ToString();
                    int vehicleid = Int32.Parse(vehicleDataGridView.Rows[rowindex].Cells["VehicleID"].Value.ToString());
                    if (MessageBox.Show("Do you want to delete this record? Vehicle name: " + vehicleName, "Delete record",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        OleDbCommand command_this = new OleDbCommand();
                        OleDbConnection conn_this = new OleDbConnection(vehicleconnStr);
                        command_this.CommandType = CommandType.Text;
                        command_this.CommandText = "delete from vehicle where vehicleID=@id";
                        command_this.Parameters.AddWithValue("@id", vehicleName);
                        command_this.Connection = conn_this;
                        conn_this.Open();
                        command_this.ExecuteNonQuery();
                        conn_this.Close();
                        vehicleDataGridView.Rows.RemoveAt(rowindex);
                    }
                }
                if (equipClick == true)
                {
                    string equipName = equipmentDataGridView.Rows[rowindex].Cells["equipment"].Value.ToString();
                    int equipid = Int32.Parse(equipmentDataGridView.Rows[rowindex].Cells["equipid"].Value.ToString());
                    if (MessageBox.Show("Do you want to delete this record? Equipment name: " + equipName, "Delete record",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        OleDbCommand command_this = new OleDbCommand();
                        OleDbConnection conn_this = new OleDbConnection(vehicleconnStr);
                        command_this.CommandType = CommandType.Text;
                        command_this.CommandText = "delete from equipment where equipid=@id";
                        command_this.Parameters.AddWithValue("@id", equipid);
                        command_this.Connection = conn_this;
                        conn_this.Open();
                        command_this.ExecuteNonQuery();
                        conn_this.Close();
                        equipmentDataGridView.Rows.RemoveAt(rowindex);
                    }
                }
            }
            else if (tabControl1.SelectedIndex == 5)
            {
                if (rowindex == -1)
                {
                    MessageBox.Show("Please select a record to delete");
                    return;
                }
                string staffname = staffDataGridView.Rows[rowindex].Cells["StaffName_admin"].Value.ToString();
                string staffid = staffDataGridView.Rows[rowindex].Cells["staffid"].Value.ToString();
                if (MessageBox.Show("All booking of this staff will be deleted.Do you want to delete this record? Staff Name: " + staffname, "Delete record",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    OleDbCommand command_attract = new OleDbCommand();
                    OleDbConnection conn_attract = new OleDbConnection(custconnStr);
                    command_attract.CommandType = CommandType.Text;
                    command_attract.CommandText = "delete from attractionbooking "
                        + "where orderby=@id";
                    command_attract.Parameters.AddWithValue("@id", staffid);
                    command_attract.Connection = conn_attract;
                    conn_attract.Open();
                    command_attract.ExecuteNonQuery();
                    conn_attract.Close();

                    OleDbCommand command_cruise = new OleDbCommand();
                    OleDbConnection conn_cruise = new OleDbConnection(custconnStr);
                    command_cruise.CommandType = CommandType.Text;
                    command_cruise.CommandText = "delete from cruisebooking "
                        + "where orderby=@id";
                    command_cruise.Parameters.AddWithValue("@id", staffid);
                    command_cruise.Connection = conn_cruise;
                    conn_cruise.Open();
                    command_cruise.ExecuteNonQuery();
                    conn_cruise.Close();

                    OleDbCommand command_hotel = new OleDbCommand();
                    OleDbConnection conn_hotel = new OleDbConnection(custconnStr);
                    command_hotel.CommandType = CommandType.Text;
                    command_hotel.CommandText = "delete from hotelbooking "
                        + "where orderby=@id";
                    command_hotel.Parameters.AddWithValue("@id", staffid);
                    command_hotel.Connection = conn_hotel;
                    conn_hotel.Open();
                    command_hotel.ExecuteNonQuery();
                    conn_hotel.Close();

                    OleDbCommand command_flight = new OleDbCommand();
                    OleDbConnection conn_flight = new OleDbConnection(custconnStr);
                    command_flight.CommandType = CommandType.Text;
                    command_flight.CommandText = "delete from flightbooking "
                        + "where orderby=@id";
                    command_flight.Parameters.AddWithValue("@id", staffid);
                    command_flight.Connection = conn_flight;
                    conn_flight.Open();
                    command_flight.ExecuteNonQuery();
                    conn_flight.Close();

                    OleDbCommand command_vehicle = new OleDbCommand();
                    OleDbConnection conn_vehicle = new OleDbConnection(custconnStr);
                    command_vehicle.CommandType = CommandType.Text;
                    command_vehicle.CommandText = "delete from vehiclebooking "
                        + "where orderby=@id";
                    command_vehicle.Parameters.AddWithValue("@id", staffid);
                    command_vehicle.Connection = conn_vehicle;
                    conn_vehicle.Open();
                    command_vehicle.ExecuteNonQuery();
                    conn_vehicle.Close();

                    OleDbCommand command_this = new OleDbCommand();
                    OleDbConnection conn_this = new OleDbConnection(custconnStr);
                    command_this.CommandType = CommandType.Text;
                    command_this.CommandText = "delete from staff where staffid=@id";
                    command_this.Parameters.AddWithValue("@id", staffid);
                    command_this.Connection = conn_this;
                    conn_this.Open();
                    command_this.ExecuteNonQuery();
                    conn_this.Close();
                    staffDataGridView.Rows.RemoveAt(rowindex);
                }
            }
            else if (tabControl1.SelectedIndex == 6)
            {
                if (rowindex == -1)
                {
                    MessageBox.Show("Please select a record to delete");
                    return;
                }
                string custsurname = customerDataGridView.Rows[rowindex].Cells["Surname"].Value.ToString();
                string custgivenname = customerDataGridView.Rows[rowindex].Cells["GivenName"].Value.ToString();
                string custid = customerDataGridView.Rows[rowindex].Cells["CustID"].Value.ToString();
                if (MessageBox.Show("All booking of this customer will be deleted.Do you want to delete this record? Customer Name: " + custsurname + " " + custgivenname, "Delete record",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    OleDbCommand command_attract = new OleDbCommand();
                    OleDbConnection conn_attract = new OleDbConnection(custconnStr);
                    command_attract.CommandType = CommandType.Text;
                    command_attract.CommandText = "delete from attractionbooking "
                        + "where custid=@id";
                    command_attract.Parameters.AddWithValue("@id", custid);
                    command_attract.Connection = conn_attract;
                    conn_attract.Open();
                    command_attract.ExecuteNonQuery();
                    conn_attract.Close();

                    OleDbCommand command_cruise = new OleDbCommand();
                    OleDbConnection conn_cruise = new OleDbConnection(custconnStr);
                    command_cruise.CommandType = CommandType.Text;
                    command_cruise.CommandText = "delete from cruisebooking "
                        + "where custid=@id";
                    command_cruise.Parameters.AddWithValue("@id", custid);
                    command_cruise.Connection = conn_cruise;
                    conn_cruise.Open();
                    command_cruise.ExecuteNonQuery();
                    conn_cruise.Close();

                    OleDbCommand command_hotel = new OleDbCommand();
                    OleDbConnection conn_hotel = new OleDbConnection(custconnStr);
                    command_hotel.CommandType = CommandType.Text;
                    command_hotel.CommandText = "delete from hotelbooking "
                        + "where custid=@id";
                    command_hotel.Parameters.AddWithValue("@id", custid);
                    command_hotel.Connection = conn_hotel;
                    conn_hotel.Open();
                    command_hotel.ExecuteNonQuery();
                    conn_hotel.Close();

                    OleDbCommand command_flight = new OleDbCommand();
                    OleDbConnection conn_flight = new OleDbConnection(custconnStr);
                    command_flight.CommandType = CommandType.Text;
                    command_flight.CommandText = "delete from flightbooking "
                        + "where custid=@id";
                    command_flight.Parameters.AddWithValue("@id", custid);
                    command_flight.Connection = conn_flight;
                    conn_flight.Open();
                    command_flight.ExecuteNonQuery();
                    conn_flight.Close();

                    OleDbCommand command_vehicle = new OleDbCommand();
                    OleDbConnection conn_vehicle = new OleDbConnection(custconnStr);
                    command_vehicle.CommandType = CommandType.Text;
                    command_vehicle.CommandText = "delete from vehiclebooking "
                        + "where custid=@id";
                    command_vehicle.Parameters.AddWithValue("@id", custid);
                    command_vehicle.Connection = conn_vehicle;
                    conn_vehicle.Open();
                    command_vehicle.ExecuteNonQuery();
                    conn_vehicle.Close();

                    OleDbCommand command_this = new OleDbCommand();
                    OleDbConnection conn_this = new OleDbConnection(custconnStr);
                    command_this.CommandType = CommandType.Text;
                    command_this.CommandText = "delete from customer where custid=@id";
                    command_this.Parameters.AddWithValue("@id", custid);
                    command_this.Connection = conn_this;
                    conn_this.Open();
                    command_this.ExecuteNonQuery();
                    conn_this.Close();
                    customerDataGridView.Rows.RemoveAt(rowindex);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'cruiseDataSet.Default' 資料表。您可以視需要進行移動或移除。
            this.cruiseTableAdapter.Fill(this.cruiseDataSet.Default);
            // TODO: 這行程式碼會將資料載入 'hotelDataSet.Hotel_room' 資料表。您可以視需要進行移動或移除。
            this.hotel_roomTableAdapter.Fill(this.hotelDataSet.Hotel_room);
            // TODO: 這行程式碼會將資料載入 'hotelDataSet.Hotel' 資料表。您可以視需要進行移動或移除。
            this.hotelTableAdapter.Fill(this.hotelDataSet.Hotel);
            // TODO: 這行程式碼會將資料載入 'customerBookingDataSet.Customer' 資料表。您可以視需要進行移動或移除。
            this.customerTableAdapter.Fill(this.customerBookingDataSet.Customer);
            // TODO: 這行程式碼會將資料載入 'customerBookingDataSet.Staff' 資料表。您可以視需要進行移動或移除。
            this.staffTableAdapter.Fill(this.customerBookingDataSet.Staff);
            // TODO: 這行程式碼會將資料載入 'vehicleDataSet.Equipment' 資料表。您可以視需要進行移動或移除。
            this.equipmentTableAdapter.Fill(this.vehicleDataSet.Equipment);
            // TODO: 這行程式碼會將資料載入 'vehicleDataSet.Vehicle' 資料表。您可以視需要進行移動或移除。
            this.vehicleTableAdapter.Fill(this.vehicleDataSet.Vehicle);
            // TODO: 這行程式碼會將資料載入 'attractionDataSet.Default' 資料表。您可以視需要進行移動或移除。
            this.attractTableAdapter.Fill(this.attractionDataSet.Default);
            // TODO: 這行程式碼會將資料載入 'cruiseDataSet.Default' 資料表。您可以視需要進行移動或移除。
            this.cruiseTableAdapter.Fill(this.cruiseDataSet.Default);
            // TODO: 這行程式碼會將資料載入 'hotelDataSet.Hotel' 資料表。您可以視需要進行移動或移除。
            this.hotelTableAdapter.Fill(this.hotelDataSet.Hotel);
            // TODO: 這行程式碼會將資料載入 'ticketDataSet.DirectDefault' 資料表。您可以視需要進行移動或移除。
            this.directDefaultTableAdapter.Fill(this.ticketDataSet.DirectDefault);
        }

        private void hotel_roomDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rowindex = -1;
            rowindex2 = -1;
        }

        private void hotelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex2 = e.RowIndex;
        }

        private void equipmentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vehicleClick == false)
            {
                equipClick = true;
            }
            else
            {
                vehicleDataGridView.ClearSelection();
            }
        }

        private void vehicleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void attractionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
        }

        private void equipmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
        }

        private void vehicleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex2 = e.RowIndex;
        }

        private void staffDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
        }

        private void cruiseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
        }

        private void staffDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void staffDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == staffDataGridView.Columns["Password"].Index)
            {
                if (e.Value != null)
                {
                    e.Value = "****";
                    e.CellStyle.ForeColor = Color.Gray;
                    e.CellStyle.SelectionForeColor = e.CellStyle.SelectionBackColor;
                    e.FormattingApplied = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = "Time : " + DateTime.Now.ToString();
        }
    }
}
