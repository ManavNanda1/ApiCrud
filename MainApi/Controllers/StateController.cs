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
    public class StateController : ApiController
    {
        MN_ProjectEntities Context = new MN_ProjectEntities();
        
        [HttpGet]
        public IHttpActionResult GetStateList()
        {
            try
            {
                List<state> StateList = Context.state.ToList();
                return Ok(StateList);
            }
            catch(Exception E)
            {
                throw E;
            }
        }
        [HttpGet]
        public IHttpActionResult GetStateList(int id)
        {
            try
            {
                Context.Configuration.ProxyCreationEnabled = false;
                List<state> StateList = Context.state.Where(x=> x.CountryId == id).ToList();
                return Ok(StateList);
            }
            catch (Exception E)
            {
                throw E;
            }
        }
    }
}
