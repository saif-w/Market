using Bay.BL;
using Bay.UC;
using Bay.DAL;
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

    public partial class Prnc : Form
    {
        detale_purn d;
        public Prnc(detale_purn df)
        {
            this.d = df;
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {


        }
        //مسح جميع البيانات
        void dd_empty()
        {
            txtid.Text = "";
            txtItem.Text = "";
            txtprice.Text = ""; txtqulty.Text = "0"; txtresolt.Text = ""; txtnotes.Text = ""; txt_detales_note.Text = "";txt_cusid_id.Text = "";txt_foter_id.Text = "";txt_foter_money.Text = ""; txtcusid_name.Text = ""; txtmoney.Text = "";txt_foter_name.Text = "";
            txtitem_count.Text = ""; txttotal_prn.Text = ""; txttotal_bay.Text = ""; txttotal_resolt.Text = "";

            dataGridView1.Rows.Clear();
        }
     
        
        private void Prnc_Load(object sender, EventArgs e)
        {
            txtusername.Text = Program.USERNAME;
            txt_detale_id.Text = _detales_pur.cus_max().Rows[0][0].ToString();
            
            radioButton1.Checked=true;
            //gg();
            // TODO: This line of code loads data into the 'buy_dataDataSet1.cus_id' table. You can move, or remove it, as needed.
            //   this.cus_idTableAdapter.Fill(this.buy_dataDataSet1.cus_id);
            // TODO: This line of code loads data into the 'buy_dataDataSet.log' table. You can move, or remove it, as needed.
            // this.logTableAdapter.Fill(this.buy_dataDataSet.log);
            //string s = _Members.user_().ToString();

            txtqulty.Text = "0";
            //comnames.DataSource = _cus_id.cus_SELECTE("");
            //comnames.ValueMember = "id";
            //comnames.DisplayMember = "name";
            ///txtname.Text= _Members.user_().Rows[0][0].ToString();
            /// 
        
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
            
            else if (Convert.ToInt32(txtqulty.Text) > Convert.ToInt32(txt_qul.Text))
            {
                MessageBox.Show("لايمكنك ادخال كمية اكبر من التي في المخزن");
            }
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
      //  int que;
        private void button1_Click(object sender, EventArgs e)
        {
            txtresolt.Text = "";
            item_pr m = new item_pr(this);

            m.ShowDialog();   
        }

        private void txtresolt_KeyUp(object sender, KeyEventArgs e)
        {
              
            }

        private void number(object sender, KeyPressEventArgs e)
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
            catch { MessageBox.Show("!!يوجد خطاء الرجاء اعادة محاولة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); } }
       void calcoleter()
        {
            txtitem_count.Text = dataGridView1.Rows.Count.ToString();
            //*******************
            Double totalpay=0;
            
            for(int i=0; i < dataGridView1.Rows.Count; i++)
            {
                    totalpay += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                
            }
            
            txttotal_prn.Text = totalpay.ToString();
            }
        string user = Program.USERNAME;
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

                //**********************اضافة الخالص*********************
                if (radioButton1.Checked == true)
                {
                    if (txttotal_bay.Text == "" || txttotal_bay.Text == "")
                    {
                        MessageBox.Show("الرجاء التأكد من تعبأت جميع البيانات");
                    }
                    else
                    {
                    _purn.purc_insert(Convert.ToInt32(txt_detale_id.Text), Convert.ToDateTime(dateTimePicker1.Text), txtnotes.Text, user, txtitem_count.Text, txttotal_prn.Text, txttotal_bay.Text);
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        _detales_pur.cus_insert(Convert.ToInt32(txt_detale_id.Text), Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), dataGridView1.Rows[i].Cells[2].Value.ToString(), dataGridView1.Rows[i].Cells[3].Value.ToString(), dataGridView1.Rows[i].Cells[4].Value.ToString(), dataGridView1.Rows[i].Cells[5].Value.ToString(), txtusername.Text, Convert.ToDateTime(dateTimePicker1.Text));
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++) { _items.items_qualty_even(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value)); }
                        d.load();
                        dd_empty();
                        txt_detale_id.Text = _detales_pur.cus_max().Rows[0][0].ToString();
                        
                        MessageBox.Show("تمت الاضافة الخالص");
                    }
                }

            //**************************اضافة الدين*********************
            else if (radioButton3.Checked == true)
            {
                if (txt_cusid_id.Text == "" || txtcusid_name.Text == "" || txttotal_bay.Text == "" || txttotal_bay.Text == "")
                {
                    MessageBox.Show(" الرجاء التأكد من تعبأت جميع البيانات الدين");
                }
                else
                {
                    Double x = Convert.ToDouble(txtmoney.Text) + Convert.ToDouble(txttotal_resolt.Text);
                    _cus_id.cus_update(Convert.ToInt32(txt_cusid_id.Text), txtcusid_name.Text, x.ToString(), Convert.ToDateTime(dateTimePicker1.Text), txtusername.Text);
                    _customers.purc_insert(Convert.ToInt32(txt_detale_id.Text), Convert.ToInt32(txt_cusid_id.Text), Convert.ToDateTime(dateTimePicker1.Text), txt_detales_note.Text, txtusername.Text, txtitem_count.Text, txttotal_prn.Text, txttotal_bay.Text);

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        _detales_pur.cus_insert(Convert.ToInt32(txt_detale_id.Text), Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), dataGridView1.Rows[i].Cells[2].Value.ToString(),
                            dataGridView1.Rows[i].Cells[3].Value.ToString(), dataGridView1.Rows[i].Cells[4].Value.ToString(), dataGridView1.Rows[i].Cells[5].Value.ToString(), txtusername.Text, Convert.ToDateTime(dateTimePicker1.Text));
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++) { _items.items_qualty_even(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value)); }
                        d.load();
                        dd_empty();
                        txt_detale_id.Text = _detales_pur.cus_max().Rows[0][0].ToString();
                        MessageBox.Show("تمت الاضافة الّدّين");
                }

            }
            //*******************************************

            //***********************اضافة الفواتير**************************
            else if (radioButton2.Checked == true)
            {
                if (txt_foter_id.Text == "" || txt_foter_name.Text == "" || txttotal_bay.Text == "" || txttotal_bay.Text == "")
                {
                    MessageBox.Show(" الرجاء التأكد من تعبأت جميع البيانات الفاتورة");
                }
                else
                {
                        try
                        {
                            Double x = Convert.ToDouble(txt_foter_money.Text) + Convert.ToDouble(txttotal_resolt.Text);
                            _Cus.cus_update(Convert.ToInt32(txt_foter_id.Text), txt_foter_name.Text, x.ToString(), Convert.ToDateTime(dateTimePicker1.Text), txtusername.Text);
                        }
                        catch (Exception ex) { MessageBox.Show(ex.ToString()); MessageBox.Show("1"); }

                        try
                        {

                            _foater.purc_insert(Convert.ToInt32(txt_detale_id.Text), Convert.ToInt32(txt_foter_id.Text), Convert.ToDateTime(dateTimePicker1.Text), txt_detales_note.Text, txtusername.Text, txtitem_count.Text, txttotal_prn.Text, txttotal_bay.Text);

                        }
                        catch (Exception ex) { MessageBox.Show(ex.ToString()); MessageBox.Show("2"); }


                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        _detales_pur.cus_insert(Convert.ToInt32(txt_detale_id.Text), Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), dataGridView1.Rows[i].Cells[2].Value.ToString(), dataGridView1.Rows[i].Cells[3].Value.ToString(), dataGridView1.Rows[i].Cells[4].Value.ToString(), dataGridView1.Rows[i].Cells[5].Value.ToString(), txtusername.Text, Convert.ToDateTime(dateTimePicker1.Text));
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++) { _items.items_qualty_even(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value)); }
                        d.load();
                        dd_empty();
                      
                        txt_detale_id.Text = _detales_pur.cus_max().Rows[0][0].ToString();
                        MessageBox.Show("تمت الاضافة الفواتير");

                }

            }
            //*************************************

        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("!!يوجد خطاء الرجاء اعادة محاولة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



}

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
          
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox5.Enabled = false;
                groupBox6.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            }

        private void comnames_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void comnames_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    
        private void button8_Click(object sender, EventArgs e)
        {
          
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                groupBox5.Enabled = true;
                groupBox6.Enabled = false;
            }
        }

        private void comnames_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
           }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            cus_id_view c = new cus_id_view(this);
            c.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fatora_view c = new fatora_view(this);
            c.Show();
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                groupBox5.Enabled = false;
                groupBox6.Enabled = true;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txttotal_prn_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }

}
