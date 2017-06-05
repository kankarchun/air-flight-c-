namespace Air_flight
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.directDefaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketDataSet = new Air_flight.ticketDataSet();
            this.attractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attractionDataSet = new Air_flight.AttractionDataSet();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleDataSet = new Air_flight.VehicleDataSet();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBookingDataSet = new Air_flight.CustomerBookingDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.directDefaultTableAdapter = new Air_flight.ticketDataSetTableAdapters.DirectDefaultTableAdapter();
            this.tableAdapterManager = new Air_flight.ticketDataSetTableAdapters.TableAdapterManager();
            this.directDefaultBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.directDefaultBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.attractTableAdapter = new Air_flight.AttractionDataSetTableAdapters.DefaultTableAdapter();
            this.tableAdapterManager3 = new Air_flight.AttractionDataSetTableAdapters.TableAdapterManager();
            this.vehicleTableAdapter = new Air_flight.VehicleDataSetTableAdapters.VehicleTableAdapter();
            this.tableAdapterManager4 = new Air_flight.VehicleDataSetTableAdapters.TableAdapterManager();
            this.equipmentTableAdapter = new Air_flight.VehicleDataSetTableAdapters.EquipmentTableAdapter();
            this.staffTableAdapter = new Air_flight.CustomerBookingDataSetTableAdapters.StaffTableAdapter();
            this.tableAdapterManager5 = new Air_flight.CustomerBookingDataSetTableAdapters.TableAdapterManager();
            this.customerTableAdapter = new Air_flight.CustomerBookingDataSetTableAdapters.CustomerTableAdapter();
            this.hotelDataSet = new Air_flight.HotelDataSet();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelTableAdapter = new Air_flight.HotelDataSetTableAdapters.HotelTableAdapter();
            this.tableAdapterManager1 = new Air_flight.HotelDataSetTableAdapters.TableAdapterManager();
            this.hotel_roomTableAdapter = new Air_flight.HotelDataSetTableAdapters.Hotel_roomTableAdapter();
            this.cruiseDataSet = new Air_flight.CruiseDataSet();
            this.cruiseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cruiseTableAdapter = new Air_flight.CruiseDataSetTableAdapters.DefaultTableAdapter();
            this.tableAdapterManager2 = new Air_flight.CruiseDataSetTableAdapters.TableAdapterManager();
            this.Customer = new System.Windows.Forms.TabPage();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GivenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn70 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn71 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn72 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn73 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff = new System.Windows.Forms.TabPage();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName_admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle = new System.Windows.Forms.TabPage();
            this.equipmentDataGridView = new System.Windows.Forms.DataGridView();
            this.EquipID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleDataGridView = new System.Windows.Forms.DataGridView();
            this.VehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attraction = new System.Windows.Forms.TabPage();
            this.attractionDataGridView = new System.Windows.Forms.DataGridView();
            this.AttractName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cruise = new System.Windows.Forms.TabPage();
            this.cruiseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cruiseNo_admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CruiseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel = new System.Windows.Forms.TabPage();
            this.hotel_roomDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelChiName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotel_roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Air_Flight = new System.Windows.Forms.TabPage();
            this.directDefaultDataGridView = new System.Windows.Forms.DataGridView();
            this.FlightID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label84 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.directDefaultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directDefaultBindingNavigator)).BeginInit();
            this.directDefaultBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cruiseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cruiseBindingSource)).BeginInit();
            this.Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.Staff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
            this.Vehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).BeginInit();
            this.Attraction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attractionDataGridView)).BeginInit();
            this.Cruise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cruiseDataGridView)).BeginInit();
            this.Hotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_roomDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataGridView)).BeginInit();
            this.Air_Flight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directDefaultDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PowderBlue;
            this.label4.Font = new System.Drawing.Font("DFKai-SB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(352, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Admintration system";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(271, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 49);
            this.label5.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(12, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(898, 483);
            this.label14.TabIndex = 33;
            // 
            // directDefaultBindingSource
            // 
            this.directDefaultBindingSource.DataMember = "DirectDefault";
            this.directDefaultBindingSource.DataSource = this.ticketDataSet;
            // 
            // ticketDataSet
            // 
            this.ticketDataSet.DataSetName = "ticketDataSet";
            this.ticketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attractBindingSource
            // 
            this.attractBindingSource.DataMember = "Default";
            this.attractBindingSource.DataSource = this.attractionDataSet;
            // 
            // attractionDataSet
            // 
            this.attractionDataSet.DataSetName = "AttractionDataSet";
            this.attractionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehicle";
            this.vehicleBindingSource.DataSource = this.vehicleDataSet;
            // 
            // vehicleDataSet
            // 
            this.vehicleDataSet.DataSetName = "VehicleDataSet";
            this.vehicleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataMember = "Equipment";
            this.equipmentBindingSource.DataSource = this.vehicleDataSet;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.customerBookingDataSet;
            // 
            // customerBookingDataSet
            // 
            this.customerBookingDataSet.DataSetName = "CustomerBookingDataSet";
            this.customerBookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.customerBookingDataSet;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(739, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Staff: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(739, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Time:";
            // 
            // directDefaultTableAdapter
            // 
            this.directDefaultTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarrierTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FlightClassTableAdapter = null;
            this.tableAdapterManager.FlightScheduleTableAdapter = null;
            this.tableAdapterManager.Indirect1TableAdapter = null;
            this.tableAdapterManager.IndirectTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Air_flight.ticketDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // directDefaultBindingNavigator
            // 
            this.directDefaultBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.directDefaultBindingNavigator.BindingSource = this.directDefaultBindingSource;
            this.directDefaultBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.directDefaultBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.directDefaultBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.directDefaultBindingNavigatorSaveItem});
            this.directDefaultBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.directDefaultBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.directDefaultBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.directDefaultBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.directDefaultBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.directDefaultBindingNavigator.Name = "directDefaultBindingNavigator";
            this.directDefaultBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.directDefaultBindingNavigator.Size = new System.Drawing.Size(931, 27);
            this.directDefaultBindingNavigator.TabIndex = 50;
            this.directDefaultBindingNavigator.Text = "bindingNavigator1";
            this.directDefaultBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // directDefaultBindingNavigatorSaveItem
            // 
            this.directDefaultBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.directDefaultBindingNavigatorSaveItem.Enabled = false;
            this.directDefaultBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("directDefaultBindingNavigatorSaveItem.Image")));
            this.directDefaultBindingNavigatorSaveItem.Name = "directDefaultBindingNavigatorSaveItem";
            this.directDefaultBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.directDefaultBindingNavigatorSaveItem.Text = "儲存資料";
            // 
            // attractTableAdapter
            // 
            this.attractTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.AttractionTableAdapter = null;
            this.tableAdapterManager3.AttractPriceTableAdapter = null;
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.Connection = null;
            this.tableAdapterManager3.UpdateOrder = Air_flight.AttractionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager4
            // 
            this.tableAdapterManager4.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager4.EquipmentListTableAdapter = null;
            this.tableAdapterManager4.EquipmentTableAdapter = this.equipmentTableAdapter;
            this.tableAdapterManager4.UpdateOrder = Air_flight.VehicleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager4.VehicleBookingTableAdapter = null;
            this.tableAdapterManager4.VehicleTableAdapter = this.vehicleTableAdapter;
            // 
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager5
            // 
            this.tableAdapterManager5.AttractionBookingTableAdapter = null;
            this.tableAdapterManager5.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager5.CruiseBookingTableAdapter = null;
            this.tableAdapterManager5.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager5.FlightBookingTableAdapter = null;
            this.tableAdapterManager5.HotelBookingTableAdapter = null;
            this.tableAdapterManager5.StaffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager5.UpdateOrder = Air_flight.CustomerBookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager5.VehicleBookingTableAdapter = null;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataMember = "Hotel";
            this.hotelBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelTableAdapter
            // 
            this.hotelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Hotel_roomTableAdapter = this.hotel_roomTableAdapter;
            this.tableAdapterManager1.HotelTableAdapter = this.hotelTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Air_flight.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hotel_roomTableAdapter
            // 
            this.hotel_roomTableAdapter.ClearBeforeFill = true;
            // 
            // cruiseDataSet
            // 
            this.cruiseDataSet.DataSetName = "CruiseDataSet";
            this.cruiseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cruiseBindingSource
            // 
            this.cruiseBindingSource.DataMember = "Default";
            this.cruiseBindingSource.DataSource = this.cruiseDataSet;
            // 
            // cruiseTableAdapter
            // 
            this.cruiseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.COrganiserTableAdapter = null;
            this.tableAdapterManager2.CruiseTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = Air_flight.CruiseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Customer
            // 
            this.Customer.AutoScroll = true;
            this.Customer.Controls.Add(this.customerDataGridView);
            this.Customer.Location = new System.Drawing.Point(4, 22);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(830, 336);
            this.Customer.TabIndex = 6;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = true;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustID,
            this.Surname,
            this.GivenName,
            this.dataGridViewTextBoxColumn70,
            this.dataGridViewTextBoxColumn69,
            this.dataGridViewTextBoxColumn71,
            this.dataGridViewTextBoxColumn72,
            this.dataGridViewTextBoxColumn73});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(3, 3);
            this.customerDataGridView.MultiSelect = false;
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.Size = new System.Drawing.Size(827, 330);
            this.customerDataGridView.TabIndex = 0;
            this.customerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellContentClick);
            // 
            // CustID
            // 
            this.CustID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustID.DataPropertyName = "CustID";
            this.CustID.HeaderText = "CustID";
            this.CustID.Name = "CustID";
            this.CustID.ReadOnly = true;
            this.CustID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CustID.Width = 45;
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GivenName
            // 
            this.GivenName.DataPropertyName = "GivenName";
            this.GivenName.HeaderText = "GivenName";
            this.GivenName.Name = "GivenName";
            this.GivenName.ReadOnly = true;
            this.GivenName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn70
            // 
            this.dataGridViewTextBoxColumn70.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn70.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn70.Name = "dataGridViewTextBoxColumn70";
            this.dataGridViewTextBoxColumn70.ReadOnly = true;
            this.dataGridViewTextBoxColumn70.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn69
            // 
            this.dataGridViewTextBoxColumn69.DataPropertyName = "DateOfBirth";
            this.dataGridViewTextBoxColumn69.HeaderText = "DateOfBirth";
            this.dataGridViewTextBoxColumn69.Name = "dataGridViewTextBoxColumn69";
            this.dataGridViewTextBoxColumn69.ReadOnly = true;
            this.dataGridViewTextBoxColumn69.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn71
            // 
            this.dataGridViewTextBoxColumn71.DataPropertyName = "Passport";
            this.dataGridViewTextBoxColumn71.HeaderText = "Passport";
            this.dataGridViewTextBoxColumn71.Name = "dataGridViewTextBoxColumn71";
            this.dataGridViewTextBoxColumn71.ReadOnly = true;
            this.dataGridViewTextBoxColumn71.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn72
            // 
            this.dataGridViewTextBoxColumn72.DataPropertyName = "Contact";
            this.dataGridViewTextBoxColumn72.HeaderText = "Contact";
            this.dataGridViewTextBoxColumn72.Name = "dataGridViewTextBoxColumn72";
            this.dataGridViewTextBoxColumn72.ReadOnly = true;
            this.dataGridViewTextBoxColumn72.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn73
            // 
            this.dataGridViewTextBoxColumn73.DataPropertyName = "Nationality";
            this.dataGridViewTextBoxColumn73.HeaderText = "Nationality";
            this.dataGridViewTextBoxColumn73.Name = "dataGridViewTextBoxColumn73";
            this.dataGridViewTextBoxColumn73.ReadOnly = true;
            this.dataGridViewTextBoxColumn73.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Staff
            // 
            this.Staff.AutoScroll = true;
            this.Staff.Controls.Add(this.staffDataGridView);
            this.Staff.Location = new System.Drawing.Point(4, 22);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(830, 336);
            this.Staff.TabIndex = 5;
            this.Staff.Text = "Staff";
            this.Staff.UseVisualStyleBackColor = true;
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.AllowUserToAddRows = false;
            this.staffDataGridView.AllowUserToDeleteRows = false;
            this.staffDataGridView.AutoGenerateColumns = false;
            this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffID,
            this.StaffName_admin,
            this.dataGridViewTextBoxColumn58,
            this.dataGridViewTextBoxColumn59,
            this.dataGridViewTextBoxColumn60,
            this.Password,
            this.dataGridViewTextBoxColumn62,
            this.dataGridViewTextBoxColumn63,
            this.dataGridViewTextBoxColumn64,
            this.dataGridViewTextBoxColumn65});
            this.staffDataGridView.DataSource = this.staffBindingSource;
            this.staffDataGridView.Location = new System.Drawing.Point(3, 3);
            this.staffDataGridView.MultiSelect = false;
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.ReadOnly = true;
            this.staffDataGridView.RowTemplate.Height = 24;
            this.staffDataGridView.Size = new System.Drawing.Size(824, 327);
            this.staffDataGridView.TabIndex = 0;
            this.staffDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffDataGridView_CellContentClick);
            this.staffDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.staffDataGridView_CellFormatting);
            this.staffDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.staffDataGridView_CellPainting);
            // 
            // StaffID
            // 
            this.StaffID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StaffID.DataPropertyName = "StaffID";
            this.StaffID.HeaderText = "StaffID";
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            this.StaffID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StaffID.Width = 46;
            // 
            // StaffName_admin
            // 
            this.StaffName_admin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StaffName_admin.DataPropertyName = "StaffName";
            this.StaffName_admin.HeaderText = "StaffName";
            this.StaffName_admin.Name = "StaffName_admin";
            this.StaffName_admin.ReadOnly = true;
            this.StaffName_admin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StaffName_admin.Width = 63;
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn58.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn58.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn58.ReadOnly = true;
            this.dataGridViewTextBoxColumn58.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn58.Width = 48;
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn59.DataPropertyName = "Center";
            this.dataGridViewTextBoxColumn59.HeaderText = "Center";
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn59.ReadOnly = true;
            this.dataGridViewTextBoxColumn59.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn59.Width = 44;
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn60.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn60.HeaderText = "Email";
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            this.dataGridViewTextBoxColumn60.ReadOnly = true;
            this.dataGridViewTextBoxColumn60.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn60.Width = 38;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Pass";
            this.Password.HeaderText = "Pass";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn62.HeaderText = "Position";
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            this.dataGridViewTextBoxColumn62.ReadOnly = true;
            this.dataGridViewTextBoxColumn62.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn63
            // 
            this.dataGridViewTextBoxColumn63.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn63.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
            this.dataGridViewTextBoxColumn63.ReadOnly = true;
            this.dataGridViewTextBoxColumn63.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn64
            // 
            this.dataGridViewTextBoxColumn64.DataPropertyName = "Ctype";
            this.dataGridViewTextBoxColumn64.HeaderText = "Ctype";
            this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
            this.dataGridViewTextBoxColumn64.ReadOnly = true;
            this.dataGridViewTextBoxColumn64.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.DataPropertyName = "Late";
            this.dataGridViewTextBoxColumn65.HeaderText = "Late";
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            this.dataGridViewTextBoxColumn65.ReadOnly = true;
            this.dataGridViewTextBoxColumn65.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Vehicle
            // 
            this.Vehicle.AutoScroll = true;
            this.Vehicle.Controls.Add(this.equipmentDataGridView);
            this.Vehicle.Controls.Add(this.vehicleDataGridView);
            this.Vehicle.Location = new System.Drawing.Point(4, 22);
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.Size = new System.Drawing.Size(830, 336);
            this.Vehicle.TabIndex = 4;
            this.Vehicle.Text = "Vehicle";
            this.Vehicle.UseVisualStyleBackColor = true;
            // 
            // equipmentDataGridView
            // 
            this.equipmentDataGridView.AllowUserToAddRows = false;
            this.equipmentDataGridView.AllowUserToDeleteRows = false;
            this.equipmentDataGridView.AutoGenerateColumns = false;
            this.equipmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipID,
            this.Equipment,
            this.dataGridViewTextBoxColumn54,
            this.dataGridViewTextBoxColumn55});
            this.equipmentDataGridView.DataSource = this.equipmentBindingSource;
            this.equipmentDataGridView.Location = new System.Drawing.Point(205, 21);
            this.equipmentDataGridView.MultiSelect = false;
            this.equipmentDataGridView.Name = "equipmentDataGridView";
            this.equipmentDataGridView.ReadOnly = true;
            this.equipmentDataGridView.RowTemplate.Height = 24;
            this.equipmentDataGridView.Size = new System.Drawing.Size(445, 126);
            this.equipmentDataGridView.TabIndex = 0;
            this.equipmentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.equipmentDataGridView_CellClick);
            this.equipmentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.equipmentDataGridView_CellContentClick);
            // 
            // EquipID
            // 
            this.EquipID.DataPropertyName = "EquipID";
            this.EquipID.HeaderText = "EquipID";
            this.EquipID.Name = "EquipID";
            this.EquipID.ReadOnly = true;
            this.EquipID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Equipment
            // 
            this.Equipment.DataPropertyName = "Equipment";
            this.Equipment.HeaderText = "Equipment";
            this.Equipment.Name = "Equipment";
            this.Equipment.ReadOnly = true;
            this.Equipment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "Suitable";
            this.dataGridViewTextBoxColumn54.HeaderText = "Suitable";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn54.ReadOnly = true;
            this.dataGridViewTextBoxColumn54.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn55.HeaderText = "Price";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.ReadOnly = true;
            this.dataGridViewTextBoxColumn55.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // vehicleDataGridView
            // 
            this.vehicleDataGridView.AllowUserToAddRows = false;
            this.vehicleDataGridView.AllowUserToDeleteRows = false;
            this.vehicleDataGridView.AutoGenerateColumns = false;
            this.vehicleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleID,
            this.Vehicle_Name,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn48,
            this.dataGridViewTextBoxColumn49,
            this.dataGridViewTextBoxColumn50});
            this.vehicleDataGridView.DataSource = this.vehicleBindingSource;
            this.vehicleDataGridView.Location = new System.Drawing.Point(43, 153);
            this.vehicleDataGridView.MultiSelect = false;
            this.vehicleDataGridView.Name = "vehicleDataGridView";
            this.vehicleDataGridView.ReadOnly = true;
            this.vehicleDataGridView.RowTemplate.Height = 24;
            this.vehicleDataGridView.Size = new System.Drawing.Size(761, 178);
            this.vehicleDataGridView.TabIndex = 0;
            this.vehicleDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehicleDataGridView_CellClick);
            this.vehicleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehicleDataGridView_CellContentClick);
            // 
            // VehicleID
            // 
            this.VehicleID.DataPropertyName = "VehicleID";
            this.VehicleID.HeaderText = "VehicleID";
            this.VehicleID.Name = "VehicleID";
            this.VehicleID.ReadOnly = true;
            this.VehicleID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Vehicle_Name
            // 
            this.Vehicle_Name.DataPropertyName = "Vehicle_Name";
            this.Vehicle_Name.HeaderText = "Vehicle_Name";
            this.Vehicle_Name.Name = "Vehicle_Name";
            this.Vehicle_Name.ReadOnly = true;
            this.Vehicle_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn46.HeaderText = "Price";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            this.dataGridViewTextBoxColumn46.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "Vehicle_Type";
            this.dataGridViewTextBoxColumn47.HeaderText = "Vehicle_Type";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.ReadOnly = true;
            this.dataGridViewTextBoxColumn47.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "Capacity";
            this.dataGridViewTextBoxColumn48.HeaderText = "Capacity";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.ReadOnly = true;
            this.dataGridViewTextBoxColumn48.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "Gear";
            this.dataGridViewTextBoxColumn49.HeaderText = "Gear";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.ReadOnly = true;
            this.dataGridViewTextBoxColumn49.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn50.HeaderText = "Color";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.ReadOnly = true;
            this.dataGridViewTextBoxColumn50.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Attraction
            // 
            this.Attraction.AutoScroll = true;
            this.Attraction.Controls.Add(this.attractionDataGridView);
            this.Attraction.Location = new System.Drawing.Point(4, 22);
            this.Attraction.Name = "Attraction";
            this.Attraction.Size = new System.Drawing.Size(830, 336);
            this.Attraction.TabIndex = 3;
            this.Attraction.Text = "Attraction";
            this.Attraction.UseVisualStyleBackColor = true;
            // 
            // attractionDataGridView
            // 
            this.attractionDataGridView.AllowUserToAddRows = false;
            this.attractionDataGridView.AllowUserToDeleteRows = false;
            this.attractionDataGridView.AutoGenerateColumns = false;
            this.attractionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attractionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttractName,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn41,
            this.Visitor,
            this.dataGridViewTextBoxColumn43});
            this.attractionDataGridView.DataSource = this.attractBindingSource;
            this.attractionDataGridView.Location = new System.Drawing.Point(3, 3);
            this.attractionDataGridView.MultiSelect = false;
            this.attractionDataGridView.Name = "attractionDataGridView";
            this.attractionDataGridView.ReadOnly = true;
            this.attractionDataGridView.RowTemplate.Height = 24;
            this.attractionDataGridView.Size = new System.Drawing.Size(824, 327);
            this.attractionDataGridView.TabIndex = 0;
            this.attractionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.attractionDataGridView_CellContentClick);
            // 
            // AttractName
            // 
            this.AttractName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AttractName.DataPropertyName = "AttractName";
            this.AttractName.HeaderText = "AttractName";
            this.AttractName.Name = "AttractName";
            this.AttractName.ReadOnly = true;
            this.AttractName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AttractName.Width = 72;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn40.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            this.dataGridViewTextBoxColumn40.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn44.HeaderText = "City";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            this.dataGridViewTextBoxColumn44.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "Cancellation";
            this.dataGridViewTextBoxColumn41.HeaderText = "Cancellation";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            this.dataGridViewTextBoxColumn41.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Visitor
            // 
            this.Visitor.DataPropertyName = "Visitor";
            this.Visitor.HeaderText = "Visitor";
            this.Visitor.Name = "Visitor";
            this.Visitor.ReadOnly = true;
            this.Visitor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn43.HeaderText = "Price";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            this.dataGridViewTextBoxColumn43.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cruise
            // 
            this.Cruise.AutoScroll = true;
            this.Cruise.Controls.Add(this.cruiseDataGridView);
            this.Cruise.Location = new System.Drawing.Point(4, 22);
            this.Cruise.Name = "Cruise";
            this.Cruise.Size = new System.Drawing.Size(830, 336);
            this.Cruise.TabIndex = 2;
            this.Cruise.Text = "Cruise";
            this.Cruise.UseVisualStyleBackColor = true;
            // 
            // cruiseDataGridView
            // 
            this.cruiseDataGridView.AllowUserToAddRows = false;
            this.cruiseDataGridView.AllowUserToDeleteRows = false;
            this.cruiseDataGridView.AutoGenerateColumns = false;
            this.cruiseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cruiseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn34,
            this.cruiseNo_admin,
            this.CruiseName,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37});
            this.cruiseDataGridView.DataSource = this.cruiseBindingSource;
            this.cruiseDataGridView.Location = new System.Drawing.Point(3, 0);
            this.cruiseDataGridView.Name = "cruiseDataGridView";
            this.cruiseDataGridView.ReadOnly = true;
            this.cruiseDataGridView.RowTemplate.Height = 24;
            this.cruiseDataGridView.Size = new System.Drawing.Size(824, 330);
            this.cruiseDataGridView.TabIndex = 0;
            this.cruiseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cruiseDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "OrganiserC";
            this.dataGridViewTextBoxColumn34.HeaderText = "OrganiserC";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            // 
            // cruiseNo_admin
            // 
            this.cruiseNo_admin.DataPropertyName = "CruiseNo";
            this.cruiseNo_admin.HeaderText = "CruiseNo";
            this.cruiseNo_admin.Name = "cruiseNo_admin";
            this.cruiseNo_admin.ReadOnly = true;
            // 
            // CruiseName
            // 
            this.CruiseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CruiseName.DataPropertyName = "CruiseName";
            this.CruiseName.HeaderText = "CruiseName";
            this.CruiseName.Name = "CruiseName";
            this.CruiseName.ReadOnly = true;
            this.CruiseName.Width = 89;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "TourDay";
            this.dataGridViewTextBoxColumn33.HeaderText = "TourDay";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "RefPrice";
            this.dataGridViewTextBoxColumn36.HeaderText = "RefPrice";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn37.HeaderText = "StartDate";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            // 
            // Hotel
            // 
            this.Hotel.AutoScroll = true;
            this.Hotel.Controls.Add(this.hotel_roomDataGridView);
            this.Hotel.Controls.Add(this.hotelDataGridView);
            this.Hotel.Location = new System.Drawing.Point(4, 22);
            this.Hotel.Name = "Hotel";
            this.Hotel.Padding = new System.Windows.Forms.Padding(3);
            this.Hotel.Size = new System.Drawing.Size(830, 336);
            this.Hotel.TabIndex = 1;
            this.Hotel.Text = "Hotel";
            this.Hotel.UseVisualStyleBackColor = true;
            // 
            // hotel_roomDataGridView
            // 
            this.hotel_roomDataGridView.AllowUserToAddRows = false;
            this.hotel_roomDataGridView.AllowUserToDeleteRows = false;
            this.hotel_roomDataGridView.AutoGenerateColumns = false;
            this.hotel_roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotel_roomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn25,
            this.HotelChiName,
            this.HotelRoom,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32});
            this.hotel_roomDataGridView.DataSource = this.hotel_roomBindingSource;
            this.hotel_roomDataGridView.Location = new System.Drawing.Point(6, 173);
            this.hotel_roomDataGridView.MultiSelect = false;
            this.hotel_roomDataGridView.Name = "hotel_roomDataGridView";
            this.hotel_roomDataGridView.ReadOnly = true;
            this.hotel_roomDataGridView.RowTemplate.Height = 24;
            this.hotel_roomDataGridView.Size = new System.Drawing.Size(821, 154);
            this.hotel_roomDataGridView.TabIndex = 1;
            this.hotel_roomDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hotel_roomDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "HotelID";
            this.dataGridViewTextBoxColumn25.HeaderText = "HotelID";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // HotelChiName
            // 
            this.HotelChiName.DataPropertyName = "Hotel_chi_name";
            this.HotelChiName.HeaderText = "Hotel_chi_name";
            this.HotelChiName.Name = "HotelChiName";
            this.HotelChiName.ReadOnly = true;
            // 
            // HotelRoom
            // 
            this.HotelRoom.DataPropertyName = "Hotel_room_name";
            this.HotelRoom.HeaderText = "Hotel_room_name";
            this.HotelRoom.Name = "HotelRoom";
            this.HotelRoom.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Hotel_room_size";
            this.dataGridViewTextBoxColumn28.HeaderText = "Hotel_room_size";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "max_adults";
            this.dataGridViewTextBoxColumn29.HeaderText = "max_adults";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "max_child";
            this.dataGridViewTextBoxColumn30.HeaderText = "max_child";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Hotel_room_description";
            this.dataGridViewTextBoxColumn31.HeaderText = "Hotel_room_description";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Fare";
            this.dataGridViewTextBoxColumn32.HeaderText = "Fare";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            // 
            // hotel_roomBindingSource
            // 
            this.hotel_roomBindingSource.DataMember = "HotelHotel_room";
            this.hotel_roomBindingSource.DataSource = this.hotelBindingSource;
            // 
            // hotelDataGridView
            // 
            this.hotelDataGridView.AllowUserToAddRows = false;
            this.hotelDataGridView.AllowUserToDeleteRows = false;
            this.hotelDataGridView.AutoGenerateColumns = false;
            this.hotelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.hotelDataGridView.DataSource = this.hotelBindingSource;
            this.hotelDataGridView.Location = new System.Drawing.Point(6, 7);
            this.hotelDataGridView.MultiSelect = false;
            this.hotelDataGridView.Name = "hotelDataGridView";
            this.hotelDataGridView.ReadOnly = true;
            this.hotelDataGridView.RowTemplate.Height = 24;
            this.hotelDataGridView.Size = new System.Drawing.Size(818, 160);
            this.hotelDataGridView.TabIndex = 0;
            this.hotelDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hotelDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "HotelID";
            this.dataGridViewTextBoxColumn17.HeaderText = "HotelID";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Hotel_chi_name";
            this.dataGridViewTextBoxColumn18.HeaderText = "Hotel_chi_name";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Hotel_en_name";
            this.dataGridViewTextBoxColumn19.HeaderText = "Hotel_en_name";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Star";
            this.dataGridViewTextBoxColumn20.HeaderText = "Star";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn21.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Region";
            this.dataGridViewTextBoxColumn22.HeaderText = "Region";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn23.HeaderText = "address";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "tel";
            this.dataGridViewTextBoxColumn24.HeaderText = "tel";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // Air_Flight
            // 
            this.Air_Flight.AutoScroll = true;
            this.Air_Flight.Controls.Add(this.directDefaultDataGridView);
            this.Air_Flight.Location = new System.Drawing.Point(4, 22);
            this.Air_Flight.Name = "Air_Flight";
            this.Air_Flight.Padding = new System.Windows.Forms.Padding(3);
            this.Air_Flight.Size = new System.Drawing.Size(830, 336);
            this.Air_Flight.TabIndex = 0;
            this.Air_Flight.Text = "Air_Flight";
            this.Air_Flight.UseVisualStyleBackColor = true;
            // 
            // directDefaultDataGridView
            // 
            this.directDefaultDataGridView.AllowUserToAddRows = false;
            this.directDefaultDataGridView.AllowUserToDeleteRows = false;
            this.directDefaultDataGridView.AutoGenerateColumns = false;
            this.directDefaultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directDefaultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlightID,
            this.dataGridViewTextBoxColumn1,
            this.FlightNo,
            this.ClassType,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn14,
            this.FlightType});
            this.directDefaultDataGridView.DataSource = this.directDefaultBindingSource;
            this.directDefaultDataGridView.Location = new System.Drawing.Point(6, 7);
            this.directDefaultDataGridView.MultiSelect = false;
            this.directDefaultDataGridView.Name = "directDefaultDataGridView";
            this.directDefaultDataGridView.ReadOnly = true;
            this.directDefaultDataGridView.RowTemplate.Height = 24;
            this.directDefaultDataGridView.Size = new System.Drawing.Size(821, 324);
            this.directDefaultDataGridView.TabIndex = 0;
            this.directDefaultDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.directDefaultDataGridView_CellContentClick);
            // 
            // FlightID
            // 
            this.FlightID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FlightID.DataPropertyName = "FlightID";
            this.FlightID.HeaderText = "FlightID";
            this.FlightID.Name = "FlightID";
            this.FlightID.ReadOnly = true;
            this.FlightID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FlightID.Width = 49;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CarrierName";
            this.dataGridViewTextBoxColumn1.HeaderText = "CarrierName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 71;
            // 
            // FlightNo
            // 
            this.FlightNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FlightNo.DataPropertyName = "FlightNo";
            this.FlightNo.HeaderText = "FlightNo";
            this.FlightNo.Name = "FlightNo";
            this.FlightNo.ReadOnly = true;
            this.FlightNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FlightNo.Width = 52;
            // 
            // ClassType
            // 
            this.ClassType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClassType.DataPropertyName = "Class";
            this.ClassType.HeaderText = "Class";
            this.ClassType.Name = "ClassType";
            this.ClassType.ReadOnly = true;
            this.ClassType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ClassType.Width = 38;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Price_Adult";
            this.dataGridViewTextBoxColumn6.HeaderText = "Price_Adult";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 67;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Price_Children";
            this.dataGridViewTextBoxColumn7.HeaderText = "Price_Children";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.Width = 81;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Price_Infant";
            this.dataGridViewTextBoxColumn8.HeaderText = "Price_Infant";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Departure_date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Departure_date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 87;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Departure_arrival";
            this.dataGridViewTextBoxColumn4.HeaderText = "Departure_arrival";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 94;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Departure_time";
            this.dataGridViewTextBoxColumn10.HeaderText = "Departure_time";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn10.Width = 85;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Arrival_time";
            this.dataGridViewTextBoxColumn11.HeaderText = "Arrival_time";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn11.Width = 67;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TravelTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "TravelTime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 66;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Origin";
            this.dataGridViewTextBoxColumn13.HeaderText = "Origin";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn13.Width = 40;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Dest";
            this.dataGridViewTextBoxColumn15.HeaderText = "Dest";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn15.Width = 35;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Aircraft";
            this.dataGridViewTextBoxColumn14.HeaderText = "Aircraft";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn14.Width = 46;
            // 
            // FlightType
            // 
            this.FlightType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FlightType.DataPropertyName = "FlightType";
            this.FlightType.HeaderText = "FlightType";
            this.FlightType.Name = "FlightType";
            this.FlightType.ReadOnly = true;
            this.FlightType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FlightType.Width = 62;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Air_Flight);
            this.tabControl1.Controls.Add(this.Hotel);
            this.tabControl1.Controls.Add(this.Cruise);
            this.tabControl1.Controls.Add(this.Attraction);
            this.tabControl1.Controls.Add(this.Vehicle);
            this.tabControl1.Controls.Add(this.Staff);
            this.tabControl1.Controls.Add(this.Customer);
            this.tabControl1.Location = new System.Drawing.Point(40, 96);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(838, 362);
            this.tabControl1.TabIndex = 43;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Air_flight.Properties.Resources.refresh_general_318_27897;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(40, 480);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 47);
            this.button5.TabIndex = 49;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Air_flight.Properties.Resources.list_512;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(12, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 47);
            this.button6.TabIndex = 38;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Air_flight.Properties.Resources.upload_arrow_318_26670;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(676, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 47);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button3.BackgroundImage = global::Air_flight.Properties.Resources.images2;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(814, 480);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 47);
            this.button3.TabIndex = 35;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Air_flight.Properties.Resources.add_icon_76240;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(529, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 47);
            this.button2.TabIndex = 34;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.BackColor = System.Drawing.Color.PowderBlue;
            this.label84.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label84.Location = new System.Drawing.Point(542, 530);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(34, 15);
            this.label84.TabIndex = 193;
            this.label84.Text = "Add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(682, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 194;
            this.label2.Text = "Update";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PowderBlue;
            this.label3.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(822, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 195;
            this.label3.Text = "Delete";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PowderBlue;
            this.label6.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(41, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 196;
            this.label6.Text = "Refresh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PowderBlue;
            this.label7.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(343, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 15);
            this.label7.TabIndex = 197;
            this.label7.Text = "Select a record to add,update or delete";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(931, 593);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label84);
            this.Controls.Add(this.directDefaultBindingNavigator);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "frmAdmin";
            this.Text = "Admintration system";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.directDefaultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directDefaultBindingNavigator)).EndInit();
            this.directDefaultBindingNavigator.ResumeLayout(false);
            this.directDefaultBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cruiseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cruiseBindingSource)).EndInit();
            this.Customer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.Staff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            this.Vehicle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).EndInit();
            this.Attraction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attractionDataGridView)).EndInit();
            this.Cruise.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cruiseDataGridView)).EndInit();
            this.Hotel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotel_roomDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataGridView)).EndInit();
            this.Air_Flight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.directDefaultDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private ticketDataSet ticketDataSet;
        private System.Windows.Forms.BindingSource directDefaultBindingSource;
        private ticketDataSetTableAdapters.DirectDefaultTableAdapter directDefaultTableAdapter;
        private ticketDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator directDefaultBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton directDefaultBindingNavigatorSaveItem;
        private AttractionDataSet attractionDataSet;
        private System.Windows.Forms.BindingSource attractBindingSource;
        private AttractionDataSetTableAdapters.DefaultTableAdapter attractTableAdapter;
        private AttractionDataSetTableAdapters.TableAdapterManager tableAdapterManager3;
        private VehicleDataSet vehicleDataSet;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private VehicleDataSetTableAdapters.VehicleTableAdapter vehicleTableAdapter;
        private VehicleDataSetTableAdapters.TableAdapterManager tableAdapterManager4;
        private VehicleDataSetTableAdapters.EquipmentTableAdapter equipmentTableAdapter;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private CustomerBookingDataSet customerBookingDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private CustomerBookingDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private CustomerBookingDataSetTableAdapters.TableAdapterManager tableAdapterManager5;
        private CustomerBookingDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private HotelDataSetTableAdapters.HotelTableAdapter hotelTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private HotelDataSetTableAdapters.Hotel_roomTableAdapter hotel_roomTableAdapter;
        private System.Windows.Forms.BindingSource hotel_roomBindingSource;
        private CruiseDataSet cruiseDataSet;
        private System.Windows.Forms.BindingSource cruiseBindingSource;
        private CruiseDataSetTableAdapters.DefaultTableAdapter cruiseTableAdapter;
        private CruiseDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.TabPage Customer;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.TabPage Staff;
        private System.Windows.Forms.DataGridView staffDataGridView;
        private System.Windows.Forms.TabPage Vehicle;
        private System.Windows.Forms.DataGridView equipmentDataGridView;
        private System.Windows.Forms.DataGridView vehicleDataGridView;
        private System.Windows.Forms.TabPage Attraction;
        private System.Windows.Forms.DataGridView attractionDataGridView;
        private System.Windows.Forms.TabPage Cruise;
        private System.Windows.Forms.DataGridView cruiseDataGridView;
        private System.Windows.Forms.TabPage Hotel;
        private System.Windows.Forms.DataGridView hotel_roomDataGridView;
        private System.Windows.Forms.DataGridView hotelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.TabPage Air_Flight;
        private System.Windows.Forms.DataGridView directDefaultDataGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelChiName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn GivenName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn69;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn73;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn cruiseNo_admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName_admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}