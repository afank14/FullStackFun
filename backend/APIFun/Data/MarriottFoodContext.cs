using Microsoft.EntityFrameworkCore;

namespace APIFun.Data
{
    public class MarriottFoodContext : DbContext 
    {
        public MarriottFoodContext(DbContextOptions<MarriottFoodContext> options) : base(options) { }

        public DbSet<MarriottFood> Foods { get; set; }
    }
}
