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
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Prnc p = this.Owner as Prnc;
            p.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            cus_ss r = new cus_ss();
            r.Show();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            login b = new login();
            b.Show();
            
            
        }
        string user = Program.USERNAME;
        private void main_form_Load(object sender, EventArgs e)
        {
            lbltitel.Text = user;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }
    }
}
