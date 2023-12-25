using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Bay.BL
{
    class _detales_sale : DAL.Class1
    {
        //**************البحث*******************
        public static DataTable cus_SELECTE(string serch)
        {
            return EXUTETABLE("select_detales_sales", CommandType.StoredProcedure,
                createparm("@serch", SqlDbType.NVarChar, serch));
        }
        //***************************اضافة***************************
        public static void cus_insert(int @id_detales, int @item_id, string @price, string @qualty, string @total, string @note, string username, DateTime date)
        {
            EXUTENONEQUARY("SP_sale_detales", CommandType.StoredProcedure,
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
        public static void _update(int id, int @id_detales, int @item_id, string @price, string @qualty, string @total, string @note, string username, DateTime date)
        {
            EXUTENONEQUARY("SP_sale_detales", CommandType.StoredProcedure,
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
            EXUTENONEQUARY("SP_sale_detales", CommandType.StoredProcedure,
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
