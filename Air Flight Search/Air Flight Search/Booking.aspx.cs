using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

namespace Air_Flight_Search
{
    public partial class Booking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string mydocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string custStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + mydocument + "/Visual Studio 2015/Projects/Air flight/Air flight/bin/x86/Debug/customerBooking.accdb";
                if (Session["user"].Equals("customer"))
                {
                    Label1.Text = "Customer Booking";
                    string sql = "select FlightNo,FlightClass,AdultNum,ChildNum,InfantNum,AdultPrice,ChildPrice,InfantPrice,Format(orderdate, 'Short Date') as OrderDate from flightbooking where custid='" + Session["uid"] + "' order by orderdate desc";
                    OleDbConnection conn = new OleDbConnection(custStr);
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = sql;
                    cmd.Connection = conn;
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    GridView1.DataSource = ds;
                    GridView1.DataBind();

                    string sql_hotel = "select HotelRoomName,NumNight,NumRoom,Price,Format(Checkin, 'Short Date') as Checkin,Format(Checkout, 'Short Date') as Checkout,Format(orderdate, 'Short Date') as OrderDate from hotelbooking where custid='" + Session["uid"] + "' order by orderdate desc";
                    OleDbCommand cmd_hotel = new OleDbCommand();
                    cmd_hotel.CommandText = sql_hotel;
                    cmd_hotel.Connection = conn;
                    OleDbDataAdapter da_hotel = new OleDbDataAdapter(cmd_hotel);
                    DataSet ds_hotel = new DataSet();
                    da_hotel.Fill(ds_hotel);
                    cmd_hotel.ExecuteNonQuery();
                    GridView2.DataSource = ds_hotel;
                    GridView2.DataBind();

                    string sql_cruise = "select CruiseNo,PersonNum,PersonPrice,Format(orderdate, 'Short Date') as OrderDate from cruisebooking where custid='" + Session["uid"] + "' order by orderdate desc";
                    OleDbCommand cmd_cruise = new OleDbCommand();
                    cmd_cruise.CommandText = sql_cruise;
                    cmd_cruise.Connection = conn;
                    OleDbDataAdapter da_cruise = new OleDbDataAdapter(cmd_cruise);
                    DataSet ds_cruise = new DataSet();
                    da_cruise.Fill(ds_cruise);
                    cmd_cruise.ExecuteNonQuery();
                    GridView3.DataSource = ds_cruise;
                    GridView3.DataBind();

                    string sql_attract = "select AttractName as AttractionName,AdultNum,ChildNum,AdultPrice,ChildPrice,Format(AttractDate, 'Short Date') as AttractionDate,VehicleStatus,Format(orderdate, 'Short Date') as OrderDate from attractionbooking where custid='" + Session["uid"] + "' order by orderdate desc";
                    OleDbCommand cmd_attract = new OleDbCommand();
                    cmd_attract.CommandText = sql_attract;
                    cmd_attract.Connection = conn;
                    OleDbDataAdapter da_attract = new OleDbDataAdapter(cmd_attract);
                    DataSet ds_attract = new DataSet();
                    da_attract.Fill(ds_attract);
                    cmd_attract.ExecuteNonQuery();
                    GridView4.DataSource = ds_attract;
                    GridView4.DataBind();

                    conn.Close();
                }
                else
                {
                    Label1.Text = "Client Booking";
                    string sql = "select Surname,Givenname,FlightNo,FlightClass,AdultNum,ChildNum,InfantNum,AdultPrice,ChildPrice,InfantPrice,Format(orderdate, 'Short Date') as OrderDate from flightbooking,customer where flightbooking.custid=customer.custid and orderby='" + Session["uid"].ToString() + "' order by orderdate desc";
                    OleDbConnection conn = new OleDbConnection(custStr);
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = sql;
                    cmd.Connection = conn;
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    GridView1.DataSource = ds;
                    GridView1.DataBind();

                    string sql_hotel = "select Surname,Givenname,HotelRoomName,NumNight,NumRoom,Price,Format(Checkin, 'Short Date') as Checkin,Format(Checkout, 'Short Date') as Checkout,Format(orderdate, 'Short Date') as OrderDate from hotelbooking,customer where hotelbooking.custid=customer.custid and orderby='" + Session["uid"] + "' order by orderdate desc";
                    OleDbCommand cmd_hotel = new OleDbCommand();
                    cmd_hotel.CommandText = sql_hotel;
                    cmd_hotel.Connection = conn;
                    OleDbDataAdapter da_hotel = new OleDbDataAdapter(cmd_hotel);
                    DataSet ds_hotel = new DataSet();
                    da_hotel.Fill(ds_hotel);
                    cmd_hotel.ExecuteNonQuery();
                    GridView2.DataSource = ds_hotel;
                    GridView2.DataBind();

                    string sql_cruise = "select Surname,Givenname,CruiseNo,PersonNum,PersonPrice,Format(orderdate, 'Short Date') as OrderDate from cruisebooking,customer where cruisebooking.custid=customer.custid and orderby='" + Session["uid"] + "' order by orderdate desc";
                    OleDbCommand cmd_cruise = new OleDbCommand();
                    cmd_cruise.CommandText = sql_cruise;
                    cmd_cruise.Connection = conn;
                    OleDbDataAdapter da_cruise = new OleDbDataAdapter(cmd_cruise);
                    DataSet ds_cruise = new DataSet();
                    da_cruise.Fill(ds_cruise);
                    cmd_cruise.ExecuteNonQuery();
                    GridView3.DataSource = ds_cruise;
                    GridView3.DataBind();

                    string sql_attract = "select Surname,Givenname,AttractName as AttractionName,AdultNum,ChildNum,AdultPrice,ChildPrice,Format(AttractDate, 'Short Date') as AttractionDate,VehicleStatus,Format(orderdate, 'Short Date') as OrderDate from attractionbooking,customer where attractionbooking.custid=customer.custid and orderby='" + Session["uid"] + "' order by orderdate desc";
                    OleDbCommand cmd_attract = new OleDbCommand();
                    cmd_attract.CommandText = sql_attract;
                    cmd_attract.Connection = conn;
                    OleDbDataAdapter da_attract = new OleDbDataAdapter(cmd_attract);
                    DataSet ds_attract = new DataSet();
                    da_attract.Fill(ds_attract);
                    cmd_attract.ExecuteNonQuery();
                    GridView4.DataSource = ds_attract;
                    GridView4.DataBind();

                    conn.Close();
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Home_Click(object sender, EventArgs e)
        {
            if (Session["user"].Equals("customer"))
                Response.Redirect("customer.aspx");
            else
                Response.Redirect("staff.aspx");
        }
    }
}