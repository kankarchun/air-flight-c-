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
    public partial class frmAir : Form
    {
        private DataTable dtAir = new DataTable();
        private DataTable dtDefault = new DataTable();
        private DataTable dtDeparture = new DataTable();
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=ticketTailor_db.accdb";
        private DateTime? newdate = null;
        private DateTime? newarrival = null;
        public static string staffname;
        public string getFlightNo { get; set; }
        private frmOrder place;
        public static bool back;

        public frmAir()
        {
            InitializeComponent();
        }

        public frmAir(frmOrder o)
        {
            InitializeComponent();
            place = o;
        }

        private void frmAir_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'ticketDataSet.DirectDefault' 資料表。您可以視需要進行移動或移除。
            this.directDefaultTableAdapter.Fill(this.ticketDataSet.DirectDefault);
            // TODO: 這行程式碼會將資料載入 'ticketDataSet.Available' 資料表。您可以視需要進行移動或移除。
            this.availableTableAdapter.Fill(this.ticketDataSet.Available);
            directDefaultDataGridView.Columns[8].DefaultCellStyle.Format = "HH:mm";
            directDefaultDataGridView.Columns[9].DefaultCellStyle.Format = "HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            //dataGridView1.Columns[8].DefaultCellStyle.Format = "HH:mm";
            //dataGridView1.Columns[9].DefaultCellStyle.Format = "HH:mm";
            if (frmLogin.customerLogin)
            {
                label12.Text = "Customer: " + staffname;
            }
            else {
                label12.Text = "Staff: " + staffname;
            }

            label11.Hide();
            if (frmLogin.customerLogin)
            {
                directDefaultDataGridView.Columns["FlightBook"].Visible = false;
            }
            if (back == true)
            {
                label11.Show();
                directDefaultDataGridView.Columns[4].HeaderText = "Destination";
                directDefaultDataGridView.Columns[5].HeaderText = "Origin";
            }
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dgvDefault_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvDefault.Columns[e.ColumnIndex].Name == "Book")
            //{
            //    //logic when clicked button
            //}
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmHotelSchedule hotel = new frmHotelSchedule();
            hotel.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            back = false;
            ucSlideMenu1.Location = new Point(ucSlideMenu1.Location.X, -175);
            do
            {
                ucSlideMenu1.Location = new Point(ucSlideMenu1.Location.X, ucSlideMenu1.Location.Y + 1);
            } while (ucSlideMenu1.Location.Y < 0);
            if (frmLogin.customerLogin)
            {
                ucSlideMenu1.button5.Visible = false;
                ucSlideMenu1.label9.Visible = false;
            }
                ucSlideMenu1.button1.Enabled = false;
        }

        private void directDefaultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void directDefaultDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabPage1.Controls.Add(directDefaultDataGridView);
                directDefaultBindingSource.Sort = "flightno asc";

            }
            else if (tabControl1.SelectedIndex == 1)
            {
                tabPage2.Controls.Add(directDefaultDataGridView);
                directDefaultBindingSource.Sort = "Departure_date asc";

            }
            else if (tabControl1.SelectedIndex == 2)
            {
                tabPage3.Controls.Add(directDefaultDataGridView);
                directDefaultBindingSource.Sort = "Departure_arrival asc";
            }
            else
            {
                directDefaultBindingSource.Sort = "price_adult asc";
                tabPage4.Controls.Add(directDefaultDataGridView);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
                int count = 0;
                string arrival = null;
                string date = null;
                string text = null;
                string direct = "FlightType = 'direct'";
                string indirect = "FlightType = 'indirect'";
                string econ = "class ='econ'";
                string business = "class='business'";

                bool used1 = false, used2 = false, used3 = false, used4 = false, used5 = false, used6 = false, used7 = false;
                if (newarrival != null)
                {
                count++;
                    arrival = "departure_arrival='" + dateTimePicker2.Value.ToString("dd-MM-yyyy") + "'";
                }
                if (newdate != null)
                {
                    count++;
                    date = "departure_date='" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "'";
                }
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    count++;
                    text = "carriername like '%" + textBox1.Text + "%' ";
                }
                if (radioButton1.Checked)
                    count++;
                if (radioButton2.Checked)
                    count++;
                if (radioButton3.Checked)
                    count++;
                if (radioButton4.Checked)
                    count++;
                if (count != 0)
                {
                    string filter = "";
                    for (int i = 1; i <= count; i++)
                    {
                        if (newarrival != null && !used1)
                        {
                            used1 = true;
                            filter += arrival;
                        }
                        else if (newdate != null && !used2)
                        {
                            used2 = true;
                            filter += date;
                        }
                        else if (!string.IsNullOrEmpty(textBox1.Text) && !used3)
                        {
                            used3 = true;
                            filter += text;
                        }
                        else if (radioButton1.Checked && !used4)
                        {
                            used4 = true;
                            filter += direct;
                        }
                        else if (radioButton2.Checked && !used5)
                        {
                            used5 = true;
                            filter += indirect;
                        }
                        else if (radioButton3.Checked && !used6)
                        {
                            used6 = true;
                            filter += econ;
                        }
                        else if (radioButton4.Checked && !used7)
                        {
                            used7 = true;
                            filter += business;
                        }
                        if (i + 1 <= count)
                        {
                            filter += " and ";
                        }
                    }
                    directDefaultBindingSource.Filter = filter;
                }
            else
            {
                label2.Text = "Please search at least one keyword.";
            }
            if (radioButton2.Checked)
            {
                directDefaultDataGridView.Columns["information"].Visible = true;
            }
            else
            {
                directDefaultDataGridView.Columns["information"].Visible = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            newdate = DateTime.Now;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            newarrival = DateTime.Now;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label2.Text = "";
            directDefaultBindingSource.Filter = "";
            textBox1.Clear();
            newarrival = null;
            newdate = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            directDefaultDataGridView.Columns["Information"].Visible = false;
        }

        private void directDefaultDataGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == directDefaultDataGridView.Columns["FlightBook"].Index && e.RowIndex >= 0)
            {
                if (back == true)
                {
                    frmOrder f = new frmOrder(place);
                    f.place.label33.Text = directDefaultDataGridView.CurrentRow.Cells["FlightNo"].Value.ToString();
                    f.place.label31.Text = directDefaultDataGridView.CurrentRow.Cells["Departure_date"].Value.ToString();
                    f.place.label36.Text = directDefaultDataGridView.CurrentRow.Cells["origin"].Value.ToString();
                    f.place.label34.Text = directDefaultDataGridView.CurrentRow.Cells["destination"].Value.ToString();
                    f.place.label35.Text = directDefaultDataGridView.CurrentRow.Cells["price_adult"].Value.ToString();
                    f.place.label29.Text = directDefaultDataGridView.CurrentRow.Cells["price_children"].Value.ToString();
                    f.place.label17.Text = directDefaultDataGridView.CurrentRow.Cells["price_infant"].Value.ToString();
                    f.place.label47.Text = directDefaultDataGridView.CurrentRow.Cells["Class"].Value.ToString();
                    f.place.label45.Text = directDefaultDataGridView.CurrentRow.Cells["FlightID"].Value.ToString();
                    if (f.place.label34.Text != f.place.label76.Text)
                    {
                        MessageBox.Show("Please choose the right origin for return ticket (" + f.place.label76.Text + ")");
                    }
                    else {
                        this.Hide();
                        f.place.numericUpDown4.ReadOnly = false;
                        f.place.numericUpDown5.ReadOnly = false;
                        f.place.numericUpDown6.ReadOnly = false;
                        f.place.Show();
                    }
                }
                else if (back == false)
                {
                    frmOrder order = new frmOrder();
                    order.label73.Text = directDefaultDataGridView.CurrentRow.Cells["FlightNo"].Value.ToString();
                    order.label71.Text = directDefaultDataGridView.CurrentRow.Cells["Departure_date"].Value.ToString();
                    order.label74.Text = directDefaultDataGridView.CurrentRow.Cells["origin"].Value.ToString();
                    order.label76.Text = directDefaultDataGridView.CurrentRow.Cells["destination"].Value.ToString();
                    order.label75.Text = directDefaultDataGridView.CurrentRow.Cells["price_adult"].Value.ToString();
                    order.label69.Text = directDefaultDataGridView.CurrentRow.Cells["price_children"].Value.ToString();
                    order.label63.Text = directDefaultDataGridView.CurrentRow.Cells["price_infant"].Value.ToString();
                    order.label49.Text = directDefaultDataGridView.CurrentRow.Cells["Class"].Value.ToString();
                    order.label51.Text = directDefaultDataGridView.CurrentRow.Cells["FlightID"].Value.ToString();
                    order.Show();
                    this.Hide();
                }
            }
            if (e.ColumnIndex == directDefaultDataGridView.Columns["Information"].Index && e.RowIndex >= 0)
            {
                frmIndirect info = new frmIndirect();
                info.number = directDefaultDataGridView.CurrentRow.Cells["FlightNo"].Value.ToString();
                info.Show();
            }
        }

        private void availableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label13.Text = "Time : " + DateTime.Now.ToString();
        }

        private void hotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHotelSchedule hotel = new frmHotelSchedule();
            hotel.Show();
            this.Hide();
        }

        private void cruiseTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCruiseTour cruise = new frmCruiseTour();
            cruise.Show();
            this.Hide();
        }

        private void attractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAttraction attraction = new frmAttraction();
            attraction.Show();
            this.Hide();
        }

        private void dataReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllBookings booking = new frmAllBookings();
            booking.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void frmAir_Leave(object sender, EventArgs e)
        {
        }
    }
}
