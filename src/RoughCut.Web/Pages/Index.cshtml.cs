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
            ImageUrl = "/assets/img/home-bg.jpg",
            Created = new DateTime(year: 2022, month: 5, day: 3),
        },
        new Article
        {
            Title = "Et delenit dignissim facilisis tempor voluptua",
            Description = "Ea sea sadipscing amet facilisis justo aliquam labore. Invidunt justo elitr nonumy at sed. Vulputate ut voluptua diam id magna sed lobortis sed ut molestie justo amet est. Diam dolore sanctus stet vel et. Augue ut sed sadipscing at dolore justo rebum lorem amet est ut imperdiet ullamcorper diam dolore et blandit dolores.",
            ImageUrl = "/assets/img/about-bg.jpg",
            Created = new DateTime(year: 2022, month: 5, day: 2),
        },
        new Article
        {
            Title = "Diam nihil diam sanctus ipsum gubergren sit eos ut exerci.",
            Description = "Justo nam amet dolore takimata lorem minim sit sea eirmod ipsum tempor diam no ipsum. Duis velit dolore diam voluptua at esse nulla facilisis exerci gubergren laoreet dolor dolore ea diam. Dolor ut nonumy eu eos. Dolore duis volutpat illum. Sea no sit duo sit voluptua et dignissim. Et eos sed labore.",
            ImageUrl = "/assets/img/contact-bg.jpg",
            Created = new DateTime(year: 2022, month: 5, day: 1),
        },
        new Article
        {
            Title = "Est erat enim diam labore diam ipsum aliquyam dignissim",
            Description = "Diam lorem rebum dolor consetetur eos sea tempor amet dolor erat dolore iusto sanctus liber duis et laoreet. Rebum accumsan in dolor vero suscipit vel justo dolor. Et sit duo in duo justo vero. Clita at ipsum feugiat eos gubergren et dolor. Facer duo justo et diam amet justo kasd magna nam eirmod.",
            ImageUrl = "/assets/img/post-bg.jpg",
            Created = new DateTime(year: 2022, month: 5, day: 1),
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
