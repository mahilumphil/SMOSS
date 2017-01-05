using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SystemProject.Models
{
    public class Post
    {
        [Key]
        public Int32 id { get; set; }
        public Int32 user_id { get; set; }
        public String title { get; set;}
        public String category { get; set; }
        public String details { get; set; }
        public String contact_person { get; set; }
        public String contact_number { get; set; }
        public String website { get; set; }
        public byte[] photo { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_updated { get; set; }
        public byte[] is_active { get; set; }
    }
}