using Microsoft.AspNetCore.Mvc.RazorPages;
using RoughCut.Web.Models;
using RoughCut.Web.Repositories.Abstractions;

namespace RoughCut.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IArticlesRepository _articlesRepository;

        public IndexModel(IArticlesRepository articlesRepository)
        {
            _articlesRepository = articlesRepository;
        }

        public Article[] Articles { get; private set; } = Array.Empty<Article>();

        public Article? LatestArticle { get; private set; }

        public async Task OnGet()
        {
            var articles = await _articlesRepository.GetAllAsync();

            LatestArticle = articles.FirstOrDefault();
            Articles = articles;
        }
    }
}
