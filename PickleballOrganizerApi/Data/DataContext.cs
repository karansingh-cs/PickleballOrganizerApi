using Microsoft.EntityFrameworkCore;
using PickleballOrganizerApi.Models;

namespace PickleballOrganizerApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Tournament> Tournaments { get; set; }
    }
}
