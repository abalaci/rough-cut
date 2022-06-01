using OrchardCore;
using OrchardCore.ContentManagement;
using RoughCut.Web.Models;
using RoughCut.Web.Repositories.Abstractions;

namespace RoughCut.Web.Repositories
{
    internal class CmsAuthorsRepository : IAuthorsRepository
    {
        private readonly IOrchardHelper _orchard;

        public CmsAuthorsRepository(IOrchardHelper orchardHelper)
        {
            _orchard = orchardHelper;
        }

        public async Task<IReadOnlyList<Author>> GetAllAsync()
        {
            var contentItems = await _orchard.QueryContentItemsAsync(query =>
                query.Where(item => item.ContentType == "ContentAuthor" && item.Published));

            return contentItems.Select(item => item.ToAuthor(_orchard))
                .OrderBy(a => a.Title)
                .ToList();
        }

        public async Task<Author?> GetByAliasAsync(string alias)
        {
            ContentItem? contentItem = await _orchard.GetContentItemByAliasAsync(alias);

            if (contentItem is null || contentItem.ContentType != "ContentAuthor")
            {
                return default;
            }

            return contentItem.ToAuthor(_orchard);
        }
    }
}
