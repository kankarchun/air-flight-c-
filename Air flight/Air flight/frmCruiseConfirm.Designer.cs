namespace Air_flight
{
    partial class frmCruiseConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCruiseConfirm));
            this.customerBookingDataSet = new Air_flight.CustomerBookingDataSet();
            this.cruiseBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cruiseBookingTableAdapter = new Air_flight.CustomerBookingDataSetTableAdapters.CruiseBookingTableAdapter();
            this.tableAdapterManager = new Air_flight.CustomerBookingDataSetTableAdapters.TableAdapterManager();
            this.cruiseBookingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cruiseBookingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cruiseBookingDataGridView = new System.Windows.Forms.DataGridView();
            this.CruiseBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CruiseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CruiseOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CruiseOrderBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cruisecustid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerBookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cruiseBookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cruiseBookingBindingNavigator)).BeginInit();
            this.cruiseBookingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cruiseBookingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBookingDataSet
            // 
            this.customerBookingDataSet.DataSetName = "CustomerBookingDataSet";
            this.customerBookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cruiseBookingBindingSource
            // 
            this.cruiseBookingBindingSource.DataMember = "CruiseBooking";
            this.cruiseBookingBindingSource.DataSource = this.customerBookingDataSet;
            // 
            // cruiseBookingTableAdapter
            // 
            this.cruiseBookingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttractionBookingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CruiseBookingTableAdapter = this.cruiseBookingTableAdapter;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.FlightBookingTableAdapter = null;
            this.tableAdapterManager.HotelBookingTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Air_flight.CustomerBookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleBookingTableAdapter = null;
            // 
            // cruiseBookingBindingNavigator
            // 
            this.cruiseBookingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cruiseBookingBindingNavigator.BindingSource = this.cruiseBookingBindingSource;
            this.cruiseBookingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cruiseBookingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cruiseBookingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cruiseBookingBindingNavigatorSaveItem});
            this.cruiseBookingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cruiseBookingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cruiseBookingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cruiseBookingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cruiseBookingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cruiseBookingBindingNavigator.Name = "cruiseBookingBindingNavigator";
            this.cruiseBookingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cruiseBookingBindingNavigator.Size = new System.Drawing.Size(395, 25);
            this.cruiseBookingBindingNavigator.TabIndex = 0;
            this.cruiseBookingBindingNavigator.Text = "bindingNavigator1";
            this.cruiseBookingBindingNavigator.Visible = false;
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
            // cruiseBookingBindingNavigatorSaveItem
            // 
            this.cruiseBookingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cruiseBookingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cruiseBookingBindingNavigatorSaveItem.Image")));
            this.cruiseBookingBindingNavigatorSaveItem.Name = "cruiseBookingBindingNavigatorSaveItem";
            this.cruiseBookingBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cruiseBookingBindingNavigatorSaveItem.Text = "儲存資料";
            this.cruiseBookingBindingNavigatorSaveItem.Click += new System.EventHandler(this.cruiseBookingBindingNavigatorSaveItem_Click);
            // 
            // cruiseBookingDataGridView
            // 
            this.cruiseBookingDataGridView.AllowUserToAddRows = false;
            this.cruiseBookingDataGridView.AllowUserToDeleteRows = false;
            this.cruiseBookingDataGridView.AutoGenerateColumns = false;
            this.cruiseBookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cruiseBookingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CruiseBookID,
            this.CruiseNo,
            this.PersonNum,
            this.PersonPrice,
            this.CruiseOrderDate,
            this.CruiseOrderBy,
            this.Cruisecustid,
            this.Document});
            this.cruiseBookingDataGridView.DataSource = this.cruiseBookingBindingSource;
            this.cruiseBookingDataGridView.Location = new System.Drawing.Point(12, 12);
            this.cruiseBookingDataGridView.Name = "cruiseBookingDataGridView";
            this.cruiseBookingDataGridView.ReadOnly = true;
            this.cruiseBookingDataGridView.RowTemplate.Height = 24;
            this.cruiseBookingDataGridView.Size = new System.Drawing.Size(845, 220);
            this.cruiseBookingDataGridView.TabIndex = 1;
            this.cruiseBookingDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cruiseBookingDataGridView_CellContentClick);
            // 
            // CruiseBookID
            // 
            this.CruiseBookID.DataPropertyName = "CruiseBookID";
            this.CruiseBookID.HeaderText = "CruiseBookID";
            this.CruiseBookID.Name = "CruiseBookID";
            this.CruiseBookID.ReadOnly = true;
            // 
            // CruiseNo
            // 
            this.CruiseNo.DataPropertyName = "CruiseNo";
            this.CruiseNo.HeaderText = "CruiseNo";
            this.CruiseNo.Name = "CruiseNo";
            this.CruiseNo.ReadOnly = true;
            // 
            // PersonNum
            // 
            this.PersonNum.DataPropertyName = "PersonNum";
            this.PersonNum.HeaderText = "PersonNum";
            this.PersonNum.Name = "PersonNum";
            this.PersonNum.ReadOnly = true;
            // 
            // PersonPrice
            // 
            this.PersonPrice.DataPropertyName = "PersonPrice";
            this.PersonPrice.HeaderText = "PersonPrice";
            this.PersonPrice.Name = "PersonPrice";
            this.PersonPrice.ReadOnly = true;
            // 
            // CruiseOrderDate
            // 
            this.CruiseOrderDate.DataPropertyName = "OrderDate";
            this.CruiseOrderDate.HeaderText = "OrderDate";
            this.CruiseOrderDate.Name = "CruiseOrderDate";
            this.CruiseOrderDate.ReadOnly = true;
            // 
            // CruiseOrderBy
            // 
            this.CruiseOrderBy.DataPropertyName = "OrderBy";
            this.CruiseOrderBy.HeaderText = "OrderBy";
            this.CruiseOrderBy.Name = "CruiseOrderBy";
            this.CruiseOrderBy.ReadOnly = true;
            // 
            // Cruisecustid
            // 
            this.Cruisecustid.DataPropertyName = "CustID";
            this.Cruisecustid.HeaderText = "CustID";
            this.Cruisecustid.Name = "Cruisecustid";
            this.Cruisecustid.ReadOnly = true;
            // 
            // Document
            // 
            this.Document.HeaderText = "Document";
            this.Document.Name = "Document";
            this.Document.ReadOnly = true;
            this.Document.Text = "Generate";
            this.Document.UseColumnTextForButtonValue = true;
            // 
            // frmCruiseConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 246);
            this.Controls.Add(this.cruiseBookingDataGridView);
            this.Controls.Add(this.cruiseBookingBindingNavigator);
            this.Name = "frmCruiseConfirm";
            this.Text = "Cruise Tour Booking Record";
            this.Load += new System.EventHandler(this.frmCruiseConfirm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cruiseBookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cruiseBookingBindingNavigator)).EndInit();
            this.cruiseBookingBindingNavigator.ResumeLayout(false);
            this.cruiseBookingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cruiseBookingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomerBookingDataSet customerBookingDataSet;
        private System.Windows.Forms.BindingSource cruiseBookingBindingSource;
        private CustomerBookingDataSetTableAdapters.CruiseBookingTableAdapter cruiseBookingTableAdapter;
        private CustomerBookingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cruiseBookingBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cruiseBookingBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cruiseBookingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseOrderBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cruisecustid;
        private System.Windows.Forms.DataGridViewButtonColumn Document;
    }
}