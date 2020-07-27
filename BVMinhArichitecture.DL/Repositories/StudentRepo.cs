using BVMinhArichitecture.DL.DatabseConnectors;
using BVMinhArichitecture.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BVMinhArichitecture.DL.Repositories
{
    public class StudentRepo : BaseRepository<Student>
    {
        public StudentRepo(IDatabaseConnector<Student> databaseConnector) : base(databaseConnector)
        {
            
        }
    }
}
