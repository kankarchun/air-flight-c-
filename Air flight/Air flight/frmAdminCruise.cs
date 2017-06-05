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

namespace Air_flight
{
    public partial class frmAdminCruise : Form
    {
        private int rowindex;
        private bool update;
        private string cruiseconnStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=cruise.accdb";
        private string organid;
        private DateTime? d1=null;

        public frmAdminCruise()
        {
            InitializeComponent();
        }

        public frmAdminCruise(int rowindex, bool update)
        {
            InitializeComponent();
            this.rowindex = rowindex;
            this.update = update;
        }

        private void frmAdminCruise_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'cruiseDataSet.COrganiser' 資料表。您可以視需要進行移動或移除。
            this.cOrganiserTableAdapter.Fill(this.cruiseDataSet.COrganiser);
            if (update)
            {

            }
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to add this record?", "Add record",
    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                using (OleDbConnection con = new OleDbConnection(cruiseconnStr))
                {
                    string Sql = "select cruiseno from cruise";
                    OleDbCommand cmd = new OleDbCommand(Sql, con);
                    con.Open();
                    OleDbDataReader DR = cmd.ExecuteReader();
                    while (DR.Read())
                    {
                        if (textBox2.Text.Equals(DR[0].ToString()))
                        {
                            MessageBox.Show("There is an existing cruise no in the database");
                            return;
                        }
                    }
                    con.Close();
                }
                if (textBox1.Text.Equals(""))
                {
                    MessageBox.Show("Please select one organiser in the data grid view");
                    return;
                }
                if (numericUpDown1.Value == 0m)
                {
                    MessageBox.Show("Reference Price cannot be $0");
                    return;
                }
                else if (numericUpDown2.Value == 0m)
                {
                    MessageBox.Show("Tour day cannot be 0");
                    return;
                }
                else if (d1 == null)
                {
                    MessageBox.Show("Please enter cruise start date");
                    return;
                }
                string startdateFormat;
                DateTime startDate;
                if (!string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    if (dateTimePicker1.Value < DateTime.Now)
                    {
                        MessageBox.Show("Cruise start date cannot smaller than today");
                        d1 = null;
                        dateTimePicker1.Value = DateTime.Now;
                        return;
                    }
                    else
                    {
                        startdateFormat = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                        startDate = DateTime.Parse(startdateFormat);
                    }

                    OleDbCommand cmd_cruise = new OleDbCommand();
                    OleDbConnection con = new OleDbConnection(cruiseconnStr);
                    cmd_cruise.CommandType = CommandType.Text;
                    cmd_cruise.CommandText = "INSERT INTO cruise(cruiseno,cruisename,refprice,tourday,organid,startdate) "
                        + "VALUES (@no,@name,@price,@day,@organid,@startdate)";
                    cmd_cruise.Parameters.AddWithValue("@no", textBox2.Text);
                    cmd_cruise.Parameters.AddWithValue("@name", textBox3.Text);
                    cmd_cruise.Parameters.AddWithValue("@price", Convert.ToDouble(numericUpDown1.Value));
                    cmd_cruise.Parameters.AddWithValue("@day", Convert.ToDouble(numericUpDown2.Value));
                    cmd_cruise.Parameters.AddWithValue("@organid", organid);
                    cmd_cruise.Parameters.AddWithValue("@startdate", startDate);

                    cmd_cruise.Connection = con;
                    con.Open();

                    cmd_cruise.ExecuteNonQuery();

                    MessageBox.Show("Cruise record added successfully.");
                    con.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("All field must be enter");
                    return;
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            d1 = dateTimePicker1.Value;
        }

        private void cOrganiserBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cOrganiserBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cruiseDataSet);

        }

        private void cOrganiserDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            organid = cOrganiserDataGridView.CurrentRow.Cells["OrganiserID"].Value.ToString();
            textBox1.Text = organid;
        }
    }
}
