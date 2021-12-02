
namespace Warehouse_Complex
{
    partial class Directory
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_warehouses = new System.Windows.Forms.TabPage();
            this.tp_goods = new System.Windows.Forms.TabPage();
            this.tp_recipients = new System.Windows.Forms.TabPage();
            this.tp_suppliers = new System.Windows.Forms.TabPage();
            this.tp_warehouseWorkers = new System.Windows.Forms.TabPage();
            this.tb_searcherGood = new System.Windows.Forms.TextBox();
            this.cb_columnsGood = new System.Windows.Forms.ComboBox();
            this.dataGridView_Good = new System.Windows.Forms.DataGridView();
            this.tb_searcherRecipients = new System.Windows.Forms.TextBox();
            this.cb_columnsRecipients = new System.Windows.Forms.ComboBox();
            this.dataGridView_Recipients = new System.Windows.Forms.DataGridView();
            this.tb_searcherSuppliers = new System.Windows.Forms.TextBox();
            this.cb_columnsSuppliers = new System.Windows.Forms.ComboBox();
            this.dataGridView_Suppliers = new System.Windows.Forms.DataGridView();
            this.tb_searcherWarehouseWorkers = new System.Windows.Forms.TextBox();
            this.cb_columnsWarehouseWorkers = new System.Windows.Forms.ComboBox();
            this.dataGridView_WarehouseWorkers = new System.Windows.Forms.DataGridView();
            this.dataGridView_Warehouse = new System.Windows.Forms.DataGridView();
            this.cb_columnsWarehouse = new System.Windows.Forms.ComboBox();
            this.tb_searcherWarehouse = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tp_warehouses.SuspendLayout();
            this.tp_goods.SuspendLayout();
            this.tp_recipients.SuspendLayout();
            this.tp_suppliers.SuspendLayout();
            this.tp_warehouseWorkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Good)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Recipients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Suppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_WarehouseWorkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Warehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_warehouses);
            this.tabControl1.Controls.Add(this.tp_goods);
            this.tabControl1.Controls.Add(this.tp_recipients);
            this.tabControl1.Controls.Add(this.tp_suppliers);
            this.tabControl1.Controls.Add(this.tp_warehouseWorkers);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_warehouses
            // 
            this.tp_warehouses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tp_warehouses.Controls.Add(this.tb_searcherWarehouse);
            this.tp_warehouses.Controls.Add(this.cb_columnsWarehouse);
            this.tp_warehouses.Controls.Add(this.dataGridView_Warehouse);
            this.tp_warehouses.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tp_warehouses.Location = new System.Drawing.Point(4, 22);
            this.tp_warehouses.Name = "tp_warehouses";
            this.tp_warehouses.Padding = new System.Windows.Forms.Padding(3);
            this.tp_warehouses.Size = new System.Drawing.Size(792, 424);
            this.tp_warehouses.TabIndex = 1;
            this.tp_warehouses.Text = "Склады";
            // 
            // tp_goods
            // 
            this.tp_goods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tp_goods.Controls.Add(this.tb_searcherGood);
            this.tp_goods.Controls.Add(this.cb_columnsGood);
            this.tp_goods.Controls.Add(this.dataGridView_Good);
            this.tp_goods.Location = new System.Drawing.Point(4, 22);
            this.tp_goods.Name = "tp_goods";
            this.tp_goods.Padding = new System.Windows.Forms.Padding(3);
            this.tp_goods.Size = new System.Drawing.Size(792, 424);
            this.tp_goods.TabIndex = 2;
            this.tp_goods.Text = "Товары";
            // 
            // tp_recipients
            // 
            this.tp_recipients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tp_recipients.Controls.Add(this.tb_searcherRecipients);
            this.tp_recipients.Controls.Add(this.cb_columnsRecipients);
            this.tp_recipients.Controls.Add(this.dataGridView_Recipients);
            this.tp_recipients.Location = new System.Drawing.Point(4, 22);
            this.tp_recipients.Name = "tp_recipients";
            this.tp_recipients.Padding = new System.Windows.Forms.Padding(3);
            this.tp_recipients.Size = new System.Drawing.Size(792, 424);
            this.tp_recipients.TabIndex = 3;
            this.tp_recipients.Text = "Получатели";
            // 
            // tp_suppliers
            // 
            this.tp_suppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tp_suppliers.Controls.Add(this.tb_searcherSuppliers);
            this.tp_suppliers.Controls.Add(this.cb_columnsSuppliers);
            this.tp_suppliers.Controls.Add(this.dataGridView_Suppliers);
            this.tp_suppliers.Location = new System.Drawing.Point(4, 22);
            this.tp_suppliers.Name = "tp_suppliers";
            this.tp_suppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tp_suppliers.Size = new System.Drawing.Size(792, 424);
            this.tp_suppliers.TabIndex = 4;
            this.tp_suppliers.Text = "Поставщики";
            // 
            // tp_warehouseWorkers
            // 
            this.tp_warehouseWorkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tp_warehouseWorkers.Controls.Add(this.tb_searcherWarehouseWorkers);
            this.tp_warehouseWorkers.Controls.Add(this.cb_columnsWarehouseWorkers);
            this.tp_warehouseWorkers.Controls.Add(this.dataGridView_WarehouseWorkers);
            this.tp_warehouseWorkers.Location = new System.Drawing.Point(4, 22);
            this.tp_warehouseWorkers.Name = "tp_warehouseWorkers";
            this.tp_warehouseWorkers.Padding = new System.Windows.Forms.Padding(3);
            this.tp_warehouseWorkers.Size = new System.Drawing.Size(792, 424);
            this.tp_warehouseWorkers.TabIndex = 5;
            this.tp_warehouseWorkers.Text = "Работники склада";
            // 
            // tb_searcherGood
            // 
            this.tb_searcherGood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_searcherGood.Location = new System.Drawing.Point(252, 58);
            this.tb_searcherGood.Name = "tb_searcherGood";
            this.tb_searcherGood.Size = new System.Drawing.Size(281, 20);
            this.tb_searcherGood.TabIndex = 5;
            this.tb_searcherGood.TextChanged += new System.EventHandler(this.tb_searcherGood_TextChanged);
            // 
            // cb_columnsGood
            // 
            this.cb_columnsGood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_columnsGood.FormattingEnabled = true;
            this.cb_columnsGood.Items.AddRange(new object[] {
            "Название",
            "Размер",
            "Состояние",
            "Название склада",
            "Id"});
            this.cb_columnsGood.Location = new System.Drawing.Point(332, 31);
            this.cb_columnsGood.Name = "cb_columnsGood";
            this.cb_columnsGood.Size = new System.Drawing.Size(121, 21);
            this.cb_columnsGood.TabIndex = 4;
            this.cb_columnsGood.Text = "Название";
            // 
            // dataGridView_Good
            // 
            this.dataGridView_Good.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Good.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Good.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Good.Location = new System.Drawing.Point(3, 84);
            this.dataGridView_Good.Name = "dataGridView_Good";
            this.dataGridView_Good.Size = new System.Drawing.Size(786, 337);
            this.dataGridView_Good.TabIndex = 3;
            // 
            // tb_searcherRecipients
            // 
            this.tb_searcherRecipients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_searcherRecipients.Location = new System.Drawing.Point(252, 58);
            this.tb_searcherRecipients.Name = "tb_searcherRecipients";
            this.tb_searcherRecipients.Size = new System.Drawing.Size(281, 20);
            this.tb_searcherRecipients.TabIndex = 5;
            this.tb_searcherRecipients.TextChanged += new System.EventHandler(this.tb_searcherRecipients_TextChanged);
            // 
            // cb_columnsRecipients
            // 
            this.cb_columnsRecipients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_columnsRecipients.FormattingEnabled = true;
            this.cb_columnsRecipients.Items.AddRange(new object[] {
            "Наименование получателя",
            "Юридический адрес",
            "Телефон",
            "Id"});
            this.cb_columnsRecipients.Location = new System.Drawing.Point(332, 31);
            this.cb_columnsRecipients.Name = "cb_columnsRecipients";
            this.cb_columnsRecipients.Size = new System.Drawing.Size(121, 21);
            this.cb_columnsRecipients.TabIndex = 4;
            this.cb_columnsRecipients.Text = "Наименование получателя";
            // 
            // dataGridView_Recipients
            // 
            this.dataGridView_Recipients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Recipients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Recipients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Recipients.Location = new System.Drawing.Point(3, 84);
            this.dataGridView_Recipients.Name = "dataGridView_Recipients";
            this.dataGridView_Recipients.Size = new System.Drawing.Size(786, 310);
            this.dataGridView_Recipients.TabIndex = 3;
            // 
            // tb_searcherSuppliers
            // 
            this.tb_searcherSuppliers.Location = new System.Drawing.Point(252, 58);
            this.tb_searcherSuppliers.Name = "tb_searcherSuppliers";
            this.tb_searcherSuppliers.Size = new System.Drawing.Size(281, 20);
            this.tb_searcherSuppliers.TabIndex = 5;
            this.tb_searcherSuppliers.TextChanged += new System.EventHandler(this.tb_searcherSuppliers_TextChanged);
            // 
            // cb_columnsSuppliers
            // 
            this.cb_columnsSuppliers.FormattingEnabled = true;
            this.cb_columnsSuppliers.Items.AddRange(new object[] {
            "Наименование поставщика",
            "Юридический адрес",
            "Телефон",
            "Id"});
            this.cb_columnsSuppliers.Location = new System.Drawing.Point(332, 31);
            this.cb_columnsSuppliers.Name = "cb_columnsSuppliers";
            this.cb_columnsSuppliers.Size = new System.Drawing.Size(121, 21);
            this.cb_columnsSuppliers.TabIndex = 4;
            this.cb_columnsSuppliers.Text = "Наименование поставщика";
            // 
            // dataGridView_Suppliers
            // 
            this.dataGridView_Suppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Suppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Suppliers.Location = new System.Drawing.Point(3, 84);
            this.dataGridView_Suppliers.Name = "dataGridView_Suppliers";
            this.dataGridView_Suppliers.Size = new System.Drawing.Size(786, 310);
            this.dataGridView_Suppliers.TabIndex = 3;
            // 
            // tb_searcherWarehouseWorkers
            // 
            this.tb_searcherWarehouseWorkers.Location = new System.Drawing.Point(252, 58);
            this.tb_searcherWarehouseWorkers.Name = "tb_searcherWarehouseWorkers";
            this.tb_searcherWarehouseWorkers.Size = new System.Drawing.Size(281, 20);
            this.tb_searcherWarehouseWorkers.TabIndex = 5;
            this.tb_searcherWarehouseWorkers.TextChanged += new System.EventHandler(this.tb_searcherWarehouseWorkers_TextChanged);
            // 
            // cb_columnsWarehouseWorkers
            // 
            this.cb_columnsWarehouseWorkers.FormattingEnabled = true;
            this.cb_columnsWarehouseWorkers.Items.AddRange(new object[] {
            "Фамилия",
            "Имя",
            "Отчество",
            "Должность",
            "Id"});
            this.cb_columnsWarehouseWorkers.Location = new System.Drawing.Point(332, 31);
            this.cb_columnsWarehouseWorkers.Name = "cb_columnsWarehouseWorkers";
            this.cb_columnsWarehouseWorkers.Size = new System.Drawing.Size(121, 21);
            this.cb_columnsWarehouseWorkers.TabIndex = 4;
            this.cb_columnsWarehouseWorkers.Text = "Фамилия";
            // 
            // dataGridView_WarehouseWorkers
            // 
            this.dataGridView_WarehouseWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_WarehouseWorkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_WarehouseWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_WarehouseWorkers.Location = new System.Drawing.Point(3, 84);
            this.dataGridView_WarehouseWorkers.Name = "dataGridView_WarehouseWorkers";
            this.dataGridView_WarehouseWorkers.Size = new System.Drawing.Size(786, 310);
            this.dataGridView_WarehouseWorkers.TabIndex = 3;
            // 
            // dataGridView_Warehouse
            // 
            this.dataGridView_Warehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Warehouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Warehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Warehouse.Location = new System.Drawing.Point(3, 111);
            this.dataGridView_Warehouse.Name = "dataGridView_Warehouse";
            this.dataGridView_Warehouse.Size = new System.Drawing.Size(786, 310);
            this.dataGridView_Warehouse.TabIndex = 0;
            // 
            // cb_columnsWarehouse
            // 
            this.cb_columnsWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_columnsWarehouse.FormattingEnabled = true;
            this.cb_columnsWarehouse.Items.AddRange(new object[] {
            "Название",
            "Тип",
            "Заведующий",
            "Id"});
            this.cb_columnsWarehouse.Location = new System.Drawing.Point(332, 58);
            this.cb_columnsWarehouse.Name = "cb_columnsWarehouse";
            this.cb_columnsWarehouse.Size = new System.Drawing.Size(121, 21);
            this.cb_columnsWarehouse.TabIndex = 1;
            this.cb_columnsWarehouse.Text = "Название";
            // 
            // tb_searcherWarehouse
            // 
            this.tb_searcherWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_searcherWarehouse.Location = new System.Drawing.Point(252, 85);
            this.tb_searcherWarehouse.Name = "tb_searcherWarehouse";
            this.tb_searcherWarehouse.Size = new System.Drawing.Size(281, 20);
            this.tb_searcherWarehouse.TabIndex = 2;
            this.tb_searcherWarehouse.TextChanged += new System.EventHandler(this.tb_searcherWarehouse_TextChanged);
            // 
            // Directory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Directory";
            this.Text = "Directory";
            this.Load += new System.EventHandler(this.Directory_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp_warehouses.ResumeLayout(false);
            this.tp_warehouses.PerformLayout();
            this.tp_goods.ResumeLayout(false);
            this.tp_goods.PerformLayout();
            this.tp_recipients.ResumeLayout(false);
            this.tp_recipients.PerformLayout();
            this.tp_suppliers.ResumeLayout(false);
            this.tp_suppliers.PerformLayout();
            this.tp_warehouseWorkers.ResumeLayout(false);
            this.tp_warehouseWorkers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Good)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Recipients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Suppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_WarehouseWorkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Warehouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_warehouses;
        private System.Windows.Forms.TabPage tp_goods;
        private System.Windows.Forms.TabPage tp_recipients;
        private System.Windows.Forms.TabPage tp_suppliers;
        private System.Windows.Forms.TabPage tp_warehouseWorkers;
        private System.Windows.Forms.TextBox tb_searcherWarehouse;
        private System.Windows.Forms.ComboBox cb_columnsWarehouse;
        private System.Windows.Forms.DataGridView dataGridView_Warehouse;
        private System.Windows.Forms.TextBox tb_searcherGood;
        private System.Windows.Forms.ComboBox cb_columnsGood;
        private System.Windows.Forms.DataGridView dataGridView_Good;
        private System.Windows.Forms.TextBox tb_searcherRecipients;
        private System.Windows.Forms.ComboBox cb_columnsRecipients;
        private System.Windows.Forms.DataGridView dataGridView_Recipients;
        private System.Windows.Forms.TextBox tb_searcherSuppliers;
        private System.Windows.Forms.ComboBox cb_columnsSuppliers;
        private System.Windows.Forms.DataGridView dataGridView_Suppliers;
        private System.Windows.Forms.TextBox tb_searcherWarehouseWorkers;
        private System.Windows.Forms.ComboBox cb_columnsWarehouseWorkers;
        private System.Windows.Forms.DataGridView dataGridView_WarehouseWorkers;
    }
}