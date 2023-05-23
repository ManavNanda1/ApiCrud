using PracProject.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ApiCrud.Controllers
{
    public class LoginController : Controller
    {
        HttpClient ApiConnnection = new HttpClient();
        public ActionResult SignUp()
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
        public ActionResult PostUser(SignUpModel Data)
        {
            try
            {
                ApiConnnection.BaseAddress = new Uri("http://localhost:53392/api/LoginApi");
                var Response = ApiConnnection.PostAsJsonAsync("LoginApi", Data);
                Response.Wait();
                var Test = Response.Result;
                if (Test.IsSuccessStatusCode)
                {
                    return RedirectToAction("SignUp");
                }
                else
                {
                    return RedirectToAction("SignUp");
                }
            }

            catch (Exception E)
            {
                throw E;
            }
        }

        public ActionResult Login()
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
        public ActionResult LoginDataCheck(LoginModel LogData)
        {
            try
            {
                ApiConnnection.BaseAddress = new Uri("http://localhost:53392/api/Login2");
                var Response = ApiConnnection.PostAsJsonAsync("Login2", LogData);
                Response.Wait();
                var data = Response.Result;
                if (data.IsSuccessStatusCode)
                {
                    return RedirectToAction("SignUp");
                }
                else
                {
                    ViewBag.Error = "Invalid Credentials";
                    return View("Login");
                }
            }
            catch(Exception E)
            {
                throw E;
            }
        }
    }
}