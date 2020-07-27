using BVMinhArichitecture.DL.DatabseConnectors;
using BVMinhArichitecture.DL.Repositories;
using BVMinhArichitecture.Entities.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BVMinhArichitecture.BL.APIs
{
    public class StudentController : BaseController
    {
        private readonly IRepository<Student> _repository;
        public StudentController(IRepository<Student> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return _repository.GetAllRepo();
        }


    }
}
