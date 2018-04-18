using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmTechServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmTechServer.Controllers
{
    [Produces("application/json")]
    public class GeoController : Controller
    {
        [HttpPost, Route("api/geo/get")]
        public ObjectResult Get([FromBody]User user)
        {
            if (Models.User.isValidUser(user.SessionId))
            {

            } 
            return new ObjectResult(new { error = 1});
            
        }

        [HttpPost, Route("api/geo/broadcast")]
        public ObjectResult StartTranslation([FromBody]Translation translation)
        {
            if (Models.User.isValidUser(translation.SessionId))
            {

            }
            return new ObjectResult(new { error = 1 });
        }

        [HttpPost, Route("api/geo/end")]
        public ObjectResult EndTranslation([FromBody]Translation translation)
        {
            if (Models.User.isValidUser(translation.SessionId))
            {
                //Connect to DB, end translation
                return new ObjectResult(new { error = 0 });
            }
            return new ObjectResult(new { error = 1 });
        }

        [HttpPost, Route("api/geo/rate")]
        public ObjectResult Rate([FromBody]Translation translation)
        {
            if (Models.User.isValidUser(translation.SessionId))
            {

            }
            return new ObjectResult(new { error = 1 });
        }

        
    }
}