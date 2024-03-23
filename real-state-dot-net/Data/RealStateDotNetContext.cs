using Microsoft.EntityFrameworkCore;
using RealStateDotNet.Models;

namespace RealStateDotNet.Data
{
    public class RealStateDotNetContext : DbContext
    {
        public RealStateDotNetContext(DbContextOptions<RealStateDotNetContext> options) : base(options) { }

        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }

        public DbSet<Models.Type> Type { get; set; }
    }
}
