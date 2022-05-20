using RoughCut.Web.Models;

namespace RoughCut.Web.Repositories.Abstractions
{
    public interface IArticlesRepository
    {
        Task<Article?> GetByAliasAsync(string alias);

        Article[] GetByAuthor(string authorId);
    }
}
