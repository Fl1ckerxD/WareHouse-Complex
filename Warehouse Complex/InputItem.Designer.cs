
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
            this.tb_weight = new System.Windows.Forms.TextBox();
            this.tb_nameGood = new System.Windows.Forms.TextBox();
            this.b_add = new System.Windows.Forms.Button();
            this.tb_fioGiver = new System.Windows.Forms.TextBox();
            this.cb_fio = new System.Windows.Forms.ComboBox();
            this.cb_nameSupplier = new System.Windows.Forms.ComboBox();
            this.cb_size = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Поставщики = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.warehouse_ComplexDataSet = new Warehouse_Complex.Warehouse_ComplexDataSet();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикиTableAdapter = new Warehouse_Complex.Warehouse_ComplexDataSetTableAdapters.ПоставщикиTableAdapter();
            this.работникиСкладаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.работники_складаTableAdapter = new Warehouse_Complex.Warehouse_ComplexDataSetTableAdapters.Работники_складаTableAdapter();
            this.tabControl1.SuspendLayout();
            this.Поставки.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_ComplexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работникиСкладаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Поставки);
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
            this.Поставки.UseVisualStyleBackColor = true;
            // 
            // tb_weight
            // 
            this.tb_weight.Location = new System.Drawing.Point(137, 157);
            this.tb_weight.Name = "tb_weight";
            this.tb_weight.Size = new System.Drawing.Size(121, 20);
            this.tb_weight.TabIndex = 14;
            // 
            // tb_nameGood
            // 
            this.tb_nameGood.Location = new System.Drawing.Point(137, 64);
            this.tb_nameGood.Name = "tb_nameGood";
            this.tb_nameGood.Size = new System.Drawing.Size(121, 20);
            this.tb_nameGood.TabIndex = 13;
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(400, 157);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(75, 23);
            this.b_add.TabIndex = 12;
            this.b_add.Text = "Добавить";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // tb_fioGiver
            // 
            this.tb_fioGiver.Location = new System.Drawing.Point(612, 148);
            this.tb_fioGiver.Name = "tb_fioGiver";
            this.tb_fioGiver.Size = new System.Drawing.Size(121, 20);
            this.tb_fioGiver.TabIndex = 11;
            // 
            // cb_fio
            // 
            this.cb_fio.DataSource = this.работникиСкладаBindingSource;
            this.cb_fio.DisplayMember = "Фамилия";
            this.cb_fio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_fio.FormattingEnabled = true;
            this.cb_fio.Location = new System.Drawing.Point(612, 106);
            this.cb_fio.Name = "cb_fio";
            this.cb_fio.Size = new System.Drawing.Size(121, 21);
            this.cb_fio.TabIndex = 10;
            this.cb_fio.ValueMember = "Id";
            // 
            // cb_nameSupplier
            // 
            this.cb_nameSupplier.DataSource = this.поставщикиBindingSource;
            this.cb_nameSupplier.DisplayMember = "Наименование  поставщика";
            this.cb_nameSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nameSupplier.FormattingEnabled = true;
            this.cb_nameSupplier.Location = new System.Drawing.Point(612, 64);
            this.cb_nameSupplier.Name = "cb_nameSupplier";
            this.cb_nameSupplier.Size = new System.Drawing.Size(121, 21);
            this.cb_nameSupplier.TabIndex = 9;
            this.cb_nameSupplier.ValueMember = "Id";
            // 
            // cb_size
            // 
            this.cb_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_size.FormattingEnabled = true;
            this.cb_size.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.cb_size.Location = new System.Drawing.Point(137, 105);
            this.cb_size.Name = "cb_size";
            this.cb_size.Size = new System.Drawing.Size(121, 21);
            this.cb_size.TabIndex = 8;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(586, 6);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 7;
            // 
            // Поставщики
            // 
            this.Поставщики.Location = new System.Drawing.Point(4, 22);
            this.Поставщики.Name = "Поставщики";
            this.Поставщики.Padding = new System.Windows.Forms.Padding(3);
            this.Поставщики.Size = new System.Drawing.Size(792, 424);
            this.Поставщики.TabIndex = 1;
            this.Поставщики.Text = "Поставщики";
            this.Поставщики.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Название товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Размер товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Вес товара";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Название поставщика";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(620, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "ФИО принявшего";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "ФИО сдавшего";
            // 
            // warehouse_ComplexDataSet
            // 
            this.warehouse_ComplexDataSet.DataSetName = "Warehouse_ComplexDataSet";
            this.warehouse_ComplexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.warehouse_ComplexDataSet;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
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
            // InputItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputItem";
            this.Text = "InputItem";
            this.Load += new System.EventHandler(this.InputItem_Load);
            this.tabControl1.ResumeLayout(false);
            this.Поставки.ResumeLayout(false);
            this.Поставки.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_ComplexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работникиСкладаBindingSource)).EndInit();
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
    }
}