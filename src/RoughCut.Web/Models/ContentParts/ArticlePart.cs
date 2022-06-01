using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using OrchardCore.Media.Fields;

namespace RoughCut.Web.Models.ContentParts
{
    public class ArticlePart : ContentPart
    {
        public ContentPickerField? Author { get; set; }

        public HtmlField? Body { get; set; }

        public TextField? Subtitle { get; set; }

        public MediaField? Image { get; set; }
    }
}
