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
    public partial class detale_purn : UserControl
    {
        public detale_purn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Prnc d = new Prnc(this);d.Show();
        }
       public void load()
        {
            dataGridView1.DataSource = _detales_pur.cus_SELECTE("");
        }
        void load_()
        {
            dataGridView1.DataSource = _detales_pur.cus_SELECTE("");
        }
        string date1 = DateTime.Now.ToShortDateString();
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("تأكيد الحذف", "هل تريد الحذف!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {

                    _detales_pur._delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToDateTime(date1));
                    MessageBox.Show("تمت الحذف");
                    load();
                }
            }
            catch { MessageBox.Show("يجب تحديد قيمة اولا"); }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _detales_pur.cus_SELECTE(txtsearch.Text);
        }

        private void detale_purn_Load(object sender, EventArgs e)
        {
            load(); load_();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
               
                load();
            }
            else
            {
                dataGridView1.DataSource = _detales_pur.cus_SELECTE(txtsearch.Text);
              
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Rep.detales_pur_report_ r = new Rep.detales_pur_report_();r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (_detales_pur.reprt_pur(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value)).Rows.Count == 1)
                { radioButton1.Checked = true; radioButton2.Checked = false; radioButton3.Checked = false; }
                else if (_detales_pur.reprt_dain(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value)).Rows.Count == 1)
                { radioButton2.Checked = true; radioButton1.Checked = false; radioButton3.Checked = false; }
                else if (_detales_pur.reprt_foater(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value)).Rows.Count == 1)
                { radioButton2.Checked = false; radioButton1.Checked = false; radioButton3.Checked = true; }
            }
            catch { MessageBox.Show("لم تتم العملية1"); }
            try
            {
                if (radioButton1.Checked == true) { Rep.detales_pur_report_ c = new Rep.detales_pur_report_(); c.txtsearch.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); c.Show(); }
                else if (radioButton2.Checked == true) { Rep.customer_report c = new Rep.customer_report(); c.txtsearch.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); c.Show(); }
                else if (radioButton3.Checked == true) { Rep.foater_report c = new Rep.foater_report(); c.txtsearch.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); c.Show(); }
            }
            catch { MessageBox.Show("تاكد من تحديد احد العناصر "); }

            
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rep.foater_report f = new Rep.foater_report();f.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Form2 f = new Form2();f.Show();
            //Rep.date_foater_report n = new Rep.date_foater_report();n.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            Rep.date_rep_pur o = new Rep.date_rep_pur();o.Show();
        }
    }
}
