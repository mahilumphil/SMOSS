using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SystemProject.Api
{
    public class ApiVisitorController : ApiController
    {
        private Data.smartshopdbDataContext db = new Data.smartshopdbDataContext();

        [HttpPost]
        [Route("api/visitor/add")]
        public HttpResponseMessage addVisitor(Models.VisitorModel add)
        {
            try
            {
                Data.visitor newVisitor = new Data.visitor();

                newVisitor.name = add.name;
                newVisitor.email = add.email;
                newVisitor.date_visited = add.date_visited;
                newVisitor.is_active = add.is_active;

                var visitor = from d in db.visitors
                              where d.email == add.email
                              select d;

                if (visitor.Any())
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Already Exist.");
                } 
                else {
                    db.visitors.InsertOnSubmit(newVisitor);
                    db.SubmitChanges();

                    return Request.CreateResponse(HttpStatusCode.OK);
                    
                }
             
            }
            catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Bad Request!");
            }
        
        }
        

    }
}
