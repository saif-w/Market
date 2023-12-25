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
    public partial class coustmer_name : Form
    {
        public coustmer_name()
        {
            InitializeComponent();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            load();
        }
        void load()
        {

            this.customer_nameTableAdapter.Fill(this.dataSet3.customer_name, txtsearch.Text);
            this.reportViewer1.RefreshReport();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
