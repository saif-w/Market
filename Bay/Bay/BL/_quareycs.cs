using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Bay.BL
{
    class _quareycs:DAL.DB

    {
        public int dain_sum()
        {
            string x = string.Format("select money from cus_id");
            DataTable dt = new DataTable();
            int v = 0;
            int c = 0;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
              c  = Convert.ToInt32(dt.Rows[0][i])+v
                ;
            }
            return c;

        }
    }
}
