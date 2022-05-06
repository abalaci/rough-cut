using Microsoft.AspNetCore.Mvc.RazorPages;
using RoughCut.Web.Models;

namespace RoughCut.Web.Pages
{
    public class CategoryModel : PageModel
    {
        public string Name { get; set; } = "Interviu";

        public Article[] Articles { get; set; } = new[]
        {
            new Article
            {
                Title = "Et delenit dignissim facilisis tempor voluptua",
                Description = "Ea sea sadipscing amet facilisis justo aliquam labore. Invidunt justo elitr nonumy at sed. Vulputate ut voluptua diam id magna sed lobortis sed ut molestie justo amet est. Diam dolore sanctus stet vel et.",
                ImageUrl = "/assets/img/about-bg.jpg",
                Created = new DateTime(year: 2022, month: 5, day: 2),
            },
            new Article
            {
                Title = "Diam nihil diam sanctus ipsum gubergren sit eos ut exerci.",
                Description = "Justo nam amet dolore takimata lorem minim sit sea eirmod ipsum tempor diam no ipsum. Duis velit dolore diam voluptua at esse nulla facilisis exerci gubergren laoreet dolor dolore ea diam. Dolor ut nonumy eu eos.",
                ImageUrl = "/assets/img/contact-bg.jpg",
                Created = new DateTime(year: 2022, month: 5, day: 1),
            },
            new Article
            {
                Title = "Accusam sanctus iriure duis kasd.",
                Description = "Dolore lorem volutpat et kasd ipsum rebum cum sea et ut magna. No duo sed elitr. Eos et te rebum. Labore lobortis diam sit autem diam tempor eirmod in sed elitr sit gubergren sea ut. Kasd takimata consequat sit clita eu facilisis lorem no et aliquyam clita iriure eirmod amet nulla labore lorem accusam.",
                ImageUrl = "/assets/img/post-sample-image.jpg",
                Created = new DateTime(year: 2022, month: 4, day: 29),
            }
        };

        public Article LatestArticle => Articles[0];

        public void OnGet()
        {
        }
    }
}
