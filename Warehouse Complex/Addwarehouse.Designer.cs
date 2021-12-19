
namespace Warehouse_Complex
{
    partial class Addwarehouse
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            this.warehouse_ComplexDataSet = new Warehouse_Complex.Warehouse_ComplexDataSet();
            this.работникиСкладаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.работники_складаTableAdapter = new Warehouse_Complex.Warehouse_ComplexDataSetTableAdapters.Работники_складаTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Add = new System.Windows.Forms.TabPage();
            this.cb_user = new System.Windows.Forms.ComboBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.b_add = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.TabPage();
            this.b_update = new System.Windows.Forms.Button();
            this.b_next = new System.Windows.Forms.Button();
            this.b_back = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_nameWarehouse = new System.Windows.Forms.TextBox();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_ComplexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работникиСкладаBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Add.SuspendLayout();
            this.Change.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idLabel.Location = new System.Drawing.Point(246, 86);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(30, 24);
            idLabel.TabIndex = 24;
            idLabel.Text = "Id:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            фамилияLabel.AutoSize = true;
            фамилияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фамилияLabel.Location = new System.Drawing.Point(246, 121);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(102, 24);
            фамилияLabel.TabIndex = 26;
            фамилияLabel.Text = "Название:";
            // 
            // имяLabel
            // 
            имяLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            имяLabel.AutoSize = true;
            имяLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            имяLabel.Location = new System.Drawing.Point(246, 156);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(49, 24);
            имяLabel.TabIndex = 28;
            имяLabel.Text = "Тип:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            отчествоLabel.AutoSize = true;
            отчествоLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            отчествоLabel.Location = new System.Drawing.Point(246, 191);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(150, 24);
            отчествоLabel.TabIndex = 30;
            отчествоLabel.Text = "Заведующий Id:";
            // 
            // warehouse_ComplexDataSet
            // 
            this.warehouse_ComplexDataSet.DataSetName = "Warehouse_ComplexDataSet";
            this.warehouse_ComplexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // работникиСкладаBindingSource
            // 
            this.работникиСкладаBindingSource.DataMember = "Работники склада";
            this.работникиСкладаBindingSource.DataSource = this.warehouse_ComplexDataSet;
            // 
            // работники_складаTableAdapter
            // 
            this.работники_складаTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Add);
            this.tabControl1.Controls.Add(this.Change);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 9;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Add.Controls.Add(this.cb_user);
            this.Add.Controls.Add(this.cb_type);
            this.Add.Controls.Add(this.label3);
            this.Add.Controls.Add(this.label2);
            this.Add.Controls.Add(this.label1);
            this.Add.Controls.Add(this.tb_name);
            this.Add.Controls.Add(this.b_add);
            this.Add.Location = new System.Drawing.Point(4, 22);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(3);
            this.Add.Size = new System.Drawing.Size(792, 424);
            this.Add.TabIndex = 0;
            this.Add.Text = "Добавить";
            // 
            // cb_user
            // 
            this.cb_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_user.FormattingEnabled = true;
            this.cb_user.Location = new System.Drawing.Point(286, 222);
            this.cb_user.Name = "cb_user";
            this.cb_user.Size = new System.Drawing.Size(206, 24);
            this.cb_user.TabIndex = 15;
            // 
            // cb_type
            // 
            this.cb_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "А",
            "B",
            "C",
            "D"});
            this.cb_type.Location = new System.Drawing.Point(346, 160);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(77, 24);
            this.cb_type.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(326, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Заведующий";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(331, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Тип склада";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(336, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название";
            // 
            // tb_name
            // 
            this.tb_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_name.Location = new System.Drawing.Point(213, 96);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(341, 22);
            this.tb_name.TabIndex = 10;
            // 
            // b_add
            // 
            this.b_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.b_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_add.Location = new System.Drawing.Point(343, 271);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(108, 42);
            this.b_add.TabIndex = 9;
            this.b_add.Text = "Добавить";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Change.Controls.Add(this.b_update);
            this.Change.Controls.Add(this.b_next);
            this.Change.Controls.Add(this.b_back);
            this.Change.Controls.Add(idLabel);
            this.Change.Controls.Add(this.tb_id);
            this.Change.Controls.Add(фамилияLabel);
            this.Change.Controls.Add(this.tb_nameWarehouse);
            this.Change.Controls.Add(имяLabel);
            this.Change.Controls.Add(this.tb_type);
            this.Change.Controls.Add(отчествоLabel);
            this.Change.Controls.Add(this.tb_user);
            this.Change.Location = new System.Drawing.Point(4, 22);
            this.Change.Name = "Change";
            this.Change.Padding = new System.Windows.Forms.Padding(3);
            this.Change.Size = new System.Drawing.Size(792, 424);
            this.Change.TabIndex = 1;
            this.Change.Text = "Изменить";
            // 
            // b_update
            // 
            this.b_update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.b_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_update.Location = new System.Drawing.Point(343, 311);
            this.b_update.Name = "b_update";
            this.b_update.Size = new System.Drawing.Size(116, 38);
            this.b_update.TabIndex = 36;
            this.b_update.Text = "Обновить";
            this.b_update.UseVisualStyleBackColor = true;
            this.b_update.Click += new System.EventHandler(this.b_update_Click);
            // 
            // b_next
            // 
            this.b_next.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.b_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_next.Location = new System.Drawing.Point(420, 251);
            this.b_next.Name = "b_next";
            this.b_next.Size = new System.Drawing.Size(45, 41);
            this.b_next.TabIndex = 35;
            this.b_next.Text = ">";
            this.b_next.UseVisualStyleBackColor = true;
            this.b_next.Click += new System.EventHandler(this.b_next_Click);
            // 
            // b_back
            // 
            this.b_back.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.b_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_back.Location = new System.Drawing.Point(337, 251);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(45, 41);
            this.b_back.TabIndex = 34;
            this.b_back.Text = "<";
            this.b_back.UseVisualStyleBackColor = true;
            this.b_back.Click += new System.EventHandler(this.b_back_Click);
            // 
            // tb_id
            // 
            this.tb_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_id.Location = new System.Drawing.Point(402, 83);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(162, 29);
            this.tb_id.TabIndex = 25;
            // 
            // tb_nameWarehouse
            // 
            this.tb_nameWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_nameWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_nameWarehouse.Location = new System.Drawing.Point(402, 118);
            this.tb_nameWarehouse.Name = "tb_nameWarehouse";
            this.tb_nameWarehouse.Size = new System.Drawing.Size(162, 29);
            this.tb_nameWarehouse.TabIndex = 27;
            // 
            // tb_type
            // 
            this.tb_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_type.Location = new System.Drawing.Point(402, 153);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(162, 29);
            this.tb_type.TabIndex = 29;
            // 
            // tb_user
            // 
            this.tb_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_user.Location = new System.Drawing.Point(402, 188);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(162, 29);
            this.tb_user.TabIndex = 31;
            // 
            // Addwarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Addwarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить или изменить склад";
            this.Load += new System.EventHandler(this.Addwarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_ComplexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работникиСкладаBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            this.Change.ResumeLayout(false);
            this.Change.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Warehouse_ComplexDataSet warehouse_ComplexDataSet;
        private System.Windows.Forms.BindingSource работникиСкладаBindingSource;
        private Warehouse_ComplexDataSetTableAdapters.Работники_складаTableAdapter работники_складаTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Add;
        private System.Windows.Forms.ComboBox cb_user;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.TabPage Change;
        private System.Windows.Forms.Button b_update;
        private System.Windows.Forms.Button b_next;
        private System.Windows.Forms.Button b_back;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_nameWarehouse;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.TextBox tb_user;
    }
}