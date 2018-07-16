using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace Angular2WebApi.SqlCOnnection
{
    public class sqlconnection
    {
        public SqlConnection sqlcon { get; set; }
        public SqlCommand sqlcmd { get; set; }
        public SqlDataAdapter sd { get; set; }

        public sqlconnection()
        {
            this.sqlcon = new SqlConnection("Data Source=NAVJOT\\SQLEXPRESS;Initial Catalog=PetroIt;Persist Security Info=True;User ID=sa;Password=petroit@1234");
            this.sqlcmd = new SqlCommand();
            this.sd = new SqlDataAdapter(sqlcmd);
        }
    }
    public struct DBParams
    {
        public object Value;
        public string DBType;

    };

}