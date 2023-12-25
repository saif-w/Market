using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bay.PL;
using Bay.BL;
namespace Bay.UC
{
    public partial class detales_sells : UserControl
    {
        public detales_sells()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sale p = new sale(this); p.Show();
        }
    public  void load()
        {
            dataGridView1.DataSource= _detales_sale.cus_SELECTE("");
        }
        private void detales_sells_Load(object sender, EventArgs e)
        {
            load();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _detales_sale.cus_SELECTE(txtsearch.Text);
        }
        string date1 = DateTime.Now.ToShortDateString();
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("تأكيد الحذف", "هل تريد الحذف!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {

                    _detales_sale._delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToDateTime(date1));
                    MessageBox.Show("تمت الحذف");
                    load();
                }
                } catch { MessageBox.Show("يجب تحديد قيمة اولا"); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {

                load();
            }
            else
            {
                dataGridView1.DataSource = _detales_sale.cus_SELECTE(txtsearch.Text);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { Rep.sales_reprt_frm c = new Rep.sales_reprt_frm(); c.txtsearch.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); c.Show(); } catch { MessageBox.Show("تاكد من تحديد احد العناصر "); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Rep.sale_date_frm c = new Rep.sale_date_frm();c.Show();
        }
    }
}
