using BVMinhArichitecture.Entities.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BVMinhArichitecture.DL.DatabaseContexts
{
    public class MariaDatabaseContext : DbContext, IDatabaseContext
    {
        public MariaDatabaseContext(DbContextOptions<MariaDatabaseContext> options) : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
