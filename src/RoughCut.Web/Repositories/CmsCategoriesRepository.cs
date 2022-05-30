using OrchardCore;
using OrchardCore.ContentManagement;
using OrchardCore.Taxonomies.Models;
using RoughCut.Web.Models;
using RoughCut.Web.Repositories.Abstractions;

namespace RoughCut.Web.Repositories
{
    internal class CmsCategoriesRepository : ICategoriesRepository
    {
        private readonly IOrchardHelper _orchard;

        public CmsCategoriesRepository(IOrchardHelper orchardHelper)
        {
            _orchard = orchardHelper;
        }

        public async Task<IReadOnlyList<Category>> GetAllAsync()
        {
            ContentItem categoriesContentItem = await _orchard.GetContentItemByIdAsync("4dsg59gyd54zp2ntr7b32bsm4x");
            var taxonomyPart = categoriesContentItem.As<TaxonomyPart>();

            return taxonomyPart.Terms.Select(t => t.ToCategory()).ToList();
        }

        public async Task<Category?> GetByAliasAsync(string alias)
        {
            // TODO: Implement a more efficient way of getting a category term by its alias.
            IReadOnlyList<Category> categories = await GetAllAsync();

            return categories.FirstOrDefault(c => string.Equals(c.Alias, alias, StringComparison.OrdinalIgnoreCase));
        }
    }
}
