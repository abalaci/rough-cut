namespace RoughCut.Web.Models
{
    public class Article
    {
        public string Alias { get; init; } = "lorem-ipsum-dolor-sit-amet";

        public string Body { get; init; } = string.Empty;

        public IReadOnlyList<Category> Categories { get; init; } = Array.Empty<Category>();

        public string Title { get; init; } = string.Empty;

        public string Description { get; init; } = string.Empty;

        public Uri ImageUrl { get; init; } = new Uri("/", UriKind.Relative);

        public DateTimeOffset Created { get; init; }

        public DateOnly CreatedDate => DateOnly.FromDateTime(Created.Date);

        public Author Author { get; init; } = new Author();
    }
}
