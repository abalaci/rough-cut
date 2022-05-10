namespace RoughCut.Web.Models
{
    public class Article
    {
        public string Alias { get; set; } = "lorem-ipsum-dolor-sit-amet";

        public string Body { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public Uri ImageUrl { get; set; } = new Uri("/", UriKind.Relative);

        public DateTimeOffset Created { get; set; }

        public DateOnly CreatedDate => DateOnly.FromDateTime(Created.Date);

        public Author Author { get; set; } = new Author { Name = "John Doe" };
    }
}
