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
    public partial class frmAttractionConfirm : Form
    {
        private string custid, custname;
        private string custconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=customerBooking.accdb";
        private string attractconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=attraction.accdb";

        public frmAttractionConfirm(string custid, string custname)
        {
            InitializeComponent();
            this.custid = custid;
            this.custname = custname;
        }

        private void attractionBookingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.attractionBookingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customerBookingDataSet);

        }

        private void frmAttractionConfirm_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'customerBookingDataSet.AttractionBooking' 資料表。您可以視需要進行移動或移除。
            this.attractionBookingTableAdapter.Fill(this.customerBookingDataSet.AttractionBooking);
            attractionBookingBindingSource.Filter = "custid='" + custid + "'";
            if (attractionBookingDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("This customer has not attraction booking, please choose another customer or do booking");
                this.Close();
            }
        }

        private void attractionBookingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string attractname = attractionBookingDataGridView.CurrentRow.Cells["attractname"].Value.ToString(),
                adultnum = attractionBookingDataGridView.CurrentRow.Cells["adultnum"].Value.ToString(),
                childnum = attractionBookingDataGridView.CurrentRow.Cells["childnum"].Value.ToString(),
                adultprice = attractionBookingDataGridView.CurrentRow.Cells["adultprice"].Value.ToString(),
                childprice = attractionBookingDataGridView.CurrentRow.Cells["childprice"].Value.ToString();

            string orderby = "", center = "";
            DateTime orderdate = DateTime.Parse(attractionBookingDataGridView.CurrentRow.Cells["attractorderdate"].Value.ToString());

            if (e.ColumnIndex == attractionBookingDataGridView.Columns["Document"].Index && e.RowIndex >= 0)
            {
                using (OleDbConnection con = new OleDbConnection(custconnStr))
                {
                    string Sql = "select cust.surname,cust.givenname,staff.center,staff.staffname "
                        + "from customer cust,staff "
                        + "where cust.custid='" + attractionBookingDataGridView.CurrentRow.Cells["attractcustid"].Value.ToString() + "' and staff.staffid='" + attractionBookingDataGridView.CurrentRow.Cells["attractorderby"].Value.ToString() + "'";
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

                    Novacode.Image img = doc.AddImage(@"tt logo\tt_attraction.jpg");
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
                    //    string Sql = "select cust.surname,cust.givenname,attractname,adultnum,childnum,adultprice,childprice "
                    //        + "from attractionbooking,customer cust "
                    //        + "where cust.custid=attractionbooking.custid";
                    //    OleDbCommand cmd = new OleDbCommand(Sql, con);
                    //    con.Open();
                    //    OleDbDataReader DR = cmd.ExecuteReader();
                    //    while (DR.Read())
                    //    {
                    //        if ((DR[0] + " " + DR[1]).Equals(custname))
                    //        {
                    //            attractname = DR[2].ToString();
                    //            adultnum = DR[3].ToString();
                    //            childnum = DR[4].ToString();
                    //            adultprice = DR[5].ToString();
                    //            childprice = DR[6].ToString();
                    //        }
                    //    }
                    //    con.Close();
                    //}

                    string attract_name = "", duration = "", cancellation = "", city = "";
                    using (OleDbConnection con = new OleDbConnection(attractconnStr))
                    {
                        string Sql = "select attractname,duration,cancellation,city "
                            + "from attraction";
                        OleDbCommand cmd = new OleDbCommand(Sql, con);
                        con.Open();
                        OleDbDataReader DR = cmd.ExecuteReader();
                        while (DR.Read())
                        {
                            if (DR[0].Equals(attractname))
                            {
                                attract_name = DR[0].ToString();
                                duration = DR[1].ToString();
                                cancellation = DR[2].ToString();
                                city = DR[3].ToString();
                            }
                        }
                        con.Close();
                    }

                    doc.InsertParagraph("Attraction name: " + attract_name);
                    doc.InsertParagraph("Attraction city: " + city);
                    // Add content to this Table.
                    table.Rows[0].Cells[0].Paragraphs.First().Append("Attraction Booking Confirmation");
                    table.Rows[0].Cells[0].Paragraphs.First().Alignment = Alignment.center;
                    table.Rows[0].Cells[0].Width = 300;
                    table.Rows[0].Cells[1].Paragraphs.First().Append("Price");
                    table.Rows[0].Cells[1].Paragraphs.First().Alignment = Alignment.center;
                    table.Rows[0].Cells[1].Width = 300;
                    table.Rows[1].Cells[0].Paragraphs.First().Append(""
                        + "Attraction duration: " + duration + Environment.NewLine
                        + "Attraction cancellation: " + cancellation + Environment.NewLine
                        + "Number of adult: " + Environment.NewLine
                        + "Number of child: " + Environment.NewLine
                        + "Adult price: " + Environment.NewLine
                        + "Child price: "
                        );
                    table.Rows[1].Cells[0].Width = 300;
                    table.Rows[1].Cells[1].Paragraphs.First().Append(""
                        + Environment.NewLine
                        + Environment.NewLine
                        + adultnum + Environment.NewLine
                        + childnum + Environment.NewLine
                        + "$" + adultprice + Environment.NewLine
                        + "$" + childprice
                        );
                    table.Rows[1].Cells[1].Paragraphs.First().Alignment = Alignment.right;
                    int attractTotal = Int32.Parse(adultprice) + Int32.Parse(childprice);
                    table.Rows[1].Cells[1].Width = 300;
                    table.Rows[2].Cells[0].Paragraphs.First().Append("Total fee");
                    table.Rows[2].Cells[0].Paragraphs.First().Alignment = Alignment.right;
                    table.Rows[2].Cells[0].Width = 300;
                    table.Rows[2].Cells[1].Paragraphs.First().Append("$" + attractTotal);
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
