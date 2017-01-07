using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SystemProject.Models
{
    public class Post
    {
        [Key]
        public Int32 id { get; set; }
        public Int32 user_id { get; set; }
        public String title { get; set; }
        public String details { get; set; }
        public String contact_person { get; set; }
        public String contact_number { get; set; }
        public String website { get; set; }
        public byte[] photo { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_updated { get; set; }
        public byte[] is_active { get; set; }
        public int category_ID { get; set; }
        public String category {get; set;}
        public String category_name { get; set; }

        public static List<Post> getCategories() 
        {
            return new List<Post>{
                new Post {category_ID = 1 , category_name = "bench shirt" , category = "T-shirt"},
                new Post {category_ID = 2 , category_name = "bench short" , category = "T-short"},
                new Post {category_ID = 3 , category_name = "bench long" , category = "T-long"},
                new Post {category_ID = 4 , category_name = "bench minus" , category = "T-minus"}
          };  
        }
       }
}