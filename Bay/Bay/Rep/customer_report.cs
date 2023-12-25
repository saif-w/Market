using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bay.UC;
namespace Bay.Rep
{
    public partial class customer_report : Form
    {
        public customer_report()
        {
            InitializeComponent();
        }

        private void customer_report_Load(object sender, EventArgs e)
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
            this.customer_idTableAdapter.Fill(this.dataSet3.customer_id, Convert.ToInt32(txtsearch.Text));
            this.customersTableAdapter.Fill(this.dataSet3.customers, Convert.ToInt32(txtsearch.Text));
            this.select_detales_pruncher_reportTableAdapter.Fill(this.dataSet2.select_detales_pruncher_report , Convert.ToInt32(txtsearch.Text));
            this.reportViewer1.RefreshReport();

        }
    }
}
