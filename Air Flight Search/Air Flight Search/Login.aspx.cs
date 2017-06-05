using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Configuration;

namespace Air_Flight_Search
{
   
    public partial class Login : System.Web.UI.Page
    {
                
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = false;
            string mydocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string custconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + mydocument + "/Visual Studio 2015/Projects/Air flight/Air flight/bin/x86/Debug/CustomerBooking.accdb";
            OleDbConnection conn = new OleDbConnection(custconnStr);
            conn.Open();
            string checkuser = "select count(*) from customer where custid='" + TextBox1.Text + "'";
            OleDbCommand cmd = new OleDbCommand(checkuser, conn);
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            string checkstaff = "select count(*) from staff where staffid='" + TextBox1.Text + "'";
            OleDbCommand cmd_staff = new OleDbCommand(checkstaff, conn);
            int temp_staff = Convert.ToInt32(cmd_staff.ExecuteScalar().ToString());
            conn.Close();
            if(temp==1 || temp_staff==1)
            {
                conn.Open();
                if (temp == 1) { 
                string checkpassword = "select contact from customer where custid='" + TextBox1.Text + "'";
                OleDbCommand passCmd = new OleDbCommand(checkpassword, conn);
                string password = passCmd.ExecuteScalar().ToString().Replace(" ","");
                    if (password == TextBox2.Text)
                    {
                        string sqlName = "select surname,givenname from customer where custid='" + TextBox1.Text + "' and contact=" + Int32.Parse(TextBox2.Text);
                        OleDbCommand nameCmd = new OleDbCommand(sqlName, conn);
                        OleDbDataReader dr = nameCmd.ExecuteReader();
                        string surname = "", givenname = "";
                        while (dr.Read())
                        {
                            surname = dr[0].ToString();
                            givenname = dr[1].ToString();
                        }
                        Session["username"] = surname + " " + givenname;
                        Session["uid"] = TextBox1.Text;
                        Session["user"] = "customer";
                        //Response.Write("Password is correct");
                        Response.Redirect("customer.aspx");
                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "Password is not correct";
                    }
                }
                else if (temp_staff == 1)
                {
                    string checkpassword = "select pass from staff where staffid='" + TextBox1.Text + "'";
                    OleDbCommand passCmd = new OleDbCommand(checkpassword, conn);
                    string password = passCmd.ExecuteScalar().ToString().Replace(" ", "");
                    if (password == TextBox2.Text)
                    {
                        string sqlName = "select staffname,[position] from staff where staffid='" + TextBox1.Text + "' and pass='" + TextBox2.Text+"'";
                        OleDbCommand nameCmd = new OleDbCommand(sqlName, conn);
                        OleDbDataReader dr = nameCmd.ExecuteReader();
                        string name="",position="";
                        while (dr.Read())
                        {
                            name = dr[0].ToString();
                            position = dr[1].ToString();
                        }
                        Session["username"] = name;
                        Session["position"] = position;
                        Session["uid"] = TextBox1.Text;
                        Session["user"] = "staff";
                        //Response.Write("Password is correct");
                        Response.Redirect("staff.aspx");
                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "Password is not correct";
                    }
                }
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Username is not correct";
            }
        }
    }
}