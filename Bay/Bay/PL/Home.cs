using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bay.BL;

namespace Bay.PL
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = _purn.cus_SELECTE("");
            int x = 0;
            DateTime d = DateTime.Now.Date;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][1].ToString() == d.ToString())
                {
                    x = x + Convert.ToInt32(dt.Rows[i][3]);
                }
            }
            textBox1.Text = x.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
