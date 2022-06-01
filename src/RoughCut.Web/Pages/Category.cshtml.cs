using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoughCut.Web.Models;
using RoughCut.Web.Repositories.Abstractions;

namespace RoughCut.Web.Pages
{
    public class CategoryPageModel : PageModel
    {
        private readonly ICategoriesRepository _categoriesRepository;

        public string Alias { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public Article[] Articles { get; set; } = new[]
        {
            new Article
            {
                Title = "Et delenit dignissim facilisis tempor voluptua",
                Description = "Ea sea sadipscing amet facilisis justo aliquam labore. Invidunt justo elitr nonumy at sed. Vulputate ut voluptua diam id magna sed lobortis sed ut molestie justo amet est. Diam dolore sanctus stet vel et.",
                ImageUrl = new Uri("/assets/img/about-bg.jpg", UriKind.Relative),
                PublishedUtc = new DateTime(year: 2022, month: 5, day: 2),
            },
            new Article
            {
                Title = "Diam nihil diam sanctus ipsum gubergren sit eos ut exerci.",
                Description = "Justo nam amet dolore takimata lorem minim sit sea eirmod ipsum tempor diam no ipsum. Duis velit dolore diam voluptua at esse nulla facilisis exerci gubergren laoreet dolor dolore ea diam. Dolor ut nonumy eu eos.",
                ImageUrl = new Uri("/assets/img/contact-bg.jpg", UriKind.Relative),
                PublishedUtc = new DateTime(year: 2022, month: 5, day: 1),
            },
            new Article
            {
                Title = "Accusam sanctus iriure duis kasd.",
                Description = "Dolore lorem volutpat et kasd ipsum rebum cum sea et ut magna. No duo sed elitr. Eos et te rebum. Labore lobortis diam sit autem diam tempor eirmod in sed elitr sit gubergren sea ut. Kasd takimata consequat sit clita eu facilisis lorem no et aliquyam clita iriure eirmod amet nulla labore lorem accusam.",
                ImageUrl = new Uri("/assets/img/astronaut.jpg", UriKind.Relative),
                PublishedUtc = new DateTime(year: 2022, month: 4, day: 29),
            }
        };

        public Article LatestArticle => Articles[0];

        public CategoryPageModel(ICategoriesRepository categoriesRepository)
        {
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

            return Page();
        }
    }
}
