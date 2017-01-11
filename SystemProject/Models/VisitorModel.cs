using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemProject.Models
{
    public class VisitorModel
    {
        public Int32 id { get; set; }
        public String name { get; set; }
        public String email { get; set; }
        public DateTime date_visited { get; set; }
        public Boolean is_active { get; set; }
    }
}