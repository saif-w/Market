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
    public partial class fatora_view : Form
    {
        Prnc p;
        public fatora_view(Prnc pr)
        {
            p = pr;
            InitializeComponent();
        }
       void load()
        {
            dataGridView1.DataSource = _Cus.cus_SELECTE("");
        }
        private void fatora_view_Load(object sender, EventArgs e)
        {
            load();
        }

        private void txtserch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _Cus.cus_SELECTE(txtserch.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            p.txt_foter_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            p.txt_foter_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            p.txt_foter_money.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            p.txt_foter_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            p.txt_foter_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            p.txt_foter_money.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            p.txt_foter_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            p.txt_foter_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            p.txt_foter_money.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.Close();
        }
    }
}
