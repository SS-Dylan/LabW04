using DSWebAPI.Models.Entities;

namespace DSWebAPI.Services;

public interface IVideoGameRepository
{
    ICollection<VideoGame> ReadAll();
    VideoGame? Read(int id);
    VideoGame Create (VideoGame game);
    void Update (int oldId, VideoGame updatedGame);
    void Delete (int id);
}
