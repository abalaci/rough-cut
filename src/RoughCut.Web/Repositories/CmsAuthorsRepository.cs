using OrchardCore;
using RoughCut.Web.Models;
using RoughCut.Web.Repositories.Abstractions;

namespace RoughCut.Web.Repositories
{
    internal class CmsAuthorsRepository : IAuthorsRepository
    {
        private readonly InMemoryAuthorsRepository _inMemoryAuthorsRepository;

        private readonly IOrchardHelper _orchard;

        public CmsAuthorsRepository(IOrchardHelper orchardHelper)
        {
            _inMemoryAuthorsRepository = new InMemoryAuthorsRepository();
            _orchard = orchardHelper;
        }

        public Task<IReadOnlyList<Author>> GetAllAsync()
        {
            return _inMemoryAuthorsRepository.GetAllAsync();
        }

        public Task<Author?> GetByIdAsync(string id)
        {
            return _inMemoryAuthorsRepository.GetByIdAsync(id);
        }
    }
}
