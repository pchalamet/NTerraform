using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_acmpca_certificate_authority")]
    public sealed class aws_acmpca_certificate_authority : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "revocation_configuration")]
        public sealed class revocation_configuration : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "data", typeName: "crl_configuration")]
            public sealed class crl_configuration : nterraform.structure
            {
                public crl_configuration()
                {
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "custom_cname", @out: true, min: 0, max: 1)]
                public string @CustomCname { get; }

                [nterraform.TerraformProperty(name: "enabled", @out: true, min: 0, max: 1)]
                public bool? @Enabled { get; }

                [nterraform.TerraformProperty(name: "expiration_in_days", @out: true, min: 0, max: 1)]
                public int? @ExpirationInDays { get; }

                [nterraform.TerraformProperty(name: "s3_bucket_name", @out: true, min: 0, max: 1)]
                public string @S3BucketName { get; }
            }

            public revocation_configuration(crl_configuration[] @crlConfiguration = null)
            {
                @CrlConfiguration = @crlConfiguration;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "crl_configuration", @out: false, min: 0, max: 0)]
            public crl_configuration[] @CrlConfiguration { get; }
        }

        public aws_acmpca_certificate_authority(string @arn,
                                                revocation_configuration[] @revocationConfiguration = null)
        {
            @Arn = @arn;
            @RevocationConfiguration = @revocationConfiguration;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "arn", @out: false, min: 1, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "certificate", @out: true, min: 0, max: 1)]
        public string @Certificate { get; }

        [nterraform.TerraformProperty(name: "certificate_chain", @out: true, min: 0, max: 1)]
        public string @CertificateChain { get; }

        [nterraform.TerraformProperty(name: "certificate_signing_request", @out: true, min: 0, max: 1)]
        public string @CertificateSigningRequest { get; }

        [nterraform.TerraformProperty(name: "not_after", @out: true, min: 0, max: 1)]
        public string @NotAfter { get; }

        [nterraform.TerraformProperty(name: "not_before", @out: true, min: 0, max: 1)]
        public string @NotBefore { get; }

        [nterraform.TerraformProperty(name: "revocation_configuration", @out: false, min: 0, max: 0)]
        public revocation_configuration[] @RevocationConfiguration { get; }

        [nterraform.TerraformProperty(name: "serial", @out: true, min: 0, max: 1)]
        public string @Serial { get; }

        [nterraform.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
        public string @Type { get; }
    }

}
