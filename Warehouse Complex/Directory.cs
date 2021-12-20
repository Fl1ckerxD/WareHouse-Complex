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
            
            mySqlAplication.ShowTable("Select dbo.Склады.Id, dbo.Склады.Название, dbo.Склады.Тип, " +
               "dbo.[Работники склада].Фамилия + ' ' + dbo.[Работники склада].Имя + ' ' + dbo.[Работники склада].Отчество [Заведующий] " +
               "FROM dbo.[Склады] INNER JOIN " +
               "dbo.[Работники склада] ON dbo.Склады.Заведующий = dbo.[Работники склада].Id", dataGridView_Warehouse);

            switch (MySqlAplication.typeUser)
            {
                case 0:
                    b_addWarehouse.Visible = false;
                    b_change.Visible = false;
                    break;
                case 1:
                    b_addWarehouse.Visible = true;
                    b_change.Visible = true;
                    break;
                case 2:
                    b_addWarehouse.Visible = true;
                    b_change.Visible = true;
                    break;
                case 3:
                    b_addWarehouse.Visible = false;
                    b_change.Visible = false;
                    break;
            }
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

        private void tb_searcherSup_TextChanged(object sender, EventArgs e)
        {
            mySqlAplication.SearchItem(dataGridView_Sup, cb_columnsSup, tb_searcherSup);
        }

        private void tb_searcherRec_TextChanged(object sender, EventArgs e)
        {
            mySqlAplication.SearchItem(dataGridView_Rec, cb_columnsRec, tb_searcherRec);
        }

        private void b_change_Click(object sender, EventArgs e)
        {
            ChangeUser changeUser = new ChangeUser();
            changeUser.Show();
        }

        private void b_addWarehouse_Click(object sender, EventArgs e)
        {
            Addwarehouse addwarehouse = new Addwarehouse();
            addwarehouse.Show();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    mySqlAplication.ShowTable("Select dbo.Склады.Id, dbo.Склады.Название, dbo.Склады.Тип, " +
               "dbo.[Работники склада].Фамилия + ' ' + dbo.[Работники склада].Имя + ' ' + dbo.[Работники склада].Отчество [Заведующий] " +
               "FROM dbo.[Склады] INNER JOIN " +
               "dbo.[Работники склада] ON dbo.Склады.Заведующий = dbo.[Работники склада].Id", dataGridView_Warehouse);
                    cb_columnsWarehouse.SelectedIndex = 0;
                    break;

                case 1:
                    mySqlAplication.ShowTable("SELECT dbo.Товары.Id, dbo.Товары.Название, dbo.Товары.Размер, dbo.Товары.Вес, dbo.Товары.Состояние, dbo.Склады.Название [Название склада], dbo.[Расположения товаров].[Номер полки] " +
              "FROM dbo.[Расположения товаров] FULL OUTER JOIN " +
              "dbo.Товары ON dbo.[Расположения товаров].Товар_Id = dbo.Товары.Id " +
              "LEFT JOIN dbo.Склады on dbo.[Расположения товаров].Склад_Id = dbo.Склады.Id", dataGridView_Good);
                    cb_columnsGood.SelectedIndex = 0;
                    break;

                case 2:
                    mySqlAplication.ShowTable("Select * from [Получатели]", dataGridView_Recipients);
                    cb_columnsRecipients.SelectedIndex = 0;
                    break;

                case 3:
                    mySqlAplication.ShowTable("Select * from [Поставщики]", dataGridView_Suppliers);
                    cb_columnsSuppliers.SelectedIndex = 0;
                    break;

                case 4:                    
                    mySqlAplication.ShowTable("Select * from [Работники склада]", dataGridView_WarehouseWorkers);
                    cb_columnsWarehouseWorkers.SelectedIndex = 0;
                    break;

                case 5:
                    mySqlAplication.ShowTable("SELECT dbo.Поставки.Id, dbo.Поставки.Дата, dbo.Поставки.Товар_Id, dbo.Товары.Название [Название товара], dbo.Поставщики.[Наименование  поставщика], " +
                "dbo.[Работники склада].Фамилия + ' ' + dbo.[Работники склада].Имя + ' ' + dbo.[Работники склада].Отчество[ФИО принявшего товар], dbo.Поставки.[ФИО сдавшего товар] " +
                "FROM dbo.[Поставки] INNER JOIN " +
                "dbo.Товары ON dbo.[Поставки].Товар_Id = dbo.Товары.Id " +
                "INNER JOIN dbo.Поставщики ON dbo.Поставщики.Id = dbo.Поставки.[Наименование поставщика] " +
                "INNER JOIN dbo.[Работники склада] on dbo.Поставки.[ФИО принявшего товар] = dbo.[Работники склада].Id", dataGridView_Sup);
                    cb_columnsRec.SelectedIndex = 0;
                    break;

                case 6:
                    mySqlAplication.ShowTable("SELECT dbo.Расходы.Id, dbo.Расходы.Дата, dbo.Расходы.Товар_Id, dbo.Товары.Название [Название товара], dbo.Получатели.[Наименование получателя], " +
                        "dbo.Расходы.[ФИО принявшего товар], dbo.[Работники склада].Фамилия + ' ' + dbo.[Работники склада].Имя + ' ' + dbo.[Работники склада].Отчество[ФИО сдавшего товар] " +
                        "FROM dbo.[Расходы] INNER JOIN " +
                        "dbo.Товары ON dbo.[Расходы].Товар_Id = dbo.Товары.Id " +
                        "INNER JOIN dbo.Получатели ON dbo.Получатели.Id = dbo.Расходы.[Наименование получателя] " +
                        "INNER JOIN dbo.[Работники склада] on dbo.Расходы.[ФИО сдавшего товар] = dbo.[Работники склада].Id", dataGridView_Rec);
                    cb_columnsSup.SelectedIndex = 0;
                    break;
            }
        }
    }
}
