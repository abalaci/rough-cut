using OrchardCore;
using OrchardCore.ContentManagement;
using RoughCut.Web.Models;
using RoughCut.Web.Repositories.Abstractions;

namespace RoughCut.Web.Repositories
{
    internal class CmsAuthorsRepository : IAuthorsRepository
    {
        private readonly InMemoryAuthorsRepository _inMemoryAuthorsRepository;

        private readonly IOrchardHelper _orchard;

        //private readonly ISession _yesSqlSession;

        public CmsAuthorsRepository(IOrchardHelper orchardHelper/*, ISession yesSqlSession*/)
        {
            _inMemoryAuthorsRepository = new InMemoryAuthorsRepository();
            _orchard = orchardHelper;
            //_yesSqlSession = yesSqlSession;
        }

        public async Task<IReadOnlyList<Author>> GetAllAsync()
        {
            var contentItems = await _orchard.GetRecentContentItemsByContentTypeAsync("ContentAuthor", maxContentItems: 30);

            return contentItems.Select(item => item.ToAuthor(_orchard)).ToList();
        }

        public async Task<Author?> GetByAliasAsync(string alias)
        {
            ContentItem contentItem = await _orchard.GetContentItemByAliasAsync(alias);

            if (contentItem is null)
            {
                return default;
            }

            return contentItem.ToAuthor(_orchard);
        }
    }
}
