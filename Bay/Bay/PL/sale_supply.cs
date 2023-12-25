using Bay.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bay.PL
{
    public partial class sale_supply : Form
    {
        sale s;
        public sale_supply(sale sa)
        {
            this.s = sa;
            InitializeComponent();
        }
        void load()
        {
            dataGridView1.DataSource = _suplies.cus_SELECTE("");
        }
        private void sale_supply_Load(object sender, EventArgs e)
        {
            load();
        }

        private void txtserch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _suplies.cus_SELECTE(txtserch.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            s.txt_suplly_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            s.txtsupply_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            s.txtsuplly_company.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            this.Close();

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            s.txt_suplly_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            s.txtsupply_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            s.txtsuplly_company.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            this.Close();
        }
    }
}
