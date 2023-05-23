using PracProject.Model.Context;
using PracProject.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracProject.Helper.Helper
{
    public class EmployeeHelper
    {
        public Employee AddEmployee (EmployeeModel EmpData)
        {
            try
            {
                Employee Data = new Employee();
                Data.Id = EmpData.Id;
                Data.Fname = EmpData.Fname;
                Data.Lname = EmpData.Lname;
                Data.DOB = EmpData.DOB;
                Data.Email = EmpData.Email;
                Data.Country = EmpData.Country;
                Data.State = EmpData.State;
                return Data;
            }
            catch(Exception E)
            {
                throw E;
            }
        }
    }
}
