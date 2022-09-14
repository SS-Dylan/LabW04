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

    public VideoGame? Read(int id)
    {
        return _db.VideoGames.Find(id);
    }

    public VideoGame Create(VideoGame game)
    {
        _db.VideoGames.Add(game);
        _db.SaveChanges();
        return game;
    }

    public void Update(int oldId, VideoGame updatedGame)
    {
        var gameToUpdate = Read(oldId);
        if(gameToUpdate != null)
        {
            gameToUpdate.Title = updatedGame.Title;
            gameToUpdate.Genre = updatedGame.Genre;
            gameToUpdate.Developer = updatedGame.Developer;
            gameToUpdate.Rating = updatedGame.Rating;
            gameToUpdate.Year = updatedGame.Year;
            _db.SaveChanges();
        }
    }

    public void Delete(int id)
    {
        var gameToDelete = Read(id);
        if(gameToDelete != null)
        {
            _db.VideoGames.Remove(gameToDelete);
            _db.SaveChanges();
        }
    }
}

