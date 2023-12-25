using Bay.BL;
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
    public partial class item_sale : Form
    {
        sale s;
        public item_sale(sale sa)
        {
            this.s = sa;
            InitializeComponent();
        }
        void load()
        {
            try { dataGridView1.DataSource = _items.items_SELECTE(""); }
            catch
            {
                MessageBox.Show("!!يوجد خطاء الرجاء اعادة محاولة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void item_sale_Load(object sender, EventArgs e)
        {
            load();
        }

        private void txtserch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _items.items_SELECTE(txtserch.Text);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            s.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
           s.txtItem.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            s.txtprice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            s.txt_qul.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value).ToString();
            this.Close();
        }
    }
}
