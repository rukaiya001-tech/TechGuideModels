using Microsoft.EntityFrameworkCore;

namespace TechGuide.Models
{
    public class TechGuideDbContext : DbContext
    {
        public TechGuideDbContext(DbContextOptions<TechGuideDbContext> options) : base(options)
        {

        }
        public DbSet<Chapters> Chapters { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Types> Types { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<AuditLogs> AuditLogs { get; set; }
        public DbSet<ErrorLogs> ErrorLogs { get; set; }
        public DbSet<Configurations> Configurations { get; set; }
        public DbSet<CoursePrerequisites> CoursePrerequisites { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define the composite key for CoursePrerequisite
            modelBuilder.Entity<CoursePrerequisites>()
                .HasKey(cp => new { cp.CourseID, cp.PrerequisiteID });

            // Configure the foreign keys and cascading delete for CoursePrerequisite
            modelBuilder.Entity<CoursePrerequisites>()
                .HasOne(cp => cp.course)
                .WithMany(c => c.CoursePrerequisites)
                .HasForeignKey(cp => cp.CourseID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CoursePrerequisites>()
                .HasOne(cp => cp.Prerequisite)
                .WithMany()
                .HasForeignKey(cp => cp.PrerequisiteID)
                .OnDelete(DeleteBehavior.NoAction);

            // Configure other relationships
            modelBuilder.Entity<Subjects>()
                .HasOne(s => s.Chapters)
                .WithMany()
                .HasForeignKey(s => s.ChapterID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Subjects)
                .WithMany()
                .HasForeignKey(d => d.SubCode)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Semester>()
                .HasOne(s => s.Department)
                .WithMany()
                .HasForeignKey(s => s.DepID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Semester)
                .WithMany()
                .HasForeignKey(c => c.SemesterID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Types)
                .WithMany()
                .HasForeignKey(c => c.TypeID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
