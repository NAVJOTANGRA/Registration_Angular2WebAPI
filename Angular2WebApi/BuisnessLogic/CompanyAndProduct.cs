using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Angular2WebApi;
using Angular2WebApi.BuisnessLogic;
using Angular2WebApi.Repository;
using Angular2WebApi.Models;

namespace Angular2WebApi.BuisnessLogic
{
    public class CompanyAndProduct
    {
        private ICompanyAndProduct repository;
        public CompanyAndProduct(ICompanyAndProduct _repos)
        {
            repository = _repos;
        }
        /// <summary>
        /// bIND dROPDOWN fRO COMAPNY
        /// </summary>
        /// <returns></returns>
        public List<ModelComapnyList> GetCompanyList()
        {
            return repository.GetCompanyList();
        }

        /// <summary>
        /// bIND dROPDOWN fRO GetCountryList
        /// </summary>
        /// <returns></returns>
        public List<CountryModel> GetCountryList()
        {
            return repository.GetCountryList();
        }

        /// <summary>
        /// bIND dROPDOWN fRO GetStateList
        /// </summary>
        /// <returns></returns>
        public List<StateModel> GetStateList()
        {
            return repository.GetStateList();
        }

        /// <summary>
        /// bIND dROPDOWN fRO GetCityList
        /// </summary>
        /// <returns></returns>
        public List<CityModel> GetCityList()
        {
            return repository.GetCityList();
        }

        /// <summary>
        /// bIND DROPDOWN FRO pRODUCTlIS
        /// </summary>
        /// <returns></returns>
        public List<ModelProductList> GetProductList()
        {
            return repository.GetProductList();
        }
        /// <summary>
        /// THIS FUNCTION IS FORSEARCH DATA FROM DATABSE
        /// </summary>
        /// <returns></returns>
        public clsResponse SearchList()
        {
            return repository.SearchList();
        }
        /// <summary>
        /// THIS FUNCTION IS USED FOR SAVE DATA IN DATABASE
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        public clsResponse AddValue(CommonTable ct)
        {
            return repository.AddValue(ct);
        }



        /// <summary>
        /// THIS FUNCTION IS USED FOR SAVE DATA IN DATABASE
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        public clsResponse SaveRegistrationForm(MRegistrationForm objSearh)
        {
            return repository.SaveRegistrationForm(objSearh);
        }

        /// <summary>
        /// dELETE FUNCTUION IS USED FOR DELETE DATA FROM DATABASE
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        public clsResponse DeleteItem(CommonTable ct)
        {
            return repository.DeleteItem(ct);
        }
        /// <summary>
        /// ?upDATE FUNCTION  IS USED FOR UPDATE DATA IN TABLE 
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        public clsResponse UpdateItem(CommonTable ct)
        {
            return repository.UpdateItem(ct);
        }
    }
}