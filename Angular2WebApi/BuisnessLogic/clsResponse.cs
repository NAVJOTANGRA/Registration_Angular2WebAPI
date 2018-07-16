using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Text;
using System.Threading.Tasks;
using System.Collections;

using System.Data;


namespace Angular2WebApi.BuisnessLogic
{
    public class clsResponse
    {
        public int StatusCode { get; set; }
        public string StatusText { get; set; }
        public string Response { get; set; } // use for to get response string.
        public DataTable ResponseDataTable { get; set; } // use for to get single response table
      public DataSet ResponseDataSet { get; set; }  // use for to get multiple tables in single dataset.
      
        public object ResponseObject { get; set; }
        public int RowsAffected { get; set; } //For saved or updated Rows count get.
        public string DocumentResponse { get; set; } //For Document Response.
    }
}