using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Complex
{
    public partial class OutputItem : Form
    {
        MySqlAplication mySqlAplication = new MySqlAplication();
        public OutputItem()
        {
            InitializeComponent();
        }

        private void OutputItem_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouse_ComplexDataSet.Работники_склада". При необходимости она может быть перемещена или удалена.
            this.работники_складаTableAdapter.Fill(this.warehouse_ComplexDataSet.Работники_склада);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouse_ComplexDataSet.Получатели". При необходимости она может быть перемещена или удалена.
            this.получателиTableAdapter.Fill(this.warehouse_ComplexDataSet.Получатели);

            mySqlAplication.Fillcombobox("SELECT Id, Название FROM Товары WHERE Состояние = N'На складе'", "Id", "Название", cb_good);
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            if (tb_fio.Text == String.Empty || cb_nameRec.Text == String.Empty || cb_fioGiver.Text == String.Empty || cb_good.Text == String.Empty)
            {
                MessageBox.Show("Не все данные введены", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    mySqlAplication.Connect();

                    SqlCommand command = new SqlCommand(
                        "INSERT INTO [Расходы] (Дата, Товар_Id, [Наименование получателя], [ФИО принявшего товар], [ФИО сдавшего товар]) " +
                        "VALUES (@Дата, @Товар_Id, @Наименование_получателя, @ФИО_принявшего_товар, @ФИО_сдавшего_товар)", mySqlAplication.sqlConnection);

                    command.Parameters.AddWithValue("Дата", dateTimePicker.Value);
                    command.Parameters.AddWithValue("Товар_Id", cb_good.SelectedValue);
                    command.Parameters.AddWithValue("Наименование_получателя", cb_nameRec.SelectedValue);
                    command.Parameters.AddWithValue("ФИО_принявшего_товар", tb_fio.Text);
                    command.Parameters.AddWithValue("ФИО_сдавшего_товар", cb_fioGiver.SelectedValue);
                    command.ExecuteNonQuery();

                    command = new SqlCommand(
                        $"UPDATE Товары SET Состояние = N'Ушел' WHERE Id = {cb_good.SelectedValue}", mySqlAplication.sqlConnection);
                    command.ExecuteNonQuery();

                    command = new SqlCommand(
                        $"DELETE FROM [Расположения товаров] WHERE Товар_Id = {cb_good.SelectedValue}", mySqlAplication.sqlConnection);
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

        private void b_addRec_Click(object sender, EventArgs e)
        {
            if (tb_nameRec.Text == String.Empty || tb_adress.Text == String.Empty || tb_number.Text == String.Empty)
            {
                MessageBox.Show("Не все данные введены", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    mySqlAplication.Connect();

                    SqlCommand command = new SqlCommand(
                        "INSERT INTO [Получатели] ([Наименование получателя], [Юридический адрес], Телефон) " +
                        "VALUES (@Наименование_получателя, @Юридический_адрес, @Телефон)", mySqlAplication.sqlConnection);

                    command.Parameters.AddWithValue("Наименование_получателя", tb_nameRec.Text);
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
