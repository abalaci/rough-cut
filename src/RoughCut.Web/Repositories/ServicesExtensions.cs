using Microsoft.Extensions.DependencyInjection.Extensions;
using RoughCut.Web.Repositories.Abstractions;

namespace RoughCut.Web.Repositories
{
    internal static class ServicesExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.TryAddScoped<IArticlesRepository, CmsArticlesRepository>();
            services.TryAddScoped<IAuthorsRepository, CmsAuthorsRepository>();
            services.TryAddScoped<ICategoriesRepository, CmsCategoriesRepository>();

            return services;
        }
    }
}
