namespace Air_flight
{
    partial class frmHotelConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHotelConfirm));
            this.customerBookingDataSet = new Air_flight.CustomerBookingDataSet();
            this.hotelBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelBookingTableAdapter = new Air_flight.CustomerBookingDataSetTableAdapters.HotelBookingTableAdapter();
            this.tableAdapterManager = new Air_flight.CustomerBookingDataSetTableAdapters.TableAdapterManager();
            this.hotelBookingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.hotelBookingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hotelBookingDataGridView = new System.Windows.Forms.DataGridView();
            this.HotelBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumNight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelOrderBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelCustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerBookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBookingBindingNavigator)).BeginInit();
            this.hotelBookingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBookingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBookingDataSet
            // 
            this.customerBookingDataSet.DataSetName = "CustomerBookingDataSet";
            this.customerBookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelBookingBindingSource
            // 
            this.hotelBookingBindingSource.DataMember = "HotelBooking";
            this.hotelBookingBindingSource.DataSource = this.customerBookingDataSet;
            // 
            // hotelBookingTableAdapter
            // 
            this.hotelBookingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttractionBookingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CruiseBookingTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.FlightBookingTableAdapter = null;
            this.tableAdapterManager.HotelBookingTableAdapter = this.hotelBookingTableAdapter;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Air_flight.CustomerBookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleBookingTableAdapter = null;
            // 
            // hotelBookingBindingNavigator
            // 
            this.hotelBookingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hotelBookingBindingNavigator.BindingSource = this.hotelBookingBindingSource;
            this.hotelBookingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hotelBookingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hotelBookingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hotelBookingBindingNavigatorSaveItem});
            this.hotelBookingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hotelBookingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hotelBookingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hotelBookingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hotelBookingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hotelBookingBindingNavigator.Name = "hotelBookingBindingNavigator";
            this.hotelBookingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hotelBookingBindingNavigator.Size = new System.Drawing.Size(410, 25);
            this.hotelBookingBindingNavigator.TabIndex = 0;
            this.hotelBookingBindingNavigator.Text = "bindingNavigator1";
            this.hotelBookingBindingNavigator.Visible = false;
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
            // hotelBookingBindingNavigatorSaveItem
            // 
            this.hotelBookingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hotelBookingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hotelBookingBindingNavigatorSaveItem.Image")));
            this.hotelBookingBindingNavigatorSaveItem.Name = "hotelBookingBindingNavigatorSaveItem";
            this.hotelBookingBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hotelBookingBindingNavigatorSaveItem.Text = "儲存資料";
            this.hotelBookingBindingNavigatorSaveItem.Click += new System.EventHandler(this.hotelBookingBindingNavigatorSaveItem_Click);
            // 
            // hotelBookingDataGridView
            // 
            this.hotelBookingDataGridView.AllowUserToAddRows = false;
            this.hotelBookingDataGridView.AllowUserToDeleteRows = false;
            this.hotelBookingDataGridView.AutoGenerateColumns = false;
            this.hotelBookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotelBookingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HotelBookID,
            this.HotelRoomID,
            this.HotelRoomName,
            this.NumNight,
            this.NumRoom,
            this.Price,
            this.HotelOrderDate,
            this.HotelOrderBy,
            this.HotelCustID,
            this.Checkin,
            this.Checkout,
            this.Document});
            this.hotelBookingDataGridView.DataSource = this.hotelBookingBindingSource;
            this.hotelBookingDataGridView.Location = new System.Drawing.Point(12, 12);
            this.hotelBookingDataGridView.Name = "hotelBookingDataGridView";
            this.hotelBookingDataGridView.ReadOnly = true;
            this.hotelBookingDataGridView.RowTemplate.Height = 24;
            this.hotelBookingDataGridView.Size = new System.Drawing.Size(1245, 220);
            this.hotelBookingDataGridView.TabIndex = 1;
            this.hotelBookingDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hotelBookingDataGridView_CellContentClick);
            // 
            // HotelBookID
            // 
            this.HotelBookID.DataPropertyName = "HotelBookID";
            this.HotelBookID.HeaderText = "HotelBookID";
            this.HotelBookID.Name = "HotelBookID";
            this.HotelBookID.ReadOnly = true;
            // 
            // HotelRoomID
            // 
            this.HotelRoomID.DataPropertyName = "HotelRoomID";
            this.HotelRoomID.HeaderText = "HotelRoomID";
            this.HotelRoomID.Name = "HotelRoomID";
            this.HotelRoomID.ReadOnly = true;
            // 
            // HotelRoomName
            // 
            this.HotelRoomName.DataPropertyName = "HotelRoomName";
            this.HotelRoomName.HeaderText = "HotelRoomName";
            this.HotelRoomName.Name = "HotelRoomName";
            this.HotelRoomName.ReadOnly = true;
            // 
            // NumNight
            // 
            this.NumNight.DataPropertyName = "NumNight";
            this.NumNight.HeaderText = "NumNight";
            this.NumNight.Name = "NumNight";
            this.NumNight.ReadOnly = true;
            // 
            // NumRoom
            // 
            this.NumRoom.DataPropertyName = "NumRoom";
            this.NumRoom.HeaderText = "NumRoom";
            this.NumRoom.Name = "NumRoom";
            this.NumRoom.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // HotelOrderDate
            // 
            this.HotelOrderDate.DataPropertyName = "OrderDate";
            this.HotelOrderDate.HeaderText = "OrderDate";
            this.HotelOrderDate.Name = "HotelOrderDate";
            this.HotelOrderDate.ReadOnly = true;
            // 
            // HotelOrderBy
            // 
            this.HotelOrderBy.DataPropertyName = "OrderBy";
            this.HotelOrderBy.HeaderText = "OrderBy";
            this.HotelOrderBy.Name = "HotelOrderBy";
            this.HotelOrderBy.ReadOnly = true;
            // 
            // HotelCustID
            // 
            this.HotelCustID.DataPropertyName = "CustID";
            this.HotelCustID.HeaderText = "CustID";
            this.HotelCustID.Name = "HotelCustID";
            this.HotelCustID.ReadOnly = true;
            // 
            // Checkin
            // 
            this.Checkin.DataPropertyName = "Checkin";
            this.Checkin.HeaderText = "Checkin";
            this.Checkin.Name = "Checkin";
            this.Checkin.ReadOnly = true;
            // 
            // Checkout
            // 
            this.Checkout.DataPropertyName = "Checkout";
            this.Checkout.HeaderText = "Checkout";
            this.Checkout.Name = "Checkout";
            this.Checkout.ReadOnly = true;
            // 
            // Document
            // 
            this.Document.HeaderText = "Document";
            this.Document.Name = "Document";
            this.Document.ReadOnly = true;
            this.Document.Text = "Generate";
            this.Document.UseColumnTextForButtonValue = true;
            // 
            // frmHotelConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 247);
            this.Controls.Add(this.hotelBookingDataGridView);
            this.Controls.Add(this.hotelBookingBindingNavigator);
            this.Name = "frmHotelConfirm";
            this.Text = "Hotel  Booking Record";
            this.Load += new System.EventHandler(this.frmHotelConfirm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBookingBindingNavigator)).EndInit();
            this.hotelBookingBindingNavigator.ResumeLayout(false);
            this.hotelBookingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBookingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomerBookingDataSet customerBookingDataSet;
        private System.Windows.Forms.BindingSource hotelBookingBindingSource;
        private CustomerBookingDataSetTableAdapters.HotelBookingTableAdapter hotelBookingTableAdapter;
        private CustomerBookingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hotelBookingBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hotelBookingBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hotelBookingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumNight;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelOrderBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelCustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkout;
        private System.Windows.Forms.DataGridViewButtonColumn Document;
    }
}