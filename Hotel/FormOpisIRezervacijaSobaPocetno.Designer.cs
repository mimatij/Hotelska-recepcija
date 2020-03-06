namespace Hotel
{
    partial class FormOpisIRezervacijaSobaPocetno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpisIRezervacijaSobaPocetno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hotelDataSet = new Hotel.HotelDataSet();
            this.OsobljeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OsobljeTableAdapter = new Hotel.HotelDataSetTableAdapters.OSOBLJETableAdapter();
            this.tableAdapterManager = new Hotel.HotelDataSetTableAdapters.TableAdapterManager();
            this.OsobljeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.oSOBLJEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.SobeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SobeTableAdapter = new Hotel.HotelDataSetTableAdapters.SOBETableAdapter();
            this.SobeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_filterLijeviStupac = new System.Windows.Forms.TableLayoutPanel();
            this.lb_brojsobe = new System.Windows.Forms.Label();
            this.lb_katsobe = new System.Windows.Forms.Label();
            this.lb_cijenasobe = new System.Windows.Forms.Label();
            this.lb_apartman = new System.Windows.Forms.Label();
            this.lb_pogledmore = new System.Windows.Forms.Label();
            this.lb_klima = new System.Windows.Forms.Label();
            this.lb_tv = new System.Windows.Forms.Label();
            this.lb_jacuzzi = new System.Windows.Forms.Label();
            this.lb_sauna = new System.Windows.Forms.Label();
            this.lb_brojkreveta = new System.Windows.Forms.Label();
            this.lb_bracnikreveti = new System.Windows.Forms.Label();
            this.lb_obicnikreveti = new System.Windows.Forms.Label();
            this.lbl_soba = new System.Windows.Forms.Label();
            this.lb_filter = new System.Windows.Forms.Label();
            this.tbl_filterDesniStupac1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_katsobe = new System.Windows.Forms.TextBox();
            this.tb_brojsobe = new System.Windows.Forms.TextBox();
            this.tbl_filterDesniStupac2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_cijenasobeOd = new System.Windows.Forms.TextBox();
            this.tb_cijenasobeDo = new System.Windows.Forms.TextBox();
            this.lb_minus = new System.Windows.Forms.Label();
            this.tbl_filterDesniStupac3 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_soba = new System.Windows.Forms.CheckBox();
            this.cb_sauna = new System.Windows.Forms.CheckBox();
            this.cb_jacuzzi = new System.Windows.Forms.CheckBox();
            this.cb_tv = new System.Windows.Forms.CheckBox();
            this.cb_klima = new System.Windows.Forms.CheckBox();
            this.cb_pogledmore = new System.Windows.Forms.CheckBox();
            this.cb_apartman = new System.Windows.Forms.CheckBox();
            this.tbl_filterDesniStupac4 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_brojkreveta = new System.Windows.Forms.TextBox();
            this.tb_bracnikreveti = new System.Windows.Forms.TextBox();
            this.tb_obicnikreveti = new System.Windows.Forms.TextBox();
            this.btn_rezerviraj = new System.Windows.Forms.Button();
            this.date_od = new System.Windows.Forms.DateTimePicker();
            this.date_do = new System.Windows.Forms.DateTimePicker();
            this.lb_datumDolaska = new System.Windows.Forms.Label();
            this.lb_datumOdlaska = new System.Windows.Forms.Label();
            this.pnl_filter = new System.Windows.Forms.Panel();
            this.btn_primijeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OsobljeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OsobljeBindingNavigator)).BeginInit();
            this.OsobljeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SobeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SobeDataGridView)).BeginInit();
            this.tbl_filterLijeviStupac.SuspendLayout();
            this.tbl_filterDesniStupac1.SuspendLayout();
            this.tbl_filterDesniStupac2.SuspendLayout();
            this.tbl_filterDesniStupac3.SuspendLayout();
            this.tbl_filterDesniStupac4.SuspendLayout();
            this.pnl_filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OsobljeBindingSource
            // 
            this.OsobljeBindingSource.DataMember = "OSOBLJE";
            this.OsobljeBindingSource.DataSource = this.hotelDataSet;
            // 
            // OsobljeTableAdapter
            // 
            this.OsobljeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OSOBLJETableAdapter = this.OsobljeTableAdapter;
            this.tableAdapterManager.RASPOREDTableAdapter = null;
            this.tableAdapterManager.REZERVACIJE_SOBATableAdapter = null;
            this.tableAdapterManager.REZERVACIJE_USLUGATableAdapter = null;
            this.tableAdapterManager.SOBETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hotel.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USLUGETableAdapter = null;
            // 
            // OsobljeBindingNavigator
            // 
            this.OsobljeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.OsobljeBindingNavigator.BindingSource = this.OsobljeBindingSource;
            this.OsobljeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.OsobljeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.OsobljeBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsobljeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.OsobljeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.oSOBLJEBindingNavigatorSaveItem});
            this.OsobljeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.OsobljeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.OsobljeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.OsobljeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.OsobljeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.OsobljeBindingNavigator.Name = "OsobljeBindingNavigator";
            this.OsobljeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.OsobljeBindingNavigator.Size = new System.Drawing.Size(1380, 28);
            this.OsobljeBindingNavigator.TabIndex = 0;
            this.OsobljeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(56, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // oSOBLJEBindingNavigatorSaveItem
            // 
            this.oSOBLJEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oSOBLJEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oSOBLJEBindingNavigatorSaveItem.Image")));
            this.oSOBLJEBindingNavigatorSaveItem.Name = "oSOBLJEBindingNavigatorSaveItem";
            this.oSOBLJEBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 25);
            this.oSOBLJEBindingNavigatorSaveItem.Text = "Save Data";
            this.oSOBLJEBindingNavigatorSaveItem.Click += new System.EventHandler(this.OsobljeBindingNavigatorSaveItem_Click);
            // 
            // SobeBindingSource
            // 
            this.SobeBindingSource.DataMember = "SOBE";
            this.SobeBindingSource.DataSource = this.hotelDataSet;
            // 
            // SobeTableAdapter
            // 
            this.SobeTableAdapter.ClearBeforeFill = true;
            // 
            // SobeDataGridView
            // 
            this.SobeDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SobeDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SobeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SobeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SobeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewCheckBoxColumn5,
            this.dataGridViewCheckBoxColumn6,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.SobeDataGridView.DataSource = this.SobeBindingSource;
            this.SobeDataGridView.Location = new System.Drawing.Point(13, 66);
            this.SobeDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.SobeDataGridView.Name = "SobeDataGridView";
            this.SobeDataGridView.RowHeadersWidth = 21;
            this.SobeDataGridView.Size = new System.Drawing.Size(996, 491);
            this.SobeDataGridView.TabIndex = 3;
            this.SobeDataGridView.SelectionChanged += new System.EventHandler(this.SobeDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn8.HeaderText = "Id";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Kat";
            this.dataGridViewTextBoxColumn9.HeaderText = "Kat";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Cijena";
            this.dataGridViewTextBoxColumn10.HeaderText = "Cijena";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Apartman";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Apartman";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Pogled_na_more";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Pogled na more";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 125;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Klima";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Klima";
            this.dataGridViewCheckBoxColumn3.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Width = 125;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "TV";
            this.dataGridViewCheckBoxColumn4.HeaderText = "TV";
            this.dataGridViewCheckBoxColumn4.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.Width = 125;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "Jacuzzi";
            this.dataGridViewCheckBoxColumn5.HeaderText = "Jacuzzi";
            this.dataGridViewCheckBoxColumn5.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.Width = 125;
            // 
            // dataGridViewCheckBoxColumn6
            // 
            this.dataGridViewCheckBoxColumn6.DataPropertyName = "Sauna";
            this.dataGridViewCheckBoxColumn6.HeaderText = "Sauna";
            this.dataGridViewCheckBoxColumn6.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
            this.dataGridViewCheckBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Broj_kreveta";
            this.dataGridViewTextBoxColumn11.HeaderText = "Broj_kreveta";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Bracni_kreveti";
            this.dataGridViewTextBoxColumn12.HeaderText = "Bracni_kreveti";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Obicni_kreveti";
            this.dataGridViewTextBoxColumn13.HeaderText = "Obicni_kreveti";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // tbl_filterLijeviStupac
            // 
            this.tbl_filterLijeviStupac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_filterLijeviStupac.ColumnCount = 1;
            this.tbl_filterLijeviStupac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_filterLijeviStupac.Controls.Add(this.lb_brojsobe, 0, 0);
            this.tbl_filterLijeviStupac.Controls.Add(this.lb_katsobe, 0, 1);
            this.tbl_filterLijeviStupac.Controls.Add(this.lb_cijenasobe, 0, 2);
            this.tbl_filterLijeviStupac.Controls.Add(this.lb_apartman, 0, 4);
            this.tbl_filterLijeviStupac.Controls.Add(this.lb_pogledmore, 0, 5);
            this.tbl_filterLijeviStupac.Controls.Add(this.lb_klima, 0, 6);
            this.tbl_filterLijeviStupac.Controls.Add(this.lb_tv, 0, 7);
            this.tbl_filterLijeviStupac.Controls.Add(this.lb_jacuzzi, 0, 8);
            this.tbl_filterLijeviStupac.Controls.Add(this.lb_sauna, 0, 9);
            this.tbl_filterLijeviStupac.Controls.Add(this.lb_brojkreveta, 0, 10);
            this.tbl_filterLijeviStupac.Controls.Add(this.lb_bracnikreveti, 0, 11);
            this.tbl_filterLijeviStupac.Controls.Add(this.lb_obicnikreveti, 0, 12);
            this.tbl_filterLijeviStupac.Controls.Add(this.lbl_soba, 0, 3);
            this.tbl_filterLijeviStupac.Location = new System.Drawing.Point(19, 202);
            this.tbl_filterLijeviStupac.Margin = new System.Windows.Forms.Padding(4);
            this.tbl_filterLijeviStupac.Name = "tbl_filterLijeviStupac";
            this.tbl_filterLijeviStupac.RowCount = 13;
            this.tbl_filterLijeviStupac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterLijeviStupac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterLijeviStupac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterLijeviStupac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterLijeviStupac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterLijeviStupac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterLijeviStupac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterLijeviStupac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterLijeviStupac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterLijeviStupac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterLijeviStupac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterLijeviStupac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterLijeviStupac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterLijeviStupac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_filterLijeviStupac.Size = new System.Drawing.Size(121, 412);
            this.tbl_filterLijeviStupac.TabIndex = 5;
            // 
            // lb_brojsobe
            // 
            this.lb_brojsobe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_brojsobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_brojsobe.Location = new System.Drawing.Point(4, 0);
            this.lb_brojsobe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_brojsobe.Name = "lb_brojsobe";
            this.lb_brojsobe.Size = new System.Drawing.Size(113, 31);
            this.lb_brojsobe.TabIndex = 7;
            this.lb_brojsobe.Text = "Broj sobe:";
            // 
            // lb_katsobe
            // 
            this.lb_katsobe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_katsobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_katsobe.Location = new System.Drawing.Point(4, 31);
            this.lb_katsobe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_katsobe.Name = "lb_katsobe";
            this.lb_katsobe.Size = new System.Drawing.Size(113, 31);
            this.lb_katsobe.TabIndex = 8;
            this.lb_katsobe.Text = "Kat:";
            // 
            // lb_cijenasobe
            // 
            this.lb_cijenasobe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_cijenasobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cijenasobe.Location = new System.Drawing.Point(4, 62);
            this.lb_cijenasobe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cijenasobe.Name = "lb_cijenasobe";
            this.lb_cijenasobe.Size = new System.Drawing.Size(113, 31);
            this.lb_cijenasobe.TabIndex = 9;
            this.lb_cijenasobe.Text = "Cijena (od-do):";
            // 
            // lb_apartman
            // 
            this.lb_apartman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_apartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_apartman.Location = new System.Drawing.Point(4, 124);
            this.lb_apartman.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_apartman.Name = "lb_apartman";
            this.lb_apartman.Size = new System.Drawing.Size(113, 31);
            this.lb_apartman.TabIndex = 10;
            this.lb_apartman.Text = "Apartman:";
            // 
            // lb_pogledmore
            // 
            this.lb_pogledmore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_pogledmore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pogledmore.Location = new System.Drawing.Point(4, 155);
            this.lb_pogledmore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pogledmore.Name = "lb_pogledmore";
            this.lb_pogledmore.Size = new System.Drawing.Size(113, 31);
            this.lb_pogledmore.TabIndex = 11;
            this.lb_pogledmore.Text = "Pogled na more:";
            // 
            // lb_klima
            // 
            this.lb_klima.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_klima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_klima.Location = new System.Drawing.Point(4, 186);
            this.lb_klima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_klima.Name = "lb_klima";
            this.lb_klima.Size = new System.Drawing.Size(113, 31);
            this.lb_klima.TabIndex = 12;
            this.lb_klima.Text = "Klima:";
            // 
            // lb_tv
            // 
            this.lb_tv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_tv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tv.Location = new System.Drawing.Point(4, 217);
            this.lb_tv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tv.Name = "lb_tv";
            this.lb_tv.Size = new System.Drawing.Size(113, 31);
            this.lb_tv.TabIndex = 13;
            this.lb_tv.Text = "TV:";
            // 
            // lb_jacuzzi
            // 
            this.lb_jacuzzi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_jacuzzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_jacuzzi.Location = new System.Drawing.Point(4, 248);
            this.lb_jacuzzi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_jacuzzi.Name = "lb_jacuzzi";
            this.lb_jacuzzi.Size = new System.Drawing.Size(113, 31);
            this.lb_jacuzzi.TabIndex = 14;
            this.lb_jacuzzi.Text = "Jacuzzi:";
            // 
            // lb_sauna
            // 
            this.lb_sauna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_sauna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sauna.Location = new System.Drawing.Point(4, 279);
            this.lb_sauna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_sauna.Name = "lb_sauna";
            this.lb_sauna.Size = new System.Drawing.Size(113, 31);
            this.lb_sauna.TabIndex = 15;
            this.lb_sauna.Text = "Sauna:";
            // 
            // lb_brojkreveta
            // 
            this.lb_brojkreveta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_brojkreveta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_brojkreveta.Location = new System.Drawing.Point(4, 310);
            this.lb_brojkreveta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_brojkreveta.Name = "lb_brojkreveta";
            this.lb_brojkreveta.Size = new System.Drawing.Size(113, 31);
            this.lb_brojkreveta.TabIndex = 16;
            this.lb_brojkreveta.Text = "Broj kreveta:";
            // 
            // lb_bracnikreveti
            // 
            this.lb_bracnikreveti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_bracnikreveti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bracnikreveti.Location = new System.Drawing.Point(4, 341);
            this.lb_bracnikreveti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_bracnikreveti.Name = "lb_bracnikreveti";
            this.lb_bracnikreveti.Size = new System.Drawing.Size(113, 31);
            this.lb_bracnikreveti.TabIndex = 17;
            this.lb_bracnikreveti.Text = "Bračni kreveti:";
            // 
            // lb_obicnikreveti
            // 
            this.lb_obicnikreveti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_obicnikreveti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_obicnikreveti.Location = new System.Drawing.Point(4, 372);
            this.lb_obicnikreveti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_obicnikreveti.Name = "lb_obicnikreveti";
            this.lb_obicnikreveti.Size = new System.Drawing.Size(113, 40);
            this.lb_obicnikreveti.TabIndex = 18;
            this.lb_obicnikreveti.Text = "Obični kreveti:";
            // 
            // lbl_soba
            // 
            this.lbl_soba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_soba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soba.Location = new System.Drawing.Point(3, 93);
            this.lbl_soba.Name = "lbl_soba";
            this.lbl_soba.Size = new System.Drawing.Size(115, 31);
            this.lbl_soba.TabIndex = 19;
            this.lbl_soba.Text = "Soba:";
            // 
            // lb_filter
            // 
            this.lb_filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_filter.AutoSize = true;
            this.lb_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_filter.Location = new System.Drawing.Point(120, 12);
            this.lb_filter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_filter.Name = "lb_filter";
            this.lb_filter.Size = new System.Drawing.Size(65, 25);
            this.lb_filter.TabIndex = 6;
            this.lb_filter.Text = "Filteri";
            // 
            // tbl_filterDesniStupac1
            // 
            this.tbl_filterDesniStupac1.ColumnCount = 1;
            this.tbl_filterDesniStupac1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tbl_filterDesniStupac1.Controls.Add(this.tb_katsobe, 0, 1);
            this.tbl_filterDesniStupac1.Controls.Add(this.tb_brojsobe, 0, 0);
            this.tbl_filterDesniStupac1.Location = new System.Drawing.Point(144, 198);
            this.tbl_filterDesniStupac1.Margin = new System.Windows.Forms.Padding(4);
            this.tbl_filterDesniStupac1.Name = "tbl_filterDesniStupac1";
            this.tbl_filterDesniStupac1.RowCount = 2;
            this.tbl_filterDesniStupac1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterDesniStupac1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterDesniStupac1.Size = new System.Drawing.Size(119, 62);
            this.tbl_filterDesniStupac1.TabIndex = 8;
            // 
            // tb_katsobe
            // 
            this.tb_katsobe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_katsobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_katsobe.Location = new System.Drawing.Point(4, 35);
            this.tb_katsobe.Margin = new System.Windows.Forms.Padding(4);
            this.tb_katsobe.Name = "tb_katsobe";
            this.tb_katsobe.Size = new System.Drawing.Size(111, 24);
            this.tb_katsobe.TabIndex = 1;
            // 
            // tb_brojsobe
            // 
            this.tb_brojsobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_brojsobe.Location = new System.Drawing.Point(4, 4);
            this.tb_brojsobe.Margin = new System.Windows.Forms.Padding(4);
            this.tb_brojsobe.Name = "tb_brojsobe";
            this.tb_brojsobe.Size = new System.Drawing.Size(109, 24);
            this.tb_brojsobe.TabIndex = 0;
            // 
            // tbl_filterDesniStupac2
            // 
            this.tbl_filterDesniStupac2.ColumnCount = 3;
            this.tbl_filterDesniStupac2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tbl_filterDesniStupac2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbl_filterDesniStupac2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tbl_filterDesniStupac2.Controls.Add(this.tb_cijenasobeOd, 0, 0);
            this.tbl_filterDesniStupac2.Controls.Add(this.tb_cijenasobeDo, 2, 0);
            this.tbl_filterDesniStupac2.Controls.Add(this.lb_minus, 1, 0);
            this.tbl_filterDesniStupac2.Location = new System.Drawing.Point(144, 260);
            this.tbl_filterDesniStupac2.Margin = new System.Windows.Forms.Padding(4);
            this.tbl_filterDesniStupac2.Name = "tbl_filterDesniStupac2";
            this.tbl_filterDesniStupac2.RowCount = 1;
            this.tbl_filterDesniStupac2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tbl_filterDesniStupac2.Size = new System.Drawing.Size(119, 34);
            this.tbl_filterDesniStupac2.TabIndex = 9;
            // 
            // tb_cijenasobeOd
            // 
            this.tb_cijenasobeOd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_cijenasobeOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cijenasobeOd.Location = new System.Drawing.Point(4, 4);
            this.tb_cijenasobeOd.Margin = new System.Windows.Forms.Padding(4);
            this.tb_cijenasobeOd.Name = "tb_cijenasobeOd";
            this.tb_cijenasobeOd.Size = new System.Drawing.Size(39, 24);
            this.tb_cijenasobeOd.TabIndex = 0;
            // 
            // tb_cijenasobeDo
            // 
            this.tb_cijenasobeDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_cijenasobeDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cijenasobeDo.Location = new System.Drawing.Point(76, 4);
            this.tb_cijenasobeDo.Margin = new System.Windows.Forms.Padding(4);
            this.tb_cijenasobeDo.Name = "tb_cijenasobeDo";
            this.tb_cijenasobeDo.Size = new System.Drawing.Size(39, 24);
            this.tb_cijenasobeDo.TabIndex = 1;
            // 
            // lb_minus
            // 
            this.lb_minus.AutoSize = true;
            this.lb_minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_minus.Location = new System.Drawing.Point(51, 0);
            this.lb_minus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_minus.Name = "lb_minus";
            this.lb_minus.Size = new System.Drawing.Size(17, 34);
            this.lb_minus.TabIndex = 2;
            this.lb_minus.Text = "-";
            this.lb_minus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbl_filterDesniStupac3
            // 
            this.tbl_filterDesniStupac3.ColumnCount = 1;
            this.tbl_filterDesniStupac3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tbl_filterDesniStupac3.Controls.Add(this.cb_soba, 0, 0);
            this.tbl_filterDesniStupac3.Controls.Add(this.cb_sauna, 0, 6);
            this.tbl_filterDesniStupac3.Controls.Add(this.cb_jacuzzi, 0, 5);
            this.tbl_filterDesniStupac3.Controls.Add(this.cb_tv, 0, 4);
            this.tbl_filterDesniStupac3.Controls.Add(this.cb_klima, 0, 3);
            this.tbl_filterDesniStupac3.Controls.Add(this.cb_pogledmore, 0, 2);
            this.tbl_filterDesniStupac3.Controls.Add(this.cb_apartman, 0, 1);
            this.tbl_filterDesniStupac3.Location = new System.Drawing.Point(183, 294);
            this.tbl_filterDesniStupac3.Margin = new System.Windows.Forms.Padding(4);
            this.tbl_filterDesniStupac3.Name = "tbl_filterDesniStupac3";
            this.tbl_filterDesniStupac3.RowCount = 7;
            this.tbl_filterDesniStupac3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterDesniStupac3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterDesniStupac3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterDesniStupac3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterDesniStupac3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterDesniStupac3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterDesniStupac3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterDesniStupac3.Size = new System.Drawing.Size(41, 210);
            this.tbl_filterDesniStupac3.TabIndex = 10;
            // 
            // cb_soba
            // 
            this.cb_soba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_soba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_soba.Location = new System.Drawing.Point(3, 3);
            this.cb_soba.Name = "cb_soba";
            this.cb_soba.Size = new System.Drawing.Size(35, 25);
            this.cb_soba.TabIndex = 19;
            this.cb_soba.UseVisualStyleBackColor = true;
            // 
            // cb_sauna
            // 
            this.cb_sauna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_sauna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sauna.Location = new System.Drawing.Point(4, 190);
            this.cb_sauna.Margin = new System.Windows.Forms.Padding(4);
            this.cb_sauna.Name = "cb_sauna";
            this.cb_sauna.Size = new System.Drawing.Size(33, 23);
            this.cb_sauna.TabIndex = 17;
            this.cb_sauna.UseVisualStyleBackColor = true;
            // 
            // cb_jacuzzi
            // 
            this.cb_jacuzzi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_jacuzzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_jacuzzi.Location = new System.Drawing.Point(4, 159);
            this.cb_jacuzzi.Margin = new System.Windows.Forms.Padding(4);
            this.cb_jacuzzi.Name = "cb_jacuzzi";
            this.cb_jacuzzi.Size = new System.Drawing.Size(33, 23);
            this.cb_jacuzzi.TabIndex = 16;
            this.cb_jacuzzi.UseVisualStyleBackColor = true;
            // 
            // cb_tv
            // 
            this.cb_tv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_tv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tv.Location = new System.Drawing.Point(4, 128);
            this.cb_tv.Margin = new System.Windows.Forms.Padding(4);
            this.cb_tv.Name = "cb_tv";
            this.cb_tv.Size = new System.Drawing.Size(33, 23);
            this.cb_tv.TabIndex = 15;
            this.cb_tv.UseVisualStyleBackColor = true;
            // 
            // cb_klima
            // 
            this.cb_klima.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_klima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_klima.Location = new System.Drawing.Point(4, 97);
            this.cb_klima.Margin = new System.Windows.Forms.Padding(4);
            this.cb_klima.Name = "cb_klima";
            this.cb_klima.Size = new System.Drawing.Size(33, 23);
            this.cb_klima.TabIndex = 14;
            this.cb_klima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_klima.UseVisualStyleBackColor = true;
            // 
            // cb_pogledmore
            // 
            this.cb_pogledmore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_pogledmore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pogledmore.Location = new System.Drawing.Point(4, 66);
            this.cb_pogledmore.Margin = new System.Windows.Forms.Padding(4);
            this.cb_pogledmore.Name = "cb_pogledmore";
            this.cb_pogledmore.Size = new System.Drawing.Size(33, 23);
            this.cb_pogledmore.TabIndex = 13;
            this.cb_pogledmore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_pogledmore.UseVisualStyleBackColor = true;
            // 
            // cb_apartman
            // 
            this.cb_apartman.AutoSize = true;
            this.cb_apartman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_apartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_apartman.Location = new System.Drawing.Point(4, 35);
            this.cb_apartman.Margin = new System.Windows.Forms.Padding(4);
            this.cb_apartman.Name = "cb_apartman";
            this.cb_apartman.Size = new System.Drawing.Size(33, 23);
            this.cb_apartman.TabIndex = 12;
            this.cb_apartman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_apartman.UseVisualStyleBackColor = true;
            // 
            // tbl_filterDesniStupac4
            // 
            this.tbl_filterDesniStupac4.ColumnCount = 1;
            this.tbl_filterDesniStupac4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tbl_filterDesniStupac4.Controls.Add(this.tb_brojkreveta, 0, 0);
            this.tbl_filterDesniStupac4.Controls.Add(this.tb_bracnikreveti, 0, 1);
            this.tbl_filterDesniStupac4.Controls.Add(this.tb_obicnikreveti, 0, 2);
            this.tbl_filterDesniStupac4.Location = new System.Drawing.Point(144, 508);
            this.tbl_filterDesniStupac4.Margin = new System.Windows.Forms.Padding(4);
            this.tbl_filterDesniStupac4.Name = "tbl_filterDesniStupac4";
            this.tbl_filterDesniStupac4.RowCount = 3;
            this.tbl_filterDesniStupac4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterDesniStupac4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterDesniStupac4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tbl_filterDesniStupac4.Size = new System.Drawing.Size(119, 90);
            this.tbl_filterDesniStupac4.TabIndex = 11;
            // 
            // tb_brojkreveta
            // 
            this.tb_brojkreveta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_brojkreveta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_brojkreveta.Location = new System.Drawing.Point(4, 4);
            this.tb_brojkreveta.Margin = new System.Windows.Forms.Padding(4);
            this.tb_brojkreveta.Name = "tb_brojkreveta";
            this.tb_brojkreveta.Size = new System.Drawing.Size(111, 24);
            this.tb_brojkreveta.TabIndex = 0;
            // 
            // tb_bracnikreveti
            // 
            this.tb_bracnikreveti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_bracnikreveti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bracnikreveti.Location = new System.Drawing.Point(4, 35);
            this.tb_bracnikreveti.Margin = new System.Windows.Forms.Padding(4);
            this.tb_bracnikreveti.Name = "tb_bracnikreveti";
            this.tb_bracnikreveti.Size = new System.Drawing.Size(111, 24);
            this.tb_bracnikreveti.TabIndex = 1;
            // 
            // tb_obicnikreveti
            // 
            this.tb_obicnikreveti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_obicnikreveti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_obicnikreveti.Location = new System.Drawing.Point(4, 66);
            this.tb_obicnikreveti.Margin = new System.Windows.Forms.Padding(4);
            this.tb_obicnikreveti.Name = "tb_obicnikreveti";
            this.tb_obicnikreveti.Size = new System.Drawing.Size(111, 24);
            this.tb_obicnikreveti.TabIndex = 2;
            // 
            // btn_rezerviraj
            // 
            this.btn_rezerviraj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_rezerviraj.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_rezerviraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rezerviraj.Location = new System.Drawing.Point(391, 609);
            this.btn_rezerviraj.Margin = new System.Windows.Forms.Padding(4);
            this.btn_rezerviraj.Name = "btn_rezerviraj";
            this.btn_rezerviraj.Size = new System.Drawing.Size(197, 71);
            this.btn_rezerviraj.TabIndex = 12;
            this.btn_rezerviraj.Text = "REZERVIRAJ";
            this.btn_rezerviraj.UseVisualStyleBackColor = false;
            this.btn_rezerviraj.Click += new System.EventHandler(this.btn_rezerviraj_Click);
            // 
            // date_od
            // 
            this.date_od.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_od.Location = new System.Drawing.Point(19, 68);
            this.date_od.Margin = new System.Windows.Forms.Padding(4);
            this.date_od.Name = "date_od";
            this.date_od.Size = new System.Drawing.Size(265, 24);
            this.date_od.TabIndex = 13;
            // 
            // date_do
            // 
            this.date_do.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_do.Location = new System.Drawing.Point(19, 142);
            this.date_do.Margin = new System.Windows.Forms.Padding(4);
            this.date_do.Name = "date_do";
            this.date_do.Size = new System.Drawing.Size(265, 24);
            this.date_do.TabIndex = 14;
            // 
            // lb_datumDolaska
            // 
            this.lb_datumDolaska.AutoSize = true;
            this.lb_datumDolaska.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_datumDolaska.Location = new System.Drawing.Point(19, 48);
            this.lb_datumDolaska.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_datumDolaska.Name = "lb_datumDolaska";
            this.lb_datumDolaska.Size = new System.Drawing.Size(126, 18);
            this.lb_datumDolaska.TabIndex = 15;
            this.lb_datumDolaska.Text = "Datum dolaska:";
            // 
            // lb_datumOdlaska
            // 
            this.lb_datumOdlaska.AutoSize = true;
            this.lb_datumOdlaska.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_datumOdlaska.Location = new System.Drawing.Point(15, 122);
            this.lb_datumOdlaska.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_datumOdlaska.Name = "lb_datumOdlaska";
            this.lb_datumOdlaska.Size = new System.Drawing.Size(126, 18);
            this.lb_datumOdlaska.TabIndex = 16;
            this.lb_datumOdlaska.Text = "Datum odlaska:";
            // 
            // pnl_filter
            // 
            this.pnl_filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_filter.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnl_filter.Controls.Add(this.btn_primijeni);
            this.pnl_filter.Controls.Add(this.lb_filter);
            this.pnl_filter.Controls.Add(this.lb_datumOdlaska);
            this.pnl_filter.Controls.Add(this.tbl_filterLijeviStupac);
            this.pnl_filter.Controls.Add(this.lb_datumDolaska);
            this.pnl_filter.Controls.Add(this.tbl_filterDesniStupac1);
            this.pnl_filter.Controls.Add(this.date_do);
            this.pnl_filter.Controls.Add(this.tbl_filterDesniStupac2);
            this.pnl_filter.Controls.Add(this.date_od);
            this.pnl_filter.Controls.Add(this.tbl_filterDesniStupac3);
            this.pnl_filter.Controls.Add(this.tbl_filterDesniStupac4);
            this.pnl_filter.Location = new System.Drawing.Point(1036, 66);
            this.pnl_filter.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_filter.Name = "pnl_filter";
            this.pnl_filter.Size = new System.Drawing.Size(295, 696);
            this.pnl_filter.TabIndex = 17;
            // 
            // btn_primijeni
            // 
            this.btn_primijeni.BackColor = System.Drawing.Color.Lavender;
            this.btn_primijeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_primijeni.Location = new System.Drawing.Point(88, 631);
            this.btn_primijeni.Margin = new System.Windows.Forms.Padding(4);
            this.btn_primijeni.Name = "btn_primijeni";
            this.btn_primijeni.Size = new System.Drawing.Size(112, 52);
            this.btn_primijeni.TabIndex = 17;
            this.btn_primijeni.Text = "Primijeni";
            this.btn_primijeni.UseVisualStyleBackColor = false;
            this.btn_primijeni.Click += new System.EventHandler(this.btn_primijeni_Click);
            // 
            // FormOpisIRezervacijaSobaPocetno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1380, 792);
            this.Controls.Add(this.pnl_filter);
            this.Controls.Add(this.btn_rezerviraj);
            this.Controls.Add(this.SobeDataGridView);
            this.Controls.Add(this.OsobljeBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOpisIRezervacijaSobaPocetno";
            this.Text = "Opis i rezervacija soba";
            this.Load += new System.EventHandler(this.FormOpisIRezervacijaSobaPocetno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OsobljeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OsobljeBindingNavigator)).EndInit();
            this.OsobljeBindingNavigator.ResumeLayout(false);
            this.OsobljeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SobeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SobeDataGridView)).EndInit();
            this.tbl_filterLijeviStupac.ResumeLayout(false);
            this.tbl_filterDesniStupac1.ResumeLayout(false);
            this.tbl_filterDesniStupac1.PerformLayout();
            this.tbl_filterDesniStupac2.ResumeLayout(false);
            this.tbl_filterDesniStupac2.PerformLayout();
            this.tbl_filterDesniStupac3.ResumeLayout(false);
            this.tbl_filterDesniStupac3.PerformLayout();
            this.tbl_filterDesniStupac4.ResumeLayout(false);
            this.tbl_filterDesniStupac4.PerformLayout();
            this.pnl_filter.ResumeLayout(false);
            this.pnl_filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource OsobljeBindingSource;
        private HotelDataSetTableAdapters.OSOBLJETableAdapter OsobljeTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator OsobljeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton oSOBLJEBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource SobeBindingSource;
        private HotelDataSetTableAdapters.SOBETableAdapter SobeTableAdapter;
        private System.Windows.Forms.DataGridView SobeDataGridView;
        private System.Windows.Forms.TableLayoutPanel tbl_filterLijeviStupac;
        private System.Windows.Forms.Label lb_brojsobe;
        private System.Windows.Forms.Label lb_katsobe;
        private System.Windows.Forms.Label lb_cijenasobe;
        private System.Windows.Forms.Label lb_apartman;
        private System.Windows.Forms.Label lb_pogledmore;
        private System.Windows.Forms.Label lb_klima;
        private System.Windows.Forms.Label lb_tv;
        private System.Windows.Forms.Label lb_jacuzzi;
        private System.Windows.Forms.Label lb_sauna;
        private System.Windows.Forms.Label lb_brojkreveta;
        private System.Windows.Forms.Label lb_bracnikreveti;
        private System.Windows.Forms.Label lb_obicnikreveti;
        private System.Windows.Forms.Label lb_filter;
        private System.Windows.Forms.TableLayoutPanel tbl_filterDesniStupac1;
        private System.Windows.Forms.TableLayoutPanel tbl_filterDesniStupac2;
        private System.Windows.Forms.TableLayoutPanel tbl_filterDesniStupac3;
        private System.Windows.Forms.TableLayoutPanel tbl_filterDesniStupac4;
        private System.Windows.Forms.TextBox tb_brojsobe;
        private System.Windows.Forms.TextBox tb_katsobe;
        private System.Windows.Forms.TextBox tb_cijenasobeOd;
        private System.Windows.Forms.TextBox tb_cijenasobeDo;
        private System.Windows.Forms.Label lb_minus;
        private System.Windows.Forms.TextBox tb_brojkreveta;
        private System.Windows.Forms.TextBox tb_bracnikreveti;
        private System.Windows.Forms.TextBox tb_obicnikreveti;
        private System.Windows.Forms.CheckBox cb_jacuzzi;
        private System.Windows.Forms.CheckBox cb_tv;
        private System.Windows.Forms.CheckBox cb_klima;
        private System.Windows.Forms.CheckBox cb_pogledmore;
        private System.Windows.Forms.CheckBox cb_apartman;
        private System.Windows.Forms.CheckBox cb_sauna;
        private System.Windows.Forms.Button btn_rezerviraj;
        private System.Windows.Forms.DateTimePicker date_od;
        private System.Windows.Forms.DateTimePicker date_do;
        private System.Windows.Forms.Label lb_datumDolaska;
        private System.Windows.Forms.Label lb_datumOdlaska;
        private System.Windows.Forms.Panel pnl_filter;
        private System.Windows.Forms.Button btn_primijeni;
        private System.Windows.Forms.Label lbl_soba;
        private System.Windows.Forms.CheckBox cb_soba;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}