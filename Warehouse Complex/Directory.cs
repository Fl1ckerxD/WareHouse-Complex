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
    public partial class Directory : Form
    {
        MySqlConnect mySqlConnect = new MySqlConnect();
        public Directory()
        {
            InitializeComponent();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTables("Select * from [Товары]");
        }    
        
        private void получателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTables("Select * from [Получатели]");
        }

        private void поставшикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTables("Select * from [Поставщики]");
        }

        private void работникикиСкладаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTables("Select * from [Работники склада]");
        }

        public void ShowTables(string select)
        {
            mySqlConnect.Connect();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, mySqlConnect.sqlConnection);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView.DataSource = dataSet.Tables[0];
        }

        private void tb_searcher_TextChanged(object sender, EventArgs e)
        {
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter = $"* LIKE '%{tb_searcher.Text}%'";
        }
    }
}
