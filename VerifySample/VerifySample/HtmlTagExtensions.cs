using HtmlTags;

namespace VerifySample
{
    public static class HtmlTagExtensions
    {
        public static HtmlTag AddSpan(this HtmlTag htmlTag, string text)
        {
            var span = new HtmlTag("span").AddClass("div-span-text");
            var paragraph = new HtmlTag("p").Style("text-align", "right").Text(text);
            span.Append(paragraph);

            return htmlTag.Append(span);
        }

        public static HtmlTag AddSubmitButton(this HtmlTag htmlTag)
        {
            var button = new HtmlTag("input").Attr("type", "submit")
                .Value("Submit").AddClasses("btn", "btn-submit");

            return htmlTag.Append(button);
        }
    }

    public static class Tags
    {
        public static HtmlTag Div = new HtmlTag("div");
        public static HtmlTag Form = new HtmlTag("form");
    }
}
