using Microsoft.EntityFrameworkCore;
using Students.Entities;
using System.Configuration;

namespace Students.Context
{
    public class StudentsContext : DbContext
    {
        public StudentsContext(DbContextOptions<StudentsContext> options)
            : base(options)
        {
        }

        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Studentt> Studentts { get; set; }
        public DbSet<StudenttLecture> StudenttLectures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudenttLecture>()
                .HasKey(sl => new { sl.LectureId, sl.StudenttId });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["StudentsDatabase"].ConnectionString;
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
