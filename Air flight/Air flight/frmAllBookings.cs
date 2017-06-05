using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Novacode;
using System.Diagnostics;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;

namespace Air_flight
{
    public partial class frmAllBookings : Form
    {
        public static string staffname;
        private string custname;
        private string custconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=customerBooking.accdb";
        //private string flightconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=ticketTailor_db.accdb";
        //private string hotelconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=hotel.accdb";
        //private string cruiseconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=cruise.accdb";
        //private string attractconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=attraction.accdb";
        //private string vehicleconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=vehicle.accdb";
        private string custid, orderdate, center, orderby;
        //private string flightno, flightclass, adultnum, childnum, infantnum, adultprice, childprice, infantprice;
        //private string carriername, origin, dest, departureTime, departureDate, arrivalTime;
        //private string hotelroomid,hotelroomname, numnight, numroom, hoteltotalprice;

        private void button7_Click(object sender, EventArgs e)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            excelApp.Workbooks.Add();
            Excel._Worksheet workSheet = excelApp.ActiveSheet;

            Excel.Range Range_title = workSheet.get_Range("A1");
            Excel.Range Range_cust = workSheet.get_Range("A1:D1");
            Excel.Range Range_col = workSheet.get_Range("A2:M2");
            Range_cust.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
            Range_title.Font.Bold = true;
            Range_col.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            workSheet.Cells[1, "A"] = "Hong Kong Ticket Tailor Ltd";
            workSheet.Cells[1, "B"] = "Customer Flight Booking Details";
            workSheet.Cells[1, "C"] = "Customer name: ";
            workSheet.Cells[1, "D"] = custname;

            workSheet.Cells[2, "A"] = "CustomerID";
            workSheet.Cells[2, "B"] = "Air Flight Book ID";
            workSheet.Cells[2, "C"] = "Air Flight ID";
            workSheet.Cells[2, "D"] = "Air Flight No";
            workSheet.Cells[2, "E"] = "Air Flight Class";
            workSheet.Cells[2, "F"] = "Adult Number";
            workSheet.Cells[2, "G"] = "Child Number";
            workSheet.Cells[2, "H"] = "Infant Number";
            workSheet.Cells[2, "I"] = "Adult Price";
            workSheet.Cells[2, "J"] = "Child Price";
            workSheet.Cells[2, "K"] = "Infant Price";
            workSheet.Cells[2, "L"] = "Order Date";
            workSheet.Cells[2, "M"] = "Order By";

            string stmt = "SELECT * FROM flightbooking where custid='" + custid + "'";

            OleDbConnection conn = new OleDbConnection(custconnStr);
            OleDbCommand cmd = new OleDbCommand(stmt, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Excel.Range Range_details = workSheet.get_Range("A" + (i + 3) + ":M" + (i + 3));
                Range_details.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                workSheet.Cells[(i + 3), "A"] = custid;
                workSheet.Cells[(i + 3), "B"] = dt.Rows[i]["FlightOrderID"].ToString();
                workSheet.Cells[(i + 3), "C"] = dt.Rows[i]["FlightID"].ToString();
                workSheet.Cells[(i + 3), "D"] = dt.Rows[i]["FlightNo"].ToString();
                workSheet.Cells[(i + 3), "E"] = dt.Rows[i]["FlightClass"].ToString();
                workSheet.Cells[(i + 3), "F"] = dt.Rows[i]["AdultNum"].ToString();
                workSheet.Cells[(i + 3), "G"] = dt.Rows[i]["ChildNum"].ToString();
                workSheet.Cells[(i + 3), "H"] = dt.Rows[i]["InfantNum"].ToString();
                workSheet.Cells[(i + 3), "I"] = dt.Rows[i]["AdultPrice"].ToString();
                workSheet.Cells[(i + 3), "J"] = dt.Rows[i]["ChildPrice"].ToString();
                workSheet.Cells[(i + 3), "K"] = dt.Rows[i]["InfantPrice"].ToString();
                workSheet.Cells[(i + 3), "L"] = ((DateTime)dt.Rows[i]["OrderDate"]).ToString("yyyy-MM-dd");
                workSheet.Cells[(i + 3), "M"] = dt.Rows[i]["OrderBy"].ToString();
            }
            workSheet.Columns.AutoFit();
        }

        public frmAllBookings()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
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
            ucSlideMenu1.button7.Enabled = false;
        }

        private void frmAllBookings_Load(object sender, EventArgs e)
        {
            if (frmLogin.customerLogin)
            {
                label12.Text = "Customer: " + staffname;
            }
            else
            {
                label12.Text = "Staff: " + staffname;
            }
            label9.Text = "Time : " + DateTime.Now;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            if (frmModuleSelection.position.Equals("Center Manager"))
                button12.Enabled = true;
            else
                button12.Enabled = false;
            string Sql = "";
            using (OleDbConnection con = new OleDbConnection(custconnStr))
            {
                if (frmLogin.customerLogin)
                {
                    Sql = "select surname,givenname from customer where custid='" + frmLogin.staffid + "'";
                }
                else
                {
                    Sql = "select surname,givenname,custid from customer";
                }
                OleDbCommand cmd = new OleDbCommand(Sql, con);
                con.Open();
                OleDbDataReader DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    comboBox1.Items.Add(DR[0] + " " + DR[1]);
                }
                con.Close();
            }
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFlightConfirm flightConfirm = new frmFlightConfirm(custid, custname);
            flightConfirm.Show();

            //string stmt = "SELECT COUNT(*) FROM flightbooking where custid='" + custid + "'";
            //int count = 0;

            //using (OleDbConnection thisConnection = new OleDbConnection(custconnStr))
            //{
            //    using (OleDbCommand cmdCount = new OleDbCommand(stmt, thisConnection))
            //    {
            //        thisConnection.Open();
            //        count = (int)cmdCount.ExecuteScalar();
            //        thisConnection.Close();
            //    }
            //}

            //if (count > 0)
            //{
            //    SaveFileDialog save = new SaveFileDialog();
            //    save.Filter = "Word document|*.docx";
            //    save.Title = "Save flight booking file";
            //    save.ShowDialog();
            //    if (save.FileName != "")
            //    {
            //        var doc = DocX.Create(save.FileName);
            //        string header = "Hong Kong Ticket Tailor Ltd";
            //        string info = ""
            //            + DateTime.Now.ToShortDateString() + Environment.NewLine + Environment.NewLine
            //            + "Customer Name: " + custname + Environment.NewLine
            //            + "Customer No: " + custid + Environment.NewLine
            //            + "Order Date: " + orderdate + Environment.NewLine
            //            + "Center: " + center + Environment.NewLine
            //            + "Staff Name: " + orderby + Environment.NewLine
            //            ;
            //        var titleformat = new Formatting();
            //        titleformat.Position = 12;
            //        titleformat.Size = 18D;
            //        titleformat.FontFamily = new System.Drawing.FontFamily("Arial Black");

            //        var infoformat = new Formatting();
            //        infoformat.FontFamily = new System.Drawing.FontFamily("Constantia");
            //        infoformat.Size = 12D;

            //        Novacode.Image img = doc.AddImage(@"tt logo\tt_air.jpg");
            //        Picture pic1 = img.CreatePicture();
            //        Paragraph pic = doc.InsertParagraph("", false, titleformat);
            //        pic.InsertPicture(pic1, 0);
            //        pic1.Width = 600;
            //        doc.InsertParagraph(Environment.NewLine);

            //        Paragraph title = doc.InsertParagraph(header, false, titleformat);
            //        title.Alignment = Alignment.center;
            //        title.Bold();
            //        title.UnderlineStyle(UnderlineStyle.singleLine);
            //        doc.InsertParagraph(Environment.NewLine);

            //        doc.InsertParagraph(info, false, infoformat);

            //        var table = doc.AddTable(3, 2);

            //        // Specify some properties for this Table.

            //        table.Design = TableDesign.MediumGrid1Accent2;

            //        using (OleDbConnection con = new OleDbConnection(custconnStr))
            //        {
            //            string Sql = "select cust.surname,cust.givenname,flightno, flightclass, adultnum, childnum, infantnum, adultprice, childprice, infantprice "
            //                + "from flightbooking,customer cust "
            //                + "where cust.custid=flightbooking.custid order by flightbooking.orderdate asc";
            //            OleDbCommand cmd = new OleDbCommand(Sql, con);
            //            con.Open();
            //            OleDbDataReader DR = cmd.ExecuteReader();
            //            while (DR.Read())
            //            {
            //                if ((DR[0] + " " + DR[1]).Equals(custname))
            //                {
            //                    flightno = DR[2].ToString();
            //                    flightclass = DR[3].ToString();
            //                    adultnum = DR[4].ToString();
            //                    childnum = DR[5].ToString();
            //                    infantnum = DR[6].ToString();
            //                    adultprice = DR[7].ToString();
            //                    childprice = DR[8].ToString();
            //                    infantprice = DR[9].ToString();
            //                }
            //            }
            //            con.Close();
            //        }

            //        using (OleDbConnection con = new OleDbConnection(flightconnStr))
            //        {
            //            string Sql = "select carriername,edd,etd,eta,origin,dest,flightno "
            //                + "from flightschedule,carrier "
            //                + "where carrier.carrierid=flightschedule.carrier";
            //            OleDbCommand cmd = new OleDbCommand(Sql, con);
            //            con.Open();
            //            OleDbDataReader DR = cmd.ExecuteReader();
            //            while (DR.Read())
            //            {
            //                if (DR[6].Equals(flightno))
            //                {
            //                    DateTime dt1 = (DateTime)DR[1];
            //                    DateTime dt2 = (DateTime)DR[2];
            //                    DateTime dt3 = (DateTime)DR[3];
            //                    carriername = DR[0].ToString();
            //                    departureDate = dt1.ToString("dd/MM/yyyy");
            //                    departureTime = dt2.ToString("HH:mm");
            //                    arrivalTime = dt3.ToString("HH:mm");
            //                    origin = DR[4].ToString();
            //                    dest = DR[5].ToString();
            //                }
            //            }
            //            con.Close();
            //        }

            //        // Add content to this Table.
            //        table.Rows[0].Cells[0].Paragraphs.First().Append("Flight Booking Confirmation");
            //        table.Rows[0].Cells[0].Paragraphs.First().Alignment = Alignment.center;
            //        table.Rows[0].Cells[0].Width = 300;
            //        table.Rows[0].Cells[1].Paragraphs.First().Append("Price");
            //        table.Rows[0].Cells[1].Paragraphs.First().Alignment = Alignment.center;
            //        table.Rows[0].Cells[1].Width = 300;
            //        table.Rows[1].Cells[0].Paragraphs.First().Append(""
            //            + "Carrier Name: " + carriername + Environment.NewLine
            //            + "Origin: " + origin + Environment.NewLine
            //            + "Destination: " + dest + Environment.NewLine
            //            + "Flight Date: " + departureDate + Environment.NewLine
            //            + "Estimated Time Of Departure: " + departureTime + Environment.NewLine
            //            + "Estimated Time Of Arrival: " + arrivalTime + Environment.NewLine
            //            + "Flight No: " + flightno + Environment.NewLine
            //            + "Class: " + flightclass + Environment.NewLine
            //            + "Adult Number: " + adultnum + Environment.NewLine
            //            + "Child Number: " + childnum + Environment.NewLine
            //            + "Infant Number: " + infantnum
            //            );
            //        table.Rows[1].Cells[0].Width = 300;
            //        table.Rows[1].Cells[1].Paragraphs.First().Append(""
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + "$" + adultprice + Environment.NewLine
            //            + "$" + childprice + Environment.NewLine
            //            + "$" + infantprice
            //            );
            //        table.Rows[1].Cells[1].Paragraphs.First().Alignment = Alignment.right;
            //        double flightTotal = Int32.Parse(adultprice) + Int32.Parse(childprice) + Int32.Parse(infantprice);
            //        table.Rows[1].Cells[1].Width = 300;
            //        table.Rows[2].Cells[0].Paragraphs.First().Append("Total fee");
            //        table.Rows[2].Cells[0].Paragraphs.First().Alignment = Alignment.right;
            //        table.Rows[2].Cells[0].Width = 300;
            //        table.Rows[2].Cells[1].Paragraphs.First().Append("$" + flightTotal);
            //        table.Rows[2].Cells[1].Paragraphs.First().Alignment = Alignment.right;
            //        table.Rows[2].Cells[1].Width = 300;
            //        table.Alignment = Alignment.center;
            //        // Insert table at index where tag #TABLE# is in document.
            //        doc.InsertTable(table);

            //        doc.InsertParagraph(Environment.NewLine);

            //        doc.Save();
            //        Process.Start("WINWORD.EXE", save.FileName);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("This customer has not flight booking");
            //}
            //frmModuleSelection menu = new frmModuleSelection();
            //menu.Show();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //using (OleDbConnection con = new OleDbConnection(custconnStr))
            //{
            //    string Sql = "select cust.surname,cust.givenname,hotel.custid,hotel.orderdate,staff.center,staff.staffname "
            //        + "from hotelbooking hotel,customer cust,staff "
            //        + "where cust.custid=hotel.custid and staff.staffid=hotel.orderby order by hotel.orderdate asc";
            //    OleDbCommand cmd = new OleDbCommand(Sql, con);
            //    con.Open();
            //    OleDbDataReader DR = cmd.ExecuteReader();
            //    while (DR.Read())
            //    {
            //        if ((DR[0] + " " + DR[1]).Equals(custname))
            //        {
            //            custid = DR[2].ToString();
            //        }
            //    }
            //    con.Close();
            //}
            frmHotelConfirm hotelConfirm = new frmHotelConfirm(custid, custname);
            hotelConfirm.Show();

            //using (OleDbConnection con = new OleDbConnection(custconnStr))
            //{
            //    string Sql = "select cust.surname,cust.givenname,hotel.custid,hotel.orderdate,staff.center,staff.staffname "
            //        + "from hotelbooking hotel,customer cust,staff "
            //        + "where cust.custid=hotel.custid and staff.staffid=hotel.orderby order by hotel.orderdate asc";
            //    OleDbCommand cmd = new OleDbCommand(Sql, con);
            //    con.Open();
            //    OleDbDataReader DR = cmd.ExecuteReader();
            //    while (DR.Read())
            //    {
            //        if ((DR[0] + " " + DR[1]).Equals(custname))
            //        {
            //            DateTime dt1 = (DateTime)DR[3];
            //            custid = DR[2].ToString();
            //            orderdate = dt1.ToString("dd/MM/yyyy");
            //            center = DR[4].ToString();
            //            orderby = DR[5].ToString();
            //        }
            //    }

            //    con.Close();
            //}

            //string stmt = "SELECT COUNT(*) FROM hotelbooking where custid='"+custid+"'";
            //int count = 0;

            //using (OleDbConnection thisConnection = new OleDbConnection(custconnStr))
            //{
            //    using (OleDbCommand cmdCount = new OleDbCommand(stmt, thisConnection))
            //    {
            //        thisConnection.Open();
            //        count = (int)cmdCount.ExecuteScalar();
            //        thisConnection.Close();
            //    }
            //}

            //if (count > 0)
            //{
            //    SaveFileDialog save = new SaveFileDialog();
            //    save.Filter = "Word document|*.docx";
            //    save.Title = "Save flight booking file";
            //    save.ShowDialog();
            //    if (save.FileName != "")
            //    {
            //        var doc = DocX.Create(save.FileName);
            //        string header = "Hong Kong Ticket Tailor Ltd";
            //        string info = ""
            //            + DateTime.Now.ToShortDateString() + Environment.NewLine + Environment.NewLine
            //            + "Customer Name: " + custname + Environment.NewLine
            //            + "Customer No: " + custid + Environment.NewLine
            //            + "Order Date: " + orderdate + Environment.NewLine
            //            + "Center: " + center + Environment.NewLine
            //            + "Staff Name: " + orderby + Environment.NewLine
            //            ;
            //        var titleformat = new Formatting();
            //        titleformat.Position = 12;
            //        titleformat.Size = 18D;
            //        titleformat.FontFamily = new System.Drawing.FontFamily("Arial Black");

            //        var infoformat = new Formatting();
            //        infoformat.FontFamily = new System.Drawing.FontFamily("Constantia");
            //        infoformat.Size = 12D;

            //        Novacode.Image img = doc.AddImage(@"tt logo\tt_hotel.jpg");
            //        Picture pic1 = img.CreatePicture();
            //        Paragraph pic = doc.InsertParagraph("", false, titleformat);
            //        pic.InsertPicture(pic1, 0);
            //        pic1.Width = 600;
            //        doc.InsertParagraph(Environment.NewLine);

            //        Paragraph title = doc.InsertParagraph(header, false, titleformat);
            //        title.Alignment = Alignment.center;
            //        title.Bold();
            //        title.UnderlineStyle(UnderlineStyle.singleLine);
            //        doc.InsertParagraph(Environment.NewLine);

            //        doc.InsertParagraph(info, false, infoformat);

            //        var table = doc.AddTable(3, 2);

            //        // Specify some properties for this Table.

            //        table.Design = TableDesign.MediumGrid1Accent2;

            //        using (OleDbConnection con = new OleDbConnection(custconnStr))
            //        {
            //            string Sql = "select cust.surname,cust.givenname,hotelroomid,numnight,numroom,price,hotelroomname "
            //                + "from hotelbooking,customer cust "
            //                + "where cust.custid=hotelbooking.custid";
            //            OleDbCommand cmd = new OleDbCommand(Sql, con);
            //            con.Open();
            //            OleDbDataReader DR = cmd.ExecuteReader();
            //            while (DR.Read())
            //            {
            //                if ((DR[0] + " " + DR[1]).Equals(custname))
            //                {
            //                    hotelroomid = DR[2].ToString();
            //                    numnight = DR[3].ToString();
            //                    numroom = DR[4].ToString();
            //                    hoteltotalprice = DR[5].ToString();
            //                    hotelroomname = DR[6].ToString();
            //                }
            //            }
            //            con.Close();
            //        }
            //        string hotel_chi_name = "", hotel_en_name = "", region = "", address = "", hotel_room_name = "", hotel_room_size = "", max_adults = "", max_child = "", hotel_room_description = "", fare = "";
            //        using (OleDbConnection con = new OleDbConnection(hotelconnStr))
            //        {
            //            string Sql = "select hotel.hotel_chi_name,hotel_en_name,region,address,hotel_room_name,hotel_room_size,max_adults,max_child,hotel_room_description,fare "
            //                + "from hotel,hotel_room "
            //                + "where hotel_room.hotelid=hotel.hotelid";
            //            OleDbCommand cmd = new OleDbCommand(Sql, con);
            //            con.Open();
            //            OleDbDataReader DR = cmd.ExecuteReader();
            //            while (DR.Read())
            //            {
            //                if (DR[4].Equals(hotelroomname))
            //                {
            //                    hotel_chi_name = DR[0].ToString();
            //                    hotel_en_name = DR[1].ToString();
            //                    region = DR[2].ToString();
            //                    address = DR[3].ToString();
            //                    hotel_room_name = DR[4].ToString();
            //                    hotel_room_size = DR[5].ToString();
            //                    max_adults = DR[6].ToString();
            //                    max_child = DR[7].ToString();
            //                    hotel_room_description = DR[8].ToString();
            //                    fare = DR[9].ToString();
            //                }
            //            }
            //            con.Close();
            //        }

            //        doc.InsertParagraph("Hotel address: " + address);
            //        doc.InsertParagraph("Hotel region: " + region);
            //        // Add content to this Table.
            //        table.Rows[0].Cells[0].Paragraphs.First().Append("Hotel Booking Confirmation");
            //        table.Rows[0].Cells[0].Paragraphs.First().Alignment = Alignment.center;
            //        table.Rows[0].Cells[0].Width = 300;
            //        table.Rows[0].Cells[1].Paragraphs.First().Append("Price");
            //        table.Rows[0].Cells[1].Paragraphs.First().Alignment = Alignment.center;
            //        table.Rows[0].Cells[1].Width = 300;
            //        table.Rows[1].Cells[0].Paragraphs.First().Append(""
            //            + "Hotel Chinese Name: " + hotel_chi_name + Environment.NewLine
            //            + "Hotel English Name: " + hotel_en_name + Environment.NewLine
            //            + "Hotel room size: " + hotel_room_size + Environment.NewLine
            //            + "Max adult in room: " + max_adults + Environment.NewLine
            //            + "Max child in room: " + max_child + Environment.NewLine
            //            + "Hotel description: " + hotel_room_description + Environment.NewLine
            //            + "Number of room: " + numroom + Environment.NewLine
            //            + "Number of night: " + numnight + Environment.NewLine
            //            + "Hotel fare: "
            //            );
            //        table.Rows[1].Cells[0].Width = 300;
            //        table.Rows[1].Cells[1].Paragraphs.First().Append(""
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + "$" + fare
            //            );
            //        table.Rows[1].Cells[1].Paragraphs.First().Alignment = Alignment.right;
            //        //double hotelTotal = Double.Parse(hoteltotalprice);
            //        table.Rows[1].Cells[1].Width = 300;
            //        table.Rows[2].Cells[0].Paragraphs.First().Append("Total fee");
            //        table.Rows[2].Cells[0].Paragraphs.First().Alignment = Alignment.right;
            //        table.Rows[2].Cells[0].Width = 300;
            //        table.Rows[2].Cells[1].Paragraphs.First().Append("$" + hoteltotalprice);
            //        table.Rows[2].Cells[1].Paragraphs.First().Alignment = Alignment.right;
            //        table.Rows[2].Cells[1].Width = 300;
            //        table.Alignment = Alignment.center;
            //        // Insert table at index where tag #TABLE# is in document.
            //        doc.InsertTable(table);

            //        doc.Save();
            //        Process.Start("WINWORD.EXE", save.FileName);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("This customer has not cruise booking");
            //}
            //frmModuleSelection menu = new frmModuleSelection();
            //menu.Show();
            //this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string custid = "";

            //using (OleDbConnection con = new OleDbConnection(custconnStr))
            //{
            //    string Sql = "select cust.surname,cust.givenname,cruise.custid,cruise.orderdate,staff.center,staff.staffname "
            //        + "from cruisebooking cruise,customer cust,staff "
            //        + "where cust.custid=cruise.custid and staff.staffid=cruise.orderby order by cruise.orderdate asc";
            //    OleDbCommand cmd = new OleDbCommand(Sql, con);
            //    con.Open();
            //    OleDbDataReader DR = cmd.ExecuteReader();
            //    while (DR.Read())
            //    {
            //        if ((DR[0] + " " + DR[1]).Equals(custname))
            //        {
            //            custid = DR[2].ToString();
            //        }
            //    }
            //    con.Close();
            //}
            frmCruiseConfirm cruiseConfirm = new frmCruiseConfirm(custid, custname);
            cruiseConfirm.Show();

            //using (OleDbConnection con = new OleDbConnection(custconnStr))
            //{
            //    string Sql = "select cust.surname,cust.givenname,cruise.custid,cruise.orderdate,staff.center,staff.staffname "
            //        + "from cruisebooking cruise,customer cust,staff "
            //        + "where cust.custid=cruise.custid and staff.staffid=cruise.orderby order by cruise.orderdate asc";
            //    OleDbCommand cmd = new OleDbCommand(Sql, con);
            //    con.Open();
            //    OleDbDataReader DR = cmd.ExecuteReader();
            //    while (DR.Read())
            //    {
            //        if ((DR[0] + " " + DR[1]).Equals(custname))
            //        {
            //            DateTime dt1 = (DateTime)DR[3];
            //            custid = DR[2].ToString();
            //            orderdate = dt1.ToString("dd/MM/yyyy");
            //            center = DR[4].ToString();
            //            orderby = DR[5].ToString();
            //        }
            //    }
            //    con.Close();
            //}

            //string stmt = "SELECT COUNT(*) FROM cruisebooking where custid='" + custid + "'";
            //int count = 0;

            //using (OleDbConnection thisConnection = new OleDbConnection(custconnStr))
            //{
            //    using (OleDbCommand cmdCount = new OleDbCommand(stmt, thisConnection))
            //    {
            //        thisConnection.Open();
            //        count = (int)cmdCount.ExecuteScalar();
            //        thisConnection.Close();
            //    }
            //}

            //if (count > 0)
            //{
            //    SaveFileDialog save = new SaveFileDialog();
            //    save.Filter = "Word document|*.docx";
            //    save.Title = "Save flight booking file";
            //    save.ShowDialog();
            //    if (save.FileName != "")
            //    {
            //        var doc = DocX.Create(save.FileName);
            //        string header = "Hong Kong Ticket Tailor Ltd";
            //        string info = ""
            //            + DateTime.Now.ToShortDateString() + Environment.NewLine + Environment.NewLine
            //            + "Customer Name: " + custname + Environment.NewLine
            //            + "Customer No: " + custid + Environment.NewLine
            //            + "Order Date: " + orderdate + Environment.NewLine
            //            + "Center: " + center + Environment.NewLine
            //            + "Staff Name: " + orderby + Environment.NewLine
            //            ;
            //        var titleformat = new Formatting();
            //        titleformat.Position = 12;
            //        titleformat.Size = 18D;
            //        titleformat.FontFamily = new System.Drawing.FontFamily("Arial Black");

            //        var infoformat = new Formatting();
            //        infoformat.FontFamily = new System.Drawing.FontFamily("Constantia");
            //        infoformat.Size = 12D;

            //        Novacode.Image img = doc.AddImage(@"tt logo\tt_cruise.jpg");
            //        Picture pic1 = img.CreatePicture();
            //        Paragraph pic = doc.InsertParagraph("", false, titleformat);
            //        pic.InsertPicture(pic1, 0);
            //        pic1.Width = 600;
            //        doc.InsertParagraph(Environment.NewLine);

            //        Paragraph title = doc.InsertParagraph(header, false, titleformat);
            //        title.Alignment = Alignment.center;
            //        title.Bold();
            //        title.UnderlineStyle(UnderlineStyle.singleLine);
            //        doc.InsertParagraph(Environment.NewLine);

            //        doc.InsertParagraph(info, false, infoformat);

            //        var table = doc.AddTable(3, 2);

            //        // Specify some properties for this Table.

            //        table.Design = TableDesign.MediumGrid1Accent2;
            //        string cruiseno="", personnum="", personprice="";
            //        using (OleDbConnection con = new OleDbConnection(custconnStr))
            //        {
            //            string Sql = "select cust.surname,cust.givenname,cruiseno,personnum,personprice "
            //                + "from cruisebooking,customer cust "
            //                + "where cust.custid=cruisebooking.custid";
            //            OleDbCommand cmd = new OleDbCommand(Sql, con);
            //            con.Open();
            //            OleDbDataReader DR = cmd.ExecuteReader();
            //            while (DR.Read())
            //            {
            //                if ((DR[0] + " " + DR[1]).Equals(custname))
            //                {
            //                    cruiseno = DR[2].ToString();
            //                    personnum = DR[3].ToString();
            //                    personprice = DR[4].ToString();
            //                }
            //            }
            //            con.Close();
            //        }
            //        string organiserC = "", organiserE = "", cruise_no = "", cruisename = "", refprice = "", tourday = "";
            //        DateTime startdate = new DateTime();
            //        using (OleDbConnection con = new OleDbConnection(cruiseconnStr))
            //        {
            //            string Sql = "select organiserC,organiserE,cruiseno,cruisename,refprice,tourday,startdate "
            //                + "from cruise,corganiser "
            //                + "where cruise.organid=corganiser.organid";
            //            OleDbCommand cmd = new OleDbCommand(Sql, con);
            //            con.Open();
            //            OleDbDataReader DR = cmd.ExecuteReader();
            //            while (DR.Read())
            //            {
            //                if (DR[4].Equals(cruiseno))
            //                {
            //                    organiserC = DR[0].ToString();
            //                    organiserE = DR[1].ToString();
            //                    cruise_no = DR[2].ToString();
            //                    cruisename = DR[3].ToString();
            //                    refprice = DR[4].ToString();
            //                    tourday = DR[5].ToString();
            //                    startdate = DateTime.Parse(DR[6].ToString());
            //                }
            //            }
            //            con.Close();
            //        }

            //        doc.InsertParagraph("Cruise name: " + cruisename);
            //        // Add content to this Table.
            //        table.Rows[0].Cells[0].Paragraphs.First().Append("Cruise Booking Confirmation");
            //        table.Rows[0].Cells[0].Paragraphs.First().Alignment = Alignment.center;
            //        table.Rows[0].Cells[0].Width = 300;
            //        table.Rows[0].Cells[1].Paragraphs.First().Append("Price");
            //        table.Rows[0].Cells[1].Paragraphs.First().Alignment = Alignment.center;
            //        table.Rows[0].Cells[1].Width = 300;
            //        table.Rows[1].Cells[0].Paragraphs.First().Append(""
            //            + "Organiser Chinese Name: " + organiserC + Environment.NewLine
            //            + "Organiser English Name: " + organiserE + Environment.NewLine
            //            + "Cruise No: " + cruise_no + Environment.NewLine
            //            + "Cruise start date: " + startdate.ToShortDateString() + Environment.NewLine
            //            + "Cruise tour day: " + tourday + Environment.NewLine
            //            + "Number of person: " + personnum + Environment.NewLine
            //            + "Cruise price: "
            //            );
            //        table.Rows[1].Cells[0].Width = 300;
            //        table.Rows[1].Cells[1].Paragraphs.First().Append(""
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + "$" + refprice
            //            );
            //        table.Rows[1].Cells[1].Paragraphs.First().Alignment = Alignment.right;
            //        //double hotelTotal = Double.Parse(hoteltotalprice);
            //        table.Rows[1].Cells[1].Width = 300;
            //        table.Rows[2].Cells[0].Paragraphs.First().Append("Total fee");
            //        table.Rows[2].Cells[0].Paragraphs.First().Alignment = Alignment.right;
            //        table.Rows[2].Cells[0].Width = 300;
            //        table.Rows[2].Cells[1].Paragraphs.First().Append("$" + personprice);
            //        table.Rows[2].Cells[1].Paragraphs.First().Alignment = Alignment.right;
            //        table.Rows[2].Cells[1].Width = 300;
            //        table.Alignment = Alignment.center;
            //        // Insert table at index where tag #TABLE# is in document.
            //        doc.InsertTable(table);

            //        doc.Save();
            //        Process.Start("WINWORD.EXE", save.FileName);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("This customer has not hotel booking");
            //}
            //frmModuleSelection menu = new frmModuleSelection();
            //menu.Show();
            //this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string custid = "";

            //using (OleDbConnection con = new OleDbConnection(custconnStr))
            //{
            //    string Sql = "select cust.surname,cust.givenname,attract.custid,attract.orderdate,staff.center,staff.staffname "
            //        + "from attractionbooking attract,customer cust,staff "
            //        + "where cust.custid=attract.custid and staff.staffid=attract.orderby order by attract.orderdate asc";
            //    OleDbCommand cmd = new OleDbCommand(Sql, con);
            //    con.Open();
            //    OleDbDataReader DR = cmd.ExecuteReader();
            //    while (DR.Read())
            //    {
            //        if ((DR[0] + " " + DR[1]).Equals(custname))
            //        {
            //            custid = DR[2].ToString();
            //        }
            //    }
            //    con.Close();
            //}
            frmAttractionConfirm attractionConfirm = new frmAttractionConfirm(custid, custname);
            attractionConfirm.Show();

            //string stmt = "SELECT COUNT(*) FROM cruisebooking where custid='" + custid + "'";
            //int count = 0;

            //using (OleDbConnection thisConnection = new OleDbConnection(custconnStr))
            //{
            //    using (OleDbCommand cmdCount = new OleDbCommand(stmt, thisConnection))
            //    {
            //        thisConnection.Open();
            //        count = (int)cmdCount.ExecuteScalar();
            //        thisConnection.Close();
            //    }
            //}

            //if (count > 0)
            //{
            //    SaveFileDialog save = new SaveFileDialog();
            //    save.Filter = "Word document|*.docx";
            //    save.Title = "Save flight booking file";
            //    save.ShowDialog();
            //    if (save.FileName != "")
            //    {
            //        var doc = DocX.Create(save.FileName);
            //        string header = "Hong Kong Ticket Tailor Ltd";
            //        string info = ""
            //            + DateTime.Now.ToShortDateString() + Environment.NewLine + Environment.NewLine
            //            + "Customer Name: " + custname + Environment.NewLine
            //            + "Customer No: " + custid + Environment.NewLine
            //            + "Order Date: " + orderdate + Environment.NewLine
            //            + "Center: " + center + Environment.NewLine
            //            + "Staff Name: " + orderby + Environment.NewLine
            //            ;
            //        var titleformat = new Formatting();
            //        titleformat.Position = 12;
            //        titleformat.Size = 18D;
            //        titleformat.FontFamily = new System.Drawing.FontFamily("Arial Black");

            //        var infoformat = new Formatting();
            //        infoformat.FontFamily = new System.Drawing.FontFamily("Constantia");
            //        infoformat.Size = 12D;

            //        Novacode.Image img = doc.AddImage(@"tt logo\tt_attraction.jpg");
            //        Picture pic1 = img.CreatePicture();
            //        Paragraph pic = doc.InsertParagraph("", false, titleformat);
            //        pic.InsertPicture(pic1, 0);
            //        pic1.Width = 600;
            //        doc.InsertParagraph(Environment.NewLine);

            //        Paragraph title = doc.InsertParagraph(header, false, titleformat);
            //        title.Alignment = Alignment.center;
            //        title.Bold();
            //        title.UnderlineStyle(UnderlineStyle.singleLine);
            //        doc.InsertParagraph(Environment.NewLine);

            //        doc.InsertParagraph(info, false, infoformat);

            //        var table = doc.AddTable(3, 2);

            //        // Specify some properties for this Table.

            //        table.Design = TableDesign.MediumGrid1Accent2;
            //        string attractname = "", adultnum = "", childnum = "", adultprice = "", childprice = "";
            //        using (OleDbConnection con = new OleDbConnection(custconnStr))
            //        {
            //            string Sql = "select cust.surname,cust.givenname,attractname,adultnum,childnum,adultprice,childprice "
            //                + "from attractionbooking,customer cust "
            //                + "where cust.custid=attractionbooking.custid";
            //            OleDbCommand cmd = new OleDbCommand(Sql, con);
            //            con.Open();
            //            OleDbDataReader DR = cmd.ExecuteReader();
            //            while (DR.Read())
            //            {
            //                if ((DR[0] + " " + DR[1]).Equals(custname))
            //                {
            //                    attractname = DR[2].ToString();
            //                    adultnum = DR[3].ToString();
            //                    childnum = DR[4].ToString();
            //                    adultprice = DR[5].ToString();
            //                    childprice = DR[6].ToString();
            //                }
            //            }
            //            con.Close();
            //        }
            //        string attract_name="",duration = "", cancellation = "", city = "";
            //        using (OleDbConnection con = new OleDbConnection(attractconnStr))
            //        {
            //            string Sql = "select attractname,duration,cancellation,city "
            //                + "from attraction";
            //            OleDbCommand cmd = new OleDbCommand(Sql, con);
            //            con.Open();
            //            OleDbDataReader DR = cmd.ExecuteReader();
            //            while (DR.Read())
            //            {
            //                if (DR[0].Equals(attractname))
            //                {
            //                    attract_name = DR[0].ToString();
            //                    duration = DR[1].ToString();
            //                    cancellation = DR[2].ToString();
            //                    city = DR[3].ToString();
            //                }
            //            }
            //            con.Close();
            //        }

            //        doc.InsertParagraph("Attraction name: " + attract_name);
            //        doc.InsertParagraph("Attraction city: " + city);
            //        // Add content to this Table.
            //        table.Rows[0].Cells[0].Paragraphs.First().Append("Attraction Booking Confirmation");
            //        table.Rows[0].Cells[0].Paragraphs.First().Alignment = Alignment.center;
            //        table.Rows[0].Cells[0].Width = 300;
            //        table.Rows[0].Cells[1].Paragraphs.First().Append("Price");
            //        table.Rows[0].Cells[1].Paragraphs.First().Alignment = Alignment.center;
            //        table.Rows[0].Cells[1].Width = 300;
            //        table.Rows[1].Cells[0].Paragraphs.First().Append(""
            //            + "Attraction duration: " + duration + Environment.NewLine
            //            + "Attraction cancellation: " + cancellation + Environment.NewLine
            //            + "Number of adult: " + adultnum + Environment.NewLine
            //            + "Number of child: " + childnum + Environment.NewLine
            //            + "Adult price: " + Environment.NewLine
            //            + "Child price: "
            //            );
            //        table.Rows[1].Cells[0].Width = 300;
            //        table.Rows[1].Cells[1].Paragraphs.First().Append(""
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + Environment.NewLine
            //            + "$" + adultprice + Environment.NewLine
            //            + "$" + childprice
            //            );
            //        table.Rows[1].Cells[1].Paragraphs.First().Alignment = Alignment.right;
            //        int attractTotal = Int32.Parse(adultprice)+ Int32.Parse(childprice);
            //        table.Rows[1].Cells[1].Width = 300;
            //        table.Rows[2].Cells[0].Paragraphs.First().Append("Total fee");
            //        table.Rows[2].Cells[0].Paragraphs.First().Alignment = Alignment.right;
            //        table.Rows[2].Cells[0].Width = 300;
            //        table.Rows[2].Cells[1].Paragraphs.First().Append("$" + attractTotal);
            //        table.Rows[2].Cells[1].Paragraphs.First().Alignment = Alignment.right;
            //        table.Rows[2].Cells[1].Width = 300;
            //        table.Alignment = Alignment.center;
            //        // Insert table at index where tag #TABLE# is in document.
            //        doc.InsertTable(table);

            //        doc.Save();
            //        Process.Start("WINWORD.EXE", save.FileName);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("This customer has not attraction booking");
            //}
            //frmModuleSelection menu = new frmModuleSelection();
            //menu.Show();
            //this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string custid = "";

            //using (OleDbConnection con = new OleDbConnection(custconnStr))
            //{
            //    string Sql = "select cust.surname,cust.givenname,vehicle.custid,vehicle.orderdate,staff.center,staff.staffname "
            //        + "from vehiclebooking vehicle,customer cust,staff "
            //        + "where cust.custid=vehicle.custid and staff.staffid=vehicle.orderby order by vehicle.orderdate asc";
            //    OleDbCommand cmd = new OleDbCommand(Sql, con);
            //    con.Open();
            //    OleDbDataReader DR = cmd.ExecuteReader();
            //    while (DR.Read())
            //    {
            //        if ((DR[0] + " " + DR[1]).Equals(custname))
            //        {
            //            custid = DR[2].ToString();
            //        }
            //    }
            //    con.Close();
            //}
            frmVehicleConfirm vehicleConfirm = new frmVehicleConfirm(custid, custname);
            vehicleConfirm.Show();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            excelApp.Workbooks.Add();
            Excel._Worksheet workSheet = excelApp.ActiveSheet;

            Excel.Range Range_title = workSheet.get_Range("A1");
            Excel.Range Range_cust = workSheet.get_Range("A1:D1");
            Excel.Range Range_col = workSheet.get_Range("A2:G2");
            Range_cust.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
            Range_title.Font.Bold = true;
            Range_col.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            workSheet.Cells[1, "A"] = "Hong Kong Ticket Tailor Ltd";
            workSheet.Cells[1, "B"] = "Customer Cruise Booking Details";
            workSheet.Cells[1, "C"] = "Customer name: ";
            workSheet.Cells[1, "D"] = custname;

            workSheet.Cells[2, "A"] = "CustomerID";
            workSheet.Cells[2, "B"] = "Cruise Booking ID";
            workSheet.Cells[2, "C"] = "Cruise No";
            workSheet.Cells[2, "D"] = "Number of person";
            workSheet.Cells[2, "E"] = "Total price";
            workSheet.Cells[2, "F"] = "Order Date";
            workSheet.Cells[2, "G"] = "Order By";

            string stmt = "SELECT * FROM cruisebooking where custid='" + custid + "'";

            OleDbConnection conn = new OleDbConnection(custconnStr);
            OleDbCommand cmd = new OleDbCommand(stmt, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Excel.Range Range_details = workSheet.get_Range("A" + (i + 3) + ":G" + (i + 3));
                Range_details.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                workSheet.Cells[(i + 3), "A"] = custid;
                workSheet.Cells[(i + 3), "B"] = dt.Rows[i]["CruiseBookID"].ToString();
                workSheet.Cells[(i + 3), "C"] = dt.Rows[i]["CruiseNo"].ToString();
                workSheet.Cells[(i + 3), "D"] = dt.Rows[i]["PersonNum"].ToString();
                workSheet.Cells[(i + 3), "E"] = dt.Rows[i]["PersonPrice"].ToString();
                workSheet.Cells[(i + 3), "F"] = ((DateTime)dt.Rows[i]["OrderDate"]).ToString("yyyy-MM-dd");
                workSheet.Cells[(i + 3), "G"] = dt.Rows[i]["OrderBy"].ToString();
            }
            workSheet.Columns.AutoFit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            excelApp.Workbooks.Add();
            Excel._Worksheet workSheet = excelApp.ActiveSheet;

            Excel.Range Range_title = workSheet.get_Range("A1");
            Excel.Range Range_cust = workSheet.get_Range("A1:D1");
            Excel.Range Range_col = workSheet.get_Range("A2:J2");
            Range_cust.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
            Range_title.Font.Bold = true;
            Range_col.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            workSheet.Cells[1, "A"] = "Hong Kong Ticket Tailor Ltd";
            workSheet.Cells[1, "B"] = "Customer Attraction Booking Details";
            workSheet.Cells[1, "C"] = "Customer name: ";
            workSheet.Cells[1, "D"] = custname;

            workSheet.Cells[2, "A"] = "CustomerID";
            workSheet.Cells[2, "B"] = "Attraction Booking ID";
            workSheet.Cells[2, "C"] = "Attraction Name";
            workSheet.Cells[2, "D"] = "Attraction Date";
            workSheet.Cells[2, "E"] = "Number of adult";
            workSheet.Cells[2, "F"] = "Number of child";
            workSheet.Cells[2, "G"] = "Adult price";
            workSheet.Cells[2, "H"] = "Child price";
            workSheet.Cells[2, "I"] = "Order Date";
            workSheet.Cells[2, "J"] = "Order By";

            string stmt = "SELECT * FROM attractionbooking where custid='" + custid + "'";

            OleDbConnection conn = new OleDbConnection(custconnStr);
            OleDbCommand cmd = new OleDbCommand(stmt, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Excel.Range Range_details = workSheet.get_Range("A" + (i + 3) + ":J" + (i + 3));
                Range_details.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                workSheet.Cells[(i + 3), "A"] = custid;
                workSheet.Cells[(i + 3), "B"] = dt.Rows[i]["AttractBookID"].ToString();
                workSheet.Cells[(i + 3), "C"] = dt.Rows[i]["AttractName"].ToString();
                workSheet.Cells[(i + 3), "D"] = ((DateTime)dt.Rows[i]["AttractDate"]).ToString("yyyy-MM-dd");
                workSheet.Cells[(i + 3), "E"] = dt.Rows[i]["AdultNum"].ToString();
                workSheet.Cells[(i + 3), "F"] = dt.Rows[i]["ChildNum"].ToString();
                workSheet.Cells[(i + 3), "G"] = dt.Rows[i]["AdultPrice"].ToString();
                workSheet.Cells[(i + 3), "H"] = dt.Rows[i]["ChildPrice"].ToString();
                workSheet.Cells[(i + 3), "I"] = ((DateTime)dt.Rows[i]["OrderDate"]).ToString("yyyy-MM-dd");
                workSheet.Cells[(i + 3), "J"] = dt.Rows[i]["OrderBy"].ToString();
            }
            workSheet.Columns.AutoFit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            excelApp.Workbooks.Add();
            Excel._Worksheet workSheet = excelApp.ActiveSheet;

            Excel.Range Range_title = workSheet.get_Range("A1");
            Excel.Range Range_cust = workSheet.get_Range("A1:D1");
            Excel.Range Range_col = workSheet.get_Range("A2:M2");
            Range_cust.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
            Range_title.Font.Bold = true;
            Range_col.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            workSheet.Cells[1, "A"] = "Hong Kong Ticket Tailor Ltd";
            workSheet.Cells[1, "B"] = "Customer Vehicle Booking Details";
            workSheet.Cells[1, "C"] = "Customer name: ";
            workSheet.Cells[1, "D"] = custname;

            workSheet.Cells[2, "A"] = "CustomerID";
            workSheet.Cells[2, "B"] = "Vehicle Booking ID";
            workSheet.Cells[2, "C"] = "Attraction Booking ID";
            workSheet.Cells[2, "D"] = "Vehicle ID";
            workSheet.Cells[2, "E"] = "Equipment ID";
            workSheet.Cells[2, "F"] = "Pickup date";
            workSheet.Cells[2, "G"] = "Dropoff date";
            workSheet.Cells[2, "H"] = "Vehicle book day";
            workSheet.Cells[2, "I"] = "Vehicle book price";
            workSheet.Cells[2, "J"] = "Number of equipment";
            workSheet.Cells[2, "K"] = "Equipment book price";
            workSheet.Cells[2, "L"] = "Order Date";
            workSheet.Cells[2, "M"] = "Order By";

            string stmt = "SELECT * FROM vehicleBooking where custid='" + custid + "'";

            OleDbConnection conn = new OleDbConnection(custconnStr);
            OleDbCommand cmd = new OleDbCommand(stmt, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Excel.Range Range_details = workSheet.get_Range("A" + (i + 3) + ":M" + (i + 3));
                Range_details.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                workSheet.Cells[(i + 3), "A"] = custid;
                workSheet.Cells[(i + 3), "B"] = dt.Rows[i]["VehicleBookID"].ToString();
                workSheet.Cells[(i + 3), "C"] = dt.Rows[i]["AttractionBookID"].ToString();
                workSheet.Cells[(i + 3), "D"] = dt.Rows[i]["VehicleID"].ToString();
                workSheet.Cells[(i + 3), "E"] = dt.Rows[i]["EquipID"].ToString();
                workSheet.Cells[(i + 3), "F"] = ((DateTime)dt.Rows[i]["PickupDate"]).ToString("yyyy-MM-dd");
                workSheet.Cells[(i + 3), "G"] = ((DateTime)dt.Rows[i]["DropoffDate"]).ToString("yyyy-MM-dd");
                workSheet.Cells[(i + 3), "H"] = dt.Rows[i]["BookDay"].ToString();
                workSheet.Cells[(i + 3), "I"] = dt.Rows[i]["VehicleBookPrice"].ToString();
                workSheet.Cells[(i + 3), "J"] = dt.Rows[i]["EquipNum"].ToString();
                workSheet.Cells[(i + 3), "K"] = dt.Rows[i]["EquipBookPrice"].ToString();
                workSheet.Cells[(i + 3), "L"] = ((DateTime)dt.Rows[i]["OrderDate"]).ToString("yyyy-MM-dd");
                workSheet.Cells[(i + 3), "M"] = dt.Rows[i]["OrderBy"].ToString();
            }
            workSheet.Columns.AutoFit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            excelApp.Workbooks.Add();
            Excel._Worksheet workSheet = excelApp.ActiveSheet;

            Excel.Range Range_title = workSheet.get_Range("A1:B1");
            Excel.Range Range_col = workSheet.get_Range("A2:H2");
            Range_title.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
            Range_title.Font.Bold = true;
            Range_col.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            workSheet.Cells[1, "A"] = "Hong Kong Ticket Tailor Ltd";
            workSheet.Cells[1, "B"] = "All center staff Report";

            workSheet.Cells[2, "A"] = "Staff Name";
            workSheet.Cells[2, "B"] = "Center";
            workSheet.Cells[2, "C"] = "Position";
            workSheet.Cells[2, "D"] = "Salary";
            workSheet.Cells[2, "E"] = "Staff Type";
            workSheet.Cells[2, "F"] = "Number of late day";
            workSheet.Cells[2, "G"] = "Top five sales";
            workSheet.Cells[2, "H"] = "Top five sales name";

            string stmt = "SELECT * FROM staff";

            OleDbConnection conn = new OleDbConnection(custconnStr);
            OleDbCommand cmd = new OleDbCommand(stmt, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int i, cellHeight = 10;

            for (i = 0; i < dt.Rows.Count; i++)
            {
                Excel.Range Range_details = workSheet.get_Range("A" + (i + 3) + ":F" + (i + 3));
                Range_details.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                workSheet.Cells[(i + 3), "A"] = dt.Rows[i]["StaffName"].ToString();
                workSheet.Cells[(i + 3), "B"] = dt.Rows[i]["Center"].ToString();
                workSheet.Cells[(i + 3), "C"] = dt.Rows[i]["Position"].ToString();
                workSheet.Cells[(i + 3), "D"] = dt.Rows[i]["Salary"].ToString();
                workSheet.Cells[(i + 3), "E"] = dt.Rows[i]["Ctype"].ToString();
                workSheet.Cells[(i + 3), "F"] = dt.Rows[i]["Late"].ToString();
                cellHeight += 10;
            }
            workSheet.Columns.AutoFit();
            object misValue = System.Reflection.Missing.Value;
            Excel.Range chartRange;
            Excel.ChartObjects xlCharts = (Excel.ChartObjects)workSheet.ChartObjects(Type.Missing);
            Excel.ChartObject staffChart = (Excel.ChartObject)xlCharts.Add(900, 10, 700, 250);
            Excel.Chart chartPage = staffChart.Chart;

            chartRange = workSheet.get_Range("A" + (0 + 2) + ":A" + (i + 2), "D" + (0 + 2) + ":D" + (i + 2));
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

            Excel.Range latechartRange;
            Excel.ChartObjects xlChartslate = (Excel.ChartObjects)workSheet.ChartObjects(Type.Missing);
            Excel.ChartObject lateChart = (Excel.ChartObject)xlChartslate.Add(900, 300, 700, 250);
            Excel.Chart chartPagelate = lateChart.Chart;

            latechartRange = workSheet.get_Range("A" + (0 + 2) + ":A" + (i + 2), "F" + (0 + 2) + ":F" + (i + 2));
            chartPagelate.SetSourceData(latechartRange, misValue);
            chartPagelate.ChartType = Excel.XlChartType.xlColumnClustered;

            int range = dt.Rows.Count;
            workSheet.Cells[3, "G"] = "=LARGE($D$3:$D$" + range + ",1)";
            workSheet.Cells[4, "G"] = "=LARGE($D$3:$D$" + range + ",2)";
            workSheet.Cells[5, "G"] = "=LARGE($D$3:$D$" + range + ",3)";
            workSheet.Cells[6, "G"] = "=LARGE($D$3:$D$" + range + ",4)";
            workSheet.Cells[7, "G"] = "=LARGE($D$3:$D$" + range + ",5)";

            workSheet.Cells[3, "H"] = "=INDEX($A$3:$A$" + range + ",MATCH(G3,$D$3:$D$" + range + ",0))";
            workSheet.Cells[4, "H"] = "=INDEX($A$3:$A$" + range + ",MATCH(G4,$D$3:$D$" + range + ",0))";
            workSheet.Cells[5, "H"] = "=INDEX($A$3:$A$" + range + ",MATCH(G5,$D$3:$D$" + range + ",0))";
            workSheet.Cells[6, "H"] = "=INDEX($A$3:$A$" + range + ",MATCH(G6,$D$3:$D$" + range + ",0))";
            workSheet.Cells[7, "H"] = "=INDEX($A$3:$A$" + range + ",MATCH(G7,$D$3:$D$" + range + ",0))";

            Excel.Range Range_top = workSheet.get_Range("G3:G7");
            Range_top.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Aqua);
            Excel.Range Range_name = workSheet.get_Range("H3:H7");
            Range_name.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Aqua);

            Excel.Range topchartRange;
            Excel.ChartObjects xlChartstop = (Excel.ChartObjects)workSheet.ChartObjects(Type.Missing);
            Excel.ChartObject topChart = (Excel.ChartObject)xlChartstop.Add(900, 600, 700, 250);
            Excel.Chart chartPagetop = topChart.Chart;

            topchartRange = workSheet.get_Range("G" + (0 + 2) + ":G" + (5 + 2));
            chartPagetop.SetSourceData(topchartRange, misValue);
            chartPagetop.SeriesCollection(1).XValues = workSheet.get_Range("H" + (0 + 3) + ":H" + (5 + 2));
            chartPagetop.ChartType = Excel.XlChartType.xlPie;
        }

        private void customerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            custname = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            using (OleDbConnection con = new OleDbConnection(custconnStr))
            {
                string Sql = "select surname,givenname,custid "
                    + "from customer";
                OleDbCommand cmd = new OleDbCommand(Sql, con);
                con.Open();
                OleDbDataReader DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    if ((DR[0] + " " + DR[1]).Equals(custname))
                    {
                        custid = DR[2].ToString();
                    }
                }
                con.Close();
            }
            label13.Visible = true;
            label13.Text = "Customer id : " +custid;
            if (frmLogin.customerLogin)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
            }
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

        private void attractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAttraction attraction = new frmAttraction();
            attraction.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            excelApp.Workbooks.Add();
            Excel._Worksheet workSheet = excelApp.ActiveSheet;

            Excel.Range Range_title = workSheet.get_Range("A1");
            Excel.Range Range_cust = workSheet.get_Range("A1:D1");
            Excel.Range Range_col = workSheet.get_Range("A2:K2");
            Range_cust.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
            Range_title.Font.Bold = true;
            Range_col.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            workSheet.Cells[1, "A"] = "Hong Kong Ticket Tailor Ltd";
            workSheet.Cells[1, "B"] = "Customer Hotel Booking Details";
            workSheet.Cells[1, "C"] = "Customer name: ";
            workSheet.Cells[1, "D"] = custname;

            workSheet.Cells[2, "A"] = "CustomerID";
            workSheet.Cells[2, "B"] = "Hotel Booking ID";
            workSheet.Cells[2, "C"] = "Hotel Room ID";
            workSheet.Cells[2, "D"] = "Hotel Room Name";
            workSheet.Cells[2, "E"] = "Number of night";
            workSheet.Cells[2, "F"] = "Number of room";
            workSheet.Cells[2, "G"] = "Total price";
            workSheet.Cells[2, "H"] = "Checkin date";
            workSheet.Cells[2, "I"] = "Checkout date";
            workSheet.Cells[2, "J"] = "Order Date";
            workSheet.Cells[2, "K"] = "Order By";

            string stmt = "SELECT * FROM hotelbooking where custid='" + custid + "'";

            OleDbConnection conn = new OleDbConnection(custconnStr);
            OleDbCommand cmd = new OleDbCommand(stmt, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Excel.Range Range_details = workSheet.get_Range("A" + (i + 3) + ":K" + (i + 3));
                Range_details.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                workSheet.Cells[(i + 3), "A"] = custid;
                workSheet.Cells[(i + 3), "B"] = dt.Rows[i]["HotelBookID"].ToString();
                workSheet.Cells[(i + 3), "C"] = dt.Rows[i]["HotelRoomID"].ToString();
                workSheet.Cells[(i + 3), "D"] = dt.Rows[i]["HotelRoomName"].ToString();
                workSheet.Cells[(i + 3), "E"] = dt.Rows[i]["NumNight"].ToString();
                workSheet.Cells[(i + 3), "F"] = dt.Rows[i]["NumRoom"].ToString();
                workSheet.Cells[(i + 3), "G"] = dt.Rows[i]["Price"].ToString();
                workSheet.Cells[(i + 3), "H"] = ((DateTime)dt.Rows[i]["Checkin"]).ToString("yyyy-MM-dd");
                workSheet.Cells[(i + 3), "I"] = ((DateTime)dt.Rows[i]["Checkout"]).ToString("yyyy-MM-dd");
                workSheet.Cells[(i + 3), "J"] = ((DateTime)dt.Rows[i]["OrderDate"]).ToString("yyyy-MM-dd");
                workSheet.Cells[(i + 3), "K"] = dt.Rows[i]["OrderBy"].ToString();
            }
            workSheet.Columns.AutoFit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label9.Text = "Time : " + DateTime.Now.ToString();
        }
    }
}
