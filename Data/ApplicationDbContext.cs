using JAP_Task_1_MoviesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JAP_Task_1_MoviesApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
