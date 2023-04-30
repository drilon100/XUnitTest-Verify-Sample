using FluentAssertions;

namespace VerifySample.UnitTests
{
    public class HtmlTagExtensionsTests
    {
        [Fact(DisplayName = "Should add span element")]
        public void ShouldAddSpanElement()
        {
            var div = Tags.Div.AddSpan("Sample text");
            var span = div.FirstChild();
            var paragraph = span.FirstChild();

            div.TagName().Should().Be("div");
            span.HasClass("div-span-text").Should().BeTrue();
            paragraph.Text().Should().Be("Sample text");
            paragraph.HasStyle("text-align").Should().BeTrue();
        }

        [Fact(DisplayName = "Should add submit button")]
        public void ShouldAddSubmitButton()
        {
            var form = Tags.Form.AddSubmitButton();
            var button = form.FirstChild();

            form.TagName().Should().Be("form");
            button.Value().Should().Be("Submit");
            button.HasClass("btn").Should().BeTrue();
            button.HasClass("btn-submit").Should().BeTrue();
            button.HasAttr("type").Should().BeTrue();
        }
    }
}
