using Bay.BL;
using Bay.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bay.PL
{
    public partial class sale : Form
    {
        detales_sells d;
        public sale(detales_sells ds)
        {
            this.d = ds;
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sale_supply sp = new sale_supply(this);
            sp.Show();
        }
        void calcoleter()
        {
            txtitem_count.Text = dataGridView1.Rows.Count.ToString();
            //*******************
            Double totalpay = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                totalpay += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);

            }

            txttotal_prn.Text = totalpay.ToString();
        }
        string user = Program.USERNAME;
        private void button1_Click(object sender, EventArgs e)
        {
            item_sale it = new item_sale(this);
            it.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtid.Text == "")
            {
                MessageBox.Show("يجب اختيار قيمة");
                return;
            }
            else if (txtqulty.Text == "0" || txtqulty.Text == "")
            {
                MessageBox.Show("يجب وضع كمية معينة");
                return;
            }

            //else if (Convert.ToInt32(txtqulty.Text) > Convert.ToInt32(txt_qul.Text))
            //{
            //    MessageBox.Show("لايمكنك ادخال كمية اكبر من التي في المخزن");
            //}
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtid.Text)
                    {
                        MessageBox.Show("هذه القيمة موجودة مسبقا"); return;
                    }

                }

                dataGridView1.Rows.Add(txtid.Text, txtItem.Text, txtprice.Text, txtqulty.Text, txtresolt.Text, txtnotes.Text);
                //*****************************************
                txtid.Text = "";
                txtItem.Text = "";
                txtprice.Text = ""; txtqulty.Text = "0"; txtresolt.Text = ""; txtnotes.Text = "";
                calcoleter();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txtItem.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtprice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txtqulty.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    txtresolt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    txtnotes.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    calcoleter();
                }
                else
                { MessageBox.Show("الرجاء اختيار البيانات "); }
            }
            catch { }
    }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            calcoleter();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            calcoleter();
        }

        private void txtqulty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != s)
            {
                e.Handled = true;
            }
        }

        private void txtqulty_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Double buytotal = Convert.ToDouble(txtprice.Text) * Convert.ToDouble(txtqulty.Text);
                txtresolt.Text = buytotal.ToString();
            }
            catch { }

        }

        private void txttotal_bay_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != s)
            {
                e.Handled = true;
            }

        }

        private void txttotal_bay_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Double dd = Convert.ToDouble(txttotal_bay.Text) - Convert.ToDouble(txttotal_prn.Text);
                txttotal_resolt.Text = dd.ToString();
            }
            catch { }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txttotal_bay.Text == "" || txttotal_bay.Text == "")
                {
                    MessageBox.Show("الرجاء التأكد من تعبأت جميع البيانات");
                }
                else if (txtsuplly_company.Text == "" || txtsupply_name.Text == "" || txt_suplly_id.Text == "") { MessageBox.Show("الرجاء ادخال المورد"); }

                else
                {
                    _sale.purc_insert(Convert.ToInt32(txt_detale_id.Text), Convert.ToInt32(txt_suplly_id.Text), Convert.ToDateTime(dateTimePicker1.Text), txtnotes.Text, user, txtitem_count.Text, txttotal_bay.Text, txttotal_bay.Text);
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        _detales_sale.cus_insert(Convert.ToInt32(txt_detale_id.Text), Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), dataGridView1.Rows[i].Cells[2].Value.ToString(), dataGridView1.Rows[i].Cells[3].Value.ToString(), dataGridView1.Rows[i].Cells[4].Value.ToString(), dataGridView1.Rows[i].Cells[5].Value.ToString(), txtusername.Text, Convert.ToDateTime(dateTimePicker1.Text));
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++) { _items.items_qualty_plass(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value)); }

                    d.load();
                    dd_empty();
                    txt_detale_id.Text = _detales_pur.cussells_max().Rows[0][0].ToString();
                    MessageBox.Show("تمت الاضافة الخالص");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("!!يوجد خطاء الرجاء اعادة محاولة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void dd_empty()
        {
            txtid.Text = "";
            txtItem.Text = "";
            txtprice.Text = ""; txtqulty.Text = "0"; txtresolt.Text = ""; txtnotes.Text = ""; txt_detales_note.Text = "";
            txtitem_count.Text = ""; txttotal_prn.Text = ""; txttotal_bay.Text = ""; txttotal_resolt.Text = "";
            txtsuplly_company.Text = "";txtsupply_name.Text = "";txt_suplly_id.Text = "";
            dataGridView1.Rows.Clear();
        }
        private void sale_Load(object sender, EventArgs e)
        {
            txtusername.Text = Program.USERNAME;
            txt_detale_id.Text = _detales_pur.cussells_max().Rows[0][0].ToString();
            txttotal_bay.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtqulty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
