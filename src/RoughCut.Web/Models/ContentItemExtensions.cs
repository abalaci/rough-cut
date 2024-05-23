using OrchardCore;
using OrchardCore.Alias.Models;
using OrchardCore.ContentManagement;
using OrchardCore.Title.Models;
using RoughCut.Web.Models.ContentParts;

namespace RoughCut.Web.Models
{
    internal static class ContentItemExtensions
    {
        public static async Task<Article> ToArticleAsync(this ContentItem contentItem, IOrchardHelper orchard)
        {
            AliasPart? aliasPart = contentItem.As<AliasPart>();
            ArticlePart? articlePart = contentItem.As<ArticlePart>();
            TitlePart? titlePart = contentItem.As<TitlePart>();

            string imagePath = articlePart.Image?.Paths?.FirstOrDefault() ?? string.Empty;

            string authorItemId = articlePart?.Author?.ContentItemIds?.FirstOrDefault() ?? string.Empty;
            ContentItem? authorItem = await orchard.GetContentItemByIdAsync(authorItemId);

            var termItemIds = articlePart?.Categories?.TermContentItemIds ?? Enumerable.Empty<string>();
            var termItems = termItemIds.Select(async t =>
                await orchard.GetTaxonomyTermAsync(articlePart?.Categories?.TaxonomyContentItemId, t))
                .Select(t => t.Result);

            return new Article
            {
                Alias = aliasPart?.Alias ?? string.Empty,
                Author = authorItem?.ToAuthor(orchard) ?? new Author(),
                Body = articlePart?.Body?.Html ?? string.Empty,
                Categories = termItems.Select(t => t.ToCategory()).ToList(),
                Description = articlePart?.Subtitle?.Text ?? string.Empty,
                PublishedUtc = new DateTimeOffset(contentItem.PublishedUtc ?? default),
                ImageUrl = new Uri(orchard.AssetUrl(imagePath), UriKind.Relative),
                Title = titlePart?.Title ?? string.Empty
            };
        }

        public static Author ToAuthor(this ContentItem contentItem, IOrchardHelper orchard)
        {
            var aliasPart = contentItem.As<AliasPart>();
            var authorPart = contentItem.As<ContentAuthorPart>();
            var titlePart = contentItem.As<TitlePart>();

            string imagePath = authorPart.Image?.Paths?.FirstOrDefault() ?? string.Empty;
            Uri? imageUrl = string.IsNullOrEmpty(imagePath)
                ? default
                : new Uri(orchard.AssetUrl(imagePath), UriKind.Relative);

            return new Author
            {
                Alias = aliasPart.Alias,
                Description = authorPart.Description?.Html ?? string.Empty,
                ImageUrl = imageUrl,
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
