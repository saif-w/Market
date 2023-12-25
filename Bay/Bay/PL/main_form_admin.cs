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
    public partial class main_form_admin : Form
    {
        public main_form_admin()
        {
            InitializeComponent();
        }
        string user = Program.USERNAME;
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //   this.Close();
          Program.close();
        }
        
        private void main_form_admin_Load(object sender, EventArgs e)
        {
           
            //**********************************
            lbl_user.Text = user;
             
        }

        private void lbl_user_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            detale_purn1.BringToFront();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            //if (panal_said_2.Width == 200)
            //    panal_said_2.Width = 0;
            //else
            //    panal_said_2.Width = 200;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

            if (panal_said_1.Height == 115)
                panal_said_1.Height = 0;
            else
                panal_said_1.Height = 115;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (panal_said_1.Height == 163)
                panal_said_1.Height = 0;
            else
                panal_said_1.Height = 163;
        }

        private void bunifuFlatButton3_MouseLeave(object sender, EventArgs e)
        {
          //  panal_said_1.Width = 0;
        }

        private void bunifuFlatButton4_MouseLeave(object sender, EventArgs e)
        {
            //panal_said_2.Width = 0;
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            sale s = this.Owner as sale;
            s.Show();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            Prnc p = this.Owner as Prnc;
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            //supply1.BringToFront();
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            return_sells1.BringToFront();
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            detales_sells1.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            items1.BringToFront();
        }

        private void bunifuFlatButton8_Click_1(object sender, EventArgs e)
        {
            supply1.BringToFront();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            cus1.BringToFront();
        }

        private void bunifuFlatButton5_Click_1(object sender, EventArgs e)
        {
            cus_id1.BringToFront();
        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
            if (panel_said_2.Height == 163)
                panel_said_2.Height = 0;
            else
                panel_said_2.Height = 163;
        }

        private void bunifuFlatButton9_Click_1(object sender, EventArgs e)
        {
            Hide();
            login l = new login();
            l.Show();
        }

        private void bunifuFlatButton10_Click_1(object sender, EventArgs e)
        {
            all_members1.BringToFront();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Today.ToShortDateString();
            label3.Text = DateTime.Now.ToString("hh:mm:ss tt");
            label5.Text = new System.Globalization.CultureInfo("AR").DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
            lbl_pur_id.Text = _purn.select_id_pur().Rows[0][0].ToString();
            lbl_id_cus.Text = _purn.select_id_cus().Rows[0][0].ToString();
            lbl_sum_cus.Text = _purn.select_sum_cus().Rows[0][0].ToString();
            lbl_sum_pur.Text = _purn.select_sum_pur().Rows[0][0].ToString();

        }

        private void home1_Load(object sender, EventArgs e)
        {

        }
    }
}
