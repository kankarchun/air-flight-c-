namespace Air_flight
{
    partial class frmVehicleConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicleConfirm));
            this.customerBookingDataSet = new Air_flight.CustomerBookingDataSet();
            this.vehicleBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleBookingTableAdapter = new Air_flight.CustomerBookingDataSetTableAdapters.VehicleBookingTableAdapter();
            this.tableAdapterManager = new Air_flight.CustomerBookingDataSetTableAdapters.TableAdapterManager();
            this.vehicleBookingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vehicleBookingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vehicleBookingDataGridView = new System.Windows.Forms.DataGridView();
            this.VehicleBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttractionBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleBookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipBookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleOrderBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleCustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DropoffDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerBookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBookingBindingNavigator)).BeginInit();
            this.vehicleBookingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBookingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBookingDataSet
            // 
            this.customerBookingDataSet.DataSetName = "CustomerBookingDataSet";
            this.customerBookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleBookingBindingSource
            // 
            this.vehicleBookingBindingSource.DataMember = "VehicleBooking";
            this.vehicleBookingBindingSource.DataSource = this.customerBookingDataSet;
            // 
            // vehicleBookingTableAdapter
            // 
            this.vehicleBookingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttractionBookingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CruiseBookingTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.FlightBookingTableAdapter = null;
            this.tableAdapterManager.HotelBookingTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Air_flight.CustomerBookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleBookingTableAdapter = this.vehicleBookingTableAdapter;
            // 
            // vehicleBookingBindingNavigator
            // 
            this.vehicleBookingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vehicleBookingBindingNavigator.BindingSource = this.vehicleBookingBindingSource;
            this.vehicleBookingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vehicleBookingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vehicleBookingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vehicleBookingBindingNavigatorSaveItem});
            this.vehicleBookingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vehicleBookingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vehicleBookingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vehicleBookingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vehicleBookingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vehicleBookingBindingNavigator.Name = "vehicleBookingBindingNavigator";
            this.vehicleBookingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vehicleBookingBindingNavigator.Size = new System.Drawing.Size(390, 25);
            this.vehicleBookingBindingNavigator.TabIndex = 0;
            this.vehicleBookingBindingNavigator.Text = "bindingNavigator1";
            this.vehicleBookingBindingNavigator.Visible = false;
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
            // vehicleBookingBindingNavigatorSaveItem
            // 
            this.vehicleBookingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vehicleBookingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vehicleBookingBindingNavigatorSaveItem.Image")));
            this.vehicleBookingBindingNavigatorSaveItem.Name = "vehicleBookingBindingNavigatorSaveItem";
            this.vehicleBookingBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vehicleBookingBindingNavigatorSaveItem.Text = "儲存資料";
            this.vehicleBookingBindingNavigatorSaveItem.Click += new System.EventHandler(this.vehicleBookingBindingNavigatorSaveItem_Click);
            // 
            // vehicleBookingDataGridView
            // 
            this.vehicleBookingDataGridView.AllowUserToAddRows = false;
            this.vehicleBookingDataGridView.AllowUserToDeleteRows = false;
            this.vehicleBookingDataGridView.AutoGenerateColumns = false;
            this.vehicleBookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleBookingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleBookID,
            this.AttractionBookID,
            this.VehicleID,
            this.EquipID,
            this.BookDay,
            this.VehicleBookPrice,
            this.EquipNum,
            this.EquipBookPrice,
            this.VehicleOrderDate,
            this.VehicleOrderBy,
            this.VehicleCustID,
            this.PickupDate,
            this.DropoffDate,
            this.Document});
            this.vehicleBookingDataGridView.DataSource = this.vehicleBookingBindingSource;
            this.vehicleBookingDataGridView.Location = new System.Drawing.Point(12, 12);
            this.vehicleBookingDataGridView.Name = "vehicleBookingDataGridView";
            this.vehicleBookingDataGridView.ReadOnly = true;
            this.vehicleBookingDataGridView.RowTemplate.Height = 24;
            this.vehicleBookingDataGridView.Size = new System.Drawing.Size(1445, 220);
            this.vehicleBookingDataGridView.TabIndex = 1;
            this.vehicleBookingDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehicleBookingDataGridView_CellContentClick);
            // 
            // VehicleBookID
            // 
            this.VehicleBookID.DataPropertyName = "VehicleBookID";
            this.VehicleBookID.HeaderText = "VehicleBookID";
            this.VehicleBookID.Name = "VehicleBookID";
            this.VehicleBookID.ReadOnly = true;
            // 
            // AttractionBookID
            // 
            this.AttractionBookID.DataPropertyName = "AttractionBookID";
            this.AttractionBookID.HeaderText = "AttractionBookID";
            this.AttractionBookID.Name = "AttractionBookID";
            this.AttractionBookID.ReadOnly = true;
            // 
            // VehicleID
            // 
            this.VehicleID.DataPropertyName = "VehicleID";
            this.VehicleID.HeaderText = "VehicleID";
            this.VehicleID.Name = "VehicleID";
            this.VehicleID.ReadOnly = true;
            // 
            // EquipID
            // 
            this.EquipID.DataPropertyName = "EquipID";
            this.EquipID.HeaderText = "EquipID";
            this.EquipID.Name = "EquipID";
            this.EquipID.ReadOnly = true;
            // 
            // BookDay
            // 
            this.BookDay.DataPropertyName = "BookDay";
            this.BookDay.HeaderText = "BookDay";
            this.BookDay.Name = "BookDay";
            this.BookDay.ReadOnly = true;
            // 
            // VehicleBookPrice
            // 
            this.VehicleBookPrice.DataPropertyName = "VehicleBookPrice";
            this.VehicleBookPrice.HeaderText = "VehicleBookPrice";
            this.VehicleBookPrice.Name = "VehicleBookPrice";
            this.VehicleBookPrice.ReadOnly = true;
            // 
            // EquipNum
            // 
            this.EquipNum.DataPropertyName = "EquipNum";
            this.EquipNum.HeaderText = "EquipNum";
            this.EquipNum.Name = "EquipNum";
            this.EquipNum.ReadOnly = true;
            // 
            // EquipBookPrice
            // 
            this.EquipBookPrice.DataPropertyName = "EquipBookPrice";
            this.EquipBookPrice.HeaderText = "EquipBookPrice";
            this.EquipBookPrice.Name = "EquipBookPrice";
            this.EquipBookPrice.ReadOnly = true;
            // 
            // VehicleOrderDate
            // 
            this.VehicleOrderDate.DataPropertyName = "OrderDate";
            this.VehicleOrderDate.HeaderText = "OrderDate";
            this.VehicleOrderDate.Name = "VehicleOrderDate";
            this.VehicleOrderDate.ReadOnly = true;
            // 
            // VehicleOrderBy
            // 
            this.VehicleOrderBy.DataPropertyName = "OrderBy";
            this.VehicleOrderBy.HeaderText = "OrderBy";
            this.VehicleOrderBy.Name = "VehicleOrderBy";
            this.VehicleOrderBy.ReadOnly = true;
            // 
            // VehicleCustID
            // 
            this.VehicleCustID.DataPropertyName = "CustID";
            this.VehicleCustID.HeaderText = "CustID";
            this.VehicleCustID.Name = "VehicleCustID";
            this.VehicleCustID.ReadOnly = true;
            // 
            // PickupDate
            // 
            this.PickupDate.DataPropertyName = "PickupDate";
            this.PickupDate.HeaderText = "PickupDate";
            this.PickupDate.Name = "PickupDate";
            this.PickupDate.ReadOnly = true;
            // 
            // DropoffDate
            // 
            this.DropoffDate.DataPropertyName = "DropoffDate";
            this.DropoffDate.HeaderText = "DropoffDate";
            this.DropoffDate.Name = "DropoffDate";
            this.DropoffDate.ReadOnly = true;
            // 
            // Document
            // 
            this.Document.HeaderText = "Document";
            this.Document.Name = "Document";
            this.Document.ReadOnly = true;
            this.Document.Text = "Generate";
            this.Document.UseColumnTextForButtonValue = true;
            // 
            // frmVehicleConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 244);
            this.Controls.Add(this.vehicleBookingDataGridView);
            this.Controls.Add(this.vehicleBookingBindingNavigator);
            this.Name = "frmVehicleConfirm";
            this.Text = "Vehicle Booking Record";
            this.Load += new System.EventHandler(this.frmVehicleConfirm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBookingBindingNavigator)).EndInit();
            this.vehicleBookingBindingNavigator.ResumeLayout(false);
            this.vehicleBookingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBookingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomerBookingDataSet customerBookingDataSet;
        private System.Windows.Forms.BindingSource vehicleBookingBindingSource;
        private CustomerBookingDataSetTableAdapters.VehicleBookingTableAdapter vehicleBookingTableAdapter;
        private CustomerBookingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vehicleBookingBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vehicleBookingBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView vehicleBookingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractionBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleBookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipBookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleOrderBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleCustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickupDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DropoffDate;
        private System.Windows.Forms.DataGridViewButtonColumn Document;
    }
}