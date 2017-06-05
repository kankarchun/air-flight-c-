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
using Novacode;
using System.Diagnostics;

namespace Air_flight
{
    public partial class frmVehicleConfirm : Form
    {
        private string custid, custname;
        private string custconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=customerBooking.accdb";
        private string vehicleconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=vehicle.accdb";

        public frmVehicleConfirm(string custid, string custname)
        {
            InitializeComponent();
            this.custid = custid;
            this.custname = custname;
        }

        private void vehicleBookingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehicleBookingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customerBookingDataSet);

        }

        private void frmVehicleConfirm_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'customerBookingDataSet.VehicleBooking' 資料表。您可以視需要進行移動或移除。
            this.vehicleBookingTableAdapter.Fill(this.customerBookingDataSet.VehicleBooking);
            vehicleBookingBindingSource.Filter = "custid='" + custid + "'";
            if (vehicleBookingDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("This customer has not vehicle booking, please choose another customer or do booking");
                this.Close();
            }
        }

        private void vehicleBookingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string bookday = vehicleBookingDataGridView.CurrentRow.Cells["bookday"].Value.ToString(),
            vehiclebookprice = vehicleBookingDataGridView.CurrentRow.Cells["vehiclebookprice"].Value.ToString(),
            equipnum = vehicleBookingDataGridView.CurrentRow.Cells["EquipNum"].Value.ToString(),
            equipbookprice = vehicleBookingDataGridView.CurrentRow.Cells["equipbookprice"].Value.ToString();
            DateTime pickupdate = DateTime.Parse(vehicleBookingDataGridView.CurrentRow.Cells["pickupdate"].Value.ToString());
            DateTime dropoffdate = DateTime.Parse(vehicleBookingDataGridView.CurrentRow.Cells["dropoffdate"].Value.ToString());

            string orderby = "", center = "";
            DateTime orderdate = DateTime.Parse(vehicleBookingDataGridView.CurrentRow.Cells["Vehicleorderdate"].Value.ToString());

            if (e.ColumnIndex == vehicleBookingDataGridView.Columns["Document"].Index && e.RowIndex >= 0)
            {
                using (OleDbConnection con = new OleDbConnection(custconnStr))
                {
                    string Sql = "select cust.surname,cust.givenname,staff.center,staff.staffname "
                        + "from customer cust,staff "
                        + "where cust.custid='" + vehicleBookingDataGridView.CurrentRow.Cells["vehiclecustid"].Value.ToString() + "' and staff.staffid='" + vehicleBookingDataGridView.CurrentRow.Cells["vehicleorderby"].Value.ToString() + "'";
                    OleDbCommand cmd = new OleDbCommand(Sql, con);
                    con.Open();
                    OleDbDataReader DR = cmd.ExecuteReader();
                    while (DR.Read())
                    {
                        if ((DR[0] + " " + DR[1]).Equals(custname))
                        {
                            orderby = DR[3].ToString();
                            center = DR[2].ToString();
                        }
                    }
                    con.Close();
                }

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Word document|*.docx";
                save.Title = "Save flight booking file";
                save.ShowDialog();
                if (save.FileName != "")
                {
                    var doc = DocX.Create(save.FileName);
                    string header = "Hong Kong Ticket Tailor Ltd";
                    string info = ""
                        + DateTime.Now.ToShortDateString() + Environment.NewLine + Environment.NewLine
                        + "Customer Name: " + custname + Environment.NewLine
                        + "Customer No: " + custid + Environment.NewLine
                        + "Order Date: " + orderdate.ToShortDateString() + Environment.NewLine
                        + "Center: " + center + Environment.NewLine
                        + "Staff Name: " + orderby + Environment.NewLine
                        ;
                    var titleformat = new Formatting();
                    titleformat.Position = 12;
                    titleformat.Size = 18D;
                    titleformat.FontFamily = new System.Drawing.FontFamily("Arial Black");

                    var infoformat = new Formatting();
                    infoformat.FontFamily = new System.Drawing.FontFamily("Constantia");
                    infoformat.Size = 12D;

                    Novacode.Image img = doc.AddImage(@"tt logo\tt_transport.jpg");
                    Picture pic1 = img.CreatePicture();
                    Paragraph pic = doc.InsertParagraph("", false, titleformat);
                    pic.InsertPicture(pic1, 0);
                    pic1.Width = 600;
                    doc.InsertParagraph(Environment.NewLine);

                    Paragraph title = doc.InsertParagraph(header, false, titleformat);
                    title.Alignment = Alignment.center;
                    title.Bold();
                    title.UnderlineStyle(UnderlineStyle.singleLine);
                    doc.InsertParagraph(Environment.NewLine);

                    doc.InsertParagraph(info, false, infoformat);

                    var table = doc.AddTable(3, 2);

                    // Specify some properties for this Table.

                    table.Design = TableDesign.MediumGrid1Accent2;

                    string vehicle_name="", vehicleprice = "", vehicle_type = "", capacity = "", gear = "", color = "", equipment = "", suitable = "", equipmentprice = "";

                    using (OleDbConnection con = new OleDbConnection(vehicleconnStr))
                    {
                        string Sql = "select [vehicle_name],[price],[vehicle_type],[capacity],[gear],[color],vehicleid "
                            + "from vehicle";
                        OleDbCommand cmd = new OleDbCommand(Sql, con);
                        con.Open();
                        OleDbDataReader DR = cmd.ExecuteReader();
                        while (DR.Read())
                        {
                            if (DR[6].Equals(vehicleBookingDataGridView.CurrentRow.Cells["vehicleid"].Value.ToString()))
                            {
                                vehicle_name = DR[0].ToString();
                                vehicleprice = DR[1].ToString();
                                vehicle_type = DR[2].ToString();
                                capacity = DR[3].ToString();
                                gear = DR[4].ToString();
                                color = DR[5].ToString();
                            }
                        }
                        con.Close();
                    }
                    using (OleDbConnection con = new OleDbConnection(vehicleconnStr))
                    {
                        string Sql = "select equipid,equipment,suitable,price "
                            + "from equipment";
                        OleDbCommand cmd = new OleDbCommand(Sql, con);
                        con.Open();
                        OleDbDataReader DR = cmd.ExecuteReader();
                        while (DR.Read())
                        {
                            if (DR[0].Equals(vehicleBookingDataGridView.CurrentRow.Cells["equipid"].Value.ToString()))
                            {
                                equipment = DR[1].ToString();
                                suitable = DR[1].ToString();
                                equipmentprice = DR[2].ToString();
                            }
                        }
                        con.Close();
                    }
            //        string bookday = vehicleBookingDataGridView.CurrentRow.Cells["bookday"].Value.ToString(),
            //vehiclebookprice = vehicleBookingDataGridView.CurrentRow.Cells["vehiclebookprice"].Value.ToString(),
            //equipnum = vehicleBookingDataGridView.CurrentRow.Cells["equipnum"].Value.ToString(),
            //equipbookprice = vehicleBookingDataGridView.CurrentRow.Cells["equipbookprice"].Value.ToString();
            //        DateTime pickupdate = DateTime.Parse(vehicleBookingDataGridView.CurrentRow.Cells["pickupdate"].Value.ToString());
            //        DateTime dropoffdate = DateTime.Parse(vehicleBookingDataGridView.CurrentRow.Cells["dropoffdate"].Value.ToString());
                    // Add content to this Table.
                    table.Rows[0].Cells[0].Paragraphs.First().Append("Vehicle Booking Confirmation");
                    table.Rows[0].Cells[0].Paragraphs.First().Alignment = Alignment.center;
                    table.Rows[0].Cells[0].Width = 300;
                    table.Rows[0].Cells[1].Paragraphs.First().Append("Price");
                    table.Rows[0].Cells[1].Paragraphs.First().Alignment = Alignment.center;
                    table.Rows[0].Cells[1].Width = 300;
                    table.Rows[1].Cells[0].Paragraphs.First().Append(""
                        + "Vehicle pickup date: " + pickupdate.ToShortDateString() + Environment.NewLine
                        + "Vehicle dropoff date: " + dropoffdate.ToShortDateString() + Environment.NewLine
                        + "Vehicle Name: " + vehicle_name + Environment.NewLine
                        + "Vehicle type: " + vehicle_type + Environment.NewLine
                        + "Vehicle capacity: " + capacity + Environment.NewLine
                        + "Vehicle gear: " + gear + Environment.NewLine
                        + "Vehicle color: " + color + Environment.NewLine
                        + "Vehicle book day: " + Environment.NewLine
                        + "Vehicle price: " + Environment.NewLine
                        + "Equipment name: " + equipment + Environment.NewLine
                        + "Number of equipment: " + Environment.NewLine
                        + "Equipment price: "
                        );
                    table.Rows[1].Cells[0].Width = 300;
                    table.Rows[1].Cells[1].Paragraphs.First().Append(""
                        + Environment.NewLine
                        + Environment.NewLine
                        + Environment.NewLine
                        + Environment.NewLine
                        + Environment.NewLine
                        + Environment.NewLine
                        + Environment.NewLine
                        + bookday + Environment.NewLine
                        + "$" + vehiclebookprice + Environment.NewLine
                        + Environment.NewLine
                        + equipnum + Environment.NewLine
                        + "$" + equipbookprice
                        );
                    table.Rows[1].Cells[1].Paragraphs.First().Alignment = Alignment.right;
                    double vehicleTotal = Int32.Parse(vehiclebookprice) + Int32.Parse(equipbookprice);
                    table.Rows[1].Cells[1].Width = 300;
                    table.Rows[2].Cells[0].Paragraphs.First().Append("Total fee");
                    table.Rows[2].Cells[0].Paragraphs.First().Alignment = Alignment.right;
                    table.Rows[2].Cells[0].Width = 300;
                    table.Rows[2].Cells[1].Paragraphs.First().Append("$" + vehicleTotal);
                    table.Rows[2].Cells[1].Paragraphs.First().Alignment = Alignment.right;
                    table.Rows[2].Cells[1].Width = 300;
                    table.Alignment = Alignment.center;
                    // Insert table at index where tag #TABLE# is in document.
                    doc.InsertTable(table);

                    doc.InsertParagraph(Environment.NewLine);

                    doc.Save();
                    Process.Start("WINWORD.EXE", save.FileName);
                }
                this.Close();
            }
        }
    }
}
