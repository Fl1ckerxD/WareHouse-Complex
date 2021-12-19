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
    public partial class Registration : Form
    {
        MySqlAplication mySqlAplication = new MySqlAplication();
        public Registration()
        {
            InitializeComponent();
        }

        private void b_reg_Click(object sender, EventArgs e)
        {
            if (tb_login.Text == String.Empty || tb_password.Text == String.Empty || tb_surname.Text == String.Empty || tb_name.Text == String.Empty)
            {
                MessageBox.Show("Не все данные введены", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    mySqlAplication.Connect();

                    SqlCommand command = new SqlCommand("INSERT INTO [Работники склада] (Фамилия, Имя, Отчество) " +
                       "VALUES (@Фамилия, @Имя, @Отчество)", mySqlAplication.sqlConnection);

                    command.Parameters.AddWithValue("Фамилия", tb_surname.Text);
                    command.Parameters.AddWithValue("Имя", tb_name.Text);
                    command.Parameters.AddWithValue("Отчество", tb_patronic.Text);
                    command.ExecuteNonQuery();

                    command = new SqlCommand("INSERT INTO Логины (Логин, Пароль, Пользователь_id) " +
                        "VALUES (@Логин, @Пароль, @Пользователь_id)", mySqlAplication.sqlConnection);

                    command.Parameters.AddWithValue("Логин", tb_login.Text);
                    command.Parameters.AddWithValue("Пароль", tb_password.Text);
                    command.Parameters.AddWithValue("Пользователь_id", idUser());
                    command.ExecuteNonQuery();

                    mySqlAplication.sqlConnection.Close();
                    MessageBox.Show("Регистрация прошла успешна", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string idUser()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select id from [Работники склада]", mySqlAplication.sqlConnection);
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            return Convert.ToString(dataTable.Rows[dataTable.Rows.Count - 1][0]);
        }

        private void b_back_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }
    }
}
