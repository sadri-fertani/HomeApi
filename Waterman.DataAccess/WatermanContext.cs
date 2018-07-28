using Microsoft.EntityFrameworkCore;
using Waterman.DataAccess.POCO;

namespace Waterman.DataAccess
{
    public class WatermanContext : DbContext
    {
        public DbSet<Todo> TodoItems { get; set; }

        public WatermanContext(DbContextOptions<WatermanContext> options) : base(options)
        {
        }
    }
}
