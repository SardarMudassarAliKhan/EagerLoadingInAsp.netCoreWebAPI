using EagerLoadingInAsp.netCoreWebAPI.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EagerLoadingInAsp.netCoreWebAPI.ApplicationDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
