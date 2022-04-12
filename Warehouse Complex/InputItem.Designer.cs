
namespace Warehouse_Complex
{
    partial class InputItem
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Поставки = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_weight = new System.Windows.Forms.TextBox();
            this.tb_nameGood = new System.Windows.Forms.TextBox();
            this.b_add = new System.Windows.Forms.Button();
            this.tb_fioGiver = new System.Windows.Forms.TextBox();
            this.cb_fio = new System.Windows.Forms.ComboBox();
            this.работникиСкладаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouse_ComplexDataSet = new Warehouse_Complex.Warehouse_ComplexDataSet();
            this.cb_nameSupplier = new System.Windows.Forms.ComboBox();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_size = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Расположение_товара = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_warehouse = new System.Windows.Forms.ComboBox();
            this.складыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.b_addLoc = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_numberShelf = new System.Windows.Forms.TextBox();
            this.cb_goodsLoc = new System.Windows.Forms.ComboBox();
            this.Поставщики = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.tb_nameSupp = new System.Windows.Forms.TextBox();
            this.tb_adress = new System.Windows.Forms.TextBox();
            this.b_addSupp = new System.Windows.Forms.Button();
            this.поставщикиTableAdapter = new Warehouse_Complex.Warehouse_ComplexDataSetTableAdapters.ПоставщикиTableAdapter();
            this.работники_складаTableAdapter = new Warehouse_Complex.Warehouse_ComplexDataSetTableAdapters.Работники_складаTableAdapter();
            this.складыTableAdapter = new Warehouse_Complex.Warehouse_ComplexDataSetTableAdapters.СкладыTableAdapter();
            this.wareHouseDataSet = new Warehouse_Complex.WareHouseDataSet();
            this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodTableAdapter = new Warehouse_Complex.WareHouseDataSetTableAdapters.GoodTableAdapter();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new Warehouse_Complex.WareHouseDataSetTableAdapters.SupplierTableAdapter();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseTableAdapter = new Warehouse_Complex.WareHouseDataSetTableAdapters.WarehouseTableAdapter();
            this.tabControl1.SuspendLayout();
            this.Поставки.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.работникиСкладаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_ComplexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            this.Расположение_товара.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.складыBindingSource)).BeginInit();
            this.Поставщики.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Поставки);
            this.tabControl1.Controls.Add(this.Расположение_товара);
            this.tabControl1.Controls.Add(this.Поставщики);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // Поставки
            // 
            this.Поставки.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.Поставки.Controls.Add(this.label6);
            this.Поставки.Controls.Add(this.label5);
            this.Поставки.Controls.Add(this.label4);
            this.Поставки.Controls.Add(this.label3);
            this.Поставки.Controls.Add(this.label2);
            this.Поставки.Controls.Add(this.label1);
            this.Поставки.Controls.Add(this.tb_weight);
            this.Поставки.Controls.Add(this.tb_nameGood);
            this.Поставки.Controls.Add(this.b_add);
            this.Поставки.Controls.Add(this.tb_fioGiver);
            this.Поставки.Controls.Add(this.cb_fio);
            this.Поставки.Controls.Add(this.cb_nameSupplier);
            this.Поставки.Controls.Add(this.cb_size);
            this.Поставки.Controls.Add(this.dateTimePicker);
            this.Поставки.Location = new System.Drawing.Point(4, 22);
            this.Поставки.Name = "Поставки";
            this.Поставки.Padding = new System.Windows.Forms.Padding(3);
            this.Поставки.Size = new System.Drawing.Size(792, 424);
            this.Поставки.TabIndex = 0;
            this.Поставки.Text = "Поставки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(472, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "ФИО сдавшего";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(472, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "ФИО принявшего";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(472, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Название поставщика";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(123, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Вес товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(123, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Размер товара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Название товара";
            // 
            // tb_weight
            // 
            this.tb_weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.tb_weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_weight.ForeColor = System.Drawing.Color.White;
            this.tb_weight.Location = new System.Drawing.Point(117, 268);
            this.tb_weight.Name = "tb_weight";
            this.tb_weight.Size = new System.Drawing.Size(208, 29);
            this.tb_weight.TabIndex = 14;
            // 
            // tb_nameGood
            // 
            this.tb_nameGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.tb_nameGood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_nameGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_nameGood.ForeColor = System.Drawing.Color.White;
            this.tb_nameGood.Location = new System.Drawing.Point(117, 135);
            this.tb_nameGood.Name = "tb_nameGood";
            this.tb_nameGood.Size = new System.Drawing.Size(208, 29);
            this.tb_nameGood.TabIndex = 13;
            // 
            // b_add
            // 
            this.b_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.b_add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_add.ForeColor = System.Drawing.Color.White;
            this.b_add.Location = new System.Drawing.Point(344, 325);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(111, 48);
            this.b_add.TabIndex = 12;
            this.b_add.Text = "Добавить";
            this.b_add.UseVisualStyleBackColor = false;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // tb_fioGiver
            // 
            this.tb_fioGiver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.tb_fioGiver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_fioGiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_fioGiver.ForeColor = System.Drawing.Color.White;
            this.tb_fioGiver.Location = new System.Drawing.Point(461, 268);
            this.tb_fioGiver.Name = "tb_fioGiver";
            this.tb_fioGiver.Size = new System.Drawing.Size(208, 29);
            this.tb_fioGiver.TabIndex = 11;
            // 
            // cb_fio
            // 
            this.cb_fio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.cb_fio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_fio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_fio.ForeColor = System.Drawing.Color.White;
            this.cb_fio.FormattingEnabled = true;
            this.cb_fio.Location = new System.Drawing.Point(461, 200);
            this.cb_fio.Name = "cb_fio";
            this.cb_fio.Size = new System.Drawing.Size(208, 32);
            this.cb_fio.TabIndex = 10;
            // 
            // работникиСкладаBindingSource
            // 
            this.работникиСкладаBindingSource.DataMember = "Работники склада";
            this.работникиСкладаBindingSource.DataSource = this.warehouse_ComplexDataSet;
            // 
            // warehouse_ComplexDataSet
            // 
            this.warehouse_ComplexDataSet.DataSetName = "Warehouse_ComplexDataSet";
            this.warehouse_ComplexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_nameSupplier
            // 
            this.cb_nameSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.cb_nameSupplier.DataSource = this.supplierBindingSource;
            this.cb_nameSupplier.DisplayMember = "Name";
            this.cb_nameSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nameSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_nameSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_nameSupplier.ForeColor = System.Drawing.Color.White;
            this.cb_nameSupplier.FormattingEnabled = true;
            this.cb_nameSupplier.Location = new System.Drawing.Point(461, 132);
            this.cb_nameSupplier.Name = "cb_nameSupplier";
            this.cb_nameSupplier.Size = new System.Drawing.Size(208, 32);
            this.cb_nameSupplier.TabIndex = 9;
            this.cb_nameSupplier.ValueMember = "Id";
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.warehouse_ComplexDataSet;
            // 
            // cb_size
            // 
            this.cb_size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.cb_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_size.ForeColor = System.Drawing.Color.White;
            this.cb_size.FormattingEnabled = true;
            this.cb_size.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.cb_size.Location = new System.Drawing.Point(117, 200);
            this.cb_size.Name = "cb_size";
            this.cb_size.Size = new System.Drawing.Size(208, 32);
            this.cb_size.TabIndex = 8;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(580, 12);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker.TabIndex = 7;
            // 
            // Расположение_товара
            // 
            this.Расположение_товара.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.Расположение_товара.Controls.Add(this.label12);
            this.Расположение_товара.Controls.Add(this.cb_warehouse);
            this.Расположение_товара.Controls.Add(this.b_addLoc);
            this.Расположение_товара.Controls.Add(this.label10);
            this.Расположение_товара.Controls.Add(this.label11);
            this.Расположение_товара.Controls.Add(this.tb_numberShelf);
            this.Расположение_товара.Controls.Add(this.cb_goodsLoc);
            this.Расположение_товара.Location = new System.Drawing.Point(4, 22);
            this.Расположение_товара.Name = "Расположение_товара";
            this.Расположение_товара.Size = new System.Drawing.Size(792, 424);
            this.Расположение_товара.TabIndex = 2;
            this.Расположение_товара.Text = "Расположение товара";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(362, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 24);
            this.label12.TabIndex = 27;
            this.label12.Text = "Склад";
            // 
            // cb_warehouse
            // 
            this.cb_warehouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_warehouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.cb_warehouse.DataSource = this.warehouseBindingSource;
            this.cb_warehouse.DisplayMember = "Title";
            this.cb_warehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_warehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_warehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_warehouse.ForeColor = System.Drawing.Color.White;
            this.cb_warehouse.FormattingEnabled = true;
            this.cb_warehouse.Location = new System.Drawing.Point(238, 184);
            this.cb_warehouse.Name = "cb_warehouse";
            this.cb_warehouse.Size = new System.Drawing.Size(317, 32);
            this.cb_warehouse.TabIndex = 26;
            this.cb_warehouse.ValueMember = "Id";
            // 
            // складыBindingSource
            // 
            this.складыBindingSource.DataMember = "Склады";
            this.складыBindingSource.DataSource = this.warehouse_ComplexDataSet;
            // 
            // b_addLoc
            // 
            this.b_addLoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.b_addLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.b_addLoc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b_addLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_addLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_addLoc.ForeColor = System.Drawing.Color.White;
            this.b_addLoc.Location = new System.Drawing.Point(344, 325);
            this.b_addLoc.Name = "b_addLoc";
            this.b_addLoc.Size = new System.Drawing.Size(111, 48);
            this.b_addLoc.TabIndex = 25;
            this.b_addLoc.Text = "Добавить";
            this.b_addLoc.UseVisualStyleBackColor = false;
            this.b_addLoc.Click += new System.EventHandler(this.b_addLoc_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(337, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "Номер полки";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(362, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "Товар";
            // 
            // tb_numberShelf
            // 
            this.tb_numberShelf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_numberShelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.tb_numberShelf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_numberShelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_numberShelf.ForeColor = System.Drawing.Color.White;
            this.tb_numberShelf.Location = new System.Drawing.Point(314, 254);
            this.tb_numberShelf.Name = "tb_numberShelf";
            this.tb_numberShelf.Size = new System.Drawing.Size(170, 29);
            this.tb_numberShelf.TabIndex = 22;
            // 
            // cb_goodsLoc
            // 
            this.cb_goodsLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_goodsLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.cb_goodsLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_goodsLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_goodsLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_goodsLoc.ForeColor = System.Drawing.Color.White;
            this.cb_goodsLoc.FormattingEnabled = true;
            this.cb_goodsLoc.Location = new System.Drawing.Point(238, 116);
            this.cb_goodsLoc.Name = "cb_goodsLoc";
            this.cb_goodsLoc.Size = new System.Drawing.Size(317, 32);
            this.cb_goodsLoc.TabIndex = 21;
            // 
            // Поставщики
            // 
            this.Поставщики.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.Поставщики.Controls.Add(this.label9);
            this.Поставщики.Controls.Add(this.label8);
            this.Поставщики.Controls.Add(this.label7);
            this.Поставщики.Controls.Add(this.tb_number);
            this.Поставщики.Controls.Add(this.tb_nameSupp);
            this.Поставщики.Controls.Add(this.tb_adress);
            this.Поставщики.Controls.Add(this.b_addSupp);
            this.Поставщики.Location = new System.Drawing.Point(4, 22);
            this.Поставщики.Name = "Поставщики";
            this.Поставщики.Padding = new System.Windows.Forms.Padding(3);
            this.Поставщики.Size = new System.Drawing.Size(792, 424);
            this.Поставщики.TabIndex = 1;
            this.Поставщики.Text = "Поставщики";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(347, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Телефон";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(297, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Юридический адрес";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(272, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Наименование  поставщика";
            // 
            // tb_number
            // 
            this.tb_number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.tb_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_number.ForeColor = System.Drawing.Color.White;
            this.tb_number.Location = new System.Drawing.Point(305, 254);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(178, 29);
            this.tb_number.TabIndex = 3;
            // 
            // tb_nameSupp
            // 
            this.tb_nameSupp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_nameSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.tb_nameSupp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_nameSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_nameSupp.ForeColor = System.Drawing.Color.White;
            this.tb_nameSupp.Location = new System.Drawing.Point(241, 116);
            this.tb_nameSupp.Name = "tb_nameSupp";
            this.tb_nameSupp.Size = new System.Drawing.Size(317, 29);
            this.tb_nameSupp.TabIndex = 2;
            // 
            // tb_adress
            // 
            this.tb_adress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_adress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.tb_adress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_adress.ForeColor = System.Drawing.Color.White;
            this.tb_adress.Location = new System.Drawing.Point(241, 184);
            this.tb_adress.Name = "tb_adress";
            this.tb_adress.Size = new System.Drawing.Size(317, 29);
            this.tb_adress.TabIndex = 1;
            // 
            // b_addSupp
            // 
            this.b_addSupp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.b_addSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.b_addSupp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b_addSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_addSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_addSupp.ForeColor = System.Drawing.Color.White;
            this.b_addSupp.Location = new System.Drawing.Point(344, 325);
            this.b_addSupp.Name = "b_addSupp";
            this.b_addSupp.Size = new System.Drawing.Size(111, 48);
            this.b_addSupp.TabIndex = 0;
            this.b_addSupp.Text = "Добавить";
            this.b_addSupp.UseVisualStyleBackColor = false;
            this.b_addSupp.Click += new System.EventHandler(this.b_addSupp_Click);
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // работники_складаTableAdapter
            // 
            this.работники_складаTableAdapter.ClearBeforeFill = true;
            // 
            // складыTableAdapter
            // 
            this.складыTableAdapter.ClearBeforeFill = true;
            // 
            // wareHouseDataSet
            // 
            this.wareHouseDataSet.DataSetName = "WareHouseDataSet";
            this.wareHouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goodBindingSource
            // 
            this.goodBindingSource.DataMember = "Good";
            this.goodBindingSource.DataSource = this.wareHouseDataSet;
            // 
            // goodTableAdapter
            // 
            this.goodTableAdapter.ClearBeforeFill = true;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.wareHouseDataSet;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataMember = "Warehouse";
            this.warehouseBindingSource.DataSource = this.wareHouseDataSet;
            // 
            // warehouseTableAdapter
            // 
            this.warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // InputItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputItem";
            this.Text = "InputItem";
            this.Load += new System.EventHandler(this.InputItem_Load);
            this.tabControl1.ResumeLayout(false);
            this.Поставки.ResumeLayout(false);
            this.Поставки.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.работникиСкладаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_ComplexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            this.Расположение_товара.ResumeLayout(false);
            this.Расположение_товара.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.складыBindingSource)).EndInit();
            this.Поставщики.ResumeLayout(false);
            this.Поставщики.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Поставки;
        private System.Windows.Forms.TextBox tb_weight;
        private System.Windows.Forms.TextBox tb_nameGood;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.TextBox tb_fioGiver;
        private System.Windows.Forms.ComboBox cb_fio;
        private System.Windows.Forms.ComboBox cb_nameSupplier;
        private System.Windows.Forms.ComboBox cb_size;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TabPage Поставщики;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Warehouse_ComplexDataSet warehouse_ComplexDataSet;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private Warehouse_ComplexDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private System.Windows.Forms.BindingSource работникиСкладаBindingSource;
        private Warehouse_ComplexDataSetTableAdapters.Работники_складаTableAdapter работники_складаTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.TextBox tb_nameSupp;
        private System.Windows.Forms.TextBox tb_adress;
        private System.Windows.Forms.Button b_addSupp;
        private System.Windows.Forms.TabPage Расположение_товара;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_warehouse;
        private System.Windows.Forms.Button b_addLoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_numberShelf;
        private System.Windows.Forms.ComboBox cb_goodsLoc;
        private System.Windows.Forms.BindingSource складыBindingSource;
        private Warehouse_ComplexDataSetTableAdapters.СкладыTableAdapter складыTableAdapter;
        private WareHouseDataSet wareHouseDataSet;
        private System.Windows.Forms.BindingSource goodBindingSource;
        private WareHouseDataSetTableAdapters.GoodTableAdapter goodTableAdapter;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private WareHouseDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private WareHouseDataSetTableAdapters.WarehouseTableAdapter warehouseTableAdapter;
    }
}