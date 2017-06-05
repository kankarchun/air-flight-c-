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
    public partial class Cruise : System.Web.UI.Page
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
            string cruiseStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + mydocument + "/Visual Studio 2015/Projects/Air flight/Air flight/bin/x86/Debug/Cruise.accdb";
            string sql = "select organiserc as Organiser_name,CruiseNo,CruiseName,Refprice as Reference_Price,TourDay,Format(StartDate, 'Short Date') as StartDate from corganiser,cruise where cruise.organid=corganiser.organid";
            OleDbConnection conn = new OleDbConnection(cruiseStr);
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
            if (TextBox1.Text != "" || TextBox10.Text != "" || TextBox11.Text != "")
            {
                LoadCruiseData();
            }
            else
            {
                LoadGridData();
            }
        }
        private void LoadCruiseData()
        {
            string mydocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string cruiseStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + mydocument + "/Visual Studio 2015/Projects/Air flight/Air flight/bin/x86/Debug/Cruise.accdb";
            string sql = "select organiserc as Organiser_name,CruiseNo,CruiseName,Refprice as Reference_Price,TourDay,Format(StartDate, 'Short Date') as StartDate from corganiser,cruise where cruise.organid=corganiser.organid and organiserc like '%" + TextBox1.Text + "%'";
            if (TextBox10.Text != "" && TextBox11.Text != "")
            {
                sql += " and Refprice between " + TextBox10.Text + " and " + TextBox11.Text;
            }
            OleDbConnection conn = new OleDbConnection(cruiseStr);
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
            LoadCruiseData();
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