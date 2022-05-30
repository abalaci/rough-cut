using OrchardCore.ContentManagement;

namespace RoughCut.Web.Models.ContentParts
{
    internal static class ServicesExtensions
    {
        public static IServiceCollection AddContentParts(this IServiceCollection services)
        {
            services.AddContentPart<ContentAuthor>();

            return services;
        }
    }
}
