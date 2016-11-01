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
        public int Id { get; set; }
        public string Url { get; set; }
        public string IconUrl { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public List<CampingPlace> CampingPlaces { get; set; }
    }
}