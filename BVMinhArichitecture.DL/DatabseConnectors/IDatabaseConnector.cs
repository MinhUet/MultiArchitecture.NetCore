using BVMinhArichitecture.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BVMinhArichitecture.DL.DatabseConnectors
{
    public interface IDatabaseConnector<T> where T : BaseEntity
    {
        IEnumerable<T> GetAllor();
    }
}
