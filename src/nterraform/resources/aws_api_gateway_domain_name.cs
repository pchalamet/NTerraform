using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_api_gateway_domain_name")]
    public sealed class aws_api_gateway_domain_name : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "endpoint_configuration")]
        public sealed class endpoint_configuration : nterraform.structure
        {
            public endpoint_configuration(string[] @types)
            {
                @Types = @types;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "types", @out: false, min: 1, max: 1)]
            public string[] @Types { get; }
        }

        public aws_api_gateway_domain_name(string @domainName,
                                           endpoint_configuration[] @endpointConfiguration,
                                           string @certificateArn = null,
                                           string @certificateBody = null,
                                           string @certificateChain = null,
                                           string @certificateName = null,
                                           string @certificatePrivateKey = null,
                                           string @regionalCertificateArn = null,
                                           string @regionalCertificateName = null)
        {
            @DomainName = @domainName;
            @EndpointConfiguration = @endpointConfiguration;
            @CertificateArn = @certificateArn;
            @CertificateBody = @certificateBody;
            @CertificateChain = @certificateChain;
            @CertificateName = @certificateName;
            @CertificatePrivateKey = @certificatePrivateKey;
            @RegionalCertificateArn = @regionalCertificateArn;
            @RegionalCertificateName = @regionalCertificateName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "domain_name", @out: false, min: 1, max: 1)]
        public string @DomainName { get; }

        [nterraform.TerraformProperty(name: "endpoint_configuration", @out: false, min: 1, max: 1)]
        public endpoint_configuration[] @EndpointConfiguration { get; }

        [nterraform.TerraformProperty(name: "certificate_arn", @out: false, min: 0, max: 1)]
        public string @CertificateArn { get; }

        [nterraform.TerraformProperty(name: "certificate_body", @out: false, min: 0, max: 1)]
        public string @CertificateBody { get; }

        [nterraform.TerraformProperty(name: "certificate_chain", @out: false, min: 0, max: 1)]
        public string @CertificateChain { get; }

        [nterraform.TerraformProperty(name: "certificate_name", @out: false, min: 0, max: 1)]
        public string @CertificateName { get; }

        [nterraform.TerraformProperty(name: "certificate_private_key", @out: false, min: 0, max: 1)]
        public string @CertificatePrivateKey { get; }

        [nterraform.TerraformProperty(name: "certificate_upload_date", @out: true, min: 0, max: 1)]
        public string @CertificateUploadDate { get; }

        [nterraform.TerraformProperty(name: "cloudfront_domain_name", @out: true, min: 0, max: 1)]
        public string @CloudfrontDomainName { get; }

        [nterraform.TerraformProperty(name: "cloudfront_zone_id", @out: true, min: 0, max: 1)]
        public string @CloudfrontZoneId { get; }

        [nterraform.TerraformProperty(name: "regional_certificate_arn", @out: false, min: 0, max: 1)]
        public string @RegionalCertificateArn { get; }

        [nterraform.TerraformProperty(name: "regional_certificate_name", @out: false, min: 0, max: 1)]
        public string @RegionalCertificateName { get; }

        [nterraform.TerraformProperty(name: "regional_domain_name", @out: true, min: 0, max: 1)]
        public string @RegionalDomainName { get; }

        [nterraform.TerraformProperty(name: "regional_zone_id", @out: true, min: 0, max: 1)]
        public string @RegionalZoneId { get; }
    }

}
