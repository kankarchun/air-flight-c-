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
    public partial class frmCruiseConfirm : Form
    {
        private string custid, custname;
        private string custconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=customerBooking.accdb";
        private string cruiseconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=cruise.accdb";

        public frmCruiseConfirm(string custid, string custname)
        {
            InitializeComponent();
            this.custid = custid;
            this.custname = custname;
        }

        private void cruiseBookingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cruiseBookingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customerBookingDataSet);

        }

        private void frmCruiseConfirm_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'customerBookingDataSet.CruiseBooking' 資料表。您可以視需要進行移動或移除。
            this.cruiseBookingTableAdapter.Fill(this.customerBookingDataSet.CruiseBooking);
            cruiseBookingBindingSource.Filter = "custid='" + custid + "'";
            if (cruiseBookingDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("This customer has not cruise booking, please choose another customer or do booking");
                this.Close();
            }
        }

        private void cruiseBookingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cruiseno = cruiseBookingDataGridView.CurrentRow.Cells["Cruiseno"].Value.ToString(),
                personnum = cruiseBookingDataGridView.CurrentRow.Cells["personnum"].Value.ToString(),
                personprice = cruiseBookingDataGridView.CurrentRow.Cells["personprice"].Value.ToString();

            string orderby = "", center = "";
            DateTime orderdate = DateTime.Parse(cruiseBookingDataGridView.CurrentRow.Cells["CruiseOrderDate"].Value.ToString());

            if (e.ColumnIndex == cruiseBookingDataGridView.Columns["Document"].Index && e.RowIndex >= 0)
            {
                using (OleDbConnection con = new OleDbConnection(custconnStr))
                {
                    string Sql = "select cust.surname,cust.givenname,staff.center,staff.staffname "
                        + "from customer cust,staff "
                        + "where cust.custid='" + cruiseBookingDataGridView.CurrentRow.Cells["Cruisecustid"].Value.ToString() + "' and staff.staffid='" + cruiseBookingDataGridView.CurrentRow.Cells["Cruiseorderby"].Value.ToString() + "'";
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
                save.Title = "Save cruise booking file";
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

                    Novacode.Image img = doc.AddImage(@"tt logo\tt_cruise.jpg");
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
                    //    string Sql = "select cust.surname,cust.givenname,cruiseno,personnum,personprice "
                    //        + "from cruisebooking,customer cust "
                    //        + "where cust.custid=cruisebooking.custid";
                    //    OleDbCommand cmd = new OleDbCommand(Sql, con);
                    //    con.Open();
                    //    OleDbDataReader DR = cmd.ExecuteReader();
                    //    while (DR.Read())
                    //    {
                    //        if ((DR[0] + " " + DR[1]).Equals(custname))
                    //        {
                    //            cruiseno = DR[2].ToString();
                    //            personnum = DR[3].ToString();
                    //            personprice = DR[4].ToString();
                    //        }
                    //    }
                    //    con.Close();
                    //}

                    string organiserC = "", organiserE = "", cruise_no = "", cruisename = "", refprice = "", tourday = "";
                    DateTime startdate = new DateTime();
                    using (OleDbConnection con = new OleDbConnection(cruiseconnStr))
                    {
                        string Sql = "select organiserC,organiserE,cruiseno,cruisename,refprice,tourday,startdate "
                            + "from cruise,corganiser "
                            + "where cruise.organid=corganiser.organid";
                        OleDbCommand cmd = new OleDbCommand(Sql, con);
                        con.Open();
                        OleDbDataReader DR = cmd.ExecuteReader();
                        while (DR.Read())
                        {
                            if (DR[2].Equals(cruiseno))
                            {
                                organiserC = DR[0].ToString();
                                organiserE = DR[1].ToString();
                                cruise_no = DR[2].ToString();
                                cruisename = DR[3].ToString();
                                refprice = DR[4].ToString();
                                tourday = DR[5].ToString();
                                startdate = DateTime.Parse(DR[6].ToString());
                            }
                        }
                        con.Close();
                    }

                    doc.InsertParagraph("Cruise name: " + cruisename);
                    // Add content to this Table.
                    table.Rows[0].Cells[0].Paragraphs.First().Append("Cruise Booking Confirmation");
                    table.Rows[0].Cells[0].Paragraphs.First().Alignment = Alignment.center;
                    table.Rows[0].Cells[0].Width = 300;
                    table.Rows[0].Cells[1].Paragraphs.First().Append("Price");
                    table.Rows[0].Cells[1].Paragraphs.First().Alignment = Alignment.center;
                    table.Rows[0].Cells[1].Width = 300;
                    table.Rows[1].Cells[0].Paragraphs.First().Append(""
                        + "Organiser Chinese Name: " + organiserC + Environment.NewLine
                        + "Organiser English Name: " + organiserE + Environment.NewLine
                        + "Cruise No: " + cruise_no + Environment.NewLine
                        + "Cruise start date: " + startdate.ToShortDateString() + Environment.NewLine
                        + "Cruise tour day: " + tourday + Environment.NewLine
                        + "Number of person: " + Environment.NewLine
                        + "Cruise price: "
                        );
                    table.Rows[1].Cells[0].Width = 300;
                    table.Rows[1].Cells[1].Paragraphs.First().Append(""
                        + Environment.NewLine
                        + Environment.NewLine
                        + Environment.NewLine
                        + Environment.NewLine
                        + Environment.NewLine
                        + Environment.NewLine
                        + personnum + Environment.NewLine
                        + "$" + refprice
                        );
                    table.Rows[1].Cells[1].Paragraphs.First().Alignment = Alignment.right;
                    //double hotelTotal = Double.Parse(hoteltotalprice);
                    table.Rows[1].Cells[1].Width = 300;
                    table.Rows[2].Cells[0].Paragraphs.First().Append("Total fee");
                    table.Rows[2].Cells[0].Paragraphs.First().Alignment = Alignment.right;
                    table.Rows[2].Cells[0].Width = 300;
                    table.Rows[2].Cells[1].Paragraphs.First().Append("$" + personprice);
                    table.Rows[2].Cells[1].Paragraphs.First().Alignment = Alignment.right;
                    table.Rows[2].Cells[1].Width = 300;
                    table.Alignment = Alignment.center;
                    // Insert table at index where tag #TABLE# is in document.
                    doc.InsertTable(table);

                    doc.Save();
                    Process.Start("WINWORD.EXE", save.FileName);
                }

                this.Close();
            }
        }
    }
}
