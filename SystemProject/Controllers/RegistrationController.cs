using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace SystemProject.Controllers
{
    public class RegistrationController : ApiController
    {
        private Data.projectdbDataContext db = new Data.projectdbDataContext();

        [Authorize]
        [Route]
        [Route/"api/registration/list"]

    }
}

