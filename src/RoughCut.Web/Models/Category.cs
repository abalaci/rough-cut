namespace RoughCut.Web.Models
{
    public class Category
    {
        public string Alias { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public Category() { }

        public Category(string alias, string title)
        {
            Alias = alias;
            Name = title;
        }
    }
}
