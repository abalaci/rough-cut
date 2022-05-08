using Microsoft.AspNetCore.Mvc.RazorPages;
using RoughCut.Web.Models;

namespace RoughCut.Web.Pages
{
    public class ArticleModel : PageModel
    {
        public string Title { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";

        public string ImageUrl { get; set; } = "/assets/img/post-sample-image.jpg";

        public Author Author { get; set; } = new Author { Name = "John Doe" };

        public DateTimeOffset Created { get; set; } = new DateTime(year: 2022, month: 05, day: 03);

        public DateOnly CreatedDate => DateOnly.FromDateTime(Created.Date);

        public void OnGet()
        {
        }
    }
}
