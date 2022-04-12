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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wareHouseDataSet.Recipient". При необходимости она может быть перемещена или удалена.
            this.recipientTableAdapter.Fill(this.wareHouseDataSet.Recipient);

            mySqlAplication.Fillcombobox("Select id, Surname + ' ' + Name + ' ' + Patronymic[ФИО] from Worker", "id", "ФИО", cb_fioGiver);
            cb_fioGiver.SelectedValue = MySqlAplication.idUser;
            mySqlAplication.Fillcombobox("SELECT Id, Title FROM Good WHERE State = N'На складе'", "Title", "Название", cb_good);
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
                        "INSERT INTO Expens (Date, GoodId, RecipientTitle, SuppientName, RecipientName) " +
                        "VALUES (@Date, @GoodId, @RecipientTitle, @SuppientName, @RecipientName)", mySqlAplication.sqlConnection);

                    command.Parameters.AddWithValue("Date", dateTimePicker.Value);
                    command.Parameters.AddWithValue("GoodId", cb_good.SelectedValue);
                    command.Parameters.AddWithValue("RecipientTitle", cb_nameRec.SelectedValue);
                    command.Parameters.AddWithValue("SuppientName", tb_fio.Text);
                    command.Parameters.AddWithValue("RecipientName", cb_fioGiver.SelectedValue);
                    command.ExecuteNonQuery();

                    command = new SqlCommand(
                        $"UPDATE Good SET State = N'Ушел' WHERE Id = {cb_good.SelectedValue}", mySqlAplication.sqlConnection);
                    command.ExecuteNonQuery();

                    command = new SqlCommand(
                        $"DELETE FROM ProductLocation WHERE GoodId = {cb_good.SelectedValue}", mySqlAplication.sqlConnection);
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
                        "INSERT INTO Recipient (Name, Steet, Phone) " +
                        "VALUES (@Recipient, @Steet, @Phone)", mySqlAplication.sqlConnection);

                    command.Parameters.AddWithValue("Recipient", tb_nameRec.Text);
                    command.Parameters.AddWithValue("Steet", tb_adress.Text);
                    command.Parameters.AddWithValue("Phone", tb_number.Text);
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
