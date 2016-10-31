using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MongoWeb.Models
{
    public class Theme
    {
        [Key]
        public int ID { get; set; }
        public string url { get; set; }
        public string iconUrl { get; set; }
        public string description { get; set; }
        public string name { get; set; }

        public List<CampingPlace> campingPlace { get; set; }
    }
}