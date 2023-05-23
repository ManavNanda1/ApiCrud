using PracProject.Model.Context;
using PracProject.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ApiCrud.Controllers
{
    public class EmployeeController : Controller
    {
        HttpClient ApiConnnection = new HttpClient();
        public ActionResult GetEmployee()
        {
            try
            {
                List<EmployeeModel> MainTable = new List<EmployeeModel>();
                ApiConnnection.BaseAddress = new Uri("http://localhost:53392/api/EmployeeApi");
                var Response = ApiConnnection.GetAsync("EmployeeApi");
                Response.Wait();
                var Test = Response.Result;
                if (Test.IsSuccessStatusCode)
                {
                    var DisplayTable = Test.Content.ReadAsAsync<List<EmployeeModel>>();
                    DisplayTable.Wait();
                    MainTable = DisplayTable.Result;
                }
                return View(MainTable);

            }
            catch(Exception E)
            {
                throw E;
            }
        }

        public ActionResult AddEmployee()
        {
            try
            {
                return View();
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        [HttpPost]
        public ActionResult PostEmployee(EmployeeModel EmpData)
        {
            try
            {
                ApiConnnection.BaseAddress = new Uri("http://localhost:53392/api/EmployeeApi");
                var Response = ApiConnnection.PostAsJsonAsync("EmployeeApi", EmpData);
                Response.Wait();
                var Test = Response.Result;
                if (Test.IsSuccessStatusCode)
                {
                    return RedirectToAction("GetEmployee");
                }
                else
                {
                    return RedirectToAction("AddEmployee");
                }
            }
            catch(Exception E)
            {
                throw E;
            }
        }
    }
}