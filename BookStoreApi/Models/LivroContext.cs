using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Models
{
    public class LivroContext : DbContext
    {
        public LivroContext(DbContextOptions<LivroContext> options)
            : base(options)
        {
        }

        public DbSet<LivroItem> LivroItems { get; set; }
    }
}