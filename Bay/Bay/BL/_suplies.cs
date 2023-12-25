using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Bay.BL
{
    class _suplies : DAL.Class1
    {

        //**************البحث*******************
        public static DataTable cus_SELECTE(string serch)
        {
            return EXUTETABLE("select_suplier", CommandType.StoredProcedure,
                createparm("@serch", SqlDbType.NVarChar, serch));
        }
        //***************************اضافة***************************
        public static void cus_insert(string name, string money, DateTime date,string @company_name, string username)
        {
            EXUTENONEQUARY("sp_suplier", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, 0),
           createparm("@name", SqlDbType.NVarChar, name),
           createparm("@money", SqlDbType.NVarChar, money),
           createparm("@username", SqlDbType.NVarChar, username),
           createparm("@date", SqlDbType.Date, date),
            createparm("@company_name", SqlDbType.NVarChar, @company_name),
           createparm("@check", SqlDbType.Char, 'a'));
           
        }
        //تعديل
        public static void cus_update(int id, string name, string money, DateTime date,string @company_name, string username)
        {
            EXUTENONEQUARY("sp_suplier", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, id),
           createparm("@name", SqlDbType.NVarChar, name),
           createparm("@money", SqlDbType.NVarChar, money),
           createparm("@date", SqlDbType.Date, date),
           createparm("@username", SqlDbType.NVarChar, username),
           createparm("@company_name", SqlDbType.NVarChar, @company_name),
           createparm("@check", SqlDbType.Char, 'u'));

        }
        //حذف
        public static void cus_delete(int id, DateTime date)
        {
           EXUTENONEQUARY("sp_suplier", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, id),
           createparm("@name", SqlDbType.NVarChar, ""),
           createparm("@money", SqlDbType.NVarChar, ""),
           createparm("@username", SqlDbType.NVarChar, ""),
           createparm("@company_name", SqlDbType.NVarChar, ""),
           createparm("@date", SqlDbType.Date, date),
           createparm("@check", SqlDbType.Char, 'd'));

        }

    }
}
