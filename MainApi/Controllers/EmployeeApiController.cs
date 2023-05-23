using PracProject.Helper.Helper;
using PracProject.Model.Context;
using PracProject.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MainApi.Controllers
{
    public class EmployeeApiController : ApiController
    {
        MN_ProjectEntities Context = new MN_ProjectEntities();

        [HttpGet]
        public IHttpActionResult GetEmpTable()
        {
            try
            {
                //Context.Configuration.ProxyCreationEnabled = false;
                List<Employee> Data = Context.Employee.ToList();
                List<EmployeeModel> models = new List<EmployeeModel>();
                foreach(Employee employee in Data)
                {
                    models.Add(new EmployeeModel
                    {
                        Id = employee.Id,
                        Country = employee.Country,
                        DOB = employee.DOB,
                        Email = employee.Email,
                        Fname = employee.Fname,
                        Lname = employee.Lname,
                        State = employee.State
                    });
                }
                return Ok(models);
            }
            catch(Exception E)
            {
                throw E;
            }
        }

        [HttpPost]

        public IHttpActionResult PostEmployee (EmployeeModel EmpData)
        {
            try
            {
                EmployeeHelper Emphelper = new EmployeeHelper();
                var Data = Emphelper.AddEmployee(EmpData);
                Context.Employee.Add(Data);
                Context.SaveChanges();
                return Ok();
            }
            catch(Exception E)
            {
                throw E;
            }
        }

    }
}
