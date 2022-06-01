using RoughCut.Web.Models;

namespace RoughCut.Web.Repositories.Abstractions
{
    public interface IAuthorsRepository
    {
        Task<IReadOnlyList<Author>> GetAllAsync();

        Task<Author?> GetByAliasAsync(string alias);
    }
}
