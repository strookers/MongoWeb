using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MongoWeb.Models
{
    public class Info
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public List<CampingPlace> campingPlace { get; set; }
    }
}