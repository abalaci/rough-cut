using RoughCut.Web.Models;
using RoughCut.Web.Repositories.Abstractions;

namespace RoughCut.Web.Repositories
{
    internal class InMemoryCategoriesRepository : ICategoriesRepository
    {
        private static readonly IReadOnlyDictionary<string, Category> _categoriesByAlias =
            new Dictionary<string, Category>
            {
                ["interviu"] = new Category
                {
                    Alias = "interviu",
                    Name = "Interviu"
                },
                ["cronica"] = new Category
                {
                    Alias = "cronica",
                    Name = "Cronică"
                },
                ["flashback"] = new Category
                {
                    Alias = "flashback",
                    Name = "Flashback"
                },
                ["carte-de-film"] = new Category
                {
                    Alias = "carte-de-film",
                    Name = "Carte de Film"
                },
                ["seriale"] = new Category
                {
                    Alias = "seriale",
                    Name = "Seriale"
                },
                ["divertisment"] = new Category
                {
                    Alias = "divertisment",
                    Name = "Divertisment"
                },
                ["videoclipuri"] = new Category
                {
                    Alias = "videoclipuri",
                    Name = "Videoclipuri"
                }
            };

        public Task<Category?> GetByAliasAsync(string alias) => Task.FromResult(GetByAlias(alias));

        public Task<IReadOnlyList<Category>> GetAllAsync() =>
            Task.FromResult<IReadOnlyList<Category>>(_categoriesByAlias.Values.ToList());

        private static Category? GetByAlias(string alias)
        {
            if (_categoriesByAlias.ContainsKey(alias))
            {
                return _categoriesByAlias[alias];
            }

            return default;
        }
    }
}
