using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MongoWeb.Models
{
    public class location
    {
        [Key]
        public int ID { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }

    }
}