using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemProject.Models
{
    public class ModelCreatePageLocalBusiness
    {
        public String category { get; set; }
        public String businessName { get; set; }
        public String streetAddress { get; set; }
        public Char zipCode { get; set; }
        public String phone { get; set; }
    }
}