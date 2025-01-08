using Repopattern.Models;
using Microsoft.EntityFrameworkCore;

namespace Repopattern.Context
{
    public class BatchDbContext : DbContext
    {
        public BatchDbContext()
        {
            
        }
        public BatchDbContext(DbContextOptions<BatchDbContext> options) : base(options) { }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Student> Students { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"server=ANAMIKA\SQLSERVER;database=BatchDb;integrated security=true;TrustServerCertificate=true");
        //}
    }
}
