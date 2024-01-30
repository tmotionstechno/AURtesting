using Microsoft.EntityFrameworkCore;
using AURScheduler.Core.Domains;
namespace AURScheduler.DBContext
{
    public class AURDbContext : DbContext
    {
        public AURDbContext(DbContextOptions<AURDbContext> options) : base(options)
        {
        }
        public DbSet<Schedule> ScheduleTask { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("DefaultConnection");
        //}

    }
}
