using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bay.BL
{
    class _cus_id:DAL.Class1
    {
        //**************البحث*******************
        public static DataTable cus_SELECTE(string serch)
        {
            return EXUTETABLE("select_cus_id", CommandType.StoredProcedure,
                createparm("@serch", SqlDbType.NVarChar, serch));
        }
        public static DataTable cus_dain(string name)
        {
            return EXUTETABLE("select money from cus_id whare name=@name", CommandType.Text,
                createparm("@name", SqlDbType.NVarChar, name));
        }
        public static DataTable cus_money(string date)
        {
            return EXUTETABLE("select count[total_resolt] from customers whare  date=@date", CommandType.Text,
                createparm("@date", SqlDbType.DateTime, date));
        }
        //عدد المدينين الدين
        public static DataTable cus_id_count_dain()
        {
            return EXUTETABLE("select count(Id) from cus_id", CommandType.Text);
        }
        //عدد المدنين فواتير
        public static DataTable cus_count_dain()
        {
            return EXUTETABLE("select count(Id) from cus", CommandType.Text);
        }
        public static DataTable supply_count_dain()
        {
            return EXUTETABLE("select count(Id) from suplier", CommandType.Text);
        }

        //جمع المدنين
        public static DataTable cus_sum_dain()
        {
            return EXUTETABLE("select sum(cast(money as int)) from cus_id", CommandType.Text);
        }
        public static DataTable cus_sum_dain_select()
        {
            return EXUTETABLE("select money from cus_id", CommandType.Text);
        }
        //***************************اضافة***************************
        public static void cus_insert(string name, string money, DateTime date, string username)
        {
            EXUTENONEQUARY("sp_cus_id", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, 0),
           createparm("@name", SqlDbType.NVarChar, name),
           createparm("@money", SqlDbType.NVarChar, money),
           createparm("@username", SqlDbType.NVarChar, username),
           createparm("@date", SqlDbType.Date, date),
           createparm("@check", SqlDbType.Char, 'a'));

        }
        //تعديل
        public static void cus_update(int id, string name, string money, DateTime date, string username)
        {
            EXUTENONEQUARY("sp_cus_id", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, id),
           createparm("@name", SqlDbType.NVarChar, name),
           createparm("@money", SqlDbType.NVarChar, money),
           createparm("@date", SqlDbType.Date, date),
           createparm("@username", SqlDbType.NVarChar, username),
           createparm("@check", SqlDbType.Char, 'u'));

        }
        //حذف
        public static void cus_delete(int id, DateTime date)
        {
            EXUTENONEQUARY("sp_cus_id", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, id),
           createparm("@name", SqlDbType.NVarChar, ""),
           createparm("@money", SqlDbType.NVarChar, ""),
           createparm("@username", SqlDbType.NVarChar, ""),
           createparm("@date", SqlDbType.Date, date),
           createparm("@check", SqlDbType.Char, 'd'));

        }
    }
}
