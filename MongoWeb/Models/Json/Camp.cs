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
        public string name { get; set; }
        public string address { get; set; }
        public string pcpl { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public string web { get; set; }
        public long tel { get; set; }
        public long tel1 { get; set; }
        public long fax { get; set; }
        public long mob { get; set; }
        public string email { get; set; }
        public string webg { get; set; }
        public int weba { get; set; }
        public int webc { get; set; }
        public int webu { get; set; }
        public int rat { get; set; }
        public string created_at { get; set; }
    }
}