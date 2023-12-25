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
    public partial class Members : UserControl
    {
        public Members()
        {
            InitializeComponent();
        }

        private void Members_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text == "" || txtpass.Text == "" || txtphone.Text == "" || txtuser.Text == "")
                {
                    MessageBox.Show("يجب ادخال جميع البيانات");
                }
                else if (_Members.user_change(txtuser.Text).Rows.Count > 0)
                {
                    MessageBox.Show("اسم مستخدم هذا موجود مسبقا");
                }
                else
                {
                    _Members.members_insert(txtuser.Text, txtpass.Text, txtname.Text, txtphone.Text, txtnote.Text,"USER");
                    MessageBox.Show("تمت الاضافة");
                    login l = new login();
                    l.Show();
                    PL.new_acount a = new new_acount();
                    a.Hide();
                }
            }
            catch
            {
                MessageBox.Show("!!يوجد خطاء الرجاء اعادة محاولة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //PL.new_acount member = new new_acount();
           
            //member.Hide();
            login l = new login();
            l.Show();
            Hide();

        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
         //   char s = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
