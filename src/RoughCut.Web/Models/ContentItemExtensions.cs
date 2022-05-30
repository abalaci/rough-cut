using OrchardCore.Alias.Models;
using OrchardCore.ContentManagement;
using OrchardCore.Html.Models;
using OrchardCore.Title.Models;

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

        public static Author ToAuthor(this ContentItem contentItem)
        {
            var aliasPart = contentItem.As<AliasPart>();
            var titlePart = contentItem.As<TitlePart>();

            return new Author();
        }

        public static Category ToCategory(this ContentItem contentItem)
        {
            var aliasPart = contentItem.As<AliasPart>();
            var titlePart = contentItem.As<TitlePart>();

            return new Category(aliasPart.Alias, titlePart.Title);
        }
    }
}
