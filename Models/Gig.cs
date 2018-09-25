using System;
using System.IO;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NinneHomePage.Models
{
    public class Gig
    {
        [BsonId]
        public BsonObjectId _id { get; set;}
        public string title { get; set; }
        public string body { get; set; }
    }
}