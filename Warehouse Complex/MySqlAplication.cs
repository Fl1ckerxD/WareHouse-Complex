using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Warehouse_Complex
{
    class MySqlAplication
    {
        public SqlConnection sqlConnection = null;
        public void Connect()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            sqlConnection.Open();
        }
        public void ShowTable(string select,DataGridView dataGridView)
        {
            Connect();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, sqlConnection);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView.DataSource = dataSet.Tables[0];
        }
        public void SearchItem(DataGridView dataGridView, ComboBox comboBox, TextBox tb_searcher)
        {
            try
            {
                (dataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[{comboBox.Text}] LIKE '%{tb_searcher.Text}%'";
            }
            catch
            {

            }        
        }
        public void Fillcombobox(string com, string valueMem, string displayMem, ComboBox comboBox)
        {
            Connect();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(com, sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            comboBox.DataSource = dataSet.Tables[0];
            comboBox.ValueMember = valueMem;
            comboBox.DisplayMember = displayMem;
            sqlConnection.Close();
        }
    }
}
