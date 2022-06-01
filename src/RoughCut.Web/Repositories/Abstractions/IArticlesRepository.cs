using RoughCut.Web.Models;

namespace RoughCut.Web.Repositories.Abstractions
{
    public interface IArticlesRepository
    {
        Task<Article[]> GetAllAsync();

        Task<Article?> GetByAliasAsync(string alias);

        Task<Article[]> GetByAuthorAsync(string authorId);

        Task<Article[]> GetByCategoryAsync(string categoryAlias);
    }
}
