using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace MongoWeb.Models
{
    public class User
    {
        public ObjectId _id { get; set; } //MongoDb uses this field as identity.

        public Guid ID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string PhoneNo { get; set; }

        public string Address { get; set; }
    }
}