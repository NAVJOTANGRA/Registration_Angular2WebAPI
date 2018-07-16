using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Angular2WebApi.BuisnessLogic;
using Angular2WebApi.Repository;
using Angular2WebApi.Models;
using System.Data;
using Angular2WebApi.SqlCOnnection;
using System.Data.Common;
namespace Angular2WebApi.Repository
{
    public class CCCompanyAndProduct : ICompanyAndProduct
    {
        int abc; int id = 1; int temp;
        sqlconnection con = new sqlconnection();
        /// <summary>
        /// Function For Bind Dropdown Company
        /// </summary>
        /// <returns></returns>
        public List<ModelComapnyList> GetCompanyList()
        {
            sqlconnection con = new sqlconnection();
            con.sqlcon.Open();
            var cmd = con.sqlcmd;
            cmd.Connection = con.sqlcon;
            List<ModelComapnyList> listdetail = new List<ModelComapnyList>();
            //   DataTable dt = new DataTable();
            # region GetCompanyDetail
            try
            {
                cmd.CommandText = "Select * from CompanyDetail";
                cmd.ExecuteNonQuery();
                var ds1 = con.sd;
                DataTable dt = new DataTable();
                ds1.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ModelComapnyList md = new ModelComapnyList();
                    md.CompanyNmae = dt.Rows[i]["CompanyNmae"].ToString();
                    md.ProjectID = Convert.ToInt16(dt.Rows[i]["ProjectID"].ToString());
                    md.Status = Convert.ToInt16(dt.Rows[i]["Status"].ToString()); ;
                   // md.CompanyDetail = dt.Rows[i]["CompanyDetail"].ToString();
                    md.CompnayId = Convert.ToInt16(dt.Rows[i]["CompnayId"].ToString());
                    md.CompanyDetail = dt.Rows[i]["CompanyDetail"].ToString();
                    
                    listdetail.Add(md);
                }
            }
            #endregion
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return listdetail;
        }

        public List<ModelComapnyList> Companylist()
        {
            List<ModelComapnyList> obj = null;

            return obj;
        }



        public List<CountryModel> GetCountryList()
        {
            sqlconnection con = new sqlconnection();
            con.sqlcon.Open();
            var cmd = con.sqlcmd;
            cmd.Connection = con.sqlcon;
            List<CountryModel> listdetail = new List<CountryModel>();
            //   DataTable dt = new DataTable();
            try
            {
                #region GetProductList
                cmd.CommandText = "Select * from Country";
                cmd.ExecuteNonQuery();
                var ds1 = con.sd;
                DataTable dt = new DataTable();
                ds1.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CountryModel md1 = new CountryModel();
                    md1.CountryName = dt.Rows[i]["CountryName"].ToString();
                    md1.CountryId = Convert.ToInt16(dt.Rows[i]["CountryId"].ToString());
                   
                    listdetail.Add(md1);
                }
            }

            #endregion
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return listdetail;
        }

        public List<StateModel> GetStateList()
        {
            sqlconnection con = new sqlconnection();
            con.sqlcon.Open();
            var cmd = con.sqlcmd;
            cmd.Connection = con.sqlcon;
            List<StateModel> listdetail = new List<StateModel>();
            //   DataTable dt = new DataTable();
            try
            {
                #region StateModel
                cmd.CommandText = "Select * from State";
                cmd.ExecuteNonQuery();
                var ds1 = con.sd;
                DataTable dt = new DataTable();
                ds1.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    StateModel md1 = new StateModel();
                    md1.StateName = dt.Rows[i]["StateName"].ToString();
                    md1.StateId = Convert.ToInt16(dt.Rows[i]["StateId"].ToString());

                    listdetail.Add(md1);
                }
            }

            #endregion
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return listdetail;
        }


        public List<CityModel> GetCityList()
        {
            sqlconnection con = new sqlconnection();
            con.sqlcon.Open();
            var cmd = con.sqlcmd;
            cmd.Connection = con.sqlcon;
            List<CityModel> listdetail = new List<CityModel>();
            //   DataTable dt = new DataTable();
            try
            {
                #region StateModel
                cmd.CommandText = "Select * from City";
                cmd.ExecuteNonQuery();
                var ds1 = con.sd;
                DataTable dt = new DataTable();
                ds1.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CityModel md1 = new CityModel();
                    md1.CityName = dt.Rows[i]["CityName"].ToString();
                    md1.CityId = Convert.ToInt16(dt.Rows[i]["CityId"].ToString());

                    listdetail.Add(md1);
                }
            }

            #endregion
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return listdetail;
        }
        /// <summary>
        /// Bind DropDown For ProductList
        /// </summary>
        /// <returns></returns>
        public List<ModelProductList> GetProductList()
        {
            sqlconnection con = new sqlconnection();
            con.sqlcon.Open();
            var cmd = con.sqlcmd;
            cmd.Connection = con.sqlcon;
            List<ModelProductList> listdetail = new List<ModelProductList>();
            //   DataTable dt = new DataTable();
            try
            {
                #region GetProductList
                cmd.CommandText = "Select * from Product";
                cmd.ExecuteNonQuery();
                var ds1 = con.sd;
                DataTable dt = new DataTable();
                ds1.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ModelProductList md = new ModelProductList();
                    md.ProductName = dt.Rows[i]["ProductName"].ToString();
                    md.ProjectId = Convert.ToInt16(dt.Rows[i]["ProjectId"].ToString());
                    md.Status = Convert.ToInt16(dt.Rows[i]["Status"].ToString()) ;
                    md.CompanyNmae = dt.Rows[i]["CompanyNmae"].ToString();
                    md.ProductId = Convert.ToInt16(dt.Rows[i]["ProductID"].ToString());
                    listdetail.Add(md);
                }
            }

            #endregion
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return listdetail;
        }

        public void getproduct()
        {
            Dictionary<string, object> disreposnse = new Dictionary<string, object>();
            clsResponse cls = new clsResponse();
            sqlconnection con = new sqlconnection();
            con.sqlcon.Open();
            var cmd = con.sqlcmd;
            cmd.Connection = con.sqlcon;
            try
            {

                disreposnse.Add("Succefully",cls);

            }
            catch (Exception ex)
            {
                disreposnse.Add("exceptionOccured", cls);
            }
        }

        public clsResponse Add()
        {
            con.sqlcon.Open();
            var cmd1 = con.sqlcmd;
            clsResponse res = new clsResponse();
            CommonTable cttable = new CommonTable();      
            cmd1.Connection = con.sqlcon;
            try
            {
                List<CommonTable> ct = new List<CommonTable>();
                DataTable dt = new DataTable();
                var sd1 = con.sd;
                sd1.Fill(dt);
                DataSet dst = new DataSet();
                dst.Copy();
                var abc = dst.DataSetName.Length.CompareTo(dt);
                //var obj = dt.Copy();
                
            }
            catch (Exception ex)
            {
                res.StatusCode = 200;
                res.StatusText = "Enter data in the list";

            }
            return res;

        }

        /// <summary>
        /// Sesrach Response List for search All element from database
        /// </summary>
        /// <returns></returns>
        public clsResponse SearchList()
        {
            Dictionary<object, object> disresponse = new Dictionary<object,object>();
            clsResponse response = new clsResponse();
            con.sqlcon.Open();
            var cmd = con.sqlcmd;
            cmd.Connection = con.sqlcon;
            try
            {
                #region SearchList
                cmd.CommandText = "Select * from CommonTable where status=1";
                cmd.ExecuteNonQuery();
                var ds1 = con.sd;
                DataSet dt = new DataSet();
                ds1.Fill(dt);
                if (dt != null && dt.Tables.Count > 0)
                {
                    response.StatusCode = 200;
                    response.StatusText = "Successfully";
                    response.ResponseDataSet = dt;

                }
                disresponse.Add((object)response,response.StatusCode);
                #endregion
            }
            catch (Exception ex)
            {
                response.StatusCode = 404;
                response.StatusText = "NotSuccessfully";
                disresponse.Add((object)response,response.StatusCode);
            }
            return response;
        }

        /// <summary>
        /// This functipon is used for save data in database
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>

        public clsResponse AddValue(CommonTable ct)
        {
            Dictionary<object, string> disresponse = new Dictionary<object, string>();
            clsResponse cls = new clsResponse();
            CommonTable tab = new CommonTable();
            con.sqlcon.Open();
            var cmd = con.sqlcmd;
            if (ct.ItemId == 0)
            {
                IdPlus(ct);
            }
            //  palindrome();
            try
            {
                cmd.Connection = con.sqlcon;
                cmd.CommandText = "[dbo].[AddValue]";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Projectid", ct.ProjectID);
                cmd.Parameters.AddWithValue("@Productname", ct.ProductName);
                cmd.Parameters.AddWithValue("@CompanyName", ct.CompanyName);
                cmd.Parameters.AddWithValue("@itemId", ct.ItemId);
                cmd.Parameters.AddWithValue("@ProductID", ct.ProductID);
                cmd.Parameters.AddWithValue("@CompanyID", ct.CompanyID);
                cmd.Parameters.AddWithValue("@Status", ct.Status);
                cmd.ExecuteNonQuery();
                cls.StatusCode = 200;
                cls.StatusText = "successufully saved";
                disresponse.Add((object)cls, "successfully saved");
               
            }
            catch
            {
                cls.StatusCode = 404;
                cls.StatusText = "Unsuccessufully saved";
                disresponse.Add((object)cls, "Unsuccessfully saved");
            }
            return cls;
        }



        /// <summary>
        /// This functipon is used for save data in database
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>

        public clsResponse SaveRegistrationForm(MRegistrationForm tab)
        {
            Dictionary<object, string> disresponse = new Dictionary<object, string>();
            clsResponse cls = new clsResponse();
            //MRegistrationForm tab = new MRegistrationForm();
            con.sqlcon.Open();
            var cmd = con.sqlcmd;
          
            try
            {
                cmd.Connection = con.sqlcon;
                cmd.CommandText = "[dbo].[SaveRegistration]";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", tab.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", tab.MiddleName);
                cmd.Parameters.AddWithValue("@fatherName", tab.fatherName);
                cmd.Parameters.AddWithValue("@_UId", tab._UId);
               
                cmd.Parameters.AddWithValue("@Country", tab.Country);
                cmd.Parameters.AddWithValue("@State", tab.State);
                cmd.Parameters.AddWithValue("@City", tab.City);
                cmd.Parameters.AddWithValue("@motherName", tab.motherName);
                cmd.ExecuteNonQuery();
                cls.StatusCode = 200;
                cls.StatusText = "successufully saved";
                disresponse.Add((object)cls, "successfully saved");

            }
            catch(Exception e)
            {
                cls.StatusCode = 404;
                cls.StatusText = "Unsuccessufully saved";
                disresponse.Add((object)cls, "Unsuccessfully saved");
            }
            return cls;
        }

        /// <summary>
        /// ?This is tempororay function for increment
        /// </summary>
        /// <param name="ct"></param>
        public void IdPlus(CommonTable ct)
        {
            if (ct.ItemId == 0)
            {
                if (temp >= 0)
                {
                    abc++;
                    ct.ItemId = abc;
                    temp = abc;

                }

            }

            // return ct.ItemId;
        }


        /// <summary>
        /// For Delete Value From Table
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>

        public clsResponse DeleteItem(CommonTable ct)
        {
            Dictionary<object, object> disresponse = new Dictionary<object, object>();
            clsResponse res = new clsResponse();
            CommonTable ct1 = new CommonTable();
            con.sqlcon.Open();
            var cmd = con.sqlcmd;

            try
            {
                cmd.Connection = con.sqlcon;
                cmd.CommandText = "[dbo].[DeleteItem]";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductID", ct.ProductID);
                cmd.Parameters.AddWithValue("@CompanyID", ct.CompanyID);
                cmd.ExecuteNonQuery();
                res.StatusCode = 200;
                res.StatusText = "SuccefullyDelete";
                disresponse.Add(res.StatusCode,(object)res);
            }
            catch (Exception ex)
            {
                res.StatusText = "Not deleted";
                res.StatusCode = 404;
                disresponse.Add(res.StatusCode, (object)res);
            }
            return res;
        }

        /// <summary>
        /// For Update Item
        /// </summary>
        /// <returns></returns>
        public clsResponse UpdateItem(CommonTable ct)
        {
            clsResponse response = new clsResponse();
            Dictionary<string, object> desRes = new Dictionary<string, object>();
            con.sqlcon.Open();
            var cmd = con.sqlcmd;
            cmd.CommandText = "[dbo].[UpdateItem]";
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@companyid", ct.CompanyID);
                cmd.Parameters.AddWithValue("@ItemId", ct.ItemId);
                cmd.Parameters.AddWithValue("@ProductID", ct.ProductID);
                cmd.Parameters.AddWithValue("@companyName", ct.CompanyName);

            }
            catch (Exception ex)
            {

            }
            return response;

        }

        public clsResponse GetUpdateData()
        {
            clsResponse response = new clsResponse();
            Dictionary<string, object> disobj = new Dictionary<string, object>();
            try
            {
                con.sqlcon.Open();
                var cmd = con.sqlcmd;
                cmd.Connection = con.sqlcon;
                cmd.CommandText = "Select * from GetUPdateTable";
                cmd.CommandType = CommandType.Text;
                DataTable st = new DataTable();
                var sd1 = con.sd;
                sd1.Fill(st);
                List<CommonTable> ctTable = new List<CommonTable>();
                for (int rows = 0; rows < st.Rows.Count; rows++)
                {
                    CommonTable ct = new CommonTable();
                    ct.CompanyID = Convert.ToInt16(st.Rows[rows]["CompanyId"].ToString());
                    ct.CompanyName = st.Rows[rows]["COmpanyName"].ToString();
                    ctTable.Add(ct);
                 //   ct.CompanyName=st.Rows
                }
            }
            catch (Exception ex)
            {
                disobj.Add("Add value", "Plz select value");
                response.StatusCode = 404;
                response.StatusText = "Plz select value";
            }
            return response;

        }

        public List<CommandType> DeleteData()
        {
            Dictionary<object, object> disreponse = new Dictionary<object, object>();
            List<CommandType> com = new List<CommandType>();
            con.sqlcon.Open();
            var cmd = con.sqlcmd;
            cmd.Connection = con.sqlcon;
            var sd1 = con.sd;
            DataTable dt = new DataTable();
            sd1.Fill(dt);
            for (int rows = 0; rows < dt.Rows.Count; rows++)
            {
                CommonTable ct = new CommonTable();
                ct.CompanyID = Convert.ToInt16(dt.Rows[rows]["CompanyID"].ToString());
                ct.CompanyName = dt.Rows[rows]["CompanyName"].ToString();
                ct.ProductID = Convert.ToInt16(dt.Rows[rows]["ProductId"].ToString());
                ct.ProductName = dt.Rows[rows]["ProductName"].ToString();
            }
            return com;
        }
    }
}