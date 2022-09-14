using DSWebAPI.Models.Entities;

namespace DSWebAPI.Services;

public interface IVideoGameRepository
{
    ICollection<VideoGame> ReadAll();
}
