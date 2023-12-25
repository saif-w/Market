using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Bay.BL
{
    class _foater : DAL.Class1
    {
        //**************البحث*******************
        public static DataTable cus_SELECTE(string serch)
        {
            return EXUTETABLE("select_foater", CommandType.StoredProcedure,
                createparm("@serch", SqlDbType.NVarChar, serch));
        }
      
        //اضافة
        public static void purc_insert(int id,int cus_id, DateTime @date, string @note, string @username, string @pur_item, string @total_paid, string @total_resolt)
        {
            EXUTENONEQUARY("sp_foter", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, id),
           createparm("@date", SqlDbType.DateTime, @date),
           createparm("@notes", SqlDbType.NVarChar, @note),
           createparm("@cus_id", SqlDbType.Int, cus_id),
           createparm("@pur_item", SqlDbType.NVarChar, @pur_item),
           createparm("@total_paid", SqlDbType.NVarChar, @total_paid),
           createparm("@total_resolt", SqlDbType.NVarChar, @total_resolt),
           createparm("@username", SqlDbType.NVarChar, @username),
           createparm("@check", SqlDbType.Char, 'a'));

        }

        //تعديل
        public static void purc_update(int id,int cus_id, DateTime @date, string @note, string @username, string @pur_item, string @total_paid, string @total_resolt)
        {
            EXUTENONEQUARY("sp_foter", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, id),
           createparm("@date", SqlDbType.DateTime, @date),
           createparm("@notes", SqlDbType.NVarChar, @note),
           createparm("@cus_id", SqlDbType.Int, cus_id),
           createparm("@pur_item", SqlDbType.NVarChar, @pur_item),
           createparm("@total_paid", SqlDbType.NVarChar, @total_paid),
           createparm("@total_resolt", SqlDbType.NVarChar, @total_resolt),
           createparm("@username", SqlDbType.NVarChar, @username),
           createparm("@check", SqlDbType.Char, 'u'));

        }
        //حذف
        public static void purc_delete(int id, DateTime @date)
        {
            EXUTENONEQUARY("sp_foter", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, id),
           createparm("@date", SqlDbType.DateTime, @date),
           createparm("@notes", SqlDbType.NVarChar, ""),
           createparm("@cus_id", SqlDbType.Int, 0),
           createparm("@pur_item", SqlDbType.NVarChar, ""),
           createparm("@total_paid", SqlDbType.NVarChar, ""),
           createparm("@total_resolt", SqlDbType.NVarChar, ""),
           createparm("@username", SqlDbType.NVarChar, ""),
           createparm("@check", SqlDbType.Char, 'd'));

        }
    }
}
