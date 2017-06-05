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
using System.IO;
using System.Diagnostics;

namespace Air_flight
{
    public partial class frmCruiseTour : Form
    {
        private DataTable dt = new DataTable();
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Cruise.accdb";
        private Boolean check = false;
        private DateTime? newdate = null;
        public static string staffname;
        
        public frmCruiseTour()
        {
            InitializeComponent();
        }

        private void frmCruiseTour_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'cruiseDataSet.Default' 資料表。您可以視需要進行移動或移除。
            this.defaultTableAdapter.Fill(this.cruiseDataSet.Default);
            //cruiseGrid("Select tourday,co.organiserC,cruiseName,refprice as price,startdate from cruise c,corganiser co where c.organid=co.organid order by tourday asc");
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            defaultDataGridView.Columns["StartDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            if (frmLogin.customerLogin)
            {
                label12.Text = "Customer: " + staffname;
            }
            else {
                label12.Text = "Staff: " + staffname;
            }
           // label8.Text = "Time : " + DateTime.Now;
            if (frmLogin.customerLogin)
            {
                defaultDataGridView.Columns["Book"].Visible = false;
            }
            timer1.Start();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (newdate.HasValue && !string.IsNullOrEmpty(textBox1.Text))
            {
                defaultBindingSource.Filter = "startdate = '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "' and organiserC like '%" + textBox1.Text + "%'";
                defaultBindingSource.Sort="tourday asc";
            }
            else if (newdate.HasValue)
            {
                defaultBindingSource.Filter= "startdate='" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "'";
                defaultBindingSource.Sort = "tourday asc";
            }
            else if (!string.IsNullOrEmpty(textBox1.Text))
            {
                defaultBindingSource.Filter = "organiserC like '%" + textBox1.Text + "%'";
                defaultBindingSource.Sort = "tourday asc";
            }
            else
            {
                label1.Text = "Please search cruise organiser or start date.";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            newdate = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            defaultBindingSource.Filter = "";
            defaultBindingSource.Sort = "tourday asc";
            //cruiseGrid("Select tourday,co.organiserC,cruiseName,refprice as price,startdate from cruise c,corganiser co where c.organid=co.organid order by tourday asc");
            if(newdate != null && !string.IsNullOrEmpty(textBox1.Text))
            {
                dateTimePicker1.Value = new DateTime(2015, 07, 01);
                newdate = null;
                textBox1.Clear();
              //  label1.Text = "Please input date and keywords again";
            }
            else if (newdate != null)
            {
                dateTimePicker1.Value = new DateTime(2015, 07, 01);
              //  label1.Text = "Please input date again";
            }else if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Clear();
              //  label1.Text = "Please input keywords again";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
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
            ucSlideMenu1.button3.Enabled = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabPage1.Controls.Add(defaultDataGridView);
                defaultBindingSource.Sort = "cruisename asc";

            }
            else
            {
                defaultBindingSource.Sort = "refprice asc";
                tabPage2.Controls.Add(defaultDataGridView);
            }
        }

        private void defaultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void defaultDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == defaultDataGridView.Columns[6].Index && e.RowIndex >= 0)
            {
                if (defaultDataGridView.CurrentRow.Cells["CruiseNo"].Value.ToString().Equals("EMM10A"))
                {
                    string path = Directory.GetCurrentDirectory() + "\\EMM10A.pdf";
                    System.Diagnostics.Process.Start(@path);
                }
                else if (defaultDataGridView.CurrentRow.Cells["CruiseNo"].Value.ToString().Equals("HCW85A"))
                {
                    string path = Directory.GetCurrentDirectory() + "\\HCW85A.pdf";
                    System.Diagnostics.Process.Start(@path);
                }
                else if (defaultDataGridView.CurrentRow.Cells["CruiseNo"].Value.ToString().Equals("HRO08A"))
                {
                    string path = Directory.GetCurrentDirectory() + "\\HRO08A.pdf";
                    System.Diagnostics.Process.Start(@path);
                }
                else if (defaultDataGridView.CurrentRow.Cells["CruiseNo"].Value.ToString().Equals("HRT04A"))
                {
                    string path = Directory.GetCurrentDirectory() + "\\HRT04A.pdf";
                    System.Diagnostics.Process.Start(@path);
                }
                else if (defaultDataGridView.CurrentRow.Cells["CruiseNo"].Value.ToString().Equals("HRX06A"))
                {
                    string path = Directory.GetCurrentDirectory() + "\\HRX06A.pdf";
                    System.Diagnostics.Process.Start(@path);
                }
                else if (defaultDataGridView.CurrentRow.Cells["CruiseNo"].Value.ToString().Equals("HSC04A"))
                {
                    string path = Directory.GetCurrentDirectory() + "\\HSC04A.pdf";
                    System.Diagnostics.Process.Start(@path);
                }
                else if (defaultDataGridView.CurrentRow.Cells["CruiseNo"].Value.ToString().Equals("HSG04A"))
                {
                    string path = Directory.GetCurrentDirectory() + "\\HSG04A.pdf";
                    System.Diagnostics.Process.Start(@path);
                }
                else if (defaultDataGridView.CurrentRow.Cells["CruiseNo"].Value.ToString().Equals("HSH06A"))
                {
                    string path = Directory.GetCurrentDirectory() + "\\HSH06A.pdf";
                    System.Diagnostics.Process.Start(@path);
                }
                else if (defaultDataGridView.CurrentRow.Cells["CruiseNo"].Value.ToString().Equals("JPD07A"))
                {
                    string path = Directory.GetCurrentDirectory() + "\\JPD07A.pdf";
                    System.Diagnostics.Process.Start(@path);
                }
                else if (defaultDataGridView.CurrentRow.Cells["CruiseNo"].Value.ToString().Equals("SSG06A"))
                {
                    string path = Directory.GetCurrentDirectory() + "\\SSG06A.pdf";
                    System.Diagnostics.Process.Start(@path);
                }
                else if (defaultDataGridView.CurrentRow.Cells["CruiseNo"].Value.ToString().Equals("TSA06A"))
                {
                    string path = Directory.GetCurrentDirectory() + "\\TSA06A.pdf";
                    System.Diagnostics.Process.Start(@path);
                }
                else if (defaultDataGridView.CurrentRow.Cells["CruiseNo"].Value.ToString().Equals("URM12A"))
                {
                    string path = Directory.GetCurrentDirectory() + "\\URM12A.pdf";
                    System.Diagnostics.Process.Start(@path);
                }
            }
            if (e.ColumnIndex == defaultDataGridView.Columns[7].Index && e.RowIndex >= 0)
            {
                frmCruiseBooking order = new frmCruiseBooking();
                order.label27.Text = defaultDataGridView.CurrentRow.Cells["TourDay"].Value.ToString();
                order.label26.Text = defaultDataGridView.CurrentRow.Cells["CruiseName"].Value.ToString();
                order.label20.Text = defaultDataGridView.CurrentRow.Cells["RefPrice"].Value.ToString();
                order.label28.Text = defaultDataGridView.CurrentRow.Cells["StartDate"].Value.ToString();
                order.label25.Text = defaultDataGridView.CurrentRow.Cells["CruiseNo"].Value.ToString();
                order.label11.Text = defaultDataGridView.CurrentRow.Cells["OrganiserC"].Value.ToString();
                order.Show();
                this.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label8.Text = "Time : "+ DateTime.Now.ToString();
        }

        private void hotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHotelSchedule hotel = new frmHotelSchedule();
            hotel.Show();
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

        private void airFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAir air = new frmAir();
            air.Show();
            this.Hide();
        }
    }
}
