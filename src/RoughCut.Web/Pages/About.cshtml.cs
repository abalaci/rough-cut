using Microsoft.AspNetCore.Mvc.RazorPages;
using RoughCut.Web.Models;
using RoughCut.Web.Repositories.Abstractions;

namespace RoughCut.Web.Pages
{
    public class AboutModel : PageModel
    {
        private readonly IAuthorsRepository _authorsRepository;

        public IReadOnlyList<Author> Authors { get; set; } = Array.Empty<Author>();

        public AboutModel(IAuthorsRepository authorsRepository)
        {
            _authorsRepository = authorsRepository;
        }

        public async Task OnGet()
        {
            Authors = await _authorsRepository.GetAllAsync();
        }
    }
}
