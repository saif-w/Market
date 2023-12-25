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
namespace Bay.PL
{
    public partial class cus_id_view : Form
    {
        Prnc p;
        public cus_id_view(Prnc pr)
        {
            p = pr;
            InitializeComponent();
        }

        private void cus_id_view_Load(object sender, EventArgs e)
        {
            load();
        }
        void load()
        {
         dataGridView1.DataSource= _cus_id.cus_SELECTE("");
        }

        private void txtserch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _cus_id.cus_SELECTE(txtserch.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            p.txt_cusid_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            p.txtcusid_name .Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            p.txtmoney.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            p.txt_cusid_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            p.txtcusid_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            p.txtmoney.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            p.txt_cusid_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            p.txtcusid_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            p.txtmoney.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.Close();

        }
    }
}
