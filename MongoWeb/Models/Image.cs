﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MongoWeb.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }
    }
}