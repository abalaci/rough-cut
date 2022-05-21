using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoughCut.Web.Models;
using RoughCut.Web.Repositories.Abstractions;

namespace RoughCut.Web.Pages
{
    public class ArticleModel : PageModel
    {
        private readonly IArticlesRepository _articlesRepository;

        public string Body { get; set; } = string.Empty;

        public Category Category { get; set; } = new Category();

        public string Title { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";

        public Uri ImageUrl { get; set; } = new Uri("/assets/img/post-sample-image.jpg", UriKind.Relative);

        public Author Author { get; set; } = new Author { Name = "John Doe" };

        public DateTimeOffset Created { get; set; } = new DateTime(year: 2022, month: 05, day: 03);

        public DateOnly CreatedDate => DateOnly.FromDateTime(Created.Date);

        public ArticleModel(IArticlesRepository articlesRepository)
        {
            _articlesRepository = articlesRepository;
        }

        public async Task<IActionResult> OnGet()
        {
            Article? article = await _articlesRepository.GetByAliasAsync("interviu-luchian-ciobanu");

            if (article is null)
            {
                return NotFound();
            }

            Author = article.Author;
            Body = article.Body;
            Category = article.Category;
            Created = article.Created;
            ImageUrl = article.ImageUrl;
            Title = article.Title;

            return Page();
        }
    }
}
