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
    public partial class frmAttraction : Form
    {
        public static string staffname;
        private DateTime? date = null;

        public frmAttraction()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmAttraction_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'attractionDataSet.Default' 資料表。您可以視需要進行移動或移除。
            this.defaultTableAdapter.Fill(this.attractionDataSet.Default);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=attraction.accdb";
            using(OleDbConnection con=new OleDbConnection(connStr))
            {
                OleDbCommand cmd = new OleDbCommand("Select city from attraction", con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                }
                textBox1.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }

            if (frmLogin.customerLogin)
            {
                defaultDataGridView.Columns["Book"].Visible = false;
                defaultDataGridView.Columns["Visitor"].Visible = true;
                label12.Text = "Customer: " + staffname;
            }
            else {
                defaultBindingSource.Filter = "Visitor = 'adult'";
                defaultDataGridView.Columns["Visitor"].Visible = false;
                label12.Text = "Staff: " + staffname;
            }
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
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
            ucSlideMenu1.button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                label2.Text = "Please input the city of attraction to search";
                return;
            }
            defaultBindingSource.Filter = "city='" + textBox1.Text + "'";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void defaultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (date == null)
            {
                MessageBox.Show("Please input attraction date");
                return;
            }
            if (dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("Attraction Date cannot smaller than today");
                dateTimePicker1.Value = DateTime.Now;
                return;
            }
            pictureBox4.Visible = true;
                if (defaultDataGridView.CurrentRow.Cells[1].Value.ToString() == "AdventureCove Waterpark")
                    pictureBox4.Image = Properties.Resources.AdventureCove;
                else if (defaultDataGridView.CurrentRow.Cells[1].Value.ToString() == "BlueMountain Day Tour")
                    pictureBox4.Image = Properties.Resources.BlueMountain;
                else if (defaultDataGridView.CurrentRow.Cells[1].Value.ToString() == "BridgeClimb Experience")
                    pictureBox4.Image = Properties.Resources.BridgeClimb;
                else if (defaultDataGridView.CurrentRow.Cells[1].Value.ToString() == "Disneyland Admission")
                    pictureBox4.Image = Properties.Resources.Disneyland;
                else if (defaultDataGridView.CurrentRow.Cells[1].Value.ToString() == "DisneySea Admission")
                    pictureBox4.Image = Properties.Resources.DisneySea;
                else if (defaultDataGridView.CurrentRow.Cells[1].Value.ToString() == "MountFuji Lake Ashi")
                    pictureBox4.Image = Properties.Resources.MountFuji;
                else if (defaultDataGridView.CurrentRow.Cells[1].Value.ToString() == "NightSafari Adventure")
                    pictureBox4.Image = Properties.Resources.NightSafari;
                else if (defaultDataGridView.CurrentRow.Cells[1].Value.ToString() == "OperaHouse Guided Working Tour")
                    pictureBox4.Image = Properties.Resources.OperaHouse;
                else if (defaultDataGridView.CurrentRow.Cells[1].Value.ToString() == "SEAAquarium")
                    pictureBox4.Image = Properties.Resources.SEAAquarium;
                else if (defaultDataGridView.CurrentRow.Cells[1].Value.ToString() == "ShrimpFishing Barbecue")
                    pictureBox4.Image = Properties.Resources.ShrimpFishing;
                else if (defaultDataGridView.CurrentRow.Cells[1].Value.ToString() == "SingaporeZoee Adventure")
                    pictureBox4.Image = Properties.Resources.SingaporeZoo;
                else if (defaultDataGridView.CurrentRow.Cells[1].Value.ToString() == "TaipeiTea Culture Day")
                    pictureBox4.Image = Properties.Resources.TaipeiTea;
                else if (defaultDataGridView.CurrentRow.Cells[1].Value.ToString() == "TokyoMorning Tour")
                    pictureBox4.Image = Properties.Resources.TokyoMorning;
                else if (defaultDataGridView.CurrentRow.Cells[1].Value.ToString() == "TraditionalChinese Performing Arts")
                    pictureBox4.Image = Properties.Resources.TraditionalChinese;
                else if (defaultDataGridView.CurrentRow.Cells[1].Value.ToString() == "TraditionalJapanese Performing Arts")
                    pictureBox4.Image = Properties.Resources.TraditionalJapanese;
                else if (defaultDataGridView.CurrentRow.Cells[1].Value.ToString() == "UniversalStudios Singapore")
                    pictureBox4.Image = Properties.Resources.UniversalStudios;
                else if (defaultDataGridView.CurrentRow.Cells[1].Value.ToString() == "Yangmingshan National Park")
                    pictureBox4.Image = Properties.Resources.Yangmingshan;
            if (e.ColumnIndex == defaultDataGridView.Columns[6].Index && e.RowIndex >= 0)
            {
                frmAttractionBooking order = new frmAttractionBooking();
                order.pictureBox1.Image = pictureBox4.Image;
                order.label25.Text = defaultDataGridView.CurrentRow.Cells["AttractName"].Value.ToString();
                order.label26.Text = defaultDataGridView.CurrentRow.Cells["Duration"].Value.ToString();
                order.label27.Text = defaultDataGridView.CurrentRow.Cells["Cancellation"].Value.ToString();
                order.label28.Text = defaultDataGridView.CurrentRow.Cells["City"].Value.ToString();
                order.label20.Text = defaultDataGridView.CurrentRow.Cells["AttractPrice"].Value.ToString();
                defaultBindingSource.Filter = "AttractName = '"+ defaultDataGridView.CurrentRow.Cells["AttractName"].Value.ToString() + "' and Visitor='Child'";
                order.label11.Text = defaultDataGridView.Rows[0].Cells["AttractPrice"].Value.ToString();
                order.label32.Text = dateTimePicker1.Value.ToShortDateString();
                order.Show();
                this.Hide();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            textBox1.Clear();
            defaultBindingSource.Filter = "";
            defaultBindingSource.Filter = "Visitor = 'adult'";
            defaultDataGridView.Columns["Visitor"].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label6.Text = "Time : " + DateTime.Now.ToString();
        }

        private void airFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAir air = new frmAir();
            air.Show();
            this.Hide();
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
    }
}
