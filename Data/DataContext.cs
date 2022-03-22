using Microsoft.EntityFrameworkCore;
using movieflix_api.Models;

namespace movieflix_api.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Movie> Movies => Set<Movie>();
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}