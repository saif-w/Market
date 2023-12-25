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
    public partial class sale_name_frm : Form
    {
        public sale_name_frm()
        {
            InitializeComponent();
        }
        void load()
        {

            this.sale_nameTableAdapter.Fill(this.dataSet7.sale_name, txtsearch.Text);
            this.reportViewer1.RefreshReport();

        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            load();
        }
    }
}
