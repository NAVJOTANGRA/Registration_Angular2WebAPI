using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Angular2WebApi.Models;

using Angular2WebApi.BuisnessLogic;

namespace Angular2WebApi.Repository
{
    public interface ICompanyAndProduct
    {
        /// <summary>
        /// This is used to bind Dropdown For company
        /// </summary>
        /// <returns></returns>
        List<ModelComapnyList> GetCompanyList();

        /// <summary>
        /// This is used to bind Dropdown For company
        /// </summary>
        /// <returns></returns>
        List<ModelProductList> GetProductList();

        /// <summary>
        /// This is used to bind Dropdown For company
        /// </summary>
        /// <returns></returns>
        List<CountryModel> GetCountryList();

        /// <summary>
        /// This is used to bind Dropdown For company
        /// </summary>
        /// <returns></returns>
        List<StateModel> GetStateList();



        /// <summary>
        /// This is used to bind Dropdown For company
        /// </summary>
        /// <returns></returns>
        List<CityModel> GetCityList();


        /// <summary>
        /// Search list from database
        /// </summary>
        /// <returns></returns>
        clsResponse SearchList();


        /// <summary>
        /// Save bvalue in database
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        clsResponse AddValue(CommonTable ct);

        /// <summary>
        /// Save bvalue in database
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        clsResponse SaveRegistrationForm(MRegistrationForm objSearh);

        /// <summary>
        /// Delete Value from grid
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        clsResponse DeleteItem(CommonTable ct);
        /// <summary>
        /// used for update data in table
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        clsResponse UpdateItem(CommonTable ct);

    }
}