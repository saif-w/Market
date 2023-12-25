using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Bay.BL
{
    class _detales_pur : DAL.Class1
    {
        //زيادة قيمة بي واحد
        public static DataTable cus_max()
        {
            return EXUTETABLE("select ISNULL(max(id_detales)+1,1) from detales_pur", CommandType.Text);
        }

        public static DataTable cussells_max()
        {
            return EXUTETABLE("select ISNULL(max(id_detales)+1,1) from sales_detales", CommandType.Text);
        }
        //******************معرفة قيمة التقرير خالص دين فاتورة***********************
        public static DataTable reprt_pur(int serch)
        {
            return EXUTETABLE("select id from Purcheses where id=@id", CommandType.Text,
                createparm("@id", SqlDbType.Int, serch));
        }
        //*******
        public static DataTable reprt_foater(int serch)
        {
            return EXUTETABLE("select id from foater where id=@id", CommandType.Text,
                createparm("@id", SqlDbType.Int, serch));
        }
        //**************
        public static DataTable reprt_dain(int serch)
        {
            return EXUTETABLE("select id from customers where id=@id", CommandType.Text,
                createparm("@id", SqlDbType.Int, serch));
        }

        //**************البحث*******************
        public static DataTable cus_SELECTE(string serch)
        {
            return EXUTETABLE("select_detales_pruncher", CommandType.StoredProcedure,
                createparm("@serch", SqlDbType.NVarChar, serch));
        }


        //***************************اضافة***************************
        public static void cus_insert(int @id_detales,int @item_id,string @price,string @qualty,string @total,string @note , string username,DateTime date)
        {
            EXUTENONEQUARY("SP_pur_detales", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, 0),
           createparm("@id_detales", SqlDbType.Int, @id_detales),
           createparm("@item_id", SqlDbType.Int, @item_id),
           createparm("@price", SqlDbType.NVarChar, @price),
           createparm("@qualty", SqlDbType.NVarChar, @qualty),
           createparm("@total", SqlDbType.NVarChar, @total),
           createparm("@note", SqlDbType.NVarChar, @note),
           createparm("@username", SqlDbType.NVarChar, username),
           createparm("@date", SqlDbType.Date, date),
           createparm("@check", SqlDbType.Char, 'a'));

        }
        //تعديل
        public static void _update(int id,int @id_detales, int @item_id, string @price, string @qualty, string @total, string @note, string username, DateTime date)
        {
            EXUTENONEQUARY("SP_pur_detales", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, id),
           createparm("@id_detales", SqlDbType.Int, @id_detales),
           createparm("@item_id", SqlDbType.Int, @item_id),
           createparm("@price", SqlDbType.NVarChar, @price),
           createparm("@qualty", SqlDbType.NVarChar, @qualty),
           createparm("@total", SqlDbType.NVarChar, @total),
           createparm("@note", SqlDbType.NVarChar, @note),
           createparm("@username", SqlDbType.NVarChar, username),
           createparm("@date", SqlDbType.Date, date),
           createparm("@check", SqlDbType.Char, 'u'));

        }
        //حذف
        public static void _delete(int id, DateTime date)
        {
            EXUTENONEQUARY("SP_pur_detales", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, id),
           createparm("@id_detales", SqlDbType.Int, 0),
           createparm("@item_id", SqlDbType.Int, 0),
           createparm("@price", SqlDbType.NVarChar, ""),
           createparm("@qualty", SqlDbType.NVarChar, ""),
           createparm("@total", SqlDbType.NVarChar, ""),
           createparm("@note", SqlDbType.NVarChar, ""),
           createparm("@username", SqlDbType.NVarChar, ""),
           createparm("@date", SqlDbType.Date, date),
           createparm("@check", SqlDbType.Char, 'd'));

        }
    }
}
