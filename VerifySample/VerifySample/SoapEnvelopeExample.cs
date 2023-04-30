using System.Text;

namespace VerifySample
{
    public class SoapEnvelopeExample
    {
        public string GetSoapEnvelope()
        {
            var builder = new StringBuilder();

            CreateEnvelope(builder);

            return builder.ToString();
        }

        private void BuildSoapBody(StringBuilder builder)
        {
            builder.Append("<SOAP-ENV:Body xmlns:m =\"http://www.xyz.org/quotations\">")
               .Append("<m:GetQuotation>")
               .Append("<m:QuotationsName>MiscroSoft</m:QuotationsName>")
               .Append("</m:GetQuotation>")
               .Append("</SOAP-ENV:Body>");
        }

        private void CreateEnvelope(StringBuilder builder)
        {
            builder.Append(@"<SOAP-ENV:Envelope xmlns:SOAP-ENV = ""http://www.w3.org/2001/12/soap-envelope"" SOAP-ENV:encodingStyle = ""http://www.w3.org/2001/12/soap-encoding"">");
            BuildSoapBody(builder);
            builder.Append("</SOAP-ENV:Envelope>");
        }
    }
}
