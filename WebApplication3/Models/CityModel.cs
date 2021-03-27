using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Models
{
    public class CityModel
    {
        public int CityId { get; set; }
        public string Cityname { get; set; }
        public List<SelectListItem>CityList { get; set; }

    }
}