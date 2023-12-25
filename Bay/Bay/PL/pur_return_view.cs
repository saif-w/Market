using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bay.BL;
using Bay.UC;
namespace Bay.PL
{
    public partial class pur_return_view : Form
    {
        Return_sells r;
        public pur_return_view(Return_sells rs)
        {
            this.r = rs;
            InitializeComponent();
        }
        void load()
        {
            dataGridView1.DataSource = _detales_pur.cus_SELECTE("");
        }
        private void pur_return_view_Load(object sender, EventArgs e)
        {
            load();
        }

        private void txtserch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _detales_pur.cus_SELECTE(txtserch.Text);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            r.txtid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            r.txtid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Close();
        }
    }
}
