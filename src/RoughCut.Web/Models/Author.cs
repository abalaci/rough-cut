namespace RoughCut.Web.Models
{
    public class Author
    {
        public string Alias { get; init; } = string.Empty;

        public string Description { get; init; } = string.Empty;

        public Uri? ImageUrl { get; init; }

        public string Title { get; init; } = string.Empty;
    }
}
