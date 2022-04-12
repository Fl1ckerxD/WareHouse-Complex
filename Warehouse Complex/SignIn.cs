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
    public partial class SignIn : Form
    {
        MySqlAplication mySqlAplication = new MySqlAplication();
        public SignIn()
        {
            InitializeComponent();
        }

        private void b_signin_Click(object sender, EventArgs e)
        {
            if(tb_login.Text == String.Empty || tb_password.Text == String.Empty)
            {
                MessageBox.Show("Не все данные введены", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mySqlAplication.Connect();

                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM [User] WHERE Login = N'{tb_login.Text}' AND Password = N'{tb_password.Text}'", mySqlAplication.sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    MySqlAplication.idUser = Convert.ToInt32(dataTable.Rows[0][0].ToString());
                    switch (dataTable.Rows[0][3])
                    {
                        case 1:
                            MySqlAplication.typeUser = 1;
                            ShowMainWin();
                            break;

                        case 2:
                            MySqlAplication.typeUser = 2;
                            ShowMainWin();
                            break;

                        case 3:
                            MySqlAplication.typeUser = 3;
                            ShowMainWin();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Не верный логин или пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }          
        }
        private void ShowMainWin()
        {
            Form1 mainWin = new Form1();
            mainWin.Show();
            this.Hide();
        }

        private void b_registr_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }
    }
}
