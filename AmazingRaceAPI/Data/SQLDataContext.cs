using AmazingRaceAPI.Entitites;
using Microsoft.EntityFrameworkCore;

namespace AmazingRaceAPI.Data
{
    public class SQLDataContext : DbContext
    {
        public SQLDataContext(DbContextOptions<SQLDataContext> options) : base(options)
        {
        }

        public DbSet<Enterprise> Enterprises { get; set; }
            

    }
}
