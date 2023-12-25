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
using Bay.PL;
using Bay.DAL;
namespace Bay.UC
{
    public partial class cus : UserControl
    {
        public cus()
        {
            InitializeComponent();
        }
        public void load()
        {
            try
            {
                dataGridView1.DataSource = _Cus.cus_SELECTE("");
            }
            catch
            {
             
            }
        }
        private void cus_Load(object sender, EventArgs e)
        {
            load(); sum();
            count();
            DateTime dt = new DateTime();
            txtdate.Text = DateTime.Now.ToString("dd/MM/yyyy").ToString();
           
           
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _Cus.cus_SELECTE(txtsearch.Text);
        }
        string user = Program.USERNAME;


        //*****************************
        void count()
        {
            try { txtcount.Text = _cus_id.cus_count_dain().Rows[0][0].ToString(); }
            catch
            {
               
            }


        }

        void sum()
        {
            try
            {//txttotal.Text = _quareycs.
             // txttotal.Text=_cus_id.cus_sum_dain().Rows[0][0].ToString();

                string x = string.Format("select money from cus");
                DataTable dt = DB.RunQuery(x);


                //   DataTable dt = _cus_id.cus_sum_dain_select();


                double v = 0;
                double c = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    double f = Convert.ToDouble(dt.Rows[i][0]);
                    c = c + f;

                }
                txttotal.Text = c.ToString();
                //double d = 0; double c = 0;
                //for (int i = 0; i < dt.Rows.Count; i++) { c = (d+Convert.ToDouble(dt.Rows[i][0]));return; }
                //txttotal.Text = c.ToString() ;
            }
            catch
            {
              
            }

        }
        //*****************************

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtmoney.Text == "")
            {
                MessageBox.Show("الرجاء ادخال بيانات");
            }
            else if (_customers.member_change(txtname.Text).Rows.Count > 0)
            {
                MessageBox.Show("يوجد هذا الاسم مسبقا");
            }
            else
            {
                _Cus.cus_insert(txtname.Text, txtmoney.Text, Convert.ToDateTime(txtdate.Text), user);
                MessageBox.Show("تمت الاضافة");
                load();
            }
            try
            {
              
            }
            catch
            {
                MessageBox.Show("!!يوجد خطاء الرجاء اعادة محاولة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("تأكيد الحذف", "هل تريد الحذف!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {

                    _Cus.cus_delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToDateTime(txtdate.Text));
                    MessageBox.Show("تمت الحذف");
                    load();
                }
                else
                {
                    string s = "";
                }
            }
            catch
            {
                MessageBox.Show("!!يوجد خطاء الرجاء اعادة محاولة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text == "" || txtmoney.Text == "")
                {
                    MessageBox.Show("الرجاء ادخال بيانات");
                }
                else if (_customers.member_change(txtname.Text).Rows.Count > 0)
                {
                    MessageBox.Show("يوجد هذا الاسم مسبقا");
                }
                else if (MessageBox.Show("تأكيد التعديل", "هل تريد التعديل!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {
                    _Cus.cus_update(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), txtname.Text, txtmoney.Text, Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value), user);
                    MessageBox.Show("تمت التعديل");
                    load();
                }
                else
                {
                    string s = "";
                }
            }
            catch
            {
                MessageBox.Show("!!يوجد خطاء الرجاء اعادة محاولة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        Bitmap bitmap;
        private void button7_Click(object sender, EventArgs e)
        {
            // Resize DataGridView to full height.
            int height = dataGridView1.Height;
            dataGridView1.Height = (dataGridView1.RowCount + 1) * dataGridView1.RowTemplate.Height;
            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0,
            0, this.dataGridView1.Width, this.dataGridView1.Height));
            //Resize DataGridView back to original height.
            dataGridView1.Height = height;
            //Show the Print Preview Dialog.
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            sum();
            count();
            load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtmoney.Text = "";
            txtname.Text = "";
        }

        private void txtmoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            { e.Handled = true; } // only allow one decimal point 
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) { e.Handled = true; }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
            {

                txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtmoney.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PL.Calcolater_cus c = new PL.Calcolater_cus();
            c.textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            c.a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            c.z = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            c.y = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            c.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            sum();
            count();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Rep.date_foater_report p = new Rep.date_foater_report();p.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Rep.foater_name_frm c = new Rep.foater_name_frm();c.Show();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
