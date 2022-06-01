using OrchardCore;
using OrchardCore.ContentManagement;
using RoughCut.Web.Models;
using RoughCut.Web.Models.ContentParts;
using RoughCut.Web.Repositories.Abstractions;

namespace RoughCut.Web.Repositories
{
    internal class CmsArticlesRepository : IArticlesRepository
    {
        private readonly IOrchardHelper _orchard;

        public CmsArticlesRepository(IOrchardHelper orchardHelper)
        {
            _orchard = orchardHelper;
        }

        public async Task<Article[]> GetAllAsync()
        {
            var contentItems = await _orchard.QueryContentItemsAsync(query =>
                query.Where(item => item.ContentType == "Article" && item.Published == true)
                    .OrderByDescending(item => item.PublishedUtc));

            return contentItems.Select(async item => await item.ToArticleAsync(_orchard))
                .Select(t => t.Result).ToArray();
        }

        public async Task<Article?> GetByAliasAsync(string alias)
        {
            ContentItem? contentItem = await _orchard.GetContentItemByAliasAsync(alias);

            if (contentItem?.ContentType != "Article")
            {
                return default;
            }

            return await contentItem.ToArticleAsync(_orchard);
        }

        public async Task<Article[]> GetByAuthorAsync(string authorId)
        {
            ContentItem? authorItem = await _orchard.GetContentItemByAliasAsync(authorId);

            if (authorItem?.ContentType != "ContentAuthor")
            {
                return Array.Empty<Article>();
            }

            var contentItems = await _orchard.QueryContentItemsAsync(query =>
                query.Where(item => item.ContentType == "Article" && item.Published == true)
                    .OrderByDescending(item => item.PublishedUtc));

            return contentItems.Where(c => c.As<ArticlePart>()?.Author?.ContentItemIds?.Contains(authorItem.ContentItemId) ?? false)
                .Select(async item => await item.ToArticleAsync(_orchard))
                .Select(t => t.Result).ToArray();
        }

        public async Task<Article[]> GetByCategoryAsync(string categoryAlias)
        {
            var articles = await GetAllAsync();

            return articles.Where(a => a.Categories.Any(c => c.Alias == categoryAlias)).ToArray();
        }
    }
}
