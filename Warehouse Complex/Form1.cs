using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Complex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_aboutProgram_Click(object sender, EventArgs e)
        {
            AboutProgram aboutProgram = new AboutProgram();
            aboutProgram.Show();
        }
        public void loadform(object Form)
        {
            if (this.p_showing.Controls.Count > 0)
                this.p_showing.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.p_showing.Controls.Add(f);
            this.p_showing.Tag = f;
            f.Show();
        }

        private void b_directory_Click(object sender, EventArgs e)
        {
            loadform(new Directory());
        }
    }
}
