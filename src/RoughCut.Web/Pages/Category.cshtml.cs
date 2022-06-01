using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoughCut.Web.Models;
using RoughCut.Web.Repositories.Abstractions;

namespace RoughCut.Web.Pages
{
    public class CategoryPageModel : PageModel
    {
        private readonly IArticlesRepository _articlesRepository;

        private readonly ICategoriesRepository _categoriesRepository;

        public string Alias { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public Article[] Articles { get; set; } = Array.Empty<Article>();

        public Article LatestArticle => Articles[0];

        public CategoryPageModel(IArticlesRepository articlesRepository, ICategoriesRepository categoriesRepository)
        {
            _articlesRepository = articlesRepository;
            _categoriesRepository = categoriesRepository;
        }

        public async Task<IActionResult> OnGet(string alias)
        {
            Category? category = await _categoriesRepository.GetByAliasAsync(alias);

            if (category is null)
            {
                return NotFound();
            }

            Alias = category.Alias;
            Name = category.Name;

            Articles = await _articlesRepository.GetByCategoryAsync(category.Alias);

            return Page();
        }
    }
}
