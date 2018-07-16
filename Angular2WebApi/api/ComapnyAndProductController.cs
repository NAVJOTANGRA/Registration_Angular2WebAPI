using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Angular2WebApi.Controllers;
using Angular2WebApi.Models;
using Angular2WebApi.Repository;
using Angular2WebApi.BuisnessLogic;
using Angular2WebApi.SqlCOnnection;
using Newtonsoft.Json;
using System.Collections;
using System.Web.Script.Serialization;
using System.Web;
using System.IO;

namespace Angular2WebApi.api
{
     [RoutePrefix("api/ComapnyAndProduct")]
    public class ComapnyAndProductController : ApiController
    {
       
        public class ClsObjCollection : CollectionBase
        {
            public ClsObjCollection()
            {

            }
        }
        public class Search
        {
            public string Key { get; set; }
            public string Value { get; set; }
            public object ObjectValue { get; set; }
        }
        public class RootObject
        {
            public List<Search> objSearch { get; set; }
        }

        public IHttpActionResult GetCountryList()
        {
            CompanyAndProduct Cobj = new CompanyAndProduct(new CCCompanyAndProduct());
            var objlist = Cobj.GetCountryList();
            return Ok(objlist.ToList());
        }
        public IHttpActionResult GetStateList()
        {
            CompanyAndProduct Cobj = new CompanyAndProduct(new CCCompanyAndProduct());
            var objlist = Cobj.GetStateList();
            return Ok(objlist.ToList());
        }
        public IHttpActionResult GetCityList()
        {
            CompanyAndProduct Cobj = new CompanyAndProduct(new CCCompanyAndProduct());
            var objlist = Cobj.GetCityList();
            return Ok(objlist.ToList());
        }
        [HttpPost]
        public IHttpActionResult SaveRegistrationForm([FromBody] MRegistrationForm objSearch)
        {
            CompanyAndProduct Cobj = new CompanyAndProduct(new CCCompanyAndProduct());
            //MRegistrationForm dt = new MRegistrationForm();
            var objlist = Cobj.SaveRegistrationForm(objSearch);
            return Ok(objlist);
        }

        public IHttpActionResult GetCOmpanyList()
        {
            CompanyAndProduct Cobj = new CompanyAndProduct(new CCCompanyAndProduct());
            var objlist = Cobj.GetCompanyList();
            return Ok(objlist.ToList());
        }
        public IHttpActionResult GetProductList()
        {
            CompanyAndProduct Cobj = new CompanyAndProduct(new CCCompanyAndProduct());
            var objlist = Cobj.GetProductList();
            return Ok(objlist.ToList());
        }

        [HttpGet]
        public IHttpActionResult SearchList()
        {
            IHttpActionResult pbj = null;
            Dictionary<string, string> disobbnj = new Dictionary<string, string>();
            clsResponse res = null;
            CompanyAndProduct Cobj = new CompanyAndProduct(new CCCompanyAndProduct());
            res = Cobj.SearchList();
            return Ok(res);
        }

        [HttpPost]
        public IHttpActionResult AddValue([FromUri]CompanyModel objsearch, ClsObjCollection obj)
        {
            //string _executingPage = null;
           
            ////For Encrpt value from encrpt value 
            //string abc = encrpyt(objsearch);

            ////For decrpt value from encrpt value 
            //string result = decrpt(abc);
            //string result2 = "successfully"; 
            //SessionCLass session = new SessionCLass();
            //clsResponse res = new clsResponse();
            //CommonTable ct = new CommonTable();
            //CompanyAndProduct Cobj = new CompanyAndProduct(new CCCompanyAndProduct());
            //IEnumerable<Search> strParam = JsonConvert.DeserializeObject<RootObject>(objsearch).objSearch.ToList();
            //string strItem = string.IsNullOrWhiteSpace(strParam.Where(t => t.Key == "ItemId").Select(t => t.Value).FirstOrDefault()) == true ? "0" : strParam.Where(t => t.Key == "ItemId").Select(t => t.Value).FirstOrDefault();
            //ct.ProjectID = Convert.ToInt16(strParam.Where(t => t.Key == "Projectid").Select(t => t.Value).FirstOrDefault());
            //ct.CompanyName = strParam.Where(t => t.Key == "CompanyName").Select(t => t.Value).FirstOrDefault();
            //ct.ProductName = strParam.Where(t => t.Key == "Productname ").Select(t => t.Value).FirstOrDefault();
            //ct.ProductID = Convert.ToInt16(strParam.Where(t => t.Key == "ProductId ").Select(t => t.Value).FirstOrDefault());
            //ct.CompanyID = Convert.ToInt16(strParam.Where(t => t.Key == "CompanyId").Select(t => t.Value).FirstOrDefault());
            //ct.Status = 1;
            //if (strItem == "0")
            //{
            //    res = Cobj.AddValue(ct);
            //}
            //else
            //{
            //    //res = Cobj.UpdateItem(obj);
            //}
            return Ok();
        }

        /// <summary>
        /// Function for DELETE item from database
        /// </summary>
        /// <param name="objSearch"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult DeleteItem([FromBody]CountryModel objSearch)
                {
            //Dictionary<object, object> disreponse = new Dictionary<object, object>();
            clsResponse cls = new clsResponse();
            //CompanyAndProduct obj = new CompanyAndProduct(new CCCompanyAndProduct());
            //try
            //{
            //    IEnumerable<Search> strparam = JsonConvert.DeserializeObject<RootObject>(objSearch).objSearch.ToList();
            //    CommonTable ct = new CommonTable();
            //    ct.CompanyID = Convert.ToInt16(strparam.Where(t => t.Key == "CompanyID").Select(t => t.Value).FirstOrDefault());
            //    ct.ProductID = Convert.ToInt16(strparam.Where(t => t.Key == "ProductID").Select(t => t.Value).FirstOrDefault());
            //    ct.CompanyName = strparam.Where(t => t.Key == "Companyname").Select(t => t.Value).FirstOrDefault();
            //    obj.DeleteItem(ct);
            //    disreponse.Add(cls.StatusCode, cls.StatusText);
            //}
           
            //catch (Exception ex)
            //{
            //    cls.StatusCode = 404;
            //    cls.StatusText = "Unsuccessfully";
            //    disreponse.Add(cls.StatusCode, cls.StatusText);
            //}
            return Ok(cls);
        }

        /// <summary>
        /// For Update DataItem
        /// </summary>

        [HttpPost]
        public IHttpActionResult UpdateItem([FromUri] string objSearch)
        {
            clsResponse cls = new clsResponse();
            CompanyAndProduct candp = new CompanyAndProduct(new CCCompanyAndProduct());
            return Ok(cls);
        }

        /// <summary>
        /// function for edit data from database
        /// </summary>
        /// <param name="abc"></param>
        /// <returns></returns>

        [HttpPut]
        public IHttpActionResult EditData([FromUri] string abc)
        {
            IHttpActionResult response = null;
            CommonTable ct = new CommonTable();
            CCCompanyAndProduct repository = new CCCompanyAndProduct();          
            return response;
        }

        /// <summary>
        /// Check For encrption and decrption data
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string encrpyt(string obj)
        {
            string pass;
            //deSerialize .net object to json object
            IEnumerable<Search> strParam = JsonConvert.DeserializeObject<RootObject>(obj).objSearch.ToList();
            //Serialize .net object to json object
            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonData = js.Serialize(strParam);
            pass = strParam.Where(t => t.Key == "Productname ").Select(t => t.Value).FirstOrDefault();
            string abcd = JsonConvert.DeserializeObject(obj).ToString();
            byte[] encData_byte = new byte[pass.Length];
            encData_byte = System.Text.Encoding.UTF8.GetBytes(pass);
            string encodedData = Convert.ToBase64String(encData_byte);
            return encodedData;
        }

        public string decrpt(string abc)
        {
                System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
                System.Text.Decoder utf8Decode = encoder.GetDecoder();
                byte[] todecode_byte = Convert.FromBase64String(abc);
                int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
                char[] decoded_char = new char[charCount];
                utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
                string result = new String(decoded_char);
                return result;           
        }   
        /// <summary>
        /// This method is used to updata excel in database
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult addexcel()
        {
            IHttpActionResult obj = null;
            Dictionary<object, object> dsiresponse = new Dictionary<object, object>();
            clsResponse cls = new clsResponse();
            return obj;
        }   
        public string ExcelUpload()
        {
            Dictionary<string, string> disresp = new Dictionary<string, string>();
            string obj = "df";
            string strpath = "";

            //Excel where u want to save
            strpath = HttpContext.Current.Server.MapPath("~/excelupload/new fiile.xlsx");
             var filename = HttpContext.Current.Request.Files.AllKeys[0];

            if (filename == null)
            {
                disresp.Add("Message","Invalid filename");                
            }
            
            Byte[] bytes = System.IO.File.ReadAllBytes(strpath);
            System.IO.MemoryStream stream = new MemoryStream(bytes);

            HttpFileCollection objfile = HttpContext.Current.Request.Files;
            for (int iCnt = 0; iCnt <= objfile.Count - 1; iCnt++)
            {
                System.Web.HttpPostedFile hpf = objfile[iCnt];
               // Compare(hpf, objfile);
            }
           //Compare excel sheet withh uploaded sheet
            return obj;
        }
//        public bool Compare(HttpFileCollection hpf  , HttpFileCollection objfile)
//        {
//         for (int cnt = 0; cnt < hpf.Count; cnt++)
//            {
//                if (hpf.Count != 1)
//                {
//                    return false;
//                }
//                else
//                {
//                    if (hpf.AllKeys != objfile.AllKeys)
//                    {
                        
                      
//                    }
//                }

//            }
////            return true;

//        }

    }
}

