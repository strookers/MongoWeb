﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MongoWeb.Models
{
    public class Location
    {
        [Key]
        public int ID { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
    }
}