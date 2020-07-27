using BVMinhArichitecture.DL.DatabseConnectors;
using BVMinhArichitecture.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BVMinhArichitecture.DL.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly IDatabaseConnector<T> _databaseConnector;
        
        public BaseRepository(IDatabaseConnector<T> databaseConnector)
        {
            _databaseConnector = databaseConnector;
        }

        public IEnumerable<T> GetAllRepo()
        {
            return _databaseConnector.GetAllor();
        }
    }
}
