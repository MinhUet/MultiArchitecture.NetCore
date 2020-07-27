using BVMinhArichitecture.Common.Utilities;
using BVMinhArichitecture.DL.DatabaseContexts;
using BVMinhArichitecture.Entities.Entity;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace BVMinhArichitecture.DL.DatabseConnectors
{
    public class MongoDatabaseConnector<T> : IDatabaseConnector<T> where T : BaseEntity
    {
        private readonly string _collectionName;
        private readonly MongoDatabaseContext _dbcontext;
        protected readonly IMongoCollection<T> _collection;
        public MongoDatabaseConnector(IDatabaseContext dbcontext)
        {
            _dbcontext = (MongoDatabaseContext)dbcontext;
            _collectionName = Utility.GetEntityName<T>();
            _collection = _dbcontext.MongoDatabase.GetCollection<T>(_collectionName);

        }
        public IEnumerable<T> GetAllor()
        {
            var entities = _collection.AsQueryable<T>();
            return entities;
        }
    }
}
