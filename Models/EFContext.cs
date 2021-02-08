using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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
            //modelBuilder.Entity<UserCourse>().HasKey(sc => new { sc.UserId, sc.CourseId });
            //modelBuilder.Entity<UserProgram>().HasKey(sc => new { sc.UserId, sc.ProgramId });
            //modelBuilder.Entity<UserGroup>().HasKey(sc => new { sc.UserId, sc.GroupId });
        }

        //Bygg nya tables
        public DbSet<User> User { get; set; }
        public DbSet<Student> Student { get; set; }
/*        public DbSet<UserCourse> UserCourse { get; set; }
        public DbSet<UserGroup> UserGroup { get; set; }*/
        //public DbSet<UserProgram> UserProgram { get; set; }
        public DbSet<ContactInfo> ContactInfo { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseDeviation> CourseDeviations { get; set; }
        public DbSet<LIAWork> LIAWork { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CompRep> CompRep { get; set; }
        public DbSet<Programme> Programmes { get; set; }

        //Skjut ut databas + tables genom Add-Migration i Package Manager Console. Ex. Add-Migration v1

        /*
        Get-Help entityframework - Displays information about entity framework commands.
        Add-Migration<migration name> - Creates a migration by adding a migration snapshot.
        Remove-Migration - Removes the last migration snapshot.
        Update-Database - Updates the database schema based on the last migration snapshot.
        Script-Migration - Generates a SQL script using all the migration snapshots.
        Scaffold-DbContext - Generates a DbContext and entity type classes for a specified database.This is called reverse engineering.
        Get-DbContext - Gets information about a DbContext type.
        Drop-Database - Drops the database.*/
    }
}