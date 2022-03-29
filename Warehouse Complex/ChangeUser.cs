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
    public partial class ChangeUser : Form
    {
        MySqlAplication mySqlAplication = new MySqlAplication();
        SqlDataAdapter dataAdapter = null;
        DataTable dataTableWorkes = null;
        DataTable dataTableUsers = null;

        private int _row = 0;
        public ChangeUser()
        {
            InitializeComponent();
        }
        private void ChangeUser_Load(object sender, EventArgs e)
        {
            mySqlAplication.Connect();

            UpdateTable("SELECT * FROM Worker");
            UpdateTableUser("SELECT * FROM User");

            FillTexbox();          

            mySqlAplication.Fillcombobox("SELECT * FROM TypeUser", "Id", "Название", cb_typeUser);

            switch (MySqlAplication.typeUser) 
            {
                case 0:
                    tabControl1.TabPages[1].Enabled = false;
                    break;
                case 1:
                    tabControl1.TabPages[1].Enabled = true;
                    FillTextboxUser();
                    break;
                case 2:
                    tabControl1.TabPages[1].Enabled = false;
                    break;
                case 3:
                    tabControl1.TabPages[1].Enabled = false;
                    break;
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
            if (tb_surname.Text == String.Empty || tb_name.Text == String.Empty)
            {
                MessageBox.Show("Не все данные введены", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    mySqlAplication.Connect();

                    SqlCommand command = new SqlCommand($"UPDATE Worker SET Surname = N'{tb_surname.Text}' , Name = N'{tb_name.Text}' , Patronymic = N'{tb_patronic.Text}' , Position = N'{tb_dol.Text}' WHERE Id = '{tb_id.Text}'", mySqlAplication.sqlConnection);
                    command.ExecuteNonQuery();

                    mySqlAplication.sqlConnection.Close();
                    MessageBox.Show("Данные успешно были изменены", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateTable("SELECT * FROM Worker");
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
                if (_row >= dataTableWorkes.Rows.Count)
                    _row = 0;
                if (_row < 0)
                    _row = dataTableWorkes.Rows.Count - 1;

                tb_id.Text = dataTableWorkes.Rows[_row][0].ToString();
                tb_surname.Text = dataTableWorkes.Rows[_row][1].ToString();
                tb_name.Text = dataTableWorkes.Rows[_row][2].ToString();
                tb_patronic.Text = dataTableWorkes.Rows[_row][3].ToString();
                tb_dol.Text = dataTableWorkes.Rows[_row][4].ToString();
            }
            catch
            {
                tb_surname.Text = "";
                tb_name.Text = "";
                tb_patronic.Text = "";
                tb_dol.Text = "";
            }
        }
        private void FillTextboxUser()
        {
            try
            {
                if (_row >= dataTableUsers.Rows.Count)
                    _row = 0;
                if (_row < 0)
                    _row = dataTableUsers.Rows.Count - 1;

                tb_login.Text = dataTableUsers.Rows[_row][0].ToString();
                tb_password.Text = dataTableUsers.Rows[_row][1].ToString();
                tb_userid.Text = dataTableUsers.Rows[_row][3].ToString();
                cb_typeUser.SelectedIndex = Convert.ToInt32(dataTableUsers.Rows[_row][2]) - 1;
            }
            catch
            {
                cb_typeUser.Text = "";
            }
        }
        private void UpdateTable(string select)
        {
            dataAdapter = new SqlDataAdapter(select, mySqlAplication.sqlConnection);
            dataTableWorkes = new DataTable();
            dataAdapter.Fill(dataTableWorkes);
        }
        private void UpdateTableUser(string select)
        {
            dataAdapter = new SqlDataAdapter(select, mySqlAplication.sqlConnection);
            dataTableUsers = new DataTable();
            //dataAdapter.Fill(dataTableUsers);
        }

        private void b_back1_Click(object sender, EventArgs e)
        {
            _row--;
            FillTextboxUser();
        }

        private void b_next1_Click(object sender, EventArgs e)
        {
            _row++;
            FillTextboxUser();
        }

        private void b_updateUser_Click(object sender, EventArgs e)
        {
            if (tb_login.Text == String.Empty || tb_password.Text == String.Empty)
            {
                MessageBox.Show("Не все данные введены", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    mySqlAplication.Connect();

                    SqlCommand command = new SqlCommand($"UPDATE User SET Password = N'{tb_password.Text}' , Type = N'{cb_typeUser.SelectedValue}' WHERE Login = N'{tb_login.Text}'", mySqlAplication.sqlConnection);
                    command.ExecuteNonQuery();

                    mySqlAplication.sqlConnection.Close();
                    MessageBox.Show("Данные успешно были изменены", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateTableUser("SELECT * FROM User");
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
