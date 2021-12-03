
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
            // InputItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewInputItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputItem";
            this.Text = "InputItem";
            this.Load += new System.EventHandler(this.InputItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInputItem;
    }
}