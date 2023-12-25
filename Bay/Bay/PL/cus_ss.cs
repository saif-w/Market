using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bay.BL;
namespace Bay.PL
{
    public partial class cus_ss : Form
    {
        public cus_ss()
        {
            InitializeComponent();
        }

        private void cus_ss_Load(object sender, EventArgs e)
        {
          
                load_c();

        }
        void load_c()
        {
            try { 
            dataGridView1.DataSource = _customers.cus_SELECTE("");
            }
            catch { MessageBox.Show("!!يوجد خطاء الرجاء اعادة محاولة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //void load_p()
        //{
        //    dataGridView1.DataSource = _purn.cus_SELECTE("");
        //}

        private void txtserach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = _customers.cus_SELECTE(txtserach.Text);
            }
            catch { MessageBox.Show("!!يوجد خطاء الرجاء اعادة محاولة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = _purn.cus_SELECTE("");
            int x =0;
            DateTime d = DateTime.Now.Date;
            for (int i=0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][1].ToString() == d.ToString())
                {
                    x =x +Convert.ToInt32(dt.Rows[i][3]);
              }
            }
            //textBox1.Text = x.ToString();
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            PL.main_form r = new PL.main_form();
            r.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("تأكيد الحذف", "هل تريد الحذف!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {
                    DateTime d = DateTime.Now.Date;
                    _customers.purc_delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToDateTime(d));

                    load_c();
                    MessageBox.Show("تمت الحذف بي نجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            //dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //textBox1.Text = _cus_id.cus_dain(txtserach.Text).Rows[0][0].ToString();
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try { 
            string x = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            DataTable dt = _cus_id.cus_SELECTE("");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][1].ToString() == x)
                {
                    textBox1.Text = dt.Rows[i][2].ToString(); return;
                }

            }
            }
            catch { MessageBox.Show("!!يوجد خطاء الرجاء اعادة محاولة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
            
        }
        Bitmap bitmap;
        private void button4_Click_2(object sender, EventArgs e)
        {
           // Resize DataGridView to full height.
            int height = dataGridView1.Height;
            dataGridView1.Height = (dataGridView1.RowCount+1) * dataGridView1.RowTemplate.Height;
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
          
        }
    }
    }

