using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Models
{
    public class SearchContext : DbContext
    {
        public SearchContext(DbContextOptions<SearchContext> options)
            : base(options)
        {
        }

        public DbSet<SearchItem> SearchItems { get; set; }
    }
}