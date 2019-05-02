using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Abstraction.Entity;

namespace Data
{
    public class TestDataContext
    {
        public class SampleContext : DbContext
        {
         //   public SampleContext(DbContextOptions<SampleContext> op) : base(op)            { }
            public DbSet<TestTable> TestTable { get; set; }
            
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                base.OnConfiguring(optionsBuilder);
                optionsBuilder.UseSqlServer("Data Source=172.29.247.38,1433;Initial Catalog=Navigator;user id=sa;password=SQLserver@2012;Connection Timeout=0;");
            }
        }
    }
}
