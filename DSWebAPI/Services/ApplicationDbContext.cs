using DSWebAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DSWebAPI.Services;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<VideoGame> VideoGames => Set<VideoGame>();
}
