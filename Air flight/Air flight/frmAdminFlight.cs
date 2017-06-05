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
    public partial class frmAdminFlight : Form
    {
        private int rowindex;
        private string flightconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=ticketTailor_db.accdb";
        private DateTime? d1 = null, d2 = null, d3 = null;
        private string carrier="";
        private int flightid;
        private bool update=false;
        private string[] details;
        private bool indirect;

        public frmAdminFlight()
        {
            InitializeComponent();
        }

        public frmAdminFlight(string[] details, bool update,bool indirect)
        {
            InitializeComponent();
            this.details = details;
            this.update = update;
            this.indirect = indirect;
        }

        private void frmAdminFlight_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'ticketDataSet.Carrier' 資料表。您可以視需要進行移動或移除。
            this.carrierTableAdapter.Fill(this.ticketDataSet.Carrier);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd-MM-yyyy";
            label17.Visible = false;
            label18.Visible = false;
            numericUpDown5.Visible = false;
            textBox16.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            dateTimePicker3.Visible = false;
            textBox3.Visible = false;
            label23.Visible = false;

                string stmt = "SELECT COUNT(*) FROM flightschedule";
                flightid = 0;

                using (OleDbConnection thisConnection = new OleDbConnection(flightconnStr))
                {
                    using (OleDbCommand cmdCount = new OleDbCommand(stmt, thisConnection))
                    {
                        thisConnection.Open();
                        flightid = (int)cmdCount.ExecuteScalar();
                        thisConnection.Close();
                    }
                }
                flightid++;
                textBox1.Text = flightid.ToString();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            d3 = dateTimePicker3.Value;
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to add this record?", "Add record",
MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (carrier.Equals(""))
                {
                    MessageBox.Show("Please select one carrier in the data grid view");
                    return;
                }
                if (numericUpDown1.Value == 0m)
                {
                    MessageBox.Show("Adult Price cannot be $0");
                    return;
                }
                else if (numericUpDown2.Value == 0m)
                {
                    MessageBox.Show("Child Price cannot be $0");
                    return;
                }
                else if (numericUpDown3.Value == 0m)
                {
                    MessageBox.Show("Infant Price cannot be $0");
                    return;
                }
                else if (d1 == null)
                {
                    MessageBox.Show("Pleasae enter departure date");
                    return;
                }
                else if (d2 == null)
                {
                    MessageBox.Show("Pleasae enter arrival date");
                    return;
                }
                string departureFormat, arrivalFormat, departureTimeFormat, arrivalTimeFormat, travelTime,
                    classType = "", tax, flightType, stopNo, flightno, origin, destination, aircraft,
                    stopArrivalTimeFormat, stopArrivalDateFormat, stopPlace;
                DateTime departureDate, arrivalDate, departureTime, arrivalTime, stopDepartureDate, stopArrivalDate, stopDepartureTime, stopArrivalTime;

                if (!string.IsNullOrWhiteSpace(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox6.Text) &&
                    !string.IsNullOrWhiteSpace(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox8.Text) &&
                    !string.IsNullOrWhiteSpace(textBox9.Text) && !string.IsNullOrWhiteSpace(textBox10.Text) &&
                    !string.IsNullOrWhiteSpace(textBox11.Text) &&
                    (radioButton1.Checked || radioButton2.Checked) && (radioButton3.Checked || radioButton4.Checked))
                {
                    flightno = textBox11.Text;
                    origin = textBox7.Text;
                    destination = textBox8.Text;
                    aircraft = textBox9.Text;

                    if (dateTimePicker1.Value < DateTime.Now)
                    {
                        MessageBox.Show("Departure date cannot smaller than today");
                        d1 = null;
                        dateTimePicker1.Value = DateTime.Now;
                        return;
                    }
                    else
                    {
                        departureFormat = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                        departureDate = DateTime.Parse(departureFormat);
                    }

                    if (dateTimePicker2.Value < DateTime.Now)
                    {
                        MessageBox.Show("Arrival date cannot smaller than today");
                        d2 = null;
                        dateTimePicker2.Value = DateTime.Now;
                        return;
                    }
                    else
                    {
                        arrivalFormat = dateTimePicker2.Value.ToString("dd/MM/yyyy");
                        arrivalDate = DateTime.Parse(arrivalFormat);
                    }
                    if (arrivalDate < departureDate)
                    {
                        MessageBox.Show("Arrival date cannot smaller than departure day");
                        d1 = null;
                        d2 = null;
                        dateTimePicker1.Value = DateTime.Now;
                        dateTimePicker2.Value = DateTime.Now;
                        return;
                    }
                    Regex checktime = new Regex(@"^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$");
                    Regex checkTravel = new Regex(@"^(?:[01]?[1-9]|1[0-9]|2[0-9])h([0-5][0-9]m)?$");
                    if (checktime.IsMatch(textBox5.Text))
                    {
                        departureTimeFormat = textBox5.Text;
                        departureTime = DateTime.Parse(departureTimeFormat);
                    }
                    else
                    {
                        MessageBox.Show("The valid values of departure time is 00:00 to 23:59");
                        textBox5.Clear();
                        return;
                    }

                    if (checktime.IsMatch(textBox6.Text))
                    {
                        arrivalTimeFormat = textBox6.Text;
                        arrivalTime = DateTime.Parse(arrivalTimeFormat);
                    }
                    else
                    {
                        MessageBox.Show("The valid values of arrival time is 00:00 to 23:59");
                        textBox6.Clear();
                        return;
                    }

                    if (checkTravel.IsMatch(textBox10.Text))
                    {
                        travelTime = textBox10.Text;
                    }
                    else
                    {
                        MessageBox.Show("The valid values of travel time is 1h to 29h or 1h01m to 29h59m");
                        textBox10.Clear();
                        return;
                    }

                    if (radioButton1.Checked)
                        classType = "Business";
                    if (radioButton2.Checked)
                        classType = "Econ";

                    if (numericUpDown4.Value == 0m)
                        tax = "Null";
                    else
                        tax = numericUpDown4.Value.ToString();

                    if (radioButton3.Checked)
                    {
                        flightType = "Direct";

                        OleDbCommand cmd_schedule = new OleDbCommand();
                        OleDbConnection con = new OleDbConnection(flightconnStr);
                        cmd_schedule.CommandType = CommandType.Text;
                        cmd_schedule.CommandText = "INSERT INTO FlightSchedule(flightid,carrier,edd,eda,etd,eta,origin,dest,aircraft,traveltime,flightno,flighttype) "
                            + "VALUES (@flightid,@carrier,@edd,@eda,@etd,@eta,@origin,@dest,@aircraft,@traveltime,@flightno,@flighttype)";
                        cmd_schedule.Parameters.AddWithValue("@flightid", flightid);
                        cmd_schedule.Parameters.AddWithValue("@carrier", Int32.Parse(carrier));
                        cmd_schedule.Parameters.AddWithValue("@edd", departureDate);
                        cmd_schedule.Parameters.AddWithValue("@eda", arrivalDate);
                        cmd_schedule.Parameters.AddWithValue("@etd", departureTime);
                        cmd_schedule.Parameters.AddWithValue("@eta", arrivalTime);
                        cmd_schedule.Parameters.AddWithValue("@origin", origin);
                        cmd_schedule.Parameters.AddWithValue("@dest", destination);
                        cmd_schedule.Parameters.AddWithValue("@aircraft", aircraft);
                        cmd_schedule.Parameters.AddWithValue("@traveltime", travelTime);
                        cmd_schedule.Parameters.AddWithValue("@flightno", flightno);
                        cmd_schedule.Parameters.AddWithValue("@flighttype", flightType);

                        OleDbCommand cmd_class = new OleDbCommand();
                        cmd_class.CommandType = CommandType.Text;
                        cmd_class.CommandText = "INSERT INTO FlightClass(flightid,flightno,class,price_adult,price_children,price_infant,tax) "
                            + "VALUES (@flightid,@flightno,@class,@adult,@children,@infant,@tax)";
                        cmd_class.Parameters.AddWithValue("@flightid", flightid);
                        cmd_class.Parameters.AddWithValue("@flightno", flightno);
                        cmd_class.Parameters.AddWithValue("@class", classType);

                        cmd_class.Parameters.AddWithValue("@adult", Convert.ToDouble(numericUpDown1.Value));
                        cmd_class.Parameters.AddWithValue("@children", Convert.ToDouble(numericUpDown2.Value));
                        cmd_class.Parameters.AddWithValue("@infant", Convert.ToDouble(numericUpDown3.Value));

                        cmd_class.Parameters.AddWithValue("@tax", tax);

                        cmd_class.Connection = con;
                        cmd_schedule.Connection = con;
                        con.Open();

                        cmd_schedule.ExecuteNonQuery();
                        cmd_class.ExecuteNonQuery();

                        MessageBox.Show("Flight record added successfully.");
                        con.Close();
                        this.Close();
                        return;
                    }

                    if (radioButton4.Checked)
                    {
                        flightType = "Indirect";


                        if (!string.IsNullOrWhiteSpace(textBox16.Text))
                        {
                            stopPlace = textBox16.Text;
                            stopNo = numericUpDown5.Value.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Stop place must be enter if the flight type is indirect");
                            return;
                        }
                        if (numericUpDown5.Value == 1m)
                        {
                            if (d3 != null && !string.IsNullOrWhiteSpace(textBox3.Text) && d3 >= departureDate && d3 <= arrivalDate)
                            {
                                if (checktime.IsMatch(textBox3.Text))
                                {
                                    stopArrivalTimeFormat = textBox3.Text;
                                    stopArrivalTime = DateTime.Parse(stopArrivalTimeFormat);
                                }
                                else
                                {
                                    MessageBox.Show("The valid values of stop arrival time is 00:00 to 23:59");
                                    textBox3.Clear();
                                    return;
                                }
                                stopDepartureDate = departureDate;
                                stopDepartureTime = departureTime;
                                stopArrivalDateFormat = dateTimePicker3.Value.ToString("dd/MM/yyyy");
                                stopArrivalDate = DateTime.Parse(stopArrivalDateFormat);
                            }
                            else
                            {
                                MessageBox.Show("Stop departure date  must be between departure date and arrival date and Stop arrival date must be enter if the flight type is indirect and stop no is 1");
                                d3 = null;
                                textBox3.Clear();
                                dateTimePicker3.Value = DateTime.Now;
                                return;
                            }
                        }
                        else
                        {
                            stopDepartureDate = arrivalDate;
                            stopDepartureTime = arrivalTime;
                            stopArrivalDate = DateTime.Now;
                            stopArrivalTime = DateTime.Now;
                        }

                        OleDbCommand cmd_schedule = new OleDbCommand();
                        OleDbConnection con = new OleDbConnection(flightconnStr);
                        cmd_schedule.CommandType = CommandType.Text;
                        cmd_schedule.CommandText = "INSERT INTO FlightSchedule(flightid,carrier,edd,eda,etd,eta,origin,dest,aircraft,traveltime,flightno,flighttype) "
                            + "VALUES (@flightid,@carrier,@edd,@eda,@etd,@eta,@origin,@dest,@aircraft,@traveltime,@flightno,@flighttype)";
                        cmd_schedule.Parameters.AddWithValue("@flightid", flightid);
                        cmd_schedule.Parameters.AddWithValue("@carrier", Int32.Parse(carrier));
                        cmd_schedule.Parameters.AddWithValue("@edd", departureDate);
                        cmd_schedule.Parameters.AddWithValue("@eda", arrivalDate);
                        cmd_schedule.Parameters.AddWithValue("@etd", departureTime);
                        cmd_schedule.Parameters.AddWithValue("@eta", arrivalTime);
                        cmd_schedule.Parameters.AddWithValue("@origin", origin);
                        cmd_schedule.Parameters.AddWithValue("@dest", destination);
                        cmd_schedule.Parameters.AddWithValue("@aircraft", aircraft);
                        cmd_schedule.Parameters.AddWithValue("@traveltime", travelTime);
                        cmd_schedule.Parameters.AddWithValue("@flightno", flightno);
                        cmd_schedule.Parameters.AddWithValue("@flighttype", flightType);

                        OleDbCommand cmd_class = new OleDbCommand();
                        cmd_class.CommandType = CommandType.Text;
                        cmd_class.CommandText = "INSERT INTO FlightClass(flightid,flightno,class,price_adult,price_children,price_infant,tax) "
                            + "VALUES (@flightid,@flightno,@class,@adult,@children,@infant,@tax)";
                        cmd_class.Parameters.AddWithValue("@flightid", flightid);
                        cmd_class.Parameters.AddWithValue("@flightno", flightno);
                        cmd_class.Parameters.AddWithValue("@class", classType);

                        cmd_class.Parameters.AddWithValue("@adult", Convert.ToDouble(numericUpDown1.Value));
                        cmd_class.Parameters.AddWithValue("@children", Convert.ToDouble(numericUpDown2.Value));
                        cmd_class.Parameters.AddWithValue("@infant", Convert.ToDouble(numericUpDown3.Value));

                        cmd_class.Parameters.AddWithValue("@tax", tax);

                        OleDbCommand cmd_indirect = new OleDbCommand();
                        cmd_indirect.CommandType = CommandType.Text;
                        cmd_indirect.CommandText = "INSERT INTO Indirect(flightid,flightno,stopno,stop,edd,etd,eda,eta,type) "
                            + "VALUES (@flightid,@flightno,@stopno,@stop,@edd,@etd,@eda,@eta,@type)";
                        cmd_indirect.Parameters.AddWithValue("@flightid", flightid);
                        cmd_indirect.Parameters.AddWithValue("@flightno", flightno);
                        cmd_indirect.Parameters.AddWithValue("@stopno", Int32.Parse(stopNo));
                        cmd_indirect.Parameters.AddWithValue("@stop", stopPlace);
                        cmd_indirect.Parameters.AddWithValue("@edd", stopDepartureDate);
                        cmd_indirect.Parameters.AddWithValue("@etd", stopDepartureTime);
                        if (numericUpDown5.Value == 1m)
                        {
                            cmd_indirect.Parameters.AddWithValue("@eda", stopArrivalDate);
                            cmd_indirect.Parameters.AddWithValue("@eta", stopArrivalTime);
                        }
                        else
                        {
                            cmd_indirect.Parameters.AddWithValue("@eda", DBNull.Value);
                            cmd_indirect.Parameters.AddWithValue("@eta", DBNull.Value);
                        }
                        cmd_indirect.Parameters.AddWithValue("@type", flightType);

                        cmd_schedule.Connection = con;
                        cmd_class.Connection = con;
                        cmd_indirect.Connection = con;
                        con.Open();

                        cmd_schedule.ExecuteNonQuery();
                        cmd_class.ExecuteNonQuery();
                        cmd_indirect.ExecuteNonQuery();

                        MessageBox.Show("Flight record added successfully.");
                        con.Close();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("All field must be enter");
                }
            }
        }

        private void carrierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carrierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ticketDataSet);

        }

        private void carrierDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carrier = carrierDataGridView.CurrentRow.Cells["CarrierID"].Value.ToString();

            textBox2.Text = carrier;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label17.Visible = true;
            label18.Visible = true;
            numericUpDown5.Visible = true;
            textBox16.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            dateTimePicker3.Visible = true;
            dateTimePicker3.Enabled = false;
            textBox3.Visible = true;
            textBox3.ReadOnly = true;
            label23.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label17.Visible = false;
            label18.Visible = false;
            numericUpDown5.Visible = false;
            textBox16.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            dateTimePicker3.Visible = false;
            textBox3.Visible = false;
            label23.Visible = false;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown5.Value==1m)
            {
                dateTimePicker3.Enabled = true;
                textBox3.ReadOnly = false;
            }
            else
            {
                dateTimePicker3.Enabled = false;
                textBox3.ReadOnly = true;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            d1 = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            d2 = dateTimePicker2.Value;
        }
    }
}
