using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemProject.Models
{
    public class PostModel
    {
        public Int32 id { get; set; }
        public Int32 user_id {get ; set;}
        public String title { get; set; }
        public String details { get; set; }
        public String contact_number { get; set; }
        public String contact_person { get; set; }
        public String website { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_updated { get; set; }
        public Boolean is_active { get; set; }
        //public Byte[] photo { get; set; }
        public String categoryname { get; set; }
        public String categorydescription { get; set; }
    }
}