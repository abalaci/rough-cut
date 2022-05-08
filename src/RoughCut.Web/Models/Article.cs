namespace RoughCut.Web.Models
{
    public class Article
    {
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public DateTimeOffset Created { get; set; }

        public DateOnly CreatedDate => DateOnly.FromDateTime(Created.Date);

        public Author Author { get; set; } = new Author { Name = "John Doe" };
    }
}
