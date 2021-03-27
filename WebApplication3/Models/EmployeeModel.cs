using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Models
{
    public class EmployeeModel
    {

        //public List<CityModel> CityList { get; set; }

        public List<StateModel> StateList { get; set; }
        public List<SelectListItem> CityList { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string  Email  { get; set; }
        public string  Password { get; set; }
        public int StateId { get; set; }

        public string Statename { get; set; }

        public int CityId { get; set; }
        public string Cityname { get; set; }
    }
}