namespace Air_flight
{
    partial class frmCruiseTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCruiseTour));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.airFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attractionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.defaultDataGridView = new System.Windows.Forms.DataGridView();
            this.CruiseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrganiserC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CruiseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TourDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Book = new System.Windows.Forms.DataGridViewButtonColumn();
            this.defaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cruiseDataSet = new Air_flight.CruiseDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.defaultTableAdapter = new Air_flight.CruiseDataSetTableAdapters.DefaultTableAdapter();
            this.tableAdapterManager = new Air_flight.CruiseDataSetTableAdapters.TableAdapterManager();
            this.defaultBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.defaultBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ucSlideMenu1 = new Air_flight.ucSlideMenu();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cruiseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBindingNavigator)).BeginInit();
            this.defaultBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(332, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cruise Tour Enquiry";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(230, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(436, 45);
            this.label5.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(123, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 86);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Air_flight.Properties.Resources.undo_512;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(553, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 43);
            this.button2.TabIndex = 33;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(81, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Cruise organiser:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(135, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Start date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(248, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 22);
            this.dateTimePicker1.TabIndex = 31;
            this.dateTimePicker1.Value = new System.DateTime(2016, 6, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(248, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Air_flight.Properties.Resources._200px_magnifying_glass_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(437, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(35, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(609, 256);
            this.label7.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(42, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(809, 56);
            this.label1.TabIndex = 28;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::Air_flight.Properties.Resources.list_512;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.ContextMenuStrip = this.contextMenuStrip1;
            this.button7.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.Location = new System.Drawing.Point(8, 9);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 45);
            this.button7.TabIndex = 37;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.airFlightToolStripMenuItem,
            this.hotelToolStripMenuItem,
            this.attractionToolStripMenuItem,
            this.dataReportToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 114);
            // 
            // airFlightToolStripMenuItem
            // 
            this.airFlightToolStripMenuItem.Name = "airFlightToolStripMenuItem";
            this.airFlightToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.airFlightToolStripMenuItem.Text = "Air Flight";
            this.airFlightToolStripMenuItem.Click += new System.EventHandler(this.airFlightToolStripMenuItem_Click);
            // 
            // hotelToolStripMenuItem
            // 
            this.hotelToolStripMenuItem.Name = "hotelToolStripMenuItem";
            this.hotelToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.hotelToolStripMenuItem.Text = "Hotel";
            this.hotelToolStripMenuItem.Click += new System.EventHandler(this.hotelToolStripMenuItem_Click);
            // 
            // attractionToolStripMenuItem
            // 
            this.attractionToolStripMenuItem.Name = "attractionToolStripMenuItem";
            this.attractionToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.attractionToolStripMenuItem.Text = "Attraction";
            this.attractionToolStripMenuItem.Click += new System.EventHandler(this.attractionToolStripMenuItem_Click);
            // 
            // dataReportToolStripMenuItem
            // 
            this.dataReportToolStripMenuItem.Name = "dataReportToolStripMenuItem";
            this.dataReportToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.dataReportToolStripMenuItem.Text = "Data Report";
            this.dataReportToolStripMenuItem.Click += new System.EventHandler(this.dataReportToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(35, 155);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 374);
            this.tabControl1.TabIndex = 39;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.defaultDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Default";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // defaultDataGridView
            // 
            this.defaultDataGridView.AllowUserToAddRows = false;
            this.defaultDataGridView.AllowUserToDeleteRows = false;
            this.defaultDataGridView.AutoGenerateColumns = false;
            this.defaultDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.defaultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.defaultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CruiseNo,
            this.OrganiserC,
            this.CruiseName,
            this.TourDay,
            this.RefPrice,
            this.StartDate,
            this.Info,
            this.Book});
            this.defaultDataGridView.DataSource = this.defaultBindingSource;
            this.defaultDataGridView.Location = new System.Drawing.Point(3, 3);
            this.defaultDataGridView.MultiSelect = false;
            this.defaultDataGridView.Name = "defaultDataGridView";
            this.defaultDataGridView.ReadOnly = true;
            this.defaultDataGridView.RowTemplate.Height = 24;
            this.defaultDataGridView.Size = new System.Drawing.Size(799, 339);
            this.defaultDataGridView.TabIndex = 0;
            this.defaultDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.defaultDataGridView_CellContentClick_1);
            // 
            // CruiseNo
            // 
            this.CruiseNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CruiseNo.DataPropertyName = "CruiseNo";
            this.CruiseNo.Frozen = true;
            this.CruiseNo.HeaderText = "CruiseNo";
            this.CruiseNo.Name = "CruiseNo";
            this.CruiseNo.ReadOnly = true;
            this.CruiseNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CruiseNo.Width = 55;
            // 
            // OrganiserC
            // 
            this.OrganiserC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrganiserC.DataPropertyName = "OrganiserC";
            this.OrganiserC.HeaderText = "OrganiserC";
            this.OrganiserC.Name = "OrganiserC";
            this.OrganiserC.ReadOnly = true;
            this.OrganiserC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OrganiserC.Width = 64;
            // 
            // CruiseName
            // 
            this.CruiseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CruiseName.DataPropertyName = "CruiseName";
            this.CruiseName.HeaderText = "CruiseName";
            this.CruiseName.Name = "CruiseName";
            this.CruiseName.ReadOnly = true;
            this.CruiseName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CruiseName.Width = 68;
            // 
            // TourDay
            // 
            this.TourDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TourDay.DataPropertyName = "TourDay";
            this.TourDay.HeaderText = "TourDay";
            this.TourDay.Name = "TourDay";
            this.TourDay.ReadOnly = true;
            this.TourDay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TourDay.Width = 53;
            // 
            // RefPrice
            // 
            this.RefPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RefPrice.DataPropertyName = "RefPrice";
            this.RefPrice.HeaderText = "RefPrice";
            this.RefPrice.Name = "RefPrice";
            this.RefPrice.ReadOnly = true;
            this.RefPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RefPrice.Width = 51;
            // 
            // StartDate
            // 
            this.StartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "StartDate";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StartDate.Width = 53;
            // 
            // Info
            // 
            this.Info.HeaderText = "Info";
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Text = "Info";
            this.Info.UseColumnTextForButtonValue = true;
            // 
            // Book
            // 
            this.Book.HeaderText = "Book";
            this.Book.Name = "Book";
            this.Book.ReadOnly = true;
            this.Book.Text = "Order";
            this.Book.UseColumnTextForButtonValue = true;
            // 
            // defaultBindingSource
            // 
            this.defaultBindingSource.DataMember = "Default";
            this.defaultBindingSource.DataSource = this.cruiseDataSet;
            // 
            // cruiseDataSet
            // 
            this.cruiseDataSet.DataSetName = "CruiseDataSet";
            this.cruiseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(808, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Price";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(33, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 12);
            this.label6.TabIndex = 34;
            this.label6.Text = "Sorting by ascending order";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(732, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 12);
            this.label12.TabIndex = 47;
            this.label12.Text = "Staff: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(733, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 12);
            this.label8.TabIndex = 49;
            this.label8.Text = "Time:";
            // 
            // defaultTableAdapter
            // 
            this.defaultTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.COrganiserTableAdapter = null;
            this.tableAdapterManager.CruiseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Air_flight.CruiseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // defaultBindingNavigator
            // 
            this.defaultBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.defaultBindingNavigator.BindingSource = this.defaultBindingSource;
            this.defaultBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.defaultBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.defaultBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.defaultBindingNavigatorSaveItem});
            this.defaultBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.defaultBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.defaultBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.defaultBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.defaultBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.defaultBindingNavigator.Name = "defaultBindingNavigator";
            this.defaultBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.defaultBindingNavigator.Size = new System.Drawing.Size(741, 25);
            this.defaultBindingNavigator.TabIndex = 50;
            this.defaultBindingNavigator.Text = "bindingNavigator1";
            this.defaultBindingNavigator.Visible = false;
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
            // defaultBindingNavigatorSaveItem
            // 
            this.defaultBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.defaultBindingNavigatorSaveItem.Enabled = false;
            this.defaultBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("defaultBindingNavigatorSaveItem.Image")));
            this.defaultBindingNavigatorSaveItem.Name = "defaultBindingNavigatorSaveItem";
            this.defaultBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.defaultBindingNavigatorSaveItem.Text = "儲存資料";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucSlideMenu1
            // 
            this.ucSlideMenu1.Location = new System.Drawing.Point(0, -175);
            this.ucSlideMenu1.Name = "ucSlideMenu1";
            this.ucSlideMenu1.Size = new System.Drawing.Size(898, 125);
            this.ucSlideMenu1.TabIndex = 51;
            // 
            // frmCruiseTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::Air_flight.Properties.Resources.Blue_Sky_Sea_Beach_Hd_Desktop_Wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 597);
            this.Controls.Add(this.ucSlideMenu1);
            this.Controls.Add(this.defaultBindingNavigator);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Name = "frmCruiseTour";
            this.Text = "Cruise Tour Enquiry";
            this.Load += new System.EventHandler(this.frmCruiseTour_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cruiseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBindingNavigator)).EndInit();
            this.defaultBindingNavigator.ResumeLayout(false);
            this.defaultBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruisePrice;
        private CruiseDataSet cruiseDataSet;
        private System.Windows.Forms.BindingSource defaultBindingSource;
        private CruiseDataSetTableAdapters.DefaultTableAdapter defaultTableAdapter;
        private CruiseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator defaultBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton defaultBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView defaultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganiserC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewButtonColumn Info;
        private System.Windows.Forms.DataGridViewButtonColumn Book;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem airFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attractionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private ucSlideMenu ucSlideMenu1;
    }
}