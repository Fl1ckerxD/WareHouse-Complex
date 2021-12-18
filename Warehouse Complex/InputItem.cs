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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouse_ComplexDataSet.Работники_склада". При необходимости она может быть перемещена или удалена.
            this.работники_складаTableAdapter.Fill(this.warehouse_ComplexDataSet.Работники_склада);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouse_ComplexDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.warehouse_ComplexDataSet.Поставщики);

            //mySqlAplication.ShowTable("SELECT dbo.Поставки.Id, dbo.Поставки.Дата, dbo.Поставки.Товар_Id, dbo.Товары.Название [Название товара], dbo.Поставщики.[Наименование  поставщика], " +
            //    "dbo.[Работники склада].Фамилия + ' ' + dbo.[Работники склада].Имя + ' ' + dbo.[Работники склада].Отчество[ФИО принявшего товар], dbo.Поставки.[ФИО сдавшего товар] " +
            //    "FROM dbo.[Поставки] FULL OUTER JOIN " +
            //    "dbo.Товары ON dbo.[Поставки].Товар_Id = dbo.Товары.Id " +
            //    "FULL OUTER JOIN dbo.Поставщики ON dbo.Поставщики.Id = dbo.Поставки.[Наименование поставщика] " +
            //    "FULL OUTER JOIN dbo.[Работники склада] on dbo.Поставки.[ФИО принявшего товар] = dbo.[Работники склада].Id", dataGridViewInputItem);
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            if(tb_nameGood.Text == String.Empty || cb_size.Text == String.Empty || tb_weight.Text == String.Empty || tb_fioGiver.Text == String.Empty)
            {
                MessageBox.Show("Не все данные введены", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    mySqlAplication.Connect();

                    SqlCommand command = new SqlCommand(
                        "INSERT INTO [Товары] (Название, Размер, Вес, Состояние) " +
                        "VALUES (@Название, @Размер, @Вес, @Состояние)", mySqlAplication.sqlConnection);

                    command.Parameters.AddWithValue("Название", tb_nameGood.Text);
                    command.Parameters.AddWithValue("Размер", cb_size.Text);
                    command.Parameters.AddWithValue("Вес", tb_weight.Text);
                    command.Parameters.AddWithValue("Состояние", "На складе");
                    command.ExecuteNonQuery();

                    command = new SqlCommand(
                        "INSERT INTO [Поставки] (Дата, Товар_Id, [Наименование поставщика], [ФИО принявшего товар], [ФИО сдавшего товар]) " +
                        "VALUES (@Дата, @Товар_Id, @Наименование_поставщика, @ФИО_принявшего_товар, @ФИО_сдавшего_товар)", mySqlAplication.sqlConnection);

                    command.Parameters.AddWithValue("Дата", dateTimePicker.Value);
                    command.Parameters.AddWithValue("Товар_Id", idGood().ToString());
                    command.Parameters.AddWithValue("Наименование_поставщика", cb_nameSupplier.SelectedValue);
                    command.Parameters.AddWithValue("ФИО_принявшего_товар", cb_fio.SelectedValue);
                    command.Parameters.AddWithValue("ФИО_сдавшего_товар", tb_fioGiver.Text);
                    command.ExecuteNonQuery();

                    mySqlAplication.sqlConnection.Close();
                    MessageBox.Show("Данные успешно были добавлены", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        private int idGood()
        {          
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select id from [Товары]", mySqlAplication.sqlConnection);
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            return Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][0]);
        }

        private void b_addSupp_Click(object sender, EventArgs e)
        {
            if(tb_nameSupp.Text == String.Empty || tb_adress.Text == String.Empty || tb_number.Text == String.Empty)
            {
                MessageBox.Show("Не все данные введены","Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    mySqlAplication.Connect();

                    SqlCommand command = new SqlCommand(
                        "INSERT INTO [Поставщики] ([Наименование  поставщика], [Юридический адрес], Телефон) " +
                        "VALUES (@Наименование_поставщика, @Юридический_адрес, @Телефон)", mySqlAplication.sqlConnection);

                    command.Parameters.AddWithValue("Наименование_поставщика", tb_nameSupp.Text);
                    command.Parameters.AddWithValue("Юридический_адрес", tb_adress.Text);
                    command.Parameters.AddWithValue("Телефон", tb_number.Text);
                    command.ExecuteNonQuery();

                    mySqlAplication.sqlConnection.Close();
                    MessageBox.Show("Данные успешно были добавлены", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            
        }
    }
    
}
