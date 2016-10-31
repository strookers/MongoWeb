﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MongoWeb.Models
{
    public class campingPlaces
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string location { get; set; }
        public string web { get; set; }
        public string tel { get; set; }
        public string tel1 { get; set; }
        public string fax { get; set; }
        public string mob { get; set; }
        public string email { get; set; }
        public string rating { get; set; }
        public DateTime created_at { get; set; }
        public DateTime update_at { get; set; }
    }
}