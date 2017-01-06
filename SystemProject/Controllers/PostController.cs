using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace SystemProject.Controllers
{
    public class PostController : ApiController
    {
        private Data.smartshopdbDataContext db = new Data.smartshopdbDataContext();

        [Route("api/post/add")]
        public HttpResponseMessage Post(Models.Post item , byte[] image)
        {
            try
            {
                
                var identityUserId = User.Identity.GetUserId();
                var dateCreated = DateTime.Now;
                var dateUpdated = DateTime.Now;
                var img = image; 


                Data.post newItem = new Data.post();

                newItem.title = item.title != null ? item.title : " ";
                newItem.category = item.category != null ? item.category : " ";
                newItem.details = item.details != null ? item.details : " ";
                newItem.contact_person = item.contact_person != null ? item.contact_person : " ";
                newItem.contact_number = item.contact_number != null ? item.contact_number : " ";
                newItem.website = item.website != null ? item.website : " ";
                newItem.date_created = dateCreated;
                newItem.date_updated = dateCreated;
                newItem.photo = img;
                newItem.is_active = true;

                //ALLOW NULL

                db.posts.InsertOnSubmit(newItem);
                db.SubmitChanges();

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}
