using Bay.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bay.Rep
{
    public partial class detales_pur_report_ : Form
    {
        public detales_pur_report_()
        {
            InitializeComponent();
        }

        private void detales_pur_report__Load(object sender, EventArgs e)
        {
            detale_purn d = new detale_purn();
           // txtsearch.Text = d.dataGridView1.CurrentRow.Cells[1].Value.ToString();

            this.reportViewer1.RefreshReport();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            this.purchesesTableAdapter.Fill(this.dataSet2.Purcheses, Convert.ToInt32(txtsearch.Text));
            this.purcheses1TableAdapter.Fill(this.dataSet2.Purcheses1, Convert.ToInt32(txtsearch.Text));
            try { this.select_detales_pruncher_reportTableAdapter.Fill(this.dataSet2.select_detales_pruncher_report, Convert.ToInt32(txtsearch.Text)); } catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            // this.dataTable1TableAdapter.Fill(this.dataSet2.DataTable1, Convert.ToInt32(txtsearch.Text));
            this.reportViewer1.RefreshReport();


        }
    }
}
