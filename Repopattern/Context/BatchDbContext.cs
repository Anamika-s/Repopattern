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
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("StudentDetails");

            modelBuilder.Entity<Student>().
                HasKey(x => x.Rn);
            modelBuilder.Entity<Student>()
                   .Property(p => p.Name)
                   .HasColumnName("StudentName")
                   .HasColumnOrder(3)
                   .HasColumnType("varchar");
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"server=ANAMIKA\SQLSERVER;database=BatchDb;integrated security=true;TrustServerCertificate=true");
        //}
    }
}
