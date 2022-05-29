using OrchardCore.Alias.Models;
using OrchardCore.ContentManagement;
using OrchardCore.Title.Models;

namespace RoughCut.Web.Models
{
    internal static class ContentItemExtensions
    {
        public static Category ToCategory(this ContentItem item)
        {
            var aliasPart = item.As<AliasPart>();
            var titlePart = item.As<TitlePart>();

            return new Category(aliasPart.Alias, titlePart.Title);
        }
    }
}
