using DSWebAPI.Models.Entities;

namespace DSWebAPI.Services;

public class DbVideoGameRepository : IVideoGameRepository
{
    private readonly ApplicationDbContext _db;

    public DbVideoGameRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public ICollection<VideoGame> ReadAll()
    {
        return _db.VideoGames.ToList();
    }
}

