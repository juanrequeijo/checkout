using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Models
{
    public class CheckoutContext : DbContext
    {
        public CheckoutContext(DbContextOptions<CheckoutContext> options)
            : base(options)
        {
        }

        public DbSet<CheckoutItem> CheckoutItems { get; set; }
    }
}