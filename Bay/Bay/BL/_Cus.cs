using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Bay.BL
{
    class _Cus : DAL.Class1
    {
        //**************البحث*******************
        public static DataTable cus_SELECTE(string serch)
        {
            return EXUTETABLE("select_cus", CommandType.StoredProcedure,
                createparm("@serch", SqlDbType.NVarChar, serch));
        }
        //***************************اضافة***************************
        public static void cus_insert(string name, string money, DateTime date, string username)
        {
            EXUTENONEQUARY("sp_cus", CommandType.StoredProcedure,
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
            EXUTENONEQUARY("sp_cus", CommandType.StoredProcedure,
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
            EXUTENONEQUARY("sp_cus", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, id),
           createparm("@name", SqlDbType.NVarChar, ""),
           createparm("@money", SqlDbType.NVarChar, ""),
           createparm("@username", SqlDbType.NVarChar, ""),
           createparm("@date", SqlDbType.Date, date),
           createparm("@check", SqlDbType.Char, 'd'));

        }

    }
}
