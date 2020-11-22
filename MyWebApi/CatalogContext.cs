using Microsoft.EntityFrameworkCore;
using System;

namespace MyWebApi
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

    }

    public class User {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
