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
            
            //mySqlAplication.ShowTable("Select dbo.Склады.Id, dbo.Склады.Название, dbo.Склады.Тип, " +
            //   "dbo.[Работники склада].Фамилия + ' ' + dbo.[Работники склада].Имя + ' ' + dbo.[Работники склада].Отчество [Заведующий] " +
            //   "FROM dbo.[Склады] INNER JOIN " +
            //   "dbo.[Работники склада] ON dbo.Склады.Заведующий = dbo.[Работники склада].Id", dataGridView_Warehouse);

            mySqlAplication.ShowTable("Select dbo.Warehouse.Id, dbo.Warehouse.Title[Название], dbo.Warehouse.Type[Тип], " +
               "dbo.Worker.Surname + ' ' + dbo.Worker.Name + ' ' + dbo.Worker.Patronymic [Заведующий] " +
               "FROM dbo.Warehouse INNER JOIN " +
               "dbo.Worker ON dbo.Warehouse.Manager = dbo.Worker.Id", dataGridView_Warehouse);

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
                    mySqlAplication.ShowTable("Select dbo.Warehouse.Id, dbo.Warehouse.Title[Название], dbo.Warehouse.Type[Тип], " +
               "dbo.Worker.Surname + ' ' + dbo.Worker.Name + ' ' + dbo.Worker.Patronymic [Заведующий] " +
               "FROM dbo.Warehouse INNER JOIN " +
               "dbo.Worker ON dbo.Warehouse.Manager = dbo.Worker.Id", dataGridView_Warehouse);
                    cb_columnsWarehouse.SelectedIndex = 0;
                    break;

                case 1:
                    mySqlAplication.ShowTable("SELECT dbo.Good.Id, dbo.Good.Title[Название], dbo.Good.Size[Размер], dbo.Good.Weight[Вес], dbo.Good.State[Состояние], dbo.Warehouse.Title [Название склада], dbo.ProductLocation.NumberShelf[Номер полки]" +
              "FROM dbo.ProductLocation FULL OUTER JOIN " +
              "dbo.Good ON dbo.ProductLocation.GoodId = dbo.Good.Id " +
              "LEFT JOIN dbo.Warehouse on dbo.ProductLocation.GoodId = dbo.Warehouse.Id", dataGridView_Good);
                    cb_columnsGood.SelectedIndex = 0;
                    break;

                case 2:
                    mySqlAplication.ShowTable("Select Name[Наименование получателя], City[Город], Street[Улица], House[Дом], Phone[Телефон] from Recipient", dataGridView_Recipients);
                    cb_columnsRecipients.SelectedIndex = 0;
                    break;

                case 3:
                    mySqlAplication.ShowTable("Select Name[Наименование поставщика], City[Город], Street[Улица], House[Дом], Phone[Телефон] from Supplier", dataGridView_Suppliers);
                    cb_columnsSuppliers.SelectedIndex = 0;
                    break;

                case 4:                    
                    mySqlAplication.ShowTable("Select Surname[Фамилия], Name[Имя], Patronymic[Отчество], Position[Должность] from Worker", dataGridView_WarehouseWorkers);
                    cb_columnsWarehouseWorkers.SelectedIndex = 0;
                    break;

                case 5:
                    mySqlAplication.ShowTable("SELECT dbo.Supply.Id, dbo.Supply.Date[Дата], dbo.Supply.GoodId[Id Товара], dbo.Good.Title [Название товара], dbo.Supplier.Name[Наименование  поставщика], " +
                "dbo.Worker.Surname + ' ' + dbo.Worker.Name + ' ' + dbo.Worker.Patronymic[ФИО принявшего товар], dbo.Supply.RecipientName[ФИО сдавшего товар] " +
                "FROM dbo.Supply INNER JOIN " +
                "dbo.Good ON dbo.Supply.GoodId = dbo.Good.Id " +
                "INNER JOIN dbo.Supplier ON dbo.Supplier.Id = dbo.Supply.SupplientTitle " +
                "INNER JOIN dbo.Worker on dbo.Supply.SupplientName = dbo.Worker.Id", dataGridView_Sup);
                    cb_columnsRec.SelectedIndex = 0;
                    break;

                case 6:
                    mySqlAplication.ShowTable("SELECT dbo.Expens.Id, dbo.Expens.Date[Дата], dbo.Expens.GoodId[Id Товара], dbo.Good.Title [Название товара], dbo.Recipient.Name[Наименование получателя], " +
                        "dbo.Expens.SupplientName[ФИО принявшего товар], dbo.Worker.Surname + ' ' + dbo.Worker.Name + ' ' + dbo.Worker.Patronymic[ФИО сдавшего товар] " +
                        "FROM dbo.Expens INNER JOIN " +
                        "dbo.Good ON dbo.Expens.GoodId = dbo.Good.Id " +
                        "INNER JOIN dbo.Recipient ON dbo.Recipient.Id = dbo.Expens.RecipientTitle " +
                        "INNER JOIN dbo.Worker on dbo.Worker.Id = dbo.Expens.RecipientName", dataGridView_Rec);
                    cb_columnsSup.SelectedIndex = 0;
                    break;
            }
        }
    }
}
