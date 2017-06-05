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
    public partial class AirFlight : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGridData();
            }
        }

        private void LoadGridData()
        {
            string mydocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string flightStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + mydocument + "/Visual Studio 2015/Projects/Air flight/Air flight/bin/x86/Debug/ticketTailor_db.accdb";
            string sql = "select flightschedule.FlightNo,Class,Format(edd,'Short Date') as Departure_date,Format(eda,'Short Date') as Arrival_date,Format(etd,'Long Time') as Departure_time,Format(eta,'Long Time') as Arrival_time,"
                + "Origin,dest as Destination,Traveltime,Price_adult,Price_children,Price_infant from flightschedule,flightclass where flightschedule.flightid=flightclass.flightid";
            OleDbConnection conn = new OleDbConnection(flightStr);
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
            if (TextBox1.Text != "" || TextBox2.Text != "" || TextBox3.Text != "" || TextBox4.Text != "" || TextBox5.Text != "" || TextBox6.Text != "" || TextBox7.Text != ""
                || (RadioButton1.Checked || RadioButton2.Checked) || (RadioButton3.Checked || RadioButton4.Checked))
            {
                LoadAirData();
            }
            else
            {
                LoadGridData();
            }
        }
        private void LoadAirData()
        {
            string mydocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string flightStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + mydocument + "/Visual Studio 2015/Projects/Air flight/Air flight/bin/x86/Debug/ticketTailor_db.accdb";
            string sql = "select flightschedule.FlightNo,Class,Format(edd,'Short Date') as Departure_date,Format(eda,'Short Date') as Arrival_date,Format(etd,'Long Time') as Departure_time,Format(eta,'Long Time') as Arrival_time,"
                + "Origin,dest as Destination,Traveltime,Price_adult,Price_children,Price_infant from flightschedule,flightclass where flightschedule.flightid=flightclass.flightid and flightschedule.flightno like '%" + TextBox1.Text + "%'";
            if (RadioButton1.Checked)
            {
                sql += " and flightclass.class='Business'";
            }
            else if (RadioButton2.Checked)
            {
                sql += " and flightclass.class='Econ'";
            }
            if (RadioButton3.Checked)
            {
                sql += " and flightschedule.flighttype='Direct'";
            }
            else if (RadioButton4.Checked)
            {
                sql += " and flightschedule.flighttype='Indirect'";
            }
            if (TextBox2.Text != "" && TextBox3.Text != "")
            {
                sql += " and flightclass.price_adult between " + TextBox2.Text + " and " + TextBox3.Text;
            }
            if (TextBox4.Text != "" && TextBox5.Text != "")
            {
                sql += " and flightclass.price_children between " + TextBox4.Text + " and " + TextBox5.Text;
            }
            if (TextBox6.Text != "" && TextBox7.Text != "")
            {
                sql += " and flightclass.price_infant between " + TextBox6.Text + " and " + TextBox7.Text;
            }
            OleDbConnection conn = new OleDbConnection(flightStr);
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
        protected void Button1_Click(object sender, EventArgs e)
        {
            LoadAirData();
        }

        protected void Home_Click(object sender, EventArgs e)
        {
            if(Session["user"].Equals("customer"))
                Response.Redirect("customer.aspx");
            else
                Response.Redirect("staff.aspx");
        }
    }
}