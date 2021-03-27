using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.Repository;

namespace WebApplication3.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepository oEmployeeRepository = new EmployeeRepository();

        // GET: Employee
        public ActionResult Index()
        {
            EmployeeModel oEmployeeModel = new EmployeeModel();
            List<SelectListItem> StateList = new List<SelectListItem>();

            oEmployeeModel.StateList = oEmployeeRepository.GetAllState();
            foreach (var item in oEmployeeModel.StateList)
            {
                StateList.Add(new SelectListItem()
                {
                    Text = item.Statename,
                    Value = item.StateId.ToString()
                });
            }
            ViewBag.StateList = StateList;

            return View();
        }
        [HttpPost]
        public ActionResult Getcity(string StateId)
        {
            int State_Id = Convert.ToInt32(StateId);
            EmployeeModel emp = new EmployeeModel();
            emp.CityList = oEmployeeRepository.GetAllCity(State_Id);
            return Json(emp.CityList, JsonRequestBehavior.AllowGet);

        }
    }

    
}
