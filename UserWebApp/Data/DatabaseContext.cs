using Microsoft.EntityFrameworkCore;
using ToDtoExtension.Entities;

namespace UserWebApp.Data;

public class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
{
    public DbSet<UserEntity> Users { get; set; }
}
