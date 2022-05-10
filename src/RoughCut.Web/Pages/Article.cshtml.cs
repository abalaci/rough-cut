using Microsoft.AspNetCore.Mvc.RazorPages;
using RoughCut.Web.Models;
using RoughCut.Web.Repositories;
using RoughCut.Web.Repositories.Abstractions;

namespace RoughCut.Web.Pages
{
    public class ArticleModel : PageModel
    {
        private readonly IArticlesRepository _articlesRepository;

        public string Body { get; set; } = string.Empty;

        public string Title { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";

        public Uri ImageUrl { get; set; } = new Uri("/assets/img/post-sample-image.jpg", UriKind.Relative);

        public Author Author { get; set; } = new Author { Name = "John Doe" };

        public DateTimeOffset Created { get; set; } = new DateTime(year: 2022, month: 05, day: 03);

        public DateOnly CreatedDate => DateOnly.FromDateTime(Created.Date);

        public ArticleModel(IArticlesRepository articlesRepository)
        {
            _articlesRepository = articlesRepository;
        }

        public void OnGet()
        {
            var result = _articlesRepository.GetByAlias("lorem-ipsum-dolor-sit-amet");

            if (result.Status == QueryResultStatus.NotFound)
            {
                // TODO: Return "Not Found" page.
            }

            Article? article = result.Entity;
            if (article is not null)
            {
                Author = article.Author;
                Body = article.Body;
                Created = article.Created;
                ImageUrl = article.ImageUrl;
                Title = article.Title;
            }
        }
    }
}
