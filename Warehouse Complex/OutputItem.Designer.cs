
namespace Warehouse_Complex
{
    partial class OutputItem
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
            this.Расходы = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_add = new System.Windows.Forms.Button();
            this.tb_fio = new System.Windows.Forms.TextBox();
            this.cb_fioGiver = new System.Windows.Forms.ComboBox();
            this.работникиСкладаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouse_ComplexDataSet = new Warehouse_Complex.Warehouse_ComplexDataSet();
            this.cb_nameRec = new System.Windows.Forms.ComboBox();
            this.получателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_good = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Получатели = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.tb_nameRec = new System.Windows.Forms.TextBox();
            this.tb_adress = new System.Windows.Forms.TextBox();
            this.b_addRec = new System.Windows.Forms.Button();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарыTableAdapter = new Warehouse_Complex.Warehouse_ComplexDataSetTableAdapters.ТоварыTableAdapter();
            this.получателиTableAdapter = new Warehouse_Complex.Warehouse_ComplexDataSetTableAdapters.ПолучателиTableAdapter();
            this.работники_складаTableAdapter = new Warehouse_Complex.Warehouse_ComplexDataSetTableAdapters.Работники_складаTableAdapter();
            this.tabControl1.SuspendLayout();
            this.Расходы.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.работникиСкладаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_ComplexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.получателиBindingSource)).BeginInit();
            this.Получатели.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Расходы);
            this.tabControl1.Controls.Add(this.Получатели);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // Расходы
            // 
            this.Расходы.AutoScroll = true;
            this.Расходы.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Расходы.Controls.Add(this.label6);
            this.Расходы.Controls.Add(this.label5);
            this.Расходы.Controls.Add(this.label4);
            this.Расходы.Controls.Add(this.label2);
            this.Расходы.Controls.Add(this.b_add);
            this.Расходы.Controls.Add(this.tb_fio);
            this.Расходы.Controls.Add(this.cb_fioGiver);
            this.Расходы.Controls.Add(this.cb_nameRec);
            this.Расходы.Controls.Add(this.cb_good);
            this.Расходы.Controls.Add(this.dateTimePicker);
            this.Расходы.Location = new System.Drawing.Point(4, 22);
            this.Расходы.Name = "Расходы";
            this.Расходы.Padding = new System.Windows.Forms.Padding(3);
            this.Расходы.Size = new System.Drawing.Size(792, 424);
            this.Расходы.TabIndex = 0;
            this.Расходы.Text = "Расходы";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(326, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "ФИО сдавшего";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(315, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "ФИО принявшего";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(269, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Наименование получателя";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(364, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Товар";
            // 
            // b_add
            // 
            this.b_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.b_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_add.Location = new System.Drawing.Point(344, 325);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(111, 48);
            this.b_add.TabIndex = 12;
            this.b_add.Text = "Добавить";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // tb_fio
            // 
            this.tb_fio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_fio.Location = new System.Drawing.Point(266, 148);
            this.tb_fio.Name = "tb_fio";
            this.tb_fio.Size = new System.Drawing.Size(256, 29);
            this.tb_fio.TabIndex = 11;
            // 
            // cb_fioGiver
            // 
            this.cb_fioGiver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_fioGiver.DataSource = this.работникиСкладаBindingSource;
            this.cb_fioGiver.DisplayMember = "Фамилия";
            this.cb_fioGiver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_fioGiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_fioGiver.FormattingEnabled = true;
            this.cb_fioGiver.Location = new System.Drawing.Point(266, 207);
            this.cb_fioGiver.Name = "cb_fioGiver";
            this.cb_fioGiver.Size = new System.Drawing.Size(256, 32);
            this.cb_fioGiver.TabIndex = 10;
            this.cb_fioGiver.ValueMember = "Id";
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
            // cb_nameRec
            // 
            this.cb_nameRec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_nameRec.DataSource = this.получателиBindingSource;
            this.cb_nameRec.DisplayMember = "Наименование получателя";
            this.cb_nameRec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nameRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_nameRec.FormattingEnabled = true;
            this.cb_nameRec.Location = new System.Drawing.Point(266, 86);
            this.cb_nameRec.Name = "cb_nameRec";
            this.cb_nameRec.Size = new System.Drawing.Size(256, 32);
            this.cb_nameRec.TabIndex = 9;
            this.cb_nameRec.ValueMember = "Id";
            // 
            // получателиBindingSource
            // 
            this.получателиBindingSource.DataMember = "Получатели";
            this.получателиBindingSource.DataSource = this.warehouse_ComplexDataSet;
            // 
            // cb_good
            // 
            this.cb_good.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_good.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_good.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_good.FormattingEnabled = true;
            this.cb_good.Location = new System.Drawing.Point(266, 269);
            this.cb_good.Name = "cb_good";
            this.cb_good.Size = new System.Drawing.Size(256, 32);
            this.cb_good.TabIndex = 8;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(586, 6);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker.TabIndex = 7;
            // 
            // Получатели
            // 
            this.Получатели.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Получатели.Controls.Add(this.label9);
            this.Получатели.Controls.Add(this.label8);
            this.Получатели.Controls.Add(this.label7);
            this.Получатели.Controls.Add(this.tb_number);
            this.Получатели.Controls.Add(this.tb_nameRec);
            this.Получатели.Controls.Add(this.tb_adress);
            this.Получатели.Controls.Add(this.b_addRec);
            this.Получатели.Location = new System.Drawing.Point(4, 22);
            this.Получатели.Name = "Получатели";
            this.Получатели.Padding = new System.Windows.Forms.Padding(3);
            this.Получатели.Size = new System.Drawing.Size(792, 424);
            this.Получатели.TabIndex = 1;
            this.Получатели.Text = "Получатели";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.label7.Location = new System.Drawing.Point(272, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Наименование получателя";
            // 
            // tb_number
            // 
            this.tb_number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_number.Location = new System.Drawing.Point(305, 254);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(178, 29);
            this.tb_number.TabIndex = 3;
            // 
            // tb_nameRec
            // 
            this.tb_nameRec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_nameRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_nameRec.Location = new System.Drawing.Point(241, 116);
            this.tb_nameRec.Name = "tb_nameRec";
            this.tb_nameRec.Size = new System.Drawing.Size(317, 29);
            this.tb_nameRec.TabIndex = 2;
            // 
            // tb_adress
            // 
            this.tb_adress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_adress.Location = new System.Drawing.Point(241, 184);
            this.tb_adress.Name = "tb_adress";
            this.tb_adress.Size = new System.Drawing.Size(317, 29);
            this.tb_adress.TabIndex = 1;
            // 
            // b_addRec
            // 
            this.b_addRec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.b_addRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_addRec.Location = new System.Drawing.Point(344, 325);
            this.b_addRec.Name = "b_addRec";
            this.b_addRec.Size = new System.Drawing.Size(111, 48);
            this.b_addRec.TabIndex = 0;
            this.b_addRec.Text = "Добавить";
            this.b_addRec.UseVisualStyleBackColor = true;
            this.b_addRec.Click += new System.EventHandler(this.b_addRec_Click);
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this.warehouse_ComplexDataSet;
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
            // 
            // получателиTableAdapter
            // 
            this.получателиTableAdapter.ClearBeforeFill = true;
            // 
            // работники_складаTableAdapter
            // 
            this.работники_складаTableAdapter.ClearBeforeFill = true;
            // 
            // OutputItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OutputItem";
            this.Text = "OutputItem";
            this.Load += new System.EventHandler(this.OutputItem_Load);
            this.tabControl1.ResumeLayout(false);
            this.Расходы.ResumeLayout(false);
            this.Расходы.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.работникиСкладаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_ComplexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.получателиBindingSource)).EndInit();
            this.Получатели.ResumeLayout(false);
            this.Получатели.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Расходы;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.TextBox tb_fio;
        private System.Windows.Forms.ComboBox cb_fioGiver;
        private System.Windows.Forms.ComboBox cb_nameRec;
        private System.Windows.Forms.ComboBox cb_good;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TabPage Получатели;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.TextBox tb_nameRec;
        private System.Windows.Forms.TextBox tb_adress;
        private System.Windows.Forms.Button b_addRec;
        private Warehouse_ComplexDataSet warehouse_ComplexDataSet;
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private Warehouse_ComplexDataSetTableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private System.Windows.Forms.BindingSource получателиBindingSource;
        private Warehouse_ComplexDataSetTableAdapters.ПолучателиTableAdapter получателиTableAdapter;
        private System.Windows.Forms.BindingSource работникиСкладаBindingSource;
        private Warehouse_ComplexDataSetTableAdapters.Работники_складаTableAdapter работники_складаTableAdapter;
    }
}