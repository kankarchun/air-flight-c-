using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_flight
{
    public partial class frmIndirect : Form
    {
        public string number;

        public frmIndirect()
        {
            InitializeComponent();
        }

        private void indirectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.indirectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ticketDataSet);

        }

        private void frmIndirect_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'ticketDataSet.Indirect' 資料表。您可以視需要進行移動或移除。
            this.indirectTableAdapter.Fill(this.ticketDataSet.Indirect);
            label16.Text = "Flight No: " + number;
            indirectBindingSource.Filter = "flightno='" + number + "'";
            
            indirectDataGridView.Columns[5].DefaultCellStyle.Format = "HH:mm";
            indirectDataGridView.Columns[7].DefaultCellStyle.Format = "HH:mm";
            DateTime Arrivaldate_1 = (DateTime)indirectDataGridView.Rows[0].Cells["EDA"].Value;
            DateTime Arrivaltime_1 = (DateTime)indirectDataGridView.Rows[0].Cells["ETA"].Value;
            DateTime Departuredate_1 = (DateTime)indirectDataGridView.Rows[0].Cells["EDD"].Value;
            DateTime Departuretime_1 = (DateTime)indirectDataGridView.Rows[0].Cells["ETD"].Value;


            label3.Text = "Stop: " + indirectDataGridView.Rows[0].Cells["Stop"].Value.ToString();
            label7.Text = "Departure Date: " + Departuredate_1.ToString("dd/MM/yyyy");
            label6.Text = "Departure Time: " + Departuretime_1.ToString("HH:mm");
            label9.Text = "Arrival Date: " + Arrivaldate_1.ToString("dd/MM/yyyy");
            label8.Text = "Arrival Time: " + Arrivaltime_1.ToString("HH:mm");

            DateTime Departuredate_2 = (DateTime)indirectDataGridView.Rows[1].Cells["EDD"].Value;
            DateTime Departuretime_2 = (DateTime)indirectDataGridView.Rows[1].Cells["ETD"].Value;
            label15.Text = "Stop: " + indirectDataGridView.Rows[1].Cells["Stop"].Value.ToString();
            label14.Text = "Departure Date: " + Departuredate_2.ToString("dd/MM/yyyy");
            label13.Text = "Departure Time: " + Departuretime_2.ToString("HH:mm");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
