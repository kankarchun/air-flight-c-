namespace Air_flight
{
    partial class frmFlightConfirm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFlightConfirm));
            this.customerBookingDataSet = new Air_flight.CustomerBookingDataSet();
            this.flightBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightBookingTableAdapter = new Air_flight.CustomerBookingDataSetTableAdapters.FlightBookingTableAdapter();
            this.tableAdapterManager = new Air_flight.CustomerBookingDataSetTableAdapters.TableAdapterManager();
            this.flightBookingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.flightBookingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.flightBookingDataGridView = new System.Windows.Forms.DataGridView();
            this.FlightOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdultNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfantNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdultPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfantPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightorderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightorderBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightcustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerBookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingBindingNavigator)).BeginInit();
            this.flightBookingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBookingDataSet
            // 
            this.customerBookingDataSet.DataSetName = "CustomerBookingDataSet";
            this.customerBookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightBookingBindingSource
            // 
            this.flightBookingBindingSource.DataMember = "FlightBooking";
            this.flightBookingBindingSource.DataSource = this.customerBookingDataSet;
            // 
            // flightBookingTableAdapter
            // 
            this.flightBookingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttractionBookingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CruiseBookingTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.FlightBookingTableAdapter = this.flightBookingTableAdapter;
            this.tableAdapterManager.HotelBookingTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Air_flight.CustomerBookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleBookingTableAdapter = null;
            // 
            // flightBookingBindingNavigator
            // 
            this.flightBookingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.flightBookingBindingNavigator.BindingSource = this.flightBookingBindingSource;
            this.flightBookingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.flightBookingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.flightBookingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.flightBookingBindingNavigatorSaveItem});
            this.flightBookingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.flightBookingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.flightBookingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.flightBookingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.flightBookingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.flightBookingBindingNavigator.Name = "flightBookingBindingNavigator";
            this.flightBookingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.flightBookingBindingNavigator.Size = new System.Drawing.Size(392, 25);
            this.flightBookingBindingNavigator.TabIndex = 0;
            this.flightBookingBindingNavigator.Text = "bindingNavigator1";
            this.flightBookingBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(28, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // flightBookingBindingNavigatorSaveItem
            // 
            this.flightBookingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.flightBookingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("flightBookingBindingNavigatorSaveItem.Image")));
            this.flightBookingBindingNavigatorSaveItem.Name = "flightBookingBindingNavigatorSaveItem";
            this.flightBookingBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.flightBookingBindingNavigatorSaveItem.Text = "儲存資料";
            this.flightBookingBindingNavigatorSaveItem.Click += new System.EventHandler(this.flightBookingBindingNavigatorSaveItem_Click);
            // 
            // flightBookingDataGridView
            // 
            this.flightBookingDataGridView.AllowUserToAddRows = false;
            this.flightBookingDataGridView.AllowUserToDeleteRows = false;
            this.flightBookingDataGridView.AutoGenerateColumns = false;
            this.flightBookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightBookingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlightOrderID,
            this.FlightID,
            this.FlightNo,
            this.FlightClass,
            this.AdultNum,
            this.ChildNum,
            this.InfantNum,
            this.AdultPrice,
            this.ChildPrice,
            this.InfantPrice,
            this.FlightorderDate,
            this.FlightorderBy,
            this.FlightcustID,
            this.Document});
            this.flightBookingDataGridView.DataSource = this.flightBookingBindingSource;
            this.flightBookingDataGridView.Location = new System.Drawing.Point(12, 12);
            this.flightBookingDataGridView.Name = "flightBookingDataGridView";
            this.flightBookingDataGridView.ReadOnly = true;
            this.flightBookingDataGridView.RowTemplate.Height = 24;
            this.flightBookingDataGridView.Size = new System.Drawing.Size(1443, 218);
            this.flightBookingDataGridView.TabIndex = 1;
            this.flightBookingDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flightBookingDataGridView_CellContentClick);
            // 
            // FlightOrderID
            // 
            this.FlightOrderID.DataPropertyName = "FlightOrderID";
            this.FlightOrderID.HeaderText = "FlightOrderID";
            this.FlightOrderID.Name = "FlightOrderID";
            this.FlightOrderID.ReadOnly = true;
            // 
            // FlightID
            // 
            this.FlightID.DataPropertyName = "FlightID";
            this.FlightID.HeaderText = "FlightID";
            this.FlightID.Name = "FlightID";
            this.FlightID.ReadOnly = true;
            // 
            // FlightNo
            // 
            this.FlightNo.DataPropertyName = "FlightNo";
            this.FlightNo.HeaderText = "FlightNo";
            this.FlightNo.Name = "FlightNo";
            this.FlightNo.ReadOnly = true;
            // 
            // FlightClass
            // 
            this.FlightClass.DataPropertyName = "FlightClass";
            this.FlightClass.HeaderText = "FlightClass";
            this.FlightClass.Name = "FlightClass";
            this.FlightClass.ReadOnly = true;
            // 
            // AdultNum
            // 
            this.AdultNum.DataPropertyName = "AdultNum";
            this.AdultNum.HeaderText = "AdultNum";
            this.AdultNum.Name = "AdultNum";
            this.AdultNum.ReadOnly = true;
            // 
            // ChildNum
            // 
            this.ChildNum.DataPropertyName = "ChildNum";
            this.ChildNum.HeaderText = "ChildNum";
            this.ChildNum.Name = "ChildNum";
            this.ChildNum.ReadOnly = true;
            // 
            // InfantNum
            // 
            this.InfantNum.DataPropertyName = "InfantNum";
            this.InfantNum.HeaderText = "InfantNum";
            this.InfantNum.Name = "InfantNum";
            this.InfantNum.ReadOnly = true;
            // 
            // AdultPrice
            // 
            this.AdultPrice.DataPropertyName = "AdultPrice";
            this.AdultPrice.HeaderText = "AdultPrice";
            this.AdultPrice.Name = "AdultPrice";
            this.AdultPrice.ReadOnly = true;
            // 
            // ChildPrice
            // 
            this.ChildPrice.DataPropertyName = "ChildPrice";
            this.ChildPrice.HeaderText = "ChildPrice";
            this.ChildPrice.Name = "ChildPrice";
            this.ChildPrice.ReadOnly = true;
            // 
            // InfantPrice
            // 
            this.InfantPrice.DataPropertyName = "InfantPrice";
            this.InfantPrice.HeaderText = "InfantPrice";
            this.InfantPrice.Name = "InfantPrice";
            this.InfantPrice.ReadOnly = true;
            // 
            // FlightorderDate
            // 
            this.FlightorderDate.DataPropertyName = "orderDate";
            this.FlightorderDate.HeaderText = "orderDate";
            this.FlightorderDate.Name = "FlightorderDate";
            this.FlightorderDate.ReadOnly = true;
            // 
            // FlightorderBy
            // 
            this.FlightorderBy.DataPropertyName = "orderBy";
            this.FlightorderBy.HeaderText = "orderBy";
            this.FlightorderBy.Name = "FlightorderBy";
            this.FlightorderBy.ReadOnly = true;
            // 
            // FlightcustID
            // 
            this.FlightcustID.DataPropertyName = "custID";
            this.FlightcustID.HeaderText = "custID";
            this.FlightcustID.Name = "FlightcustID";
            this.FlightcustID.ReadOnly = true;
            // 
            // Document
            // 
            this.Document.HeaderText = "Document";
            this.Document.Name = "Document";
            this.Document.ReadOnly = true;
            this.Document.Text = "Generate";
            this.Document.UseColumnTextForButtonValue = true;
            // 
            // frmFlightConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 247);
            this.Controls.Add(this.flightBookingDataGridView);
            this.Controls.Add(this.flightBookingBindingNavigator);
            this.Name = "frmFlightConfirm";
            this.Text = "Flight Booking Record";
            this.Load += new System.EventHandler(this.frmFlightConfirm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingBindingNavigator)).EndInit();
            this.flightBookingBindingNavigator.ResumeLayout(false);
            this.flightBookingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightBookingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomerBookingDataSet customerBookingDataSet;
        private System.Windows.Forms.BindingSource flightBookingBindingSource;
        private CustomerBookingDataSetTableAdapters.FlightBookingTableAdapter flightBookingTableAdapter;
        private CustomerBookingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator flightBookingBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton flightBookingBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView flightBookingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdultNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfantNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdultPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfantPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightorderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightorderBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightcustID;
        private System.Windows.Forms.DataGridViewButtonColumn Document;
    }
}