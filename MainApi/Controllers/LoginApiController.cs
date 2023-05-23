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
    public class LoginApiController : ApiController
    {
        MN_ProjectEntities Context = new MN_ProjectEntities();
        [HttpPost]
        public IHttpActionResult PostSignUpData(SignUpModel Data)
        {
            try
            {
                UserHelper Addhelper = new UserHelper();
                var UserData = Addhelper.AddUser(Data);
                Context.Users.Add(UserData);
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
