using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_api_gateway_domain_name")]
    public sealed class aws_api_gateway_domain_name : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "endpoint_configuration")]
        public sealed class endpoint_configuration : nterraform.Core.structure
        {
            public endpoint_configuration(string[] @types)
            {
                @Types = @types;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "types", @out: false, min: 1, max: 1)]
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

        [nterraform.Core.TerraformProperty(name: "domain_name", @out: false, min: 1, max: 1)]
        public string @DomainName { get; }

        [nterraform.Core.TerraformProperty(name: "endpoint_configuration", @out: false, min: 1, max: 1)]
        public endpoint_configuration[] @EndpointConfiguration { get; }

        [nterraform.Core.TerraformProperty(name: "certificate_arn", @out: false, min: 0, max: 1)]
        public string @CertificateArn { get; }

        [nterraform.Core.TerraformProperty(name: "certificate_body", @out: false, min: 0, max: 1)]
        public string @CertificateBody { get; }

        [nterraform.Core.TerraformProperty(name: "certificate_chain", @out: false, min: 0, max: 1)]
        public string @CertificateChain { get; }

        [nterraform.Core.TerraformProperty(name: "certificate_name", @out: false, min: 0, max: 1)]
        public string @CertificateName { get; }

        [nterraform.Core.TerraformProperty(name: "certificate_private_key", @out: false, min: 0, max: 1)]
        public string @CertificatePrivateKey { get; }

        [nterraform.Core.TerraformProperty(name: "certificate_upload_date", @out: true, min: 0, max: 1)]
        public string @CertificateUploadDate { get; }

        [nterraform.Core.TerraformProperty(name: "cloudfront_domain_name", @out: true, min: 0, max: 1)]
        public string @CloudfrontDomainName { get; }

        [nterraform.Core.TerraformProperty(name: "cloudfront_zone_id", @out: true, min: 0, max: 1)]
        public string @CloudfrontZoneId { get; }

        [nterraform.Core.TerraformProperty(name: "regional_certificate_arn", @out: false, min: 0, max: 1)]
        public string @RegionalCertificateArn { get; }

        [nterraform.Core.TerraformProperty(name: "regional_certificate_name", @out: false, min: 0, max: 1)]
        public string @RegionalCertificateName { get; }

        [nterraform.Core.TerraformProperty(name: "regional_domain_name", @out: true, min: 0, max: 1)]
        public string @RegionalDomainName { get; }

        [nterraform.Core.TerraformProperty(name: "regional_zone_id", @out: true, min: 0, max: 1)]
        public string @RegionalZoneId { get; }
    }

}
