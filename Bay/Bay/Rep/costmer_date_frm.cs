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
    public partial class costmer_date_frm : Form
    {
        public costmer_date_frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.customer_dateTableAdapter.Fill(this.dataSet3.customer_date, datestart.Text, dateend.Text);
            this.reportViewer1.RefreshReport();

        }
    }
}
