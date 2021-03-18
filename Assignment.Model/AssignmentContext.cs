using Microsoft.EntityFrameworkCore;

namespace Assignment.Model
{
    public class AssignmentContext : DbContext
    {
        public AssignmentContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities
        public DbSet<DomainUrl> Domains { get; set; }
        public DbSet<DomainAccessRecord> AccessRecords { get; set; }
    }
}
