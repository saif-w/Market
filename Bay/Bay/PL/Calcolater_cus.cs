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
    public partial class Calcolater_cus : Form
    {
        public Calcolater_cus()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != s)
            {
                e.Handled = true;
            }
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

                UC.cus u = new UC.cus();
                if (textBox3.Text == "")
                {
                    MessageBox.Show("يجب تعبئة البيانات");
                }
                else
                {
                    _Cus.cus_update(Convert.ToInt32(a), z, textBox3.Text, Convert.ToDateTime(y), user);
                    u.load();
                    u.dataGridView1.DataSource = _Cus.cus_SELECTE("");
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

        private void Calcolater_cus_Load(object sender, EventArgs e)
        {

        }
    }
}
