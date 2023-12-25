using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bay.BL
{
    class _items:DAL.Class1
    {
        //تعديل الكمية نقص
        public static DataTable items_qualty_even(int id,int qut)
        {
            return EXUTETABLE("salerandpancer", CommandType.StoredProcedure,
                createparm("@id", SqlDbType.Int, id),
                createparm("@qut", SqlDbType.Int, qut)
                );
        }

        //تعديل الكمية زيادة
        public static DataTable items_qualty_plass(int id, int qut)
        {
            return EXUTETABLE("salerandpancer_sale", CommandType.StoredProcedure,
                createparm("@id", SqlDbType.Int, id),
                createparm("@qut", SqlDbType.Int, qut)
                );
        }

        public static DataTable items_qualty_plass_return(int id, double qut)
        {
            return EXUTETABLE("UPDATE Items SET qualty=qualty+@qut where id=@id", CommandType.Text,
                createparm("@id", SqlDbType.Int, id),
                createparm("@qut", SqlDbType.Int, qut)
                );
        }

        //**************البحث*******************
        public static DataTable items_SELECTE(string serch)
        {
            return EXUTETABLE("select_item", CommandType.StoredProcedure,
                createparm("@serch", SqlDbType.NVarChar, serch));
        }


        //***************************اضافة***************************
        public static void items_insert(string @item_name,string @item_price_purchace,string  @item_price_sells,string @unit,string @qualty,string @username,string @item_notes)
        {
            EXUTENONEQUARY("SP_Items", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, 0),
           createparm("@item_name", SqlDbType.NVarChar, @item_name),
           createparm("@item_price_purchace", SqlDbType.NVarChar, @item_price_purchace),
           createparm("@item_price_sells", SqlDbType.NVarChar, @item_price_sells),
           createparm("@unit", SqlDbType.NVarChar, @unit),
           createparm("@qualty", SqlDbType.NVarChar, @qualty),
           createparm("@username", SqlDbType.NVarChar, @username),
           createparm("@item_notes", SqlDbType.NVarChar, @item_notes),
           createparm("@check", SqlDbType.Char, 'a'));
            
        }

        public static void items_update(int id,string @item_name, string @item_price_purchace, string @item_price_sells, string @unit,string @qualty, string @username, string @item_notes)
        {
            EXUTENONEQUARY("SP_Items", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, id),
           createparm("@item_name", SqlDbType.NVarChar, @item_name),
           createparm("@item_price_purchace", SqlDbType.NVarChar, @item_price_purchace),
           createparm("@item_price_sells", SqlDbType.NVarChar, @item_price_sells),
           createparm("@unit", SqlDbType.NVarChar, @unit),
           createparm("@qualty", SqlDbType.NVarChar, @qualty),
           createparm("@username", SqlDbType.NVarChar, @username),
           createparm("@item_notes", SqlDbType.NVarChar, @item_notes),
           createparm("@check", SqlDbType.Char, 'u'));

        }
        public static void items_delete(int id)
        {
            EXUTENONEQUARY("SP_Items", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, id),
           createparm("@item_name", SqlDbType.NVarChar, ""),
           createparm("@item_price_purchace", SqlDbType.NVarChar,"" ),
           createparm("@item_price_sells", SqlDbType.NVarChar, ""),
           createparm("@unit", SqlDbType.NVarChar, ""),
           createparm("@qualty", SqlDbType.NVarChar, ""),
           createparm("@username", SqlDbType.NVarChar, ""),
           createparm("@item_notes", SqlDbType.NVarChar, ""),
           createparm("@check", SqlDbType.Char, 'd'));

        }
    }
}
