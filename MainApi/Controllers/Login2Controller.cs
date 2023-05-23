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
    public class Login2Controller : ApiController
    {
        MN_ProjectEntities Context = new MN_ProjectEntities();
        [HttpPost]
        public IHttpActionResult LoginCheck(LoginModel LogData)
        {
            try
            {
                bool Student = Context.Users.Any(x => x.Email == LogData.Email && x.Password == LogData.Password);
                if(Student)
                {
                    return Ok(1);
                }
                else
                {
                    return Unauthorized();
                }
            }
            catch (Exception E)
            {

                throw E;
            }
        }

    }
}
