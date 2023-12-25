using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
namespace Bay
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static string USERNAME;
        [STAThread]






        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                      Application.Run(new PL.login());
            //try
            //{

            //    ManagementObjectSearcher mosdisks = new ManagementObjectSearcher("" +
            //        "SELECT * FROM Win32_DiskDrive " +
            //        "where SerialNumber IS NOT NULL AND" +
            //        " MediaType = 'Fixed hard disk media'");
            //    foreach (ManagementObject modisk in mosdisks.Get())
            //    {
            //        if ((modisk["SerialNumber"].ToString() == "130831TE8511L5132X2K"))
            //        {
            //            Application.Run(new PL.login());
            //        }
            //        else
            //        {
            //            MessageBox.Show("غير مرخص لك بستخدام النظام الرجاء التواصل مع المبرمج عن طريق الرقم الاتي 0926940371", "خطاء في البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            //            Application.Exit();
            //        }
            //    }

            //} catch(Exception ex) { MessageBox.Show("شكرا على استخدام نظامنا");  }

        }

        public static void close()
        {
            Application.Exit();
        }
    }


}
