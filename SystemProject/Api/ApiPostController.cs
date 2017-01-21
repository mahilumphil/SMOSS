using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace SystemProject.Api
{
    public class ApiPostController : ApiController
    {
        private Data.smartshopdbDataContext db = new Data.smartshopdbDataContext();


        [HttpPost]
        [Route("api/post/add")]
        public HttpResponseMessage addPost(Models.PostModel add)
        {
            try
            {
                Data.post newPost = new Data.post();
                //string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Images\applicantPhotoPlaceHolder.png");

                //Byte[] bytes = File.ReadAllBytes(HttpContext.Current.Server.MapPath("~/Images/applicantPhotoPlaceHolder.png"));
                //String file = Convert.ToBase64String(bytes);
                //byte[] imgarr = Convert.FromBase64String(file);

                newPost.categoryname = add.categoryname;
                newPost.categorydescription = add.categorydescription;
                newPost.title = add.title;
                newPost.details = add.details;
                newPost.contact_person = add.contact_person;
                newPost.contact_number = add.contact_number;
                newPost.website = add.website;
                newPost.is_active = add.is_active;
                newPost.date_created = add.date_created;
                newPost.date_updated = add.date_created;
                //newPost.photo = imgarr;

                db.posts.InsertOnSubmit(newPost);
                db.SubmitChanges();


                return Request.CreateResponse(HttpStatusCode.OK, " ");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Bad Request");

            }
        }


        [HttpGet]
        [Route("api/post/list")]
        public List<Models.PostModel> Get()
        {
            var getpost = from d in db.posts
                          select new Models.PostModel
                              {
                                  categoryname = d.categoryname,
                                  categorydescription = d.categorydescription,
                                  title = d.title,
                                  details = d.details,
                                  contact_person = d.contact_person,
                                  contact_number = d.contact_number,
                                  website = d.website,
                                  is_active = d.is_active,
                                  date_created = d.date_created

                              };

            return getpost.ToList();
        }


    }
}
