using Data.SchoolSystem.Schools;
using Data.SchoolSystem.Students;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }

        public DbSet<StudentData> Students { get; set; }
        public DbSet<SchoolData> Schools { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            InitializeTables(builder);
        }

        public static void InitializeTables(ModelBuilder builder)
        {
            if (builder is null) return;
            builder.Entity<StudentData>().ToTable(nameof(Students));
            builder.Entity<SchoolData>().ToTable(nameof(Schools));
        }
    }
}
