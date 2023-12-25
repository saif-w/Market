using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Bay.DAL
{
    class DB
    {
        public string spname;

        public object ConfigurationManager { get; private set; }




        public static DataTable RunQuery(string query)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\BUY_DATA1.MDF';Integrated Security=True;Connect Timeout=30");
            //conn.ConnectionString = ConfigurationManager.ConnectionStrings[1].ToString();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;

            conn.Open();
            cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();

            try
            {

                dt.Load(cmd.ExecuteReader());
                conn.Close();
                return dt;

            }
            catch (Exception ex)
            {

                conn.Close();
                return dt;

            }



        }

        public DataTable serchQuery(string query)
        {


            return RunQuery(query);

        }
    }
}
