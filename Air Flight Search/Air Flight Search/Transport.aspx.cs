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
    public partial class Transport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string mydocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string hotelStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + mydocument + "/Visual Studio 2015/Projects/Air flight/Air flight/bin/x86/Debug/Vehicle.accdb";
                string sql = "select Vehicle_name,Price,Vehicle_type,Capacity,Gear,Color from vehicle";
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

                string sql_room = "select Equipment,Suitable,Price from equipment";
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
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mydocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string hotelStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + mydocument + "/Visual Studio 2015/Projects/Air flight/Air flight/bin/x86/Debug/Vehicle.accdb";
            string sql = "select Vehicle_name,Price,Vehicle_type,Capacity,Gear,Color from vehicle where vehicle_type='"+DropDownList1.SelectedValue+"'";
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

            string sql_room = "select Equipment,Suitable,Price from equipment where suitable='"+DropDownList1.SelectedValue+"'";
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
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