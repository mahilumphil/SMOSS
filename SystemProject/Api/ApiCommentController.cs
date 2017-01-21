using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SystemProject.Api
{
    public class ApiCommentController : ApiController
    {
        private Data.smartshopdbDataContext db = new Data.smartshopdbDataContext();

        [HttpPost]
        [Route("api/comment/add")]
        public HttpResponseMessage Comments(Models.CommentModel add)
        {
            try
            {
                Data.comment newComment = new Data.comment();
                Data.AspNetUser userID = new Data.AspNetUser();
                Data.visitor visitorID= new Data.visitor();

                newComment.comment1 = add.comment;
                userID.Id = newComment.user_id;
                visitorID.Id = newComment.visitor_id;

                db.comments.InsertOnSubmit(newComment);
                db.SubmitChanges();

                return Request.CreateResponse(HttpStatusCode.OK);

            }
            catch (Exception e) {
                Debug.WriteLine(e);
                return Request.CreateResponse(HttpStatusCode.BadRequest , "Bad Request");
            }   
        
        }


        [HttpGet]
        [Route("api/comment/list")]
        public List<Models.CommentModel> Get()
        {
            var getcomment = from d in db.comments
                          select new Models.CommentModel
                          {
                              comment = d.comment1,
                              visitor_id = Convert.ToString(d.visitor_id),
                              user_id = Convert.ToInt32(d.user_id)
                          };

            return getcomment.ToList();
        }
    }
}
