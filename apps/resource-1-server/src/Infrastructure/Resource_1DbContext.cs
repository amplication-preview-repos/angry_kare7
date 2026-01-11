using Microsoft.EntityFrameworkCore;
using Resource_1.Infrastructure.Models;

namespace Resource_1.Infrastructure;

public class Resource_1DbContext : DbContext
{
    public Resource_1DbContext(DbContextOptions<Resource_1DbContext> options)
        : base(options) { }

    public DbSet<UserDbModel> Users { get; set; }
}
