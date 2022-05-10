using RoughCut.Web.Models;

namespace RoughCut.Web.Repositories.Abstractions
{
    public interface IArticlesRepository
    {
        QueryResult<Article> GetByAlias(string alias);
    }
}
