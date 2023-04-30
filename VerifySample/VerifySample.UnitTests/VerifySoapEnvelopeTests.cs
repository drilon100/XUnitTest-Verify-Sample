namespace VerifySample.UnitTests
{
    [UsesVerify]
    public class VerifySoapEnvelopeTests
    {
        [Fact(DisplayName = "Should get SOAP envelope")]
        public async Task ShouldGetSoapEnvelope()
        {
            var example = new SoapEnvelopeExample();
            var envelope = example.GetSoapEnvelope();

            await VerifyXml(envelope);
        }
    }
}
