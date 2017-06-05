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
    public partial class frmHotelSchedule : Form
    {
        private DataTable dtDefault = new DataTable();
        private DataTable dtInformation = new DataTable();
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;"+ "Data Source=Hotel.accdb";
        private Boolean check = false;
        public static string staffname;
        public int row;
        private DateTime? checkin=null, checkout=null;
        private frmHotelOrder hotelorder;
        public static bool second;

        public frmHotelSchedule()
        {
            InitializeComponent();
        }

        public frmHotelSchedule(frmHotelOrder h)
        {
            InitializeComponent();
            hotelorder = h;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmHotelSchedule_Load(object sender, EventArgs e)
        {

            // TODO: 這行程式碼會將資料載入 'hotelDataSet.Information' 資料表。您可以視需要進行移動或移除。
            this.informationTableAdapter.Fill(this.hotelDataSet.Information);
            // TODO: 這行程式碼會將資料載入 'hotelDataSet.Default' 資料表。您可以視需要進行移動或移除。
            this.defaultTableAdapter.Fill(this.hotelDataSet.Default);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            if (frmLogin.customerLogin)
            {
                label12.Text = "Customer: " + staffname;
            }
            else {
                label12.Text = "Staff: " + staffname;
            }
            timer1.Start();
            if (frmLogin.customerLogin)
            {
                label11.Visible = false;
                label6.Visible = false;
                label9.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                informationDataGridView.Columns["Book"].Visible = false;
            }
            if (second == true)
            {
                informationDataGridView.Visible = true;
            }
                //string sort = "Select Hotel_chi_name,Hotel_en_name,star,region,address,rating from hotel ";
                //SortDefault(sort+"order by Hotel_en_name asc");
                //name,star,region,address,price,
                //room size,room type,room description,fare
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmAir air = new frmAir();
            air.Show();
            this.Hide();
        }

        private void defaultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            informationDataGridView.Visible = true;
            if (second == true)
            {
                defaultDataGridView.ClearSelection();
                return;
            }
            informationBindingSource.Filter = "hotel_chi_name='" + defaultDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() + "'";
            row = e.RowIndex;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            second = false;
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
            ucSlideMenu1.button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            informationDataGridView.Visible = false;
            label1.Text = "";
            int count = 0;
            //string checkin = "departure_date='" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "'";
            //string checkout = "departure_arrival='" + dateTimePicker2.Value.ToString("dd-MM-yyyy") + "'";
            string text = "Hotel_chi_name like '%" + textBox2.Text + "%' ";
            string region = "Region like '%" + textBox4.Text + "%' ";
            //string direct = "FlightType = 'direct'";
            //string indirect = "FlightType = 'indirect'";
            //string econ = "class ='econ'";
            //string business = "class='business'";

            bool used1 = false, used2 = false, used3 = false, used4 = false, used5 = false, used6 = false, used7 = false;
            if (!string.IsNullOrEmpty(textBox2.Text))
                count++;
            if (!string.IsNullOrEmpty(textBox4.Text))
                count++;
            if (count != 0)
            {
                string filter = "";
                for (int i = 1; i <= count; i++)
                {
                    if (!string.IsNullOrEmpty(textBox2.Text) && !used3)
                    {
                        used3 = true;
                        filter += text;
                    }
                    else if (!string.IsNullOrEmpty(textBox4.Text) && !used4)
                    {
                        used4 = true;
                        filter += region;
                    }
                    if (i + 1 <= count)
                    {
                        filter += " and ";
                    }
                }
                defaultBindingSource.Filter = filter;
            }
            else
            {
                label1.Text = "Please search at least one keyword.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            informationDataGridView.Visible = false;
            defaultBindingSource.Filter = "";
            textBox2.Clear();
            textBox4.Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabPage1.Controls.Add(defaultDataGridView);
                defaultBindingSource.Sort = "hotel_chi_name asc";

            }
            else if (tabControl1.SelectedIndex == 1)
            {
                tabPage2.Controls.Add(defaultDataGridView);
                defaultBindingSource.Sort = "rating desc";

            }
            else
            {
                defaultBindingSource.Sort = "star asc";
                tabPage4.Controls.Add(defaultDataGridView);
            }
        }

        private void informationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = "";
            if (checkin == null || checkout == null)
            {
                label1.Text = "Please select checkin date and checkout date";
                return;
            }
            else if(dateTimePicker1.Value==dateTimePicker2.Value)
            {
                MessageBox.Show("Checkin date and checkout date cannot be same");
                return;
            }
            else if (e.ColumnIndex == informationDataGridView.Columns[7].Index && e.RowIndex >= 0)
            {
                if (dateTimePicker1.Value > dateTimePicker2.Value)
                {
                    MessageBox.Show("Checkin date cannot higher than checkout date");
                    return;
                }
                if (second == true)
                {
                    this.Hide();
                    frmHotelOrder f = new frmHotelOrder(hotelorder);
                    f.order.label8.Text = informationDataGridView.CurrentRow.Cells["Hotel_room_name"].Value.ToString();
                    f.order.label7.Text = informationDataGridView.CurrentRow.Cells["fare"].Value.ToString();
                    f.order.label9.Text = informationDataGridView.CurrentRow.Cells["max_adults"].Value.ToString();
                    f.order.label14.Text = informationDataGridView.CurrentRow.Cells["max_child"].Value.ToString();
                    f.order.label22.Text = informationDataGridView.CurrentRow.Cells["HotelID"].Value.ToString();
                    f.order.numericUpDown4.Enabled = true;

                    f.order.secondprice = Double.Parse(f.order.label7.Text);
                    f.order.numRoom_second = Convert.ToInt32(f.order.numericUpDown4.Value);
                    int secondnight = Int32.Parse(f.order.label38.Text);
                    f.order.secondsubtotal = (f.order.secondprice * secondnight * f.order.numRoom_second);
                    double grandTotal = f.order.firstsubtotal + f.order.secondsubtotal;
                    f.order.label57.Text = grandTotal.ToString();
                    f.order.Show();
                }
                else if (second == false)
                {
                    frmHotelOrder hotel_order = new frmHotelOrder();
                    hotel_order.label46.Text = defaultDataGridView.Rows[row].Cells[0].Value.ToString();
                    hotel_order.label47.Text = defaultDataGridView.Rows[row].Cells[2].Value.ToString();
                    hotel_order.label48.Text = dateTimePicker1.Value.ToShortDateString();
                    hotel_order.label49.Text = dateTimePicker2.Value.ToShortDateString();
                    hotel_order.label50.Text = informationDataGridView.CurrentRow.Cells["Hotel_room_name"].Value.ToString();
                    hotel_order.label51.Text = informationDataGridView.CurrentRow.Cells["fare"].Value.ToString();
                    hotel_order.label11.Text = informationDataGridView.CurrentRow.Cells["max_adults"].Value.ToString();
                    hotel_order.label16.Text = informationDataGridView.CurrentRow.Cells["max_child"].Value.ToString();
                    hotel_order.label33.Text = informationDataGridView.CurrentRow.Cells["HotelID"].Value.ToString();
                    hotel_order.Show();
                    this.Hide();
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            checkout = DateTime.Now;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            checkin = DateTime.Now;
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

        private void airFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAir air = new frmAir();
            air.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void frmHotelSchedule_Leave(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label10.Text = "Time : " + DateTime.Now.ToString();
        }
    }
}
