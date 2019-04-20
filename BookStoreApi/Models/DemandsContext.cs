using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Models
{
    public class DemandsContext : DbContext
    {
        public DemandsContext(DbContextOptions<DemandsContext> options)
            : base(options)
        {
        }

        public DbSet<DemandsItem> DemandsItems { get; set; }
    }
}