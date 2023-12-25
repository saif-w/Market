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
using Bay.DAL;
namespace Bay.UC
{
    public partial class Items : UserControl
    {
        public Items()
        {
            InitializeComponent();
        }
        string user = Program.USERNAME;
        private void Items_Load(object sender, EventArgs e)
        {
            comunit.SelectedIndex = 0;

            //txtusername.Text = _Members.user_().ToString();
            
           load();
        }
      public void load()
        {  
            try {
              dataGridView1.Refresh();
                dataGridView1.DataSource = _items.items_SELECTE(""); }
            catch
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (txtbay.Text == "" || txtitem.Text == "" || txtqualty.Text == "" || txtsell.Text == "" ) { MessageBox.Show("الرجاء التأكد من تعبئة البيانات"); }
                else
                {
                    _items.items_insert(txtitem.Text, txtbay.Text, txtsell.Text, comunit.SelectedItem.ToString(), txtqualty.Text, user, txtnote.Text);
                    load();
                    MessageBox.Show("تمت الاضافة");
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
                if (MessageBox.Show("تم التعديل بي نجاح", "هل تريد التعديل!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {
                    _items.items_update(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), txtitem.Text, txtbay.Text, txtsell.Text, comunit.SelectedItem.ToString(), txtqualty.Text, user, txtnote.Text);
                    load();
                    MessageBox.Show("تمت التعديل بي نجاح", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);

                }
                else
                {
                    string x = "";
                }
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
                if (txtbay.Text == "" || txtitem.Text == "" || txtqualty.Text == "" || txtsell.Text == "" || txtusername.Text == "") { MessageBox.Show("الرجاء التأكد من تعبئة البيانات"); }

               else if (MessageBox.Show("تأكيد الحذف", "هل تريد الحذف!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {
                    _items.items_delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    load();
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

        private void number(object sender, KeyPressEventArgs e)
        {
            char s = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != s)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txtitem.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtbay.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txtsell.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    comunit.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    txtqualty.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    //  txtusername.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    //txtnote.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                }
                catch { MessageBox.Show("!!يوجد خطاء الرجاء اعادة محاولة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
        private void txtserach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = _items.items_SELECTE(txtserach.Text);
            }
            catch { MessageBox.Show("!!يوجد خطاء الرجاء اعادة محاولة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

        private void button4_Click(object sender, EventArgs e)
        {

            txtbay.Text = "";
            txtitem.Text = "";
            txtnote.Text = "";
            txtsell.Text = "";
            txtqualty.Text = "";
            
        }

        private void number1(object sender, KeyPressEventArgs e)
        {
            char s = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            load();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }
        Bitmap bitmap;
        private void button7_Click(object sender, EventArgs e)
        {
            //// Resize DataGridView to full height.
            //int height = dataGridView1.Height;
            //dataGridView1.Height = (dataGridView1.RowCount + 1) * dataGridView1.RowTemplate.Height;
            ////Create a Bitmap and draw the DataGridView on it.
            //bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            //dataGridView1.DrawToBitmap(bitmap, new Rectangle(0,
            //0, this.dataGridView1.Width, this.dataGridView1.Height));
            ////Resize DataGridView back to original height.
            //dataGridView1.Height = height;
            ////Show the Print Preview Dialog.
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            //printPreviewDialog1.ShowDialog();
            Rep.item_report_form r = new Rep.item_report_form();r.Show();

            
        }

        private void button3_Click_1(object sender, EventArgs e)
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
