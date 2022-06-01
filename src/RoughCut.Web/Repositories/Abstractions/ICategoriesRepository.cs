using RoughCut.Web.Models;

namespace RoughCut.Web.Repositories.Abstractions
{
    public interface ICategoriesRepository
    {
        Task<Category?> GetByAliasAsync(string alias);

        Task<IReadOnlyList<Category>> GetAllAsync();
    }
}
