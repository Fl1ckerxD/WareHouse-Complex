
namespace Warehouse_Complex
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.p_showing = new System.Windows.Forms.Panel();
            this.b_directory = new System.Windows.Forms.Button();
            this.b_sup = new System.Windows.Forms.Button();
            this.b_rec = new System.Windows.Forms.Button();
            this.b_aboutProgram = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.b_directory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.b_sup, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.b_rec, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.b_aboutProgram, 0, 3);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.10133F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.10133F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.10133F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.69602F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 586);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // p_showing
            // 
            this.p_showing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.p_showing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_showing.Location = new System.Drawing.Point(200, 0);
            this.p_showing.Name = "p_showing";
            this.p_showing.Size = new System.Drawing.Size(784, 586);
            this.p_showing.TabIndex = 1;
            // 
            // b_directory
            // 
            this.b_directory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_directory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.b_directory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b_directory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_directory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_directory.ForeColor = System.Drawing.Color.White;
            this.b_directory.Image = global::Warehouse_Complex.Properties.Resources.directory50x;
            this.b_directory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_directory.Location = new System.Drawing.Point(4, 46);
            this.b_directory.Name = "b_directory";
            this.b_directory.Size = new System.Drawing.Size(192, 97);
            this.b_directory.TabIndex = 0;
            this.b_directory.Text = "          Справочники";
            this.b_directory.UseVisualStyleBackColor = false;
            this.b_directory.Click += new System.EventHandler(this.b_directory_Click);
            // 
            // b_sup
            // 
            this.b_sup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_sup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.b_sup.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b_sup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_sup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_sup.ForeColor = System.Drawing.Color.White;
            this.b_sup.Image = global::Warehouse_Complex.Properties.Resources.log_in50x;
            this.b_sup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_sup.Location = new System.Drawing.Point(4, 192);
            this.b_sup.Name = "b_sup";
            this.b_sup.Size = new System.Drawing.Size(192, 97);
            this.b_sup.TabIndex = 1;
            this.b_sup.Text = "     Приход";
            this.b_sup.UseVisualStyleBackColor = false;
            this.b_sup.Click += new System.EventHandler(this.b_sup_Click);
            // 
            // b_rec
            // 
            this.b_rec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_rec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.b_rec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b_rec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_rec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_rec.ForeColor = System.Drawing.Color.White;
            this.b_rec.Image = global::Warehouse_Complex.Properties.Resources.log_out50x;
            this.b_rec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_rec.Location = new System.Drawing.Point(4, 338);
            this.b_rec.Name = "b_rec";
            this.b_rec.Size = new System.Drawing.Size(192, 97);
            this.b_rec.TabIndex = 2;
            this.b_rec.Text = "     Расход";
            this.b_rec.UseVisualStyleBackColor = false;
            this.b_rec.Click += new System.EventHandler(this.b_rec_Click);
            // 
            // b_aboutProgram
            // 
            this.b_aboutProgram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_aboutProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.b_aboutProgram.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b_aboutProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_aboutProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_aboutProgram.ForeColor = System.Drawing.Color.White;
            this.b_aboutProgram.Image = ((System.Drawing.Image)(resources.GetObject("b_aboutProgram.Image")));
            this.b_aboutProgram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_aboutProgram.Location = new System.Drawing.Point(4, 529);
            this.b_aboutProgram.Name = "b_aboutProgram";
            this.b_aboutProgram.Size = new System.Drawing.Size(192, 53);
            this.b_aboutProgram.TabIndex = 3;
            this.b_aboutProgram.Text = "         О программе";
            this.b_aboutProgram.UseVisualStyleBackColor = false;
            this.b_aboutProgram.Click += new System.EventHandler(this.b_aboutProgram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 586);
            this.Controls.Add(this.p_showing);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 625);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Складской комплекс";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button b_sup;
        private System.Windows.Forms.Button b_rec;
        private System.Windows.Forms.Button b_aboutProgram;
        private System.Windows.Forms.Panel p_showing;
        private System.Windows.Forms.Button b_directory;
    }
}

