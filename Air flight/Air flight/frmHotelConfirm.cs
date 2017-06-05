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
    public partial class frmHotelConfirm : Form
    {
        private string custid, custname;
        private string custconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=customerBooking.accdb";
        private string hotelconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=hotel.accdb";

        public frmHotelConfirm(string custid, string custname)
        {
            InitializeComponent();
            this.custid = custid;
            this.custname = custname;
        }

        private void hotelBookingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hotelBookingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customerBookingDataSet);

        }

        private void frmHotelConfirm_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'customerBookingDataSet.HotelBooking' 資料表。您可以視需要進行移動或移除。
            this.hotelBookingTableAdapter.Fill(this.customerBookingDataSet.HotelBooking);
            hotelBookingBindingSource.Filter = "custid='" + custid + "'";
            if (hotelBookingDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("This customer has not hotel booking, please choose another customer or do booking");
                this.Close();
            }
        }

        private void hotelBookingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string hotelroomid = hotelBookingDataGridView.CurrentRow.Cells["hotelroomid"].Value.ToString(),
                hotelroomname = hotelBookingDataGridView.CurrentRow.Cells["hotelroomname"].Value.ToString(),
                numnight = hotelBookingDataGridView.CurrentRow.Cells["numnight"].Value.ToString(),
                numroom = hotelBookingDataGridView.CurrentRow.Cells["numroom"].Value.ToString(),
                hoteltotalprice = hotelBookingDataGridView.CurrentRow.Cells["price"].Value.ToString();
            string orderby = "", center = "";
            DateTime orderdate = DateTime.Parse(hotelBookingDataGridView.CurrentRow.Cells["Hotelorderdate"].Value.ToString());
            DateTime checkin = DateTime.Parse(hotelBookingDataGridView.CurrentRow.Cells["checkin"].Value.ToString());
            DateTime checkout = DateTime.Parse(hotelBookingDataGridView.CurrentRow.Cells["checkout"].Value.ToString());

            if (e.ColumnIndex == hotelBookingDataGridView.Columns["Document"].Index && e.RowIndex >= 0)
            {
                using (OleDbConnection con = new OleDbConnection(custconnStr))
                {
                    string Sql = "select cust.surname,cust.givenname,staff.center,staff.staffname "
                        + "from customer cust,staff "
                        + "where cust.custid='" + hotelBookingDataGridView.CurrentRow.Cells["hotelcustid"].Value.ToString() + "' and staff.staffid='" + hotelBookingDataGridView.CurrentRow.Cells["hotelorderby"].Value.ToString() + "'";
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
                save.Title = "Save hotel booking file";
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

                    Novacode.Image img = doc.AddImage(@"tt logo\tt_hotel.jpg");
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
                    //    string Sql = "select cust.surname,cust.givenname,hotelroomid,numnight,numroom,price,hotelroomname "
                    //        + "from hotelbooking,customer cust "
                    //        + "where cust.custid=hotelbooking.custid";
                    //    OleDbCommand cmd = new OleDbCommand(Sql, con);
                    //    con.Open();
                    //    OleDbDataReader DR = cmd.ExecuteReader();
                    //    while (DR.Read())
                    //    {
                    //        if ((DR[0] + " " + DR[1]).Equals(custname))
                    //        {
                    //            hotelroomid = DR[2].ToString();
                    //            numnight = DR[3].ToString();
                    //            numroom = DR[4].ToString();
                    //            hoteltotalprice = DR[5].ToString();
                    //            hotelroomname = DR[6].ToString();
                    //        }
                    //    }
                    //    con.Close();
                    //}

                    string hotel_chi_name = "", hotel_en_name = "", region = "", address = "", hotel_room_name = "", hotel_room_size = "", max_adults = "", max_child = "", hotel_room_description = "", fare = "";
                    using (OleDbConnection con = new OleDbConnection(hotelconnStr))
                    {
                        string Sql = "select hotel.hotel_chi_name,hotel_en_name,region,address,hotel_room_name,hotel_room_size,max_adults,max_child,hotel_room_description,fare "
                            + "from hotel,hotel_room "
                            + "where hotel_room.hotelid=hotel.hotelid and hotel_room.hotelid="+hotelroomid;
                        OleDbCommand cmd = new OleDbCommand(Sql, con);
                        con.Open();
                        OleDbDataReader DR = cmd.ExecuteReader();
                        while (DR.Read())
                        {
                            if (DR[4].Equals(hotelroomname))
                            {
                                hotel_chi_name = DR[0].ToString();
                                hotel_en_name = DR[1].ToString();
                                region = DR[2].ToString();
                                address = DR[3].ToString();
                                hotel_room_name = DR[4].ToString();
                                hotel_room_size = DR[5].ToString();
                                max_adults = DR[6].ToString();
                                max_child = DR[7].ToString();
                                hotel_room_description = DR[8].ToString();
                                fare = DR[9].ToString();
                            }
                        }
                        con.Close();
                    }

                    doc.InsertParagraph("Hotel address: " + address);
                    doc.InsertParagraph("Hotel region: " + region);
                    // Add content to this Table.
                    table.Rows[0].Cells[0].Paragraphs.First().Append("Hotel Booking Confirmation");
                    table.Rows[0].Cells[0].Paragraphs.First().Alignment = Alignment.center;
                    table.Rows[0].Cells[0].Width = 300;
                    table.Rows[0].Cells[1].Paragraphs.First().Append("Price");
                    table.Rows[0].Cells[1].Paragraphs.First().Alignment = Alignment.center;
                    table.Rows[0].Cells[1].Width = 300;
                    table.Rows[1].Cells[0].Paragraphs.First().Append(""
                        + "Hotel Chinese Name: " + hotel_chi_name + Environment.NewLine
                        + "Hotel English Name: " + hotel_en_name + Environment.NewLine
                        + "Hotel room size: " + hotel_room_size + Environment.NewLine
                        + "Max adult in room: " + max_adults + Environment.NewLine
                        + "Max child in room: " + max_child + Environment.NewLine
                        + "Hotel description: " + hotel_room_description + Environment.NewLine
                        + "Hotel checkin: " + checkin.ToShortDateString() + Environment.NewLine
                        + "Hotel checkout: " + checkout.ToShortDateString() + Environment.NewLine
                        + "Number of room: " + numroom + Environment.NewLine
                        + "Number of night: " + numnight + Environment.NewLine
                        + "Hotel fare: "
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
                        + numroom + Environment.NewLine
                        + numnight + Environment.NewLine
                        + "$" + fare
                        );
                    table.Rows[1].Cells[1].Paragraphs.First().Alignment = Alignment.right;
                    //double hotelTotal = Double.Parse(hoteltotalprice);
                    table.Rows[1].Cells[1].Width = 300;
                    table.Rows[2].Cells[0].Paragraphs.First().Append("Total fee");
                    table.Rows[2].Cells[0].Paragraphs.First().Alignment = Alignment.right;
                    table.Rows[2].Cells[0].Width = 300;
                    table.Rows[2].Cells[1].Paragraphs.First().Append("$" + hoteltotalprice);
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
