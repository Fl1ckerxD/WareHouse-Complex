
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
            this.dataGridViewInputItem = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cb_goodId = new System.Windows.Forms.ComboBox();
            this.cb_nameSupplier = new System.Windows.Forms.ComboBox();
            this.cb_fio = new System.Windows.Forms.ComboBox();
            this.tb_fioGiver = new System.Windows.Forms.TextBox();
            this.b_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInputItem
            // 
            this.dataGridViewInputItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInputItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInputItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewInputItem.Location = new System.Drawing.Point(0, 198);
            this.dataGridViewInputItem.Name = "dataGridViewInputItem";
            this.dataGridViewInputItem.Size = new System.Drawing.Size(800, 252);
            this.dataGridViewInputItem.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(588, 12);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // cb_goodId
            // 
            this.cb_goodId.FormattingEnabled = true;
            this.cb_goodId.Location = new System.Drawing.Point(217, 47);
            this.cb_goodId.Name = "cb_goodId";
            this.cb_goodId.Size = new System.Drawing.Size(121, 21);
            this.cb_goodId.TabIndex = 2;
            // 
            // cb_nameSupplier
            // 
            this.cb_nameSupplier.FormattingEnabled = true;
            this.cb_nameSupplier.Location = new System.Drawing.Point(445, 47);
            this.cb_nameSupplier.Name = "cb_nameSupplier";
            this.cb_nameSupplier.Size = new System.Drawing.Size(121, 21);
            this.cb_nameSupplier.TabIndex = 3;
            // 
            // cb_fio
            // 
            this.cb_fio.FormattingEnabled = true;
            this.cb_fio.Location = new System.Drawing.Point(217, 115);
            this.cb_fio.Name = "cb_fio";
            this.cb_fio.Size = new System.Drawing.Size(121, 21);
            this.cb_fio.TabIndex = 4;
            // 
            // tb_fioGiver
            // 
            this.tb_fioGiver.Location = new System.Drawing.Point(445, 116);
            this.tb_fioGiver.Name = "tb_fioGiver";
            this.tb_fioGiver.Size = new System.Drawing.Size(121, 20);
            this.tb_fioGiver.TabIndex = 5;
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(355, 160);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(75, 23);
            this.b_add.TabIndex = 6;
            this.b_add.Text = "Добавить";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // InputItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.tb_fioGiver);
            this.Controls.Add(this.cb_fio);
            this.Controls.Add(this.cb_nameSupplier);
            this.Controls.Add(this.cb_goodId);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dataGridViewInputItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputItem";
            this.Text = "InputItem";
            this.Load += new System.EventHandler(this.InputItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInputItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cb_goodId;
        private System.Windows.Forms.ComboBox cb_nameSupplier;
        private System.Windows.Forms.ComboBox cb_fio;
        private System.Windows.Forms.TextBox tb_fioGiver;
        private System.Windows.Forms.Button b_add;
    }
}