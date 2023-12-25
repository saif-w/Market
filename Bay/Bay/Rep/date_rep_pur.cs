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
    public partial class date_rep_pur : Form
    {
        public date_rep_pur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.select_pruncher_reportTableAdapter.Fill(this.dataSet2.select_pruncher_report, Convert.ToDateTime(datestart.Text), Convert.ToDateTime(dateend.Text));
            this.reportViewer1.RefreshReport();

        }
    }
}
