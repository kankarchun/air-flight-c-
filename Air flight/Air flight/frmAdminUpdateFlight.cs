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
    public partial class frmAdminUpdateFlight : Form
    {
        private int rowindex;
        private string flightconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=ticketTailor_db.accdb";
        private DateTime? d1 = null, d2 = null, d3 = null;
        private string carrier = "";
        private int flightid;
        private bool update = false;
        private string[] details, currRowIndriect;
        private bool indirect;

        public frmAdminUpdateFlight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update this record?", "Update record",
MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
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
                        cmd_schedule.CommandText = "Update FlightSchedule set edd=@edd,eda=@eda,etd=@etd,eta=@eta,"
                            + "origin=@origin,dest=@dest,aircraft=@aircraft,traveltime=@traveltime,flightno=@flightno,flighttype=@flighttype where flightid=@flightid";
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
                        cmd_schedule.Parameters.AddWithValue("@flightid", flightid);

                        OleDbCommand cmd_class = new OleDbCommand();
                        cmd_class.CommandType = CommandType.Text;
                        cmd_class.CommandText = "Update FlightClass set flightno=@flightno,price_adult=@adult,price_children=@children,price_infant=@infant,tax=@tax "
                            + "where flightid=@flightid and class=@class";
                        cmd_class.Parameters.AddWithValue("@flightno", flightno);
                        cmd_class.Parameters.AddWithValue("@adult", Convert.ToDouble(numericUpDown1.Value));
                        cmd_class.Parameters.AddWithValue("@children", Convert.ToDouble(numericUpDown2.Value));
                        cmd_class.Parameters.AddWithValue("@infant", Convert.ToDouble(numericUpDown3.Value));
                        cmd_class.Parameters.AddWithValue("@tax", tax);
                        cmd_class.Parameters.AddWithValue("@flightid", flightid);
                        cmd_class.Parameters.AddWithValue("@class", classType);
                        cmd_class.Connection = con;
                        cmd_schedule.Connection = con;
                        con.Open();

                        cmd_schedule.ExecuteNonQuery();
                        cmd_class.ExecuteNonQuery();

                        MessageBox.Show("Flight record updated successfully.");
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
                            if (d3 != null && !string.IsNullOrWhiteSpace(textBox3.Text) && d3 > DateTime.Now)
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
                                MessageBox.Show("Stop departure date  must be smaller than today and Stop arrival date must be enter if the flight type is indirect and stop no is 1");
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
                        cmd_schedule.CommandText = "Update FlightSchedule set edd=@edd,eda=@eda,etd=@etd,eta=@eta,"
                            + "origin=@origin,dest=@dest,aircraft=@aircraft,traveltime=@traveltime,flightno=@flightno,flighttype=@flighttype where flightid=@flightid";
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
                        cmd_schedule.Parameters.AddWithValue("@flightid", flightid);

                        OleDbCommand cmd_class = new OleDbCommand();
                        cmd_class.CommandType = CommandType.Text;
                        cmd_class.CommandText = "Update FlightClass set flightno=@flightno,class=@class,price_adult=@adult,price_children=@children,price_infant=@infant,tax=@tax "
                            + "where flightid=@flightid";
                        cmd_class.Parameters.AddWithValue("@flightno", flightno);
                        cmd_class.Parameters.AddWithValue("@class", classType);
                        cmd_class.Parameters.AddWithValue("@adult", Convert.ToDouble(numericUpDown1.Value));
                        cmd_class.Parameters.AddWithValue("@children", Convert.ToDouble(numericUpDown2.Value));
                        cmd_class.Parameters.AddWithValue("@infant", Convert.ToDouble(numericUpDown3.Value));
                        cmd_class.Parameters.AddWithValue("@tax", tax);
                        cmd_class.Parameters.AddWithValue("@flightid", flightid);

                        OleDbCommand cmd_indirect = new OleDbCommand();
                        cmd_indirect.CommandType = CommandType.Text;
                        cmd_indirect.CommandText = "Update Indirect set flightno=@flightno,stopno=@stopno,stop=@stop,edd=@edd,etd=@etd,eda=@eda,eta=@eta,type=@type "
                            + "where flightid=@flightid";
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
                        cmd_indirect.Parameters.AddWithValue("@flightid", flightid);

                        cmd_schedule.Connection = con;
                        cmd_class.Connection = con;
                        con.Open();

                        cmd_schedule.ExecuteNonQuery();
                        cmd_class.ExecuteNonQuery();

                        MessageBox.Show("Flight record updated successfully.");
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            d1 = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            d2 = dateTimePicker2.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown5.Value == 1m)
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
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Departure time cannot be empty");
                textBox5.Text = details[4];
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Arrival time cannot be empty");
                textBox6.Text = details[5];
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Origin cannot be empty");
                textBox7.Text = details[6];
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox8.Text))
            {
                MessageBox.Show("Destination cannot be empty");
                textBox8.Text = details[7];
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox9.Text))
            {
                MessageBox.Show("Aircraft cannot be empty");
                textBox9.Text = details[8];
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox10.Text))
            {
                MessageBox.Show("Travel time cannot be empty");
                textBox10.Text = details[9];
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox11.Text))
            {
                MessageBox.Show("Flight no cannot be empty");
                textBox11.Text = details[10];
            }
        }

        private void textBox16_Leave(object sender, EventArgs e)
        {
            if (indirect == true)
            {
                if (string.IsNullOrWhiteSpace(textBox16.Text))
                {
                    MessageBox.Show("Stop place cannot be empty");
                    textBox16.Text = details[18];
                }
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (indirect == true)
            {
                if (string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Stop arrival time cannot be empty");
                    textBox3.Text = details[20];
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        public frmAdminUpdateFlight(string[] details, bool update, bool indirect, string[] currRowIndriect)
        {
            InitializeComponent();
            this.details = details;
            this.update = update;
            this.indirect = indirect;
            this.currRowIndriect = currRowIndriect;
        }

        private void frmAdminUpdateFlight_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd-MM-yyyy";

            if (indirect == false)
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

            textBox1.Text = details[0];
            flightid = Int32.Parse(details[0]);
            textBox2.Text = details[1];
            dateTimePicker1.Value = DateTime.Parse(details[2]);
            dateTimePicker2.Value = DateTime.Parse(details[3]);
            textBox5.Text = details[4];
            textBox6.Text = details[5];
            textBox7.Text = details[6];
            textBox8.Text = details[7];
            textBox9.Text = details[8];
            textBox10.Text = details[9];
            textBox11.Text = details[10];
            numericUpDown1.Value = Convert.ToDecimal(details[12]);
            numericUpDown2.Value = Decimal.Parse(details[13]);
            numericUpDown3.Value = Decimal.Parse(details[14]);

            if (details[11].Equals("Business"))
            {
                radioButton1.Checked = true;
            }
            else if (details[11].Equals("Econ"))
            {
                radioButton2.Checked = true;
            }
            if (details[15].Equals("NULL"))
            {
                numericUpDown4.Value = 0m;
            }
            else
            {
                numericUpDown4.Value = Decimal.Parse(details[15]);
            }
            if (details[16].Equals("Direct"))
            {
                radioButton3.Checked = true;
                radioButton4.Enabled = false;
            }
            else if (details[16].Equals("Indirect"))
            {
                radioButton4.Checked = true;
                radioButton3.Enabled = false;
            }
            if (indirect)
            {
                numericUpDown5.Value = Decimal.Parse(currRowIndriect[0]);
                textBox16.Text = currRowIndriect[1];
                dateTimePicker3.Value = DateTime.Parse(currRowIndriect[2]);
                textBox3.Text = currRowIndriect[3];
            }

        }
    }
}
