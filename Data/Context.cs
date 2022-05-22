using Microsoft.EntityFrameworkCore;
using Sahibinden.Entities;

namespace Sahibinden.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Model> Models { get; set; }
    }
}
