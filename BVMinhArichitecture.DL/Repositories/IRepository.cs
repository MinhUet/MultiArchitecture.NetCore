using BVMinhArichitecture.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BVMinhArichitecture.DL.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAllRepo();
    }
}
