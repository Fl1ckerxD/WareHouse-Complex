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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wareHouseDataSet.Good". При необходимости она может быть перемещена или удалена.
            this.goodTableAdapter.Fill(this.wareHouseDataSet.Good);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouse_ComplexDataSet.Склады". При необходимости она может быть перемещена или удалена.
            this.складыTableAdapter.Fill(this.warehouse_ComplexDataSet.Склады);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouse_ComplexDataSet.Работники_склада". При необходимости она может быть перемещена или удалена.
            this.работники_складаTableAdapter.Fill(this.warehouse_ComplexDataSet.Работники_склада);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouse_ComplexDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.warehouse_ComplexDataSet.Поставщики);

            mySqlAplication.Fillcombobox("SELECT Id, Title FROM Good WHERE State = N'На складе'", "Title", "Название", cb_goodsLoc);
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
                        "INSERT INTO Good (Title, Size, Weight, State) " +
                        "VALUES (@Title, @Size, @Weight, @State)", mySqlAplication.sqlConnection);

                    command.Parameters.AddWithValue("Title", tb_nameGood.Text);
                    command.Parameters.AddWithValue("Size", cb_size.Text);
                    command.Parameters.AddWithValue("Weight", tb_weight.Text);
                    command.Parameters.AddWithValue("State", "На складе");
                    command.ExecuteNonQuery();

                    command = new SqlCommand(
                        "INSERT INTO Supply (Date, GoodId, SupplientTitle, SupplientName, RecipientName) " +
                        "VALUES (@Date, @GoodId, @SupplientTitle, @SupplientName, @RecipientName)", mySqlAplication.sqlConnection);

                    command.Parameters.AddWithValue("Date", dateTimePicker.Value);
                    command.Parameters.AddWithValue("GoodId", idGood());
                    command.Parameters.AddWithValue("SupplientTitle", cb_nameSupplier.SelectedValue);
                    command.Parameters.AddWithValue("SupplientName", cb_fio.SelectedValue);
                    command.Parameters.AddWithValue("RecipientName", tb_fioGiver.Text);
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
        private string idGood()
        {          
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Id from Good", mySqlAplication.sqlConnection);
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            return Convert.ToString(dataTable.Rows[dataTable.Rows.Count - 1][0]);
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
                        "INSERT INTO Supplier (Name, Street, Phone) " +
                        "VALUES (@Name, @Street, @Phone)", mySqlAplication.sqlConnection);

                    command.Parameters.AddWithValue("Name", tb_nameSupp.Text);
                    command.Parameters.AddWithValue("Street", tb_adress.Text);
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

        private void b_addLoc_Click(object sender, EventArgs e)
        {
            if (cb_goodsLoc.Text == String.Empty || cb_warehouse.Text == String.Empty || tb_numberShelf.Text == String.Empty)
            {
                MessageBox.Show("Не все данные введены", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    mySqlAplication.Connect();

                    SqlCommand command = new SqlCommand(
                        "INSERT INTO ProductLocation (GoodId, WarehouseId, NumberShelf) " +
                        "VALUES (@GoodId, @WarehouseId, @NumberShelf)", mySqlAplication.sqlConnection);

                    command.Parameters.AddWithValue("GoodId", cb_goodsLoc.SelectedValue);
                    command.Parameters.AddWithValue("WarehouseId", cb_warehouse.SelectedValue);
                    command.Parameters.AddWithValue("NumberShelf", tb_numberShelf.Text);
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
