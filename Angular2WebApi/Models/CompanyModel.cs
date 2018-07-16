using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Angular2WebApi.Models
{
    public class CompanyModel
    {
        public int Projectid { get; set; }
        public string CompanyName { get; set; }
        public string Productname { get; set; }
        public int ItemId { get; set; }
        public int CompanyId { get; set;}

    }
}