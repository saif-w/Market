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
    public partial class date_foater_report : Form
    {
        public date_foater_report()
        {
            InitializeComponent();
        }

        private void date_foater_report_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.foter_dateTableAdapter.Fill(this.dataSet4.foter_date,datestart.Text, dateend.Text);
            this.reportViewer1.RefreshReport();

        }
    }
}
