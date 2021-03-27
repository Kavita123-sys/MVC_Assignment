using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages.Html;
using WebApplication3.Models;
using SelectListItem = System.Web.Mvc.SelectListItem;

namespace WebApplication3.Repository
{
    public class EmployeeRepository
    {
        public List<StateModel> GetAllState()
        {
            List<StateModel> StateList = new List<StateModel>();
            String MyData = "Data Source=DESKTOP-UE4FHFH;Initial Catalog=DemoDB;Integrated Security= SSPI;";
            try
            {

                SqlConnection con = new SqlConnection(MyData);
                con.Open();

                SqlCommand cmd = new SqlCommand("GetAllDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {


                    StateModel oStateModel = new StateModel();

                    oStateModel.StateId = Convert.ToInt32(dr["StateId"]);
                    oStateModel.Statename = dr["Statename"].ToString();
                    StateList.Add(oStateModel);

                }

            }

            catch (Exception)
            {

            }
            return StateList;
        }
        public List<SelectListItem> GetAllCity(int StateId)

        {
            List<SelectListItem> CityList = new List<SelectListItem>();
            String MyData = "Data Source=DESKTOP-UE4FHFH;Initial Catalog=DemoDB;Integrated Security= SSPI";
            try
            {

                SqlConnection con = new SqlConnection(MyData);
                con.Open();

                SqlCommand cmd = new SqlCommand("GetAllCityDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StateId",StateId);
                SqlDataReader dr1 = cmd.ExecuteReader();

                while (dr1.Read())
                {
                    CityList.Add(new SelectListItem()
                        {
                        Text = dr1["Cityname"].ToString(),
                        Value = dr1["CityId"].ToString()

                    });
                }
            }
            catch (Exception ex)
            {

            }
            return CityList;
        }
    }
}
    

    