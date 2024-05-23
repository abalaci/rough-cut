using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoughCut.Web.Models;
using RoughCut.Web.Repositories.Abstractions;

namespace RoughCut.Web.Pages
{
    public class AuthorModel : PageModel
    {
        private readonly IArticlesRepository _articlesRepository;

        private readonly IAuthorsRepository _authorsRepository;

        public IReadOnlyList<Article> Articles { get; set; } = new List<Article>();

        public string Description { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";

        public Uri? ImageUrl { get; set; }

        public string Name { get; set; } = string.Empty;

        public AuthorModel(IArticlesRepository articlesRepository, IAuthorsRepository authorsRepository)
        {
            _articlesRepository = articlesRepository;
            _authorsRepository = authorsRepository;
        }

        public async Task<IActionResult> OnGet(string authorId)
        {
            Author? author = await _authorsRepository.GetByAliasAsync(authorId);

            if (author is null)
            {
                return NotFound();
            }

            Description = author.Description;
            ImageUrl = author.ImageUrl;
            Name = author.Title;

            Articles = await _articlesRepository.GetByAuthorAsync(authorId);

            return Page();
        }
    }
}
