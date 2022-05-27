using RoughCut.Web.Models;

namespace RoughCut.Web.Repositories.Abstractions
{
    public interface IAuthorsRepository
    {
        Task<Author?> GetByIdAsync(string id);

        Task<IReadOnlyList<Author>> GetAllAsync();
    }
}
