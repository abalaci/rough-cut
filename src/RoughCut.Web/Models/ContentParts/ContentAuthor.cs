using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using OrchardCore.Media.Fields;

namespace RoughCut.Web.Models.ContentParts
{
    public class ContentAuthor : ContentPart
    {
        public HtmlField? Description { get; set; }

        public MediaField? Image { get; set; }
    }
}
