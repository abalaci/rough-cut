using Microsoft.AspNetCore.Mvc.RazorPages;
using RoughCut.Web.Models;

namespace RoughCut.Web.Pages;

public class IndexModel : PageModel
{
    private readonly Article[] _articles = new[]
    {
        new Article
        {
            Title = "Dolores no illum magna sanctus et lorem enim te quod accusam duo",
            Description = "Elitr enim consetetur erat eos vel sea sed nonumy elitr lobortis lorem invidunt nisl. Facilisi erat rebum rebum sed est augue et possim nonummy invidunt elitr consequat sed sea accusam nonumy.",
            ImageUrl = new Uri("/assets/img/home-bg.jpg", UriKind.Relative),
            Created = new DateTime(year: 2022, month: 5, day: 3),
        },
        new Article
        {
            Title = "Et delenit dignissim facilisis tempor voluptua",
            Description = "Ea sea sadipscing amet facilisis justo aliquam labore. Invidunt justo elitr nonumy at sed. Vulputate ut voluptua diam id magna sed lobortis sed ut molestie justo amet est. Diam dolore sanctus stet vel et.",
            ImageUrl = new Uri("/assets/img/about-bg.jpg", UriKind.Relative),
            Created = new DateTime(year: 2022, month: 5, day: 2),
        },
        new Article
        {
            Title = "Diam nihil diam sanctus ipsum gubergren sit eos ut exerci.",
            Description = "Justo nam amet dolore takimata lorem minim sit sea eirmod ipsum tempor diam no ipsum. Duis velit dolore diam voluptua at esse nulla facilisis exerci gubergren laoreet dolor dolore ea diam. Dolor ut nonumy eu eos.",
            ImageUrl = new Uri("/assets/img/contact-bg.jpg", UriKind.Relative),
            Created = new DateTime(year: 2022, month: 5, day: 1),
        },
        new Article
        {
            Title = "Est erat enim diam labore diam ipsum aliquyam dignissim",
            Description = "Diam lorem rebum dolor consetetur eos sea tempor amet dolor erat dolore iusto sanctus liber duis et laoreet. Rebum accumsan in dolor vero suscipit vel justo dolor. Et sit duo in duo justo vero.",
            ImageUrl = new Uri("/assets/img/post-bg.jpg", UriKind.Relative),
            Created = new DateTime(year: 2022, month: 5, day: 1),
        },
        new Article
        {
            Title = "Accusam sanctus iriure duis kasd.",
            Description = "Dolore lorem volutpat et kasd ipsum rebum cum sea et ut magna. No duo sed elitr. Eos et te rebum. Labore lobortis diam sit autem diam tempor eirmod in sed elitr sit gubergren sea ut. Kasd takimata consequat sit clita eu facilisis lorem no et aliquyam clita iriure eirmod amet nulla labore lorem accusam.",
            ImageUrl = new Uri("/assets/img/post-sample-image.jpg", UriKind.Relative),
            Created = new DateTime(year: 2022, month: 4, day: 29),
        }
    };

    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public Article[] Articles => _articles;

    public Article LatestArticle => _articles[0];

    public void OnGet()
    {
    }
}
