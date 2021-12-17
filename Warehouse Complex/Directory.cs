using System;
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
        private void Directory_Load(object sender, EventArgs e)
        {
            cb_columnsWarehouse.SelectedIndex = 0;
            cb_columnsGood.SelectedIndex = 0;
            cb_columnsRecipients.SelectedIndex = 0;
            cb_columnsSuppliers.SelectedIndex = 0;
            cb_columnsWarehouseWorkers.SelectedIndex = 0;

            mySqlAplication.ShowTable("Select dbo.Склады.Id, dbo.Склады.Название, dbo.Склады.Тип, " +
                "dbo.[Работники склада].Фамилия + ' ' + dbo.[Работники склада].Имя + ' ' + dbo.[Работники склада].Отчество [Заведующий] " +
                "FROM dbo.[Склады] FULL OUTER JOIN " +
                "dbo.[Работники склада] ON dbo.Склады.Заведующий = dbo.[Работники склада].Id", dataGridView_Warehouse);

            mySqlAplication.ShowTable("SELECT dbo.Товары.Id, dbo.Товары.Название, dbo.Товары.Размер, dbo.Товары.Вес, dbo.Товары.Состояние, dbo.Склады.Название [Название склада], dbo.[Расположения товаров].[Номер полки] " +
               "FROM dbo.[Расположения товаров] FULL OUTER JOIN " +
               "dbo.Товары ON dbo.[Расположения товаров].Товар_Id = dbo.Товары.Id " +
               "FULL OUTER JOIN dbo.Склады on dbo.[Расположения товаров].Склад_Id = dbo.Склады.Id", dataGridView_Good);

            mySqlAplication.ShowTable("Select * from [Получатели]", dataGridView_Recipients);

            mySqlAplication.ShowTable("Select * from [Поставщики]", dataGridView_Suppliers);

            mySqlAplication.ShowTable("Select * from [Работники склада]", dataGridView_WarehouseWorkers);
        }
        private void tb_searcherWarehouse_TextChanged(object sender, EventArgs e)
        {
            mySqlAplication.SearchItem(dataGridView_Warehouse, cb_columnsWarehouse, tb_searcherWarehouse);
        }
        private void tb_searcherGood_TextChanged(object sender, EventArgs e)
        {
            mySqlAplication.SearchItem(dataGridView_Good, cb_columnsGood, tb_searcherGood);
        }
        private void tb_searcherRecipients_TextChanged(object sender, EventArgs e)
        {
            mySqlAplication.SearchItem(dataGridView_Recipients, cb_columnsRecipients, tb_searcherRecipients);
        }
        private void tb_searcherSuppliers_TextChanged(object sender, EventArgs e)
        {
            mySqlAplication.SearchItem(dataGridView_Suppliers, cb_columnsSuppliers, tb_searcherSuppliers);
        }
        private void tb_searcherWarehouseWorkers_TextChanged(object sender, EventArgs e)
        {
            mySqlAplication.SearchItem(dataGridView_WarehouseWorkers, cb_columnsWarehouseWorkers, tb_searcherWarehouseWorkers);
        }
    }
}
