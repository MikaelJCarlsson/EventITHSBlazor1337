using ITHSManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Threading;
using System.Threading.Tasks;

namespace ITHSManagement.Models
{


    public class EFContext : DbContext
    {

        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LIAWork>().HasKey(sc => new { sc.StudentId, sc.CompanyId });
        }

        public DbSet<User> User { get; set; }
        public DbSet<Student> Student { get; set; }

        public DbSet<ContactInfo> ContactInfo { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseDeviation> CourseDeviations { get; set; }
        public DbSet<LIAWork> LIAWork { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CompRep> CompRep { get; set; }
        public DbSet<Programme> Programmes { get; set; }

    }
}