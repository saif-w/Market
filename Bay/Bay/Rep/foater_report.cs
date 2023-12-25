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
    public partial class foater_report : Form
    {
        public foater_report()
        {
            InitializeComponent();
        }

        private void foater_report_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter.Fill(this.dataSet4.DataTable1, Convert.ToInt32(txtsearch.Text));
            this.foaterTableAdapter.Fill(this.dataSet4.foater, Convert.ToInt32(txtsearch.Text));
            this.select_detales_pruncher_reportTableAdapter.Fill(this.dataSet2.select_detales_pruncher_report, Convert.ToInt32(txtsearch.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
