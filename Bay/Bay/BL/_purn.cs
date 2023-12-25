using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bay.BL
{
    class _purn:DAL.Class1
    {


        //بيانات الديون والمشتريات
        public static DataTable select_id_pur()
        {
            return EXUTETABLE("select (count(id)) from Purcheses", CommandType.Text
               );
        }

        public static DataTable select_sum_pur()
        {
            return EXUTETABLE("select (sum(cast(total_resolt as float))) from Purcheses", CommandType.Text
               );
        }
        public static DataTable select_id_cus()
        {
            return EXUTETABLE("select (count(id)) from cus_id", CommandType.Text
               );
        }

        public static DataTable select_sum_cus()
        {
            return EXUTETABLE("select (SUM( cast(money as float)))from cus_id", CommandType.Text
               );
        }



        //**************البحث*******************
        public static DataTable cus_SELECTE(string serch)
        {
            return EXUTETABLE("select_pruncher", CommandType.StoredProcedure,
                createparm("@serch", SqlDbType.NVarChar, serch));
        }
        //اضافة
        public static void purc_insert(int id,DateTime @date,string @note,string @username,string @pur_item,string @total_paid,string @total_resolt)
        {
            EXUTENONEQUARY("SP_purchese", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, id),
           createparm("@date", SqlDbType.DateTime, @date),
           createparm("@notes", SqlDbType.NVarChar, @note),
           createparm("@username", SqlDbType.NVarChar, @username),
           createparm("@pur_item", SqlDbType.NVarChar, @pur_item),
           createparm("@total_paid", SqlDbType.NVarChar, @total_paid),
           createparm("@total_resolt", SqlDbType.NVarChar, @total_resolt),
           createparm("@check", SqlDbType.Char, 'a'));
            
        }

        //تعديل
        public static void purc_update(int id,DateTime @date, string @note, string @username, string @pur_item, string @total_paid, string @total_resolt)
        {
            EXUTENONEQUARY("SP_purchese", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, id),
           createparm("@date", SqlDbType.DateTime, @date),
           createparm("@notes", SqlDbType.NVarChar, @note),
           createparm("@username", SqlDbType.NVarChar, @username),
           createparm("@pur_item", SqlDbType.NVarChar, @pur_item),
           createparm("@total_paid", SqlDbType.NVarChar, @total_paid),
           createparm("@total_resolt", SqlDbType.NVarChar, @total_resolt),
           createparm("@check", SqlDbType.Char, 'u'));

        }
        //حذف
        public static void purc_delete(int id,DateTime @date)
        {
            EXUTENONEQUARY("SP_purchese", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, id),
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
