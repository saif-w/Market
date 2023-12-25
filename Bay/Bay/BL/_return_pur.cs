using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Bay.BL
{
    class _return_pur:DAL.Class1
    {
        //**************البحث*******************
        public static DataTable _SELECTE(int id)
        {
            return EXUTETABLE("select_return_pur", CommandType.StoredProcedure,
                createparm("@id", SqlDbType.Int, id));
        }
        //عرض
        public static DataTable SELECTE_coustomer_view(int id)
        {
            return EXUTETABLE("SELECT [pur_item],[total_paid],[total_resolt] FROM [customers] where id=@id  ", CommandType.Text,
                createparm("@id", SqlDbType.Int, id)
                );
        }


        //تعديل العرض
        public static void _update_costumer_view(int id,string @pur_item,string @total_paid,string @total_resolt)
        {
            EXUTENONEQUARY("UPDATE [customers] SET [pur_item] = @pur_item,[total_paid] = @total_paid,[total_resolt] = @total_resolt  WHERE where id=@id", CommandType.Text,
           createparm("@id", SqlDbType.Int, id),
           createparm("@pur_item", SqlDbType.NVarChar, @pur_item),
           createparm("@total_paid", SqlDbType.NVarChar, @total_paid),
           createparm("@total_resolt", SqlDbType.NVarChar, @total_resolt));
        }
        //اضافة
        //***************************اضافة***************************
        public static void _insert(int @pur_id,string @item_name,string @username,string @price,string @qte,string @total,DateTime @date)
        {
            EXUTENONEQUARY("SP_return_pur", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, 0),
           createparm("@pur_id", SqlDbType.Int, @pur_id),
           createparm("@item_name", SqlDbType.NVarChar, @item_name),
           createparm("@username", SqlDbType.NVarChar, @username),
          createparm("@price", SqlDbType.NVarChar, @price),
          createparm("@qte", SqlDbType.NVarChar, @qte),
          createparm("@total", SqlDbType.NVarChar, @total),
          createparm("@date", SqlDbType.NVarChar, @date),
           createparm("@check", SqlDbType.Char, 'a'));

        }

        public static void _update(int id)
        {
            EXUTENONEQUARY("sp_update_sale_cala", CommandType.StoredProcedure,
           createparm("@id", SqlDbType.Int, id));
        }

        public static DataTable cus_id_SELECTE(int @_id)
        {
            return EXUTETABLE("select c.name from  cus_id c, Purcheses d,Members m  where c.username=m.username and d.username= m.username and d.id=@_id ", CommandType.Text,
                createparm("@id", SqlDbType.Int, @_id));
        }

        public static DataTable cus_SELECTE(int @_id)
        {
            return EXUTETABLE("select c.name from  cus c, Purcheses d,Members m  where c.username=m.username and d.username= m.username and d.id=@_id ", CommandType.Text,
                createparm("@_id", SqlDbType.Int, @_id));
        }

        public static DataTable item_pur_SELECTE(int @_id)
        {
            return EXUTETABLE("SELECT i.id,i.item_name  FROM Items i,detales_pur p where  p.item_id=i.id and p.id_detales=@id ", CommandType.Text,
                createparm("@id", SqlDbType.Int, @_id));
        }

        public static DataTable return_pur_SELECTE(int @_id)
        {
            return EXUTETABLE("SELECT [price] ,p.[qualty] ,[total]  FROM Items i,detales_pur p where  p.item_id=i.id and i.id=@id", CommandType.Text,
                createparm("@id", SqlDbType.Int, @_id));
        }

    }
}
