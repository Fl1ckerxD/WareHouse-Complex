
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tp_warehouses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tp_warehouses.Controls.Add(this.textBox1);
            this.tp_warehouses.Controls.Add(this.comboBox1);
            this.tp_warehouses.Controls.Add(this.dataGridView1);
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
            this.tp_warehouseWorkers.Location = new System.Drawing.Point(4, 22);
            this.tp_warehouseWorkers.Name = "tp_warehouseWorkers";
            this.tp_warehouseWorkers.Padding = new System.Windows.Forms.Padding(3);
            this.tp_warehouseWorkers.Size = new System.Drawing.Size(792, 424);
            this.tp_warehouseWorkers.TabIndex = 5;
            this.tp_warehouseWorkers.Text = "Работники склада";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(332, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 20);
            this.textBox1.TabIndex = 2;
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
            this.tabControl1.ResumeLayout(false);
            this.tp_warehouses.ResumeLayout(false);
            this.tp_warehouses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_warehouses;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tp_goods;
        private System.Windows.Forms.TabPage tp_recipients;
        private System.Windows.Forms.TabPage tp_suppliers;
        private System.Windows.Forms.TabPage tp_warehouseWorkers;
    }
}