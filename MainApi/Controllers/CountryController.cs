using PracProject.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MainApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CountryController : ApiController
    {
        MN_ProjectEntities Context = new MN_ProjectEntities();
        [HttpGet]

        public IHttpActionResult GetCountryList()
        {
            try
            {
                Context.Configuration.ProxyCreationEnabled = false;
                List<Country> CountryList = Context.Country.ToList();
                return Ok(CountryList);
            }
            catch(Exception E)
            {
                throw E;
            }
        }

    }
}
