using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RoughCut.Web.Pages
{
    public class ArticleModel : PageModel
    {
        public string Title { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";

        public string ImageUrl { get; set; } = "/assets/img/post-sample-image.jpg";

        public void OnGet()
        {
        }
    }
}
