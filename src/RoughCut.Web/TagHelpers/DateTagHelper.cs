using System.Globalization;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace RoughCut.Web.TagHelpers
{
    public class DateTagHelper : TagHelper
    {
        private static readonly IFormatProvider _formatProvider = new CultureInfo("ro-RO");

        public DateOnly On { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "time";
            output.Attributes.SetAttribute("datetime", On.ToString("yyyy-MM-dd", _formatProvider));
            output.Content.SetContent(On.ToString("d MMMM yyyy", _formatProvider));
        }
    }
}
