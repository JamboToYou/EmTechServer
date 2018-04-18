using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmTechServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmTechServer.Models.Office;

namespace EmTechServer.Controllers
{
    [Produces("application/json")]
    public class UserController : Controller
    {
       
        [HttpGet,Route("api/user")]
        public string Get()
        {
            return "Welcome to the Em.Tech Server";
        }
        
        [HttpPost,Route("api/user/create")]
        public ObjectResult Create([FromBody]User user)
        {
            if (!String.IsNullOrEmpty(user.Number) && !String.IsNullOrEmpty(user.MacAdress))
            {
                string sess = SessionIdGenerator.Generator.GetNewId(); // check DB
                //Connect to database
                return new ObjectResult(new { error = 0, sessionId = sess });
            }
            return new ObjectResult(new {error = 1});
        }

        [HttpPost, Route("api/user/auth")]
        public ObjectResult Auth([FromBody]User user)
        {
            if (!String.IsNullOrEmpty(user.Number) && !String.IsNullOrEmpty(user.MacAdress) && !String.IsNullOrEmpty(user.SessionId))
            {
               
                //Connect to database
                if(Models.User.isValidUser(user.SessionId))
                {
                    return new ObjectResult(new { error = 0, SessionId  = "SessiondIdExample" });
                } else
                {
                    return new ObjectResult(new { error = 1 });
                }              
            }
            return new ObjectResult(new { error = 1 });
        }


        [HttpPost, Route("api/user/profile")]
        public ObjectResult Profile([FromBody]User user)
        {
            if (Models.User.isValidUser(user.SessionId))
            {
                //Connect to database
                return new ObjectResult(new { error = 0 });
            }
            return new ObjectResult(new { error = 1 });
        }

    }
}