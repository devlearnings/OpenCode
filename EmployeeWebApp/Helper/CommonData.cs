using EmployeeWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeWebApp.Helper
{
    public static class CommonData
    {
        public static List<SelectListItem> GetCountryList()
        {
            List<SelectListItem> countryList = new List<SelectListItem>();
            countryList.Add(new SelectListItem { Value = "1", Text = "America" });
            countryList.Add(new SelectListItem { Value = "2", Text = "India" });
            countryList.Add(new SelectListItem { Value = "3", Text = "Russia" });
            return countryList;
        }

        public static List<State> GetStateList()
        {
            List<State> stateList = new List<State>();
            stateList.Add(new State { CountryId = 2, StateId = 1, StateName = "Gujarat"});
            stateList.Add(new State { CountryId = 2, StateId = 2, StateName = "Rajasthan" });
            stateList.Add(new State { CountryId = 2, StateId = 3, StateName = "Maharashtra" });
            stateList.Add(new State { CountryId = 1, StateId = 4, StateName = "California" });
            stateList.Add(new State { CountryId = 1, StateId = 5, StateName = "Los Angeles" });
            stateList.Add(new State { CountryId = 3, StateId = 6, StateName = "Finland" });
            return stateList;
        }
    }
}