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
namespace Bay.UC
{
    public partial class Return_sells : UserControl
    {
        public Return_sells()
        {
            InitializeComponent();
        }

        private void Return_sells_Load(object sender, EventArgs e)
        {
          //  load();
        }
        void hh()
        {
          if( txtid.Text == "")
            {

            }
            else {
               // txtname.Text = _return_pur.cus_SELECTE(Convert.ToInt32(txtid.Text)).Rows[0][0].ToString() + _return_pur.cus_id_SELECTE(Convert.ToInt32(txtid.Text)).Rows[0][0].ToString();
                comitem.DataSource = _return_pur.item_pur_SELECTE(Convert.ToInt32(txtid.Text));
                comitem.DisplayMember = "item_name";
                comitem.ValueMember = "id";
                load();
            }
                
            
        }
        private void txtitem_KeyDown(object sender, KeyEventArgs e)
        {
            
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                   // txtname.Text = _return_pur.cus_SELECTE(Convert.ToInt32(txtid.Text)).Rows[0][0].ToString() + _return_pur.cus_id_SELECTE(Convert.ToInt32(txtid.Text)).Rows[0][0].ToString();
                    comitem.DataSource = _return_pur.item_pur_SELECTE(Convert.ToInt32(txtid.Text));
                    comitem.DisplayMember = "item_name";
                    comitem.ValueMember = "id";
                   // load();
                }
            }


            catch {
               // txtname.Text = txtprice.Text = txtqut.Text = txttotal.Text = "";
                dataGridView1.DataSource = null;
                comitem.DataSource = null;
                MessageBox.Show("رقم الفاتورة غير موجود");
            }
        }
        void load()
        {
            dataGridView1.DataSource= _return_pur._SELECTE(Convert.ToInt32(txtid.Text));
        }
        private void txtitem_TextChanged(object sender, EventArgs e)
        {

        }
        string user = Program.USERNAME;
        string date1 = DateTime.Now.ToString("dd/MM/yyyy").ToString();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtqut.Text) > qte)
                {
                    MessageBox.Show("يجب ادخال كمية اقل من التي في الفاتورة");
                }

                else if (Convert.ToDouble(txtqut.Text) == qte)
                {

                    _detales_pur._delete(Convert.ToInt32(txtid.Text), Convert.ToDateTime(date1));
                    _items.items_qualty_plass_return(Convert.ToInt32(txtid.Text), Convert.ToDouble(txtqut.Text));

                    MessageBox.Show("تمت الاضافة");



                }
                else
                {
                    DataTable dt = _return_pur.SELECTE_coustomer_view(Convert.ToInt32(txtid.Text));
                    int a = Convert.ToInt32(dt.Rows[0][0].ToString()); Double b = Convert.ToDouble(dt.Rows[0][1].ToString()); Double c = Convert.ToDouble(dt.Rows[0][2].ToString());
                    _return_pur._update(Convert.ToInt32(txtid.Text));
                    _return_pur._insert(Convert.ToInt32(txtid.Text), comitem.Text, user, txtprice.Text, txtqut.Text, txttotal.Text, Convert.ToDateTime(date1));
                    _return_pur._insert(Convert.ToInt32(txtid.Text), comitem.Text.ToString(), user, txtprice.Text, txtqut.Text, txttotal.Text, Convert.ToDateTime(date1));
                    MessageBox.Show("تمت الاضافة");
                    load();
                }
            } catch (Exception ex) { MessageBox.Show(ex.ToString()); }
           
           
        }

        private void txtqut_KeyUp(object sender, KeyEventArgs e)
        {
            double v  = Convert.ToDouble(txtprice.Text) / Convert.ToDouble(txtqut.Text);
            txttotal.Text = v.ToString();
        }
        double qte;
        double total;
      
        private void number(object sender, KeyPressEventArgs e)
        {
            char s = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != s)
            {
                e.Handled = true;
            }
        }

        private void comitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = _return_pur.return_pur_SELECTE(Convert.ToInt32(txtid.Text));
                txtprice.Text = dt.Rows[0][0].ToString();
                qte = Convert.ToDouble(dt.Rows[0][1].ToString());
                total = Convert.ToDouble(dt.Rows[0][2].ToString());

            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pur_return_view p = new pur_return_view(this);p.Show(); 
        }

        private void txtid_KeyUp(object sender, KeyEventArgs e)
        {
            comitem.DataSource = _return_pur.item_pur_SELECTE(Convert.ToInt32(txtid.Text));
            comitem.DisplayMember = "item_name";
            comitem.ValueMember = "id";
            load();
        }

        private void txtid_Layout(object sender, LayoutEventArgs e)
        {
            comitem.DataSource = _return_pur.item_pur_SELECTE(Convert.ToInt32(txtid.Text));
            comitem.DisplayMember = "item_name";
            comitem.ValueMember = "id";
            load();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            }

        private void button4_Click(object sender, EventArgs e)
        {

        this.dataTable2TableAdapter.Fill(this.dataSet4.DataTable2, Convert.ToInt32(txtid.Text));
            comitem.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtprice.Text=dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
