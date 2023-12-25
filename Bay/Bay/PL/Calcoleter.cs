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
    public partial class Calcoleter : Form
    {
        public Calcoleter()
        {
            InitializeComponent();
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Double dd = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
                textBox3.Text = dd.ToString();
            }
            catch { MessageBox.Show("!!يوجد خطاء الرجاء اعادة محاولة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public string a;
        public string z;
        public string y;
        string user = Program.USERNAME;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                UC.cus_id u = new UC.cus_id();
                if (textBox3.Text == "")
                {
                    MessageBox.Show("يجب تعبئة البيانات");
                }
                else
                {
                    _cus_id.cus_update(Convert.ToInt32(a), z, textBox3.Text, Convert.ToDateTime(y),user);
                    u.load();
                    u.dataGridView1.DataSource = _cus_id.cus_SELECTE("");
                    u.dataGridView1.Update();
                    MessageBox.Show("تم تعديل القيمة");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("خطاء", "!!يوجد خطاء الرجاء اعادة محاولة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        UC.cus_id c = new UC.cus_id();
       
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != s)
            {
                e.Handled = true;
            }
        }
        public void load_()
        {
            UC.cus_id c = new UC.cus_id();
            c.dataGridView1.DataSource = _cus_id.cus_SELECTE("");
        }
        private void Calcoleter_Load(object sender, EventArgs e)
        {
            UC.cus_id c = new UC.cus_id();
          
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
