using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemProject.Models
{
    public class ModelAds
    {
        public Int32 productID { get; set; }
        public String company { get; set; }
        public String staff { get; set; }
        public Byte[] image { get; set; }
        public String adsDetails { get; set; }
        public Int32 adsID { get; set; }
        public String adsName { get; set; }
    }
}