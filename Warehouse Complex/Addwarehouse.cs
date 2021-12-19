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
    public partial class Addwarehouse : Form
    {
        MySqlAplication mySqlAplication = new MySqlAplication();
        SqlDataAdapter dataAdapter = null;
        DataTable dataTable = null;

        private int _row = 0;
        public Addwarehouse()
        {
            InitializeComponent();
        }

        private void Addwarehouse_Load(object sender, EventArgs e)
        {
            mySqlAplication.Fillcombobox("Select id, Фамилия + ' ' + Имя + ' ' + Отчество[ФИО] from [Работники склада]", "id", "ФИО", cb_user);

            UpdateTable();

            FillTexbox();
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == String.Empty || cb_type.Text == String.Empty)
            {
                MessageBox.Show("Не все данные введены", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    mySqlAplication.Connect();

                    SqlCommand command = new SqlCommand(
                        "INSERT INTO [Склады] (Название, Тип, Заведующий) " +
                        "VALUES (@Название, @Тип, @Заведующий)", mySqlAplication.sqlConnection);

                    command.Parameters.AddWithValue("Название", tb_name.Text);
                    command.Parameters.AddWithValue("Тип", cb_type.Text);
                    command.Parameters.AddWithValue("Заведующий", cb_user.SelectedValue);
                    command.ExecuteNonQuery();

                    mySqlAplication.sqlConnection.Close();
                    MessageBox.Show("Данные успешно были добавлены", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateTable();
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void b_back_Click(object sender, EventArgs e)
        {
            _row--;
            FillTexbox();
        }

        private void b_next_Click(object sender, EventArgs e)
        {
            _row++;
            FillTexbox();
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            if (tb_nameWarehouse.Text == String.Empty || tb_type.Text == String.Empty)
            {
                MessageBox.Show("Не все данные введены", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    mySqlAplication.Connect();

                    SqlCommand command = new SqlCommand($"UPDATE [Склады] SET Название = N'{tb_nameWarehouse.Text}' , Тип = N'{tb_type.Text}' , Заведующий = N'{tb_user.Text}' WHERE Id = '{tb_id.Text}'", mySqlAplication.sqlConnection);
                    command.ExecuteNonQuery();

                    mySqlAplication.sqlConnection.Close();
                    MessageBox.Show("Данные успешно были изменены", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateTable();
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void FillTexbox()
        {
            try
            {
                if (_row >= dataTable.Rows.Count)
                    _row = 0;
                if (_row < 0)
                    _row = dataTable.Rows.Count - 1;

                tb_id.Text = dataTable.Rows[_row][0].ToString();
                tb_nameWarehouse.Text = dataTable.Rows[_row][1].ToString();
                tb_type.Text = dataTable.Rows[_row][2].ToString();
                tb_user.Text = dataTable.Rows[_row][3].ToString();
            }
            catch
            {
                tb_nameWarehouse.Text = "";
                tb_type.Text = "";
                tb_user.Text = "";
            }
        }
        private void UpdateTable()
        {
            dataAdapter = new SqlDataAdapter("SELECT * FROM [Склады]", mySqlAplication.sqlConnection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
        }
    }
}
