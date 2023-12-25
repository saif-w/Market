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
namespace Bay.UC
{
    public partial class all_members : UserControl
    {
        public all_members()
        {
            InitializeComponent();
        }
        string user = Program.USERNAME;
        private void all_members_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            load();
           
        }
        void load()
        {
            try
            {
                dataGridView1.DataSource = _Members.member_SELECTE("",user);
            }
            catch {}


        }

        private void txtserach_TextChanged(object sender, EventArgs e)
        {
         dataGridView1.DataSource= _Members.member_SELECTE(txtserach.Text,user);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("تم التعديل بي نجاح", "هل تريد التعديل!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {
                    _Members.members_update(dataGridView1.CurrentRow.Cells[0].Value.ToString(), comboBox1.SelectedItem.ToString());
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
