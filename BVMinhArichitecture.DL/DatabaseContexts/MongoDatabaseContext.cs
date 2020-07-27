using BVMinhArichitecture.Common.Configurations;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace BVMinhArichitecture.DL.DatabaseContexts
{
    public class MongoDatabaseContext : IDatabaseContext
    {
        private readonly IMongoDatabase _mongoDatabase;
        private readonly IMongoClient _mongoClient;
        public MongoDatabaseContext()
        {
            _mongoClient = new MongoClient(GetConfiguration.GetAppSettings("MongoDB", "ConnectionString")/*"mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass%20Community&ssl=false"*/);
            _mongoDatabase = _mongoClient.GetDatabase(GetConfiguration.GetAppSettings("MongoDB", "DatabaseName")/*"BVMinh_MongoDb"*/);
        }
        public IMongoDatabase MongoDatabase { get => _mongoDatabase; }
    }
}
