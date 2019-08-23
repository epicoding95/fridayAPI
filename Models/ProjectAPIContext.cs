using Microsoft.EntityFrameworkCore;

namespace ProjectAPI.Models
{
    public class ProjectAPIContext : DbContext
    {   

        public DbSet<Park> Parks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"server=localhost;user id=root;password=epicodus;port=3306;database=projectAPI;");

        public ProjectAPIContext(DbContextOptions options) : base(options)
        {

        }
        public ProjectAPIContext()
        {

        }

    }
}