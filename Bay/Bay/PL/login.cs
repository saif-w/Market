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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (_Members.log_(txtuser.Text, txtpass.Text,"ADMIN").Rows.Count == 1)
                {
                    Program.USERNAME = _Members.log_(txtuser.Text, txtpass.Text,"ADMIN").Rows[0][0].ToString();
                    main_form_admin m = new main_form_admin();
                    m.Show();
                    Hide();

                }
                else if (_Members.log_(txtuser.Text, txtpass.Text, "USER").Rows.Count == 1)
                {
                    MessageBox.Show("الرجاء الانتظار حتى يتم قبول حسابك من قبل الادمن");

                }
                else if (_Members.log_(txtuser.Text, txtpass.Text, "BLOCK").Rows.Count == 1)
                {
                    MessageBox.Show("عذرا لقد تم حظرك");
                }
                else
                {
                    MessageBox.Show("خطاء في الادخال");
                }
            }
            catch { MessageBox.Show("!!يوجد خطاء الرجاء اعادة محاولة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new_acount n = new new_acount();

            Hide();
            n.Show();
        }
    }
}
