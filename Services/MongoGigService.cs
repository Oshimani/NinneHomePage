using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using NinneHomePage.Interfaces;
using NinneHomePage.Models;

namespace NinneHomePage.Services
{
    class MongoGigService : IGigService
    {
        private readonly MongoClient _mongoClient;
        private readonly IMongoDatabase _dataBase;
        private readonly string _collectionName;
        private readonly IMongoCollection<Gig> _collection;

        public MongoGigService(IConfiguration config)
        {
            this._mongoClient = new MongoClient(config["MongoDB:ConnectionString"]);
            this._dataBase = this._mongoClient.GetDatabase(config["MongoDb:DataBase:Name"]);
            this._collectionName = config["MongoDB:DataBase:Collections:Gigs:Name"];
            this._collection = this._dataBase.GetCollection<Gig>(this._collectionName);
        }


        // get Gigs
        public async Task<IList<Gig>> getGigs(int limit)
        {
            FindOptions<Gig> options = new FindOptions<Gig>()
            {
                Limit = limit
            };
            try
            {
                IAsyncCursor<Gig> results = await this._collection.FindAsync(Builders<Gig>.Filter.Empty, options);
                return results.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}