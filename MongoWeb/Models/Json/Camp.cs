using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace MongoWeb.Models.Json
{
    public class Camp
    {
        public ObjectId _id { get; set; }
        public int code { get; set; }
        public object name { get; set; }
        public object address { get; set; }
        public object pcpl { get; set; }
        public object lat { get; set; }
        public object lng { get; set; }
        public object web { get; set; }
        public object tel { get; set; }
        public object tel1 { get; set; }
        public object fax { get; set; }
        public object mob { get; set; }
        public object email { get; set; }
        public object webg { get; set; }
        public object weba { get; set; }
        public object webc { get; set; }
        public object webu { get; set; }
        public object rat { get; set; }
        public string created_at { get; set; }
    }
}