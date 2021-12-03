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
    public partial class InputItem : Form
    {
        MySqlAplication mySqlAplication = new MySqlAplication();
        public InputItem()
        {
            InitializeComponent();
        }

        private void InputItem_Load(object sender, EventArgs e)
        {
            mySqlAplication.ShowTable("SELECT dbo.Поставки.Id, dbo.Поставки.Дата, dbo.Поставки.Товар_Id, dbo.Товары.Название [Название товара], dbo.Поставщики.[Наименование  поставщика], "+
                "dbo.[Работники склада].Фамилия + ' ' + dbo.[Работники склада].Имя + ' ' + dbo.[Работники склада].Отчество[ФИО принявшего товар], dbo.Поставки.[ФИО сдавшего товар] "+
                "FROM dbo.[Поставки] FULL OUTER JOIN "+
                "dbo.Товары ON dbo.[Поставки].Товар_Id = dbo.Товары.Id "+
                "FULL OUTER JOIN dbo.Поставщики ON dbo.Поставщики.Id = dbo.Поставки.[Наименование поставщика] "+
                "FULL OUTER JOIN dbo.[Работники склада] on dbo.Поставки.[ФИО принявшего товар] = dbo.[Работники склада].Id", dataGridViewInputItem);
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                "INSERT INTO [Поставки] (Дата, Товар_Id, [Наименование поставщика], [ФИО принявшего товар], [ФИО сдавшего товар]) " +
                "VALUES (@Дата, @Товар_Id, @[Наименование поставщика], @[ФИО принявшего товар], @[ФИО сдавшего товар])",mySqlAplication.sqlConnection);

            command.Parameters.AddWithValue("Дата", dateTimePicker.Value);
            command.Parameters.AddWithValue("Товар_Id", cb_goodId.Text);
            command.Parameters.AddWithValue("[Наименование поставщика]", cb_nameSupplier.Text);
            command.Parameters.AddWithValue("[ФИО принявшего товар]", cb_fio.Text);
            command.Parameters.AddWithValue("[ФИО сдавшего товар]", tb_fioGiver.Text);
        }
    }
}
