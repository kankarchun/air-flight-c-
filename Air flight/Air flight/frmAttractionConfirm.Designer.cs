namespace Air_flight
{
    partial class frmAttractionConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttractionConfirm));
            this.customerBookingDataSet = new Air_flight.CustomerBookingDataSet();
            this.attractionBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attractionBookingTableAdapter = new Air_flight.CustomerBookingDataSetTableAdapters.AttractionBookingTableAdapter();
            this.tableAdapterManager = new Air_flight.CustomerBookingDataSetTableAdapters.TableAdapterManager();
            this.attractionBookingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.attractionBookingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.attractionBookingDataGridView = new System.Windows.Forms.DataGridView();
            this.AttractBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttractName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdultNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdultPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttractOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttractOrderBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttractCustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerBookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractionBookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractionBookingBindingNavigator)).BeginInit();
            this.attractionBookingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attractionBookingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBookingDataSet
            // 
            this.customerBookingDataSet.DataSetName = "CustomerBookingDataSet";
            this.customerBookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attractionBookingBindingSource
            // 
            this.attractionBookingBindingSource.DataMember = "AttractionBooking";
            this.attractionBookingBindingSource.DataSource = this.customerBookingDataSet;
            // 
            // attractionBookingTableAdapter
            // 
            this.attractionBookingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttractionBookingTableAdapter = this.attractionBookingTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CruiseBookingTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.FlightBookingTableAdapter = null;
            this.tableAdapterManager.HotelBookingTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Air_flight.CustomerBookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleBookingTableAdapter = null;
            // 
            // attractionBookingBindingNavigator
            // 
            this.attractionBookingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.attractionBookingBindingNavigator.BindingSource = this.attractionBookingBindingSource;
            this.attractionBookingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.attractionBookingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.attractionBookingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.attractionBookingBindingNavigatorSaveItem});
            this.attractionBookingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.attractionBookingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.attractionBookingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.attractionBookingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.attractionBookingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.attractionBookingBindingNavigator.Name = "attractionBookingBindingNavigator";
            this.attractionBookingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.attractionBookingBindingNavigator.Size = new System.Drawing.Size(402, 25);
            this.attractionBookingBindingNavigator.TabIndex = 0;
            this.attractionBookingBindingNavigator.Text = "bindingNavigator1";
            this.attractionBookingBindingNavigator.Visible = false;
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
            // attractionBookingBindingNavigatorSaveItem
            // 
            this.attractionBookingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.attractionBookingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("attractionBookingBindingNavigatorSaveItem.Image")));
            this.attractionBookingBindingNavigatorSaveItem.Name = "attractionBookingBindingNavigatorSaveItem";
            this.attractionBookingBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.attractionBookingBindingNavigatorSaveItem.Text = "儲存資料";
            this.attractionBookingBindingNavigatorSaveItem.Click += new System.EventHandler(this.attractionBookingBindingNavigatorSaveItem_Click);
            // 
            // attractionBookingDataGridView
            // 
            this.attractionBookingDataGridView.AllowUserToAddRows = false;
            this.attractionBookingDataGridView.AllowUserToDeleteRows = false;
            this.attractionBookingDataGridView.AutoGenerateColumns = false;
            this.attractionBookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attractionBookingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttractBookID,
            this.AttractName,
            this.AdultNum,
            this.ChildNum,
            this.AdultPrice,
            this.ChildPrice,
            this.AttractOrderDate,
            this.AttractOrderBy,
            this.AttractCustID,
            this.Document});
            this.attractionBookingDataGridView.DataSource = this.attractionBookingBindingSource;
            this.attractionBookingDataGridView.Location = new System.Drawing.Point(12, 12);
            this.attractionBookingDataGridView.Name = "attractionBookingDataGridView";
            this.attractionBookingDataGridView.ReadOnly = true;
            this.attractionBookingDataGridView.RowTemplate.Height = 24;
            this.attractionBookingDataGridView.Size = new System.Drawing.Size(1043, 220);
            this.attractionBookingDataGridView.TabIndex = 1;
            this.attractionBookingDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.attractionBookingDataGridView_CellContentClick);
            // 
            // AttractBookID
            // 
            this.AttractBookID.DataPropertyName = "AttractBookID";
            this.AttractBookID.HeaderText = "AttractBookID";
            this.AttractBookID.Name = "AttractBookID";
            this.AttractBookID.ReadOnly = true;
            // 
            // AttractName
            // 
            this.AttractName.DataPropertyName = "AttractName";
            this.AttractName.HeaderText = "AttractName";
            this.AttractName.Name = "AttractName";
            this.AttractName.ReadOnly = true;
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
            // AttractOrderDate
            // 
            this.AttractOrderDate.DataPropertyName = "OrderDate";
            this.AttractOrderDate.HeaderText = "OrderDate";
            this.AttractOrderDate.Name = "AttractOrderDate";
            this.AttractOrderDate.ReadOnly = true;
            // 
            // AttractOrderBy
            // 
            this.AttractOrderBy.DataPropertyName = "OrderBy";
            this.AttractOrderBy.HeaderText = "OrderBy";
            this.AttractOrderBy.Name = "AttractOrderBy";
            this.AttractOrderBy.ReadOnly = true;
            // 
            // AttractCustID
            // 
            this.AttractCustID.DataPropertyName = "CustID";
            this.AttractCustID.HeaderText = "CustID";
            this.AttractCustID.Name = "AttractCustID";
            this.AttractCustID.ReadOnly = true;
            // 
            // Document
            // 
            this.Document.HeaderText = "Document";
            this.Document.Name = "Document";
            this.Document.ReadOnly = true;
            this.Document.Text = "Generate";
            this.Document.UseColumnTextForButtonValue = true;
            // 
            // frmAttractionConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 246);
            this.Controls.Add(this.attractionBookingDataGridView);
            this.Controls.Add(this.attractionBookingBindingNavigator);
            this.Name = "frmAttractionConfirm";
            this.Text = "Attraction Booking Record";
            this.Load += new System.EventHandler(this.frmAttractionConfirm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractionBookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractionBookingBindingNavigator)).EndInit();
            this.attractionBookingBindingNavigator.ResumeLayout(false);
            this.attractionBookingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attractionBookingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomerBookingDataSet customerBookingDataSet;
        private System.Windows.Forms.BindingSource attractionBookingBindingSource;
        private CustomerBookingDataSetTableAdapters.AttractionBookingTableAdapter attractionBookingTableAdapter;
        private CustomerBookingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator attractionBookingBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton attractionBookingBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView attractionBookingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdultNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdultPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractOrderBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractCustID;
        private System.Windows.Forms.DataGridViewButtonColumn Document;
    }
}