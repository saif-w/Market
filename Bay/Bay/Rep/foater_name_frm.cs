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
    public partial class foater_name_frm : Form
    {
        public foater_name_frm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            load();
        }
        void load()
        {

            this.foater_nameTableAdapter.Fill(this.dataSet4.foater_name, txtsearch.Text);
            this.reportViewer1.RefreshReport();

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            load();
        }
    }
}
