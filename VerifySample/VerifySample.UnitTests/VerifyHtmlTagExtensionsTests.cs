using HtmlTags;

namespace VerifySample.UnitTests
{
    [UsesVerify]
    public class VerifyHtmlTagExtensionsTests
    {
        [Fact(DisplayName = "Should add span element")]
        public async Task ShouldAddSpanElement()
        {
            var div = new HtmlTag("div").AddSpan("Sample text");

            await Verifier.Verify(div.ToHtmlString());
        }

        [Fact(DisplayName = "Should add submit button")]
        public async Task ShouldAddSubmitButton()
        {
            var form = new HtmlTag("form").AddSubmitButton();

            await Verifier.Verify(form.ToHtmlString());
        }
    }
}
