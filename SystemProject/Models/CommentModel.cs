using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemProject.Models
{
    public class CommentModel
    {
        public String Id { get; set; }
        public String visitor_id { get; set; }
        public String comment { get; set; }
        public DateTime date_created { get; set; }
        public Boolean is_active { get; set; }
        public Int32 user_id { get; set; }
    }
}