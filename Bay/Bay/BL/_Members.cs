using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bay.BL
{
    class _Members:DAL.Class1
    {
      
        public static DataTable user_change(string user)
        {
            return EXUTETABLE("SELECT * from Members WHERE(username = @username)", CommandType.Text,
               createparm("@username", SqlDbType.NVarChar, user)
                );
        }

        public static DataTable log_(string user,string pass,string state)
        {
            return EXUTETABLE("SELECT username, password ,state FROM Members WHERE(username = @username) AND(password = @password) AND (state = @state)", CommandType.Text,
               createparm("@username", SqlDbType.NVarChar, user),
                createparm("@password", SqlDbType.NVarChar, pass)
               , createparm("@state", SqlDbType.NVarChar, state)
               );
        }

      
        //***************************اضافة***************************
        public static void members_insert(string username,string password,string name, string phone, string note,string state)
        {
            EXUTENONEQUARY("SP_Members", CommandType.StoredProcedure,
          
           createparm("@username", SqlDbType.NVarChar, username),
           createparm("@password", SqlDbType.NVarChar, password),
           createparm("@phone", SqlDbType.NVarChar, phone),
           createparm("@name", SqlDbType.NVarChar, name),
           createparm("@note", SqlDbType.NVarChar, note),
           createparm("@state", SqlDbType.NVarChar, state),
           createparm("@check", SqlDbType.Char, 'a'));

        }
        public static DataTable member_SELECTE(string serch,string @username)
        {
            return EXUTETABLE("select_member", CommandType.StoredProcedure,
                createparm("@serch", SqlDbType.NVarChar, serch), createparm("@username", SqlDbType.NVarChar, @username));
        }
        public static void members_update(string username,string state)
        {
            EXUTENONEQUARY("SP_Members_admin", CommandType.StoredProcedure,

           createparm("@username", SqlDbType.NVarChar, username),
          
           createparm("@state", SqlDbType.NVarChar, state),
           createparm("@check", SqlDbType.Char, 'u'));

        }
       
    }
}
