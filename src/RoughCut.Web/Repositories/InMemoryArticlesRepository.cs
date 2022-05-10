using RoughCut.Web.Models;
using RoughCut.Web.Repositories.Abstractions;

namespace RoughCut.Web.Repositories
{
    internal class InMemoryArticlesRepository : IArticlesRepository
    {
        private static readonly IReadOnlyDictionary<string, Article> _articles =
            new Dictionary<string, Article>(StringComparer.OrdinalIgnoreCase)
            {
                ["lorem-ipsum-dolor-sit-amet"] = new Article
                {
                    Alias = "lorem-ipsum-dolor-sit-amet",
                    Author = new Author { Name = "John Doe" },
                    Body = @"<p>Zzril augue vel et. Sit elitr sed quod sed ea et diam clita accumsan at dolore lorem. At invidunt rebum enim gubergren molestie. Vel qui no iusto. Erat elitr vel sanctus gubergren at magna facilisis accusam kasd dignissim. Nonumy autem amet lorem invidunt aliquyam sed eos eos amet enim magna et sit eros amet et wisi aliquam. Et suscipit invidunt rebum nulla liber dolore qui labore est gubergren elitr ad magna. Erat labore lorem sit ut.</p>
                    <p>Iusto clita minim aliquyam nulla eu erat vel consequat eum lorem dolore et nibh lorem justo justo dolor. Labore diam feugiat ipsum sadipscing eu et ipsum duo velit dolor magna suscipit sanctus duis eirmod diam vero aliquyam. Dolor labore stet invidunt. Eirmod nulla takimata et vel magna aliquyam nonumy nonumy aliquip no. Sea et erat amet dolor diam magna illum rebum dolores feugiat possim dolor sed lorem dolore duis. Amet kasd elitr nulla est ipsum invidunt eum dignissim sea accusam. Luptatum justo est consetetur duo amet et consequat sit sanctus ad est. Dolor lorem consequat sed ex magna vero voluptua sadipscing consequat. Dolor ex blandit sed magna eirmod dolor lorem feugait dolore sit facilisis. Dolor dolore lorem takimata et enim. Iriure accusam dolor. Ipsum erat enim dolor consetetur et vel vero lobortis takimata sed consequat et ut. Clita labore at aliquyam no ipsum placerat dolor option sea et luptatum dolore sed nisl erat.</p>
                    <p>Ea et vel diam diam nihil consetetur invidunt duis justo. Vero gubergren dolore ipsum dolore ipsum at justo sed nonumy magna eu. Duo sadipscing kasd lorem nonumy nonumy sit ut. Labore magna magna et sanctus consetetur sit tempor. Gubergren esse no tempor lorem amet ipsum sed vel sed duo consetetur quis tempor sit et eirmod dolor. Sed sit gubergren duo in eu voluptua sit et illum. Illum sed accusam dolores et facilisi sed at sed gubergren. Clita ut et dolores lorem nonumy consetetur ut est. Feugiat no hendrerit at sadipscing justo enim. Eos amet sadipscing ea sit clita autem nonumy. Et diam no sit duo.</p>
                    <p>Qui lorem lorem consequat et sadipscing eirmod ipsum elitr. Liber in ea sadipscing. Ipsum sanctus hendrerit tempor lorem elit amet odio invidunt vero labore consequat feugait takimata nihil lorem et.</p>",
                    Created = new DateTime(year: 2022, month: 5, day: 11),
                    ImageUrl = new Uri("/assets/img/post-sample-image.jpg", UriKind.Relative),
                    Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                }
            };

        public QueryResult<Article> GetByAlias(string alias)
        {
            if (!_articles.ContainsKey(alias))
            {
                return QueryResult<Article>.NotFound;
            }

            return new QueryResult<Article>(_articles[alias]);
        }
    }
}