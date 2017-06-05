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
    public partial class Attraction : System.Web.UI.Page
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
            string attractStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + mydocument + "/Visual Studio 2015/Projects/Air flight/Air flight/bin/x86/Debug/Attraction.accdb";
            string sql = "select attraction.attractname as Attraction_name,Duration,Cancellation,City,Visitor,Price from attraction,attractprice where attraction.attractname=attractprice.attractname";
            OleDbConnection conn = new OleDbConnection(attractStr);
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
        private void LoadAttractData()
        {
            string mydocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string attractStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + mydocument + "/Visual Studio 2015/Projects/Air flight/Air flight/bin/x86/Debug/Attraction.accdb";
            string sql = "select attraction.attractname as Attraction_name,Duration,Cancellation,City,Visitor,Price from attraction,attractprice where attraction.attractname=attractprice.attractname and city like '%" + TextBox1.Text + "%'";
            if (TextBox2.Text != "" && TextBox3.Text != "")
            {
                sql += " and price between " + TextBox2.Text + " and " + TextBox3.Text;
            }
            if (RadioButton1.Checked)
            {
                sql += " and Visitor ='Adult'";
            }
            else if (RadioButton2.Checked)
            {
                sql += " and Visitor ='Child'";
            }
            OleDbConnection conn = new OleDbConnection(attractStr);
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
            LoadAttractData();
        }

        protected void Home_Click(object sender, EventArgs e)
        {
            if (Session["user"].Equals("customer"))
                Response.Redirect("customer.aspx");
            else
                Response.Redirect("staff.aspx");
        }

        protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            if (TextBox1.Text != "" || TextBox2.Text != "" || TextBox3.Text != "" || (RadioButton1.Checked || RadioButton2.Checked))
            {
                LoadAttractData();
            }else{
                 LoadGridData();
            }
        }
    }
}