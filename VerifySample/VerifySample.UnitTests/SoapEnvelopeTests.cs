using FluentAssertions;

namespace VerifySample.UnitTests
{
    public class SoapEnvelopeTests
    {
        [Fact(DisplayName = "Should get SOAP envelope")]
        public void ShouldGetSoapEnvelope()
        {
            var example = new SoapEnvelopeExample();
            var envelope = example.GetSoapEnvelope();

            envelope.Contains("<SOAP-ENV:Envelope").Should().BeTrue();
            envelope.Contains("<SOAP-ENV:Body xmlns:m =\"http://www.xyz.org/quotations\">").Should().BeTrue();
            envelope.Contains("<m:GetQuotation>").Should().BeTrue();
            envelope.Contains("<m:QuotationsName>MiscroSoft</m:QuotationsName>").Should().BeTrue();
            envelope.Contains("</m:GetQuotation>").Should().BeTrue();
            envelope.Contains("</SOAP-ENV:Body>").Should().BeTrue();
            envelope.Contains("</SOAP-ENV:Envelope>").Should().BeTrue();
        }
    }
}
