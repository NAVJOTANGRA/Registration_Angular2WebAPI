using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Angular2WebApi.Models
{
    public class CommonTable
    {
        public int ProjectID { get; set; }
        public string CompanyName { get; set; }
        public string ProductName { get; set; }
        public int Status { get; set; }
        public int ItemId { get; set; }
        public int CompanyID { get; set; }
        public int ProductID { get; set; }
    }
}