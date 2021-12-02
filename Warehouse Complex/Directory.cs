﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Warehouse_Complex
{
    public partial class Directory : Form
    {
        MySqlAplication mySqlAplication = new MySqlAplication();
        public Directory()
        {
            InitializeComponent();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mySqlAplication.ShowTable("SELECT dbo.Товары.Id, dbo.Товары.Название, dbo.Товары.Размер, dbo.Товары.Состояние, dbo.Склады.Название [Название склада], dbo.[Расположения товаров].[Номер полки] "+
                "FROM dbo.[Расположения товаров] FULL OUTER JOIN " +
                "dbo.Товары ON dbo.[Расположения товаров].Товар_Id = dbo.Товары.Id "+
                "FULL OUTER JOIN dbo.Склады on dbo.[Расположения товаров].Склад_Id = dbo.Склады.Id", dataGridView);
        }    
        
        private void получателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mySqlAplication.ShowTable("Select * from [Получатели]", dataGridView);
        }

        private void поставшикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mySqlAplication.ShowTable("Select * from [Поставщики]", dataGridView);
        }

        private void работникикиСкладаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mySqlAplication.ShowTable("Select * from [Работники склада]", dataGridView);
        }

        

        private void tb_searcher_TextChanged(object sender, EventArgs e)
        {
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter = $"* LIKE '%{tb_searcher.Text}%'";
        }
    }
}
