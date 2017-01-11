using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemProject.Models
{
    public class ModelLike
    {
        public Int32 id { get; set; }
        public Int32 visitor_id { get; set; }
        public Int64 likes { get; set; }
        public String date_created { get; set; }
    }
}