using Microsoft.Extensions.DependencyInjection.Extensions;
using RoughCut.Web.Repositories.Abstractions;

namespace RoughCut.Web.Repositories
{
    internal static class ServicesExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.TryAddScoped<IArticlesRepository, InMemoryArticlesRepository>();
            services.TryAddScoped<IAuthorsRepository, InMemoryAuthorsRepository>();
            services.TryAddScoped<ICategoriesRepository, InMemoryCategoriesRepository>();

            return services;
        }
    }
}
