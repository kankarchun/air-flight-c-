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
    public partial class frmFlightConfirm : Form
    {
        private string custid,custname;
        private string custconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=customerBooking.accdb";
        private string flightconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=ticketTailor_db.accdb";

        public frmFlightConfirm(string custid,string custname)
        {
            InitializeComponent();
            this.custid = custid;
            this.custname = custname;
        }

        private void flightBookingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.flightBookingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customerBookingDataSet);

        }

        private void frmFlightConfirm_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'customerBookingDataSet.FlightBooking' 資料表。您可以視需要進行移動或移除。
            this.flightBookingTableAdapter.Fill(this.customerBookingDataSet.FlightBooking);
            flightBookingBindingSource.Filter = "custid='" + custid + "'";
            if (flightBookingDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("This customer has not flight booking, please choose another customer or do booking");
                this.Close();
            }
        }

        private void flightBookingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string flightno= flightBookingDataGridView.CurrentRow.Cells["Flightno"].Value.ToString(),
                flightclass = flightBookingDataGridView.CurrentRow.Cells["Flightclass"].Value.ToString(),
                adultnum = flightBookingDataGridView.CurrentRow.Cells["adultnum"].Value.ToString(),
                childnum = flightBookingDataGridView.CurrentRow.Cells["childnum"].Value.ToString(),
                infantnum = flightBookingDataGridView.CurrentRow.Cells["infantnum"].Value.ToString(),
                adultprice = flightBookingDataGridView.CurrentRow.Cells["adultprice"].Value.ToString(),
                childprice = flightBookingDataGridView.CurrentRow.Cells["childprice"].Value.ToString(),
                infantprice = flightBookingDataGridView.CurrentRow.Cells["infantprice"].Value.ToString();
            string carriername = "", origin = "", dest = "", departureTime = "", departureDate = "", arrivalTime = "";

            string orderby = "", center = "";
            DateTime orderdate = DateTime.Parse(flightBookingDataGridView.CurrentRow.Cells["Flightorderdate"].Value.ToString());

            if (e.ColumnIndex == flightBookingDataGridView.Columns["Document"].Index && e.RowIndex >= 0)
            {
                //string stmt = "SELECT COUNT(*) FROM flightbooking where custid='" + custid + "'";
                //int count = 0;

                using (OleDbConnection con = new OleDbConnection(custconnStr))
                {
                    string Sql = "select cust.surname,cust.givenname,staff.center,staff.staffname "
                        + "from customer cust,staff "
                        + "where cust.custid='" + flightBookingDataGridView.CurrentRow.Cells["Flightcustid"].Value.ToString() + "' and staff.staffid='" + flightBookingDataGridView.CurrentRow.Cells["Flightorderby"].Value.ToString() + "'";
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

                    Novacode.Image img = doc.AddImage(@"tt logo\tt_air.jpg");
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

                    //using (OleDbConnection con = new OleDbConnection(custconnStr))
                    //{
                    //    string Sql = "select cust.surname,cust.givenname,flightno, flightclass, adultnum, childnum, infantnum, adultprice, childprice, infantprice "
                    //        + "from flightbooking,customer cust "
                    //        + "where cust.custid=flightbooking.custid order by flightbooking.orderdate asc";
                    //    OleDbCommand cmd = new OleDbCommand(Sql, con);
                    //    con.Open();
                    //    OleDbDataReader DR = cmd.ExecuteReader();
                    //    while (DR.Read())
                    //    {
                    //        if ((DR[0] + " " + DR[1]).Equals(custname))
                    //        {
                    //            flightno = DR[2].ToString();
                    //            flightclass = DR[3].ToString();
                    //            adultnum = DR[4].ToString();
                    //            childnum = DR[5].ToString();
                    //            infantnum = DR[6].ToString();
                    //            adultprice = DR[7].ToString();
                    //            childprice = DR[8].ToString();
                    //            infantprice = DR[9].ToString();
                    //        }
                    //    }
                    //    con.Close();
                    //}

                    using (OleDbConnection con = new OleDbConnection(flightconnStr))
                    {
                        string Sql = "select carriername,edd,etd,eta,origin,dest,flightno "
                            + "from flightschedule,carrier "
                            + "where carrier.carrierid=flightschedule.carrier";
                        OleDbCommand cmd = new OleDbCommand(Sql, con);
                        con.Open();
                        OleDbDataReader DR = cmd.ExecuteReader();
                        while (DR.Read())
                        {
                            if (DR[6].Equals(flightno))
                            {
                                DateTime dt1 = (DateTime)DR[1];
                                DateTime dt2 = (DateTime)DR[2];
                                DateTime dt3 = (DateTime)DR[3];
                                carriername = DR[0].ToString();
                                departureDate = dt1.ToString("dd/MM/yyyy");
                                departureTime = dt2.ToString("HH:mm");
                                arrivalTime = dt3.ToString("HH:mm");
                                origin = DR[4].ToString();
                                dest = DR[5].ToString();
                            }
                        }
                        con.Close();
                    }

                    // Add content to this Table.
                    table.Rows[0].Cells[0].Paragraphs.First().Append("Flight Booking Confirmation");
                    table.Rows[0].Cells[0].Paragraphs.First().Alignment = Alignment.center;
                    table.Rows[0].Cells[0].Width = 300;
                    table.Rows[0].Cells[1].Paragraphs.First().Append("Price");
                    table.Rows[0].Cells[1].Paragraphs.First().Alignment = Alignment.center;
                    table.Rows[0].Cells[1].Width = 300;
                    table.Rows[1].Cells[0].Paragraphs.First().Append(""
                        + "Carrier Name: " + carriername + Environment.NewLine
                        + "Origin: " + origin + Environment.NewLine
                        + "Destination: " + dest + Environment.NewLine
                        + "Flight Date: " + departureDate + Environment.NewLine
                        + "Estimated Time Of Departure: " + departureTime + Environment.NewLine
                        + "Estimated Time Of Arrival: " + arrivalTime + Environment.NewLine
                        + "Flight No: " + flightno + Environment.NewLine
                        + "Class: " + flightclass + Environment.NewLine
                        + "Adult Number: " + Environment.NewLine
                        + "Child Number: " + Environment.NewLine
                        + "Infant Number: " + Environment.NewLine
                        + "Adult price: " + Environment.NewLine
                        + "Child price: " + Environment.NewLine
                        + "Infant price: "
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
                        + Environment.NewLine
                        + adultnum + Environment.NewLine
                        + childnum + Environment.NewLine
                        + infantnum + Environment.NewLine
                        + "$" + adultprice + Environment.NewLine
                        + "$" + childprice + Environment.NewLine
                        + "$" + infantprice
                        );
                    table.Rows[1].Cells[1].Paragraphs.First().Alignment = Alignment.right;
                    double flightTotal = Int32.Parse(adultprice) + Int32.Parse(childprice) + Int32.Parse(infantprice);
                    table.Rows[1].Cells[1].Width = 300;
                    table.Rows[2].Cells[0].Paragraphs.First().Append("Total fee");
                    table.Rows[2].Cells[0].Paragraphs.First().Alignment = Alignment.right;
                    table.Rows[2].Cells[0].Width = 300;
                    table.Rows[2].Cells[1].Paragraphs.First().Append("$" + flightTotal);
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
