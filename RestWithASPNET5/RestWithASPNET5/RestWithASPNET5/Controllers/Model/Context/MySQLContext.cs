using Microsoft.EntityFrameworkCore;

namespace RestWithASPNET5.Controllers.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<Person> People { get; set; }
    }
}
