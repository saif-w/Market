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
    public partial class item_report_form : Form
    {
        public item_report_form()
        {
            InitializeComponent();
        }

        private void item_report_form_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            load();
            this.reportViewer1.RefreshReport();

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            this.select_item_report1TableAdapter.Fill(this.dataSet5.select_item_report1, txtsearch.Text);
            this.reportViewer1.RefreshReport();

        }
        void load()
        {

            this.select_item_report1TableAdapter.Fill(this.dataSet5.select_item_report1, txtsearch.Text);
            this.reportViewer1.RefreshReport();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
