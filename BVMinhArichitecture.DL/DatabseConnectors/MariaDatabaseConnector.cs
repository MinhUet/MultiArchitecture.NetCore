using BVMinhArichitecture.DL.DatabaseContexts;
using BVMinhArichitecture.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BVMinhArichitecture.DL.DatabseConnectors
{
    public class MariaDatabaseConnector<T> : IDatabaseConnector<T> where T : BaseEntity
    {
        private readonly MariaDatabaseContext _dbcontext;
        public MariaDatabaseConnector(IDatabaseContext dbcontext)
        {
            _dbcontext = (MariaDatabaseContext)dbcontext;
        }
        public IEnumerable<T> GetAllor()
        {
            return _dbcontext.Set<T>().ToList();
        }
    }
}
