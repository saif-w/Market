using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Bay.BL
{
    class _sale : DAL.Class1
    {
        //**************البحث*******************
        public static DataTable cus_SELECTE(string serch)
        {
            return EXUTETABLE("select_sales", CommandType.StoredProcedure,
                createparm("@serch", SqlDbType.NVarChar, serch));
        }
        //اضافة
        public static void purc_insert(int id,int id_sup, DateTime @date, string @note, string @username, string @pur_item, string @total_paid, string @total_resolt)
        {
            EXUTENONEQUARY("SP_sale", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, id),
           createparm("@id_sup", SqlDbType.Int, id_sup),
           createparm("@date", SqlDbType.DateTime, @date),
           createparm("@notes", SqlDbType.NVarChar, @note),
           createparm("@username", SqlDbType.NVarChar, @username),
           createparm("@pur_item", SqlDbType.NVarChar, @pur_item),
           createparm("@total_paid", SqlDbType.NVarChar, @total_paid),
           createparm("@total_resolt", SqlDbType.NVarChar, @total_resolt),
           createparm("@check", SqlDbType.Char, 'a'));

        }

        //تعديل
        public static void purc_update(int id, int id_sup,DateTime @date, string @note, string @username, string @pur_item, string @total_paid, string @total_resolt)
        {
            EXUTENONEQUARY("SP_sale", CommandType.StoredProcedure,
          createparm("@id", SqlDbType.Int, id),
          createparm("@id_sup", SqlDbType.Int, id_sup),
          createparm("@date", SqlDbType.DateTime, @date),
          createparm("@notes", SqlDbType.NVarChar, @note),
          createparm("@username", SqlDbType.NVarChar, @username),
          createparm("@pur_item", SqlDbType.NVarChar, @pur_item),
          createparm("@total_paid", SqlDbType.NVarChar, @total_paid),
          createparm("@total_resolt", SqlDbType.NVarChar, @total_resolt),
          createparm("@check", SqlDbType.Char, 'u'));

        }
        //حذف
        public static void purc_delete(int id, DateTime @date)
        {
            EXUTENONEQUARY("SP_sale", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, id),
            createparm("@id_sup", SqlDbType.Int, 0),
           createparm("@date", SqlDbType.DateTime, @date),
           createparm("@notes", SqlDbType.NVarChar, ""),
           createparm("@username", SqlDbType.NVarChar, ""),
           createparm("@pur_item", SqlDbType.NVarChar, ""),
           createparm("@total_paid", SqlDbType.NVarChar, ""),
           createparm("@total_resolt", SqlDbType.NVarChar, ""),
           createparm("@check", SqlDbType.Char, 'd'));

        }
    }
}
