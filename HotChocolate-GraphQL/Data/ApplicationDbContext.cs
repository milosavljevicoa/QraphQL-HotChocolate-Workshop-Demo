using Microsoft.EntityFrameworkCore;
using HotChocolate_GraphQL.Entities;

namespace HotChocolate_GraphQL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Speaker> Speakers { get; set; }
    }
}

