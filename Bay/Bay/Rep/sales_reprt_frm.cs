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
    public partial class sales_reprt_frm : Form
    {
        public sales_reprt_frm()
        {
            InitializeComponent();
        }

        private void sales_reprt_frm_Load(object sender, EventArgs e)
        {

          //  this.reportViewer1.RefreshReport();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.salesTableAdapter.Fill(this.dataSet7.sales, Convert.ToInt32(txtsearch.Text));
            this.sale_1TableAdapter.Fill(this.dataSet7.sale_1, Convert.ToInt32(txtsearch.Text));
            this.select_detales_sales_reportTableAdapter.Fill(this.dataSet7.select_detales_sales_report, Convert.ToInt32(txtsearch.Text));
            this.reportViewer1.RefreshReport();

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            this.salesTableAdapter.Fill(this.dataSet7.sales, Convert.ToInt32(txtsearch.Text));
            this.sale_1TableAdapter.Fill(this.dataSet7.sale_1, Convert.ToInt32(txtsearch.Text));
            this.select_detales_sales_reportTableAdapter.Fill(this.dataSet7.select_detales_sales_report, Convert.ToInt32(txtsearch.Text));
            this.reportViewer1.RefreshReport();

        }
    }
}
