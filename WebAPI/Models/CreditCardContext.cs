
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class CreditCardContext : DbContext
    {
        public CreditCardContext(DbContextOptions<CreditCardContext> options)
            : base(options)
        {
        }

        public DbSet<CreditCardItem> CreditCardItem { get; set; }
    }
}