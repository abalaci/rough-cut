using OrchardCore;
using OrchardCore.ContentManagement;
using RoughCut.Web.Models;
using RoughCut.Web.Repositories.Abstractions;

namespace RoughCut.Web.Repositories
{
    internal class CmsArticlesRepository : IArticlesRepository
    {
        private readonly InMemoryArticlesRepository _inMemoryArticlesRepository;

        private readonly IOrchardHelper _orchard;

        public CmsArticlesRepository(IOrchardHelper orchardHelper)
        {
            _inMemoryArticlesRepository = new InMemoryArticlesRepository();
            _orchard = orchardHelper;
        }

        public Task<Article[]> GetAllAsync()
        {
            return _inMemoryArticlesRepository.GetAllAsync();
        }

        public async Task<Article?> GetByAliasAsync(string alias)
        {
            ContentItem? contentItem = await _orchard.GetContentItemByAliasAsync(alias);

            if (contentItem?.ContentType != "Article")
            {
                return default;
            }

            return contentItem.ToArticle();
        }

        public Task<Article[]> GetByAuthorAsync(string authorId)
        {
            return _inMemoryArticlesRepository.GetByAuthorAsync(authorId);
        }
    }
}
