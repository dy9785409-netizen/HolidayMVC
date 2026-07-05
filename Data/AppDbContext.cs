using HolidayApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HolidayApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Holiday> Holidays { get; set; }
    }
}