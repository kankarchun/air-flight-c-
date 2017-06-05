namespace Air_flight
{
    partial class frmAttraction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttraction));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.airFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cruiseTourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.attractionDataSet = new Air_flight.AttractionDataSet();
            this.defaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.defaultTableAdapter = new Air_flight.AttractionDataSetTableAdapters.DefaultTableAdapter();
            this.tableAdapterManager = new Air_flight.AttractionDataSetTableAdapters.TableAdapterManager();
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
            this.defaultDataGridView = new System.Windows.Forms.DataGridView();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttractName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancellation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttractPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ucSlideMenu1 = new Air_flight.ucSlideMenu();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attractionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBindingNavigator)).BeginInit();
            this.defaultBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(424, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Attraction Enquiry";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(249, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(560, 45);
            this.label5.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(401, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(296, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "City search: ";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Air_flight.Properties.Resources._200px_magnifying_glass_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(618, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 49);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(29, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(931, 52);
            this.label2.TabIndex = 30;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Air_flight.Properties.Resources.list_512;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ContextMenuStrip = this.contextMenuStrip1;
            this.button2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(12, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 45);
            this.button2.TabIndex = 37;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.airFlightToolStripMenuItem,
            this.hotelToolStripMenuItem,
            this.cruiseTourToolStripMenuItem,
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
            // cruiseTourToolStripMenuItem
            // 
            this.cruiseTourToolStripMenuItem.Name = "cruiseTourToolStripMenuItem";
            this.cruiseTourToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.cruiseTourToolStripMenuItem.Text = "Cruise Tour";
            this.cruiseTourToolStripMenuItem.Click += new System.EventHandler(this.cruiseTourToolStripMenuItem_Click);
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
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Aqua;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(29, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(931, 326);
            this.label3.TabIndex = 39;
            // 
            // attractionDataSet
            // 
            this.attractionDataSet.DataSetName = "AttractionDataSet";
            this.attractionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // defaultBindingSource
            // 
            this.defaultBindingSource.DataMember = "Default";
            this.defaultBindingSource.DataSource = this.attractionDataSet;
            // 
            // defaultTableAdapter
            // 
            this.defaultTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttractionTableAdapter = null;
            this.tableAdapterManager.AttractPriceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Air_flight.AttractionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.defaultBindingNavigator.Size = new System.Drawing.Size(684, 25);
            this.defaultBindingNavigator.TabIndex = 40;
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
            // defaultDataGridView
            // 
            this.defaultDataGridView.AllowUserToAddRows = false;
            this.defaultDataGridView.AllowUserToDeleteRows = false;
            this.defaultDataGridView.AutoGenerateColumns = false;
            this.defaultDataGridView.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.defaultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.defaultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.City,
            this.AttractName,
            this.Duration,
            this.Cancellation,
            this.Visitor,
            this.AttractPrice,
            this.Book});
            this.defaultDataGridView.DataSource = this.defaultBindingSource;
            this.defaultDataGridView.GridColor = System.Drawing.SystemColors.Info;
            this.defaultDataGridView.Location = new System.Drawing.Point(49, 204);
            this.defaultDataGridView.Name = "defaultDataGridView";
            this.defaultDataGridView.ReadOnly = true;
            this.defaultDataGridView.RowTemplate.Height = 24;
            this.defaultDataGridView.Size = new System.Drawing.Size(660, 288);
            this.defaultDataGridView.TabIndex = 40;
            this.defaultDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.defaultDataGridView_CellContentClick);
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.City.Width = 31;
            // 
            // AttractName
            // 
            this.AttractName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AttractName.DataPropertyName = "AttractName";
            this.AttractName.HeaderText = "AttractName";
            this.AttractName.Name = "AttractName";
            this.AttractName.ReadOnly = true;
            this.AttractName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AttractName.Width = 69;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cancellation
            // 
            this.Cancellation.DataPropertyName = "Cancellation";
            this.Cancellation.HeaderText = "Cancellation";
            this.Cancellation.Name = "Cancellation";
            this.Cancellation.ReadOnly = true;
            this.Cancellation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Visitor
            // 
            this.Visitor.DataPropertyName = "Visitor";
            this.Visitor.HeaderText = "Visitor";
            this.Visitor.Name = "Visitor";
            this.Visitor.ReadOnly = true;
            this.Visitor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Visitor.Visible = false;
            // 
            // AttractPrice
            // 
            this.AttractPrice.DataPropertyName = "Price";
            this.AttractPrice.HeaderText = "Price";
            this.AttractPrice.Name = "AttractPrice";
            this.AttractPrice.ReadOnly = true;
            this.AttractPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Book
            // 
            this.Book.HeaderText = "Book";
            this.Book.Name = "Book";
            this.Book.ReadOnly = true;
            this.Book.Text = "Order";
            this.Book.UseColumnTextForButtonValue = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Air_flight.Properties.Resources.undo_512;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(747, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 50);
            this.button3.TabIndex = 42;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(853, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 12);
            this.label12.TabIndex = 47;
            this.label12.Text = "Staff: ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox4.Location = new System.Drawing.Point(734, 241);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(207, 153);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(853, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 49;
            this.label6.Text = "Time:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(69, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 86);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PowderBlue;
            this.label8.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(772, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Attraction date:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(767, 213);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 22);
            this.dateTimePicker1.TabIndex = 31;
            this.dateTimePicker1.Value = new System.DateTime(2016, 5, 28, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucSlideMenu1
            // 
            this.ucSlideMenu1.Location = new System.Drawing.Point(0, -175);
            this.ucSlideMenu1.Name = "ucSlideMenu1";
            this.ucSlideMenu1.Size = new System.Drawing.Size(1010, 125);
            this.ucSlideMenu1.TabIndex = 51;
            // 
            // frmAttraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 617);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ucSlideMenu1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.defaultDataGridView);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.defaultBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "frmAttraction";
            this.Text = "Attraction Enquiry";
            this.Load += new System.EventHandler(this.frmAttraction_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attractionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBindingNavigator)).EndInit();
            this.defaultBindingNavigator.ResumeLayout(false);
            this.defaultBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private AttractionDataSet attractionDataSet;
        private System.Windows.Forms.BindingSource defaultBindingSource;
        private AttractionDataSetTableAdapters.DefaultTableAdapter defaultTableAdapter;
        private AttractionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem airFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cruiseTourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cancellation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractPrice;
        private System.Windows.Forms.DataGridViewButtonColumn Book;
        private ucSlideMenu ucSlideMenu1;
    }
}