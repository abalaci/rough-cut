using OrchardCore;
using OrchardCore.Alias.Models;
using OrchardCore.ContentManagement;
using OrchardCore.Html.Models;
using OrchardCore.Title.Models;
using RoughCut.Web.Models.ContentParts;

namespace RoughCut.Web.Models
{
    internal static class ContentItemExtensions
    {
        public static Article ToArticle(this ContentItem contentItem)
        {
            var aliasPart = contentItem.As<AliasPart>();
            var bodyPart = contentItem.As<HtmlBodyPart>();
            var titlePart = contentItem.As<TitlePart>();

            return new Article
            {
                Alias = aliasPart.Alias,
                Body = bodyPart.Html,
                Created = new DateTimeOffset(contentItem.CreatedUtc ?? default),
                Title = titlePart.Title
            };
        }

        public static Author ToAuthor(this ContentItem contentItem, IOrchardHelper orchard)
        {
            var aliasPart = contentItem.As<AliasPart>();
            var authorPart = contentItem.As<ContentAuthor>();
            var titlePart = contentItem.As<TitlePart>();
            string imagePath = authorPart.Image?.Paths.FirstOrDefault() ?? string.Empty;

            return new Author
            {
                Alias = aliasPart.Alias,
                Description = authorPart.Description?.Html ?? string.Empty,
                ImageUrl = new Uri(orchard.AssetUrl(imagePath), UriKind.Relative),
                Title = titlePart.Title
            };
        }

        public static Category ToCategory(this ContentItem contentItem)
        {
            var aliasPart = contentItem.As<AliasPart>();
            var titlePart = contentItem.As<TitlePart>();

            return new Category(aliasPart.Alias, titlePart.Title);
        }
    }
}
