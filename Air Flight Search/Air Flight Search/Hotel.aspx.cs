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
    public partial class Hotel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGridData();
                LoadGridData2();
            }
        }
        private void LoadGridData2()
        {
            string mydocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string hotelStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + mydocument + "/Visual Studio 2015/Projects/Air flight/Air flight/bin/x86/Debug/hotel.accdb";
            OleDbConnection conn_room = new OleDbConnection(hotelStr);
            string sql_room = "select hotel_chi_name as Hotel_Chinese_name,Hotel_room_name,Hotel_room_size,Max_adults,Max_child,Hotel_room_description,Fare from hotel_room";
            OleDbCommand cmd_room = new OleDbCommand();
            cmd_room.CommandText = sql_room;
            cmd_room.Connection = conn_room;
            OleDbDataAdapter da_room = new OleDbDataAdapter(cmd_room);
            DataSet ds_room = new DataSet();
            da_room.Fill(ds_room);
            conn_room.Open();
            cmd_room.ExecuteNonQuery();
            GridView2.DataSource = ds_room;
            GridView2.DataBind();
            conn_room.Close();
        }
        private void LoadGridData()
        {
            string mydocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string hotelStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + mydocument + "/Visual Studio 2015/Projects/Air flight/Air flight/bin/x86/Debug/hotel.accdb";
            string sql = "select hotel_chi_name as Hotel_Chinese_name,hotel_en_name as Hotel_English_name,Star,Rating,Region,Address from hotel";
            OleDbConnection conn = new OleDbConnection(hotelStr);
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

            conn.Close();
        }
        protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            
            LoadGridData();
        }

        protected void grdData2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;
            if (TextBox1.Text != "" || TextBox2.Text != "" || TextBox8.Text != "" || TextBox9.Text != "")
            {
                LoadHotelData();
            }
            else
            {
                LoadGridData2();
            }
        }
        private void LoadHotelData()
        {
            string mydocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string hotelStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + mydocument + "/Visual Studio 2015/Projects/Air flight/Air flight/bin/x86/Debug/hotel.accdb";
            string sql = "select hotel_chi_name as Hotel_Chinese_name,hotel_en_name as Hotel_English_name,Star,Rating,Region,Address from hotel where hotel_chi_name like'%" + TextBox1.Text + "%' and region like '%" + TextBox2.Text + "%'";
            OleDbConnection conn = new OleDbConnection(hotelStr);
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

            string sql_room = "select hotel.hotel_chi_name as Hotel_Chinese_name,Hotel_room_name,Hotel_room_size,Max_adults,Max_child,Hotel_room_description,Fare from hotel_room,hotel where hotel_room.hotel_chi_name like '%" + TextBox1.Text + "%' and hotel.hotelid=hotel_room.hotelid and hotel.region like '%" + TextBox2.Text + "%'";
            if (TextBox8.Text != "" && TextBox9.Text != "")
            {
                sql_room += " and hotel_room.fare between " + TextBox8.Text + " and " + TextBox9.Text;
            }
            OleDbCommand cmd_room = new OleDbCommand();
            cmd_room.CommandText = sql_room;
            cmd_room.Connection = conn;
            OleDbDataAdapter da_room = new OleDbDataAdapter(cmd_room);
            DataSet ds_room = new DataSet();
            da_room.Fill(ds_room);
            cmd_room.ExecuteNonQuery();
            GridView2.DataSource = ds_room;
            GridView2.DataBind();

            conn.Close();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            LoadHotelData();
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