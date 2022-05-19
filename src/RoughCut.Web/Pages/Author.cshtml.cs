using Microsoft.AspNetCore.Mvc.RazorPages;
using RoughCut.Web.Models;

namespace RoughCut.Web.Pages
{
    public class AuthorModel : PageModel
    {
        public IReadOnlyList<Article> Articles { get; set; } = new List<Article>();

        public string Description { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";

        public string Id { get; set; } = string.Empty;

        public Uri ImageUrl { get; set; } = new Uri("/", UriKind.Relative);

        public string Name { get; set; } = "Jane Doe";

        public void OnGet()
        {

        }
    }
}
