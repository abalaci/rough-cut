using RoughCut.Web.Models;
using RoughCut.Web.Repositories.Abstractions;

namespace RoughCut.Web.Repositories
{
    internal class InMemoryAuthorsRepository : IAuthorsRepository
    {
        private static readonly IReadOnlyDictionary<string, Author> _authors =
            new Dictionary<string, Author>(StringComparer.OrdinalIgnoreCase)
            {
                ["mara-crisan"] = new Author
                {
                    Id = "mara-crisan",
                    Name = "Mara Crișan",
                    Description = "Lorem sea amet ut lorem et vero ipsum et ipsum amet iusto. Iusto no diam tempor laoreet nulla no sea iriure sed lorem. Dolore ipsum takimata ut ipsum. Et justo invidunt nulla erat magna nulla esse lobortis sadipscing id assum. Diam no dignissim no clita facilisi dolor cum. Stet et eirmod aliquyam. Kasd lorem autem accusam in accusam."
                },
                ["john-doe"] = new Author
                {
                    Id = "john-doe",
                    Name = "John Doe",
                    Description = "Lorem sea amet ut lorem et vero ipsum et ipsum amet iusto. Iusto no diam tempor laoreet nulla no sea iriure sed lorem. Dolore ipsum takimata ut ipsum. Et justo invidunt nulla erat magna nulla esse lobortis sadipscing id assum. Diam no dignissim no clita facilisi dolor cum. Stet et eirmod aliquyam. Kasd lorem autem accusam in accusam."
                }
            };

        public Task<IReadOnlyList<Author>> GetAllAsync() => Task.FromResult(_authors.Values.ToList() as IReadOnlyList<Author>);

        public Task<Author?> GetByIdAsync(string id) => Task.FromResult(GetById(id));

        private static Author? GetById(string id)
        {
            if (!_authors.ContainsKey(id))
            {
                return default;
            }

            return _authors[id];
        }
    }
}
