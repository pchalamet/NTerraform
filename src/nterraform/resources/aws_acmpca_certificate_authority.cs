using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_acmpca_certificate_authority")]
    public sealed class aws_acmpca_certificate_authority : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "certificate_authority_configuration")]
        public sealed class certificate_authority_configuration : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "subject")]
            public sealed class subject : nterraform.Core.structure
            {
                public subject(string @commonName = null,
                               string @country = null,
                               string @distinguishedNameQualifier = null,
                               string @generationQualifier = null,
                               string @givenName = null,
                               string @initials = null,
                               string @locality = null,
                               string @organization = null,
                               string @organizationalUnit = null,
                               string @pseudonym = null,
                               string @state = null,
                               string @surname = null,
                               string @title = null)
                {
                    @CommonName = @commonName;
                    @Country = @country;
                    @DistinguishedNameQualifier = @distinguishedNameQualifier;
                    @GenerationQualifier = @generationQualifier;
                    @GivenName = @givenName;
                    @Initials = @initials;
                    @Locality = @locality;
                    @Organization = @organization;
                    @OrganizationalUnit = @organizationalUnit;
                    @Pseudonym = @pseudonym;
                    @State = @state;
                    @Surname = @surname;
                    @Title = @title;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "common_name", @out: false, min: 0, max: 1)]
                public string @CommonName { get; }

                [nterraform.Core.TerraformProperty(name: "country", @out: false, min: 0, max: 1)]
                public string @Country { get; }

                [nterraform.Core.TerraformProperty(name: "distinguished_name_qualifier", @out: false, min: 0, max: 1)]
                public string @DistinguishedNameQualifier { get; }

                [nterraform.Core.TerraformProperty(name: "generation_qualifier", @out: false, min: 0, max: 1)]
                public string @GenerationQualifier { get; }

                [nterraform.Core.TerraformProperty(name: "given_name", @out: false, min: 0, max: 1)]
                public string @GivenName { get; }

                [nterraform.Core.TerraformProperty(name: "initials", @out: false, min: 0, max: 1)]
                public string @Initials { get; }

                [nterraform.Core.TerraformProperty(name: "locality", @out: false, min: 0, max: 1)]
                public string @Locality { get; }

                [nterraform.Core.TerraformProperty(name: "organization", @out: false, min: 0, max: 1)]
                public string @Organization { get; }

                [nterraform.Core.TerraformProperty(name: "organizational_unit", @out: false, min: 0, max: 1)]
                public string @OrganizationalUnit { get; }

                [nterraform.Core.TerraformProperty(name: "pseudonym", @out: false, min: 0, max: 1)]
                public string @Pseudonym { get; }

                [nterraform.Core.TerraformProperty(name: "state", @out: false, min: 0, max: 1)]
                public string @State { get; }

                [nterraform.Core.TerraformProperty(name: "surname", @out: false, min: 0, max: 1)]
                public string @Surname { get; }

                [nterraform.Core.TerraformProperty(name: "title", @out: false, min: 0, max: 1)]
                public string @Title { get; }
            }

            public certificate_authority_configuration(string @keyAlgorithm,
                                                       string @signingAlgorithm,
                                                       subject[] @subject)
            {
                @KeyAlgorithm = @keyAlgorithm;
                @SigningAlgorithm = @signingAlgorithm;
                @Subject = @subject;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "key_algorithm", @out: false, min: 1, max: 1)]
            public string @KeyAlgorithm { get; }

            [nterraform.Core.TerraformProperty(name: "signing_algorithm", @out: false, min: 1, max: 1)]
            public string @SigningAlgorithm { get; }

            [nterraform.Core.TerraformProperty(name: "subject", @out: false, min: 1, max: 1)]
            public subject[] @Subject { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "revocation_configuration")]
        public sealed class revocation_configuration : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "crl_configuration")]
            public sealed class crl_configuration : nterraform.Core.structure
            {
                public crl_configuration(int @expirationInDays,
                                         string @customCname = null,
                                         bool? @enabled = null,
                                         string @s3BucketName = null)
                {
                    @ExpirationInDays = @expirationInDays;
                    @CustomCname = @customCname;
                    @Enabled = @enabled;
                    @S3BucketName = @s3BucketName;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "expiration_in_days", @out: false, min: 1, max: 1)]
                public int @ExpirationInDays { get; }

                [nterraform.Core.TerraformProperty(name: "custom_cname", @out: false, min: 0, max: 1)]
                public string @CustomCname { get; }

                [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
                public bool? @Enabled { get; }

                [nterraform.Core.TerraformProperty(name: "s3_bucket_name", @out: false, min: 0, max: 1)]
                public string @S3BucketName { get; }
            }

            public revocation_configuration(crl_configuration[] @crlConfiguration = null)
            {
                @CrlConfiguration = @crlConfiguration;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "crl_configuration", @out: false, min: 0, max: 1)]
            public crl_configuration[] @CrlConfiguration { get; }
        }

        public aws_acmpca_certificate_authority(certificate_authority_configuration[] @certificateAuthorityConfiguration,
                                                bool? @enabled = null,
                                                revocation_configuration[] @revocationConfiguration = null,
                                                Dictionary<string,string> @tags = null,
                                                string @type = null)
        {
            @CertificateAuthorityConfiguration = @certificateAuthorityConfiguration;
            @Enabled = @enabled;
            @RevocationConfiguration = @revocationConfiguration;
            @Tags = @tags;
            @Type = @type;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "certificate_authority_configuration", @out: false, min: 1, max: 1)]
        public certificate_authority_configuration[] @CertificateAuthorityConfiguration { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "certificate", @out: true, min: 0, max: 1)]
        public string @Certificate { get; }

        [nterraform.Core.TerraformProperty(name: "certificate_chain", @out: true, min: 0, max: 1)]
        public string @CertificateChain { get; }

        [nterraform.Core.TerraformProperty(name: "certificate_signing_request", @out: true, min: 0, max: 1)]
        public string @CertificateSigningRequest { get; }

        [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.Core.TerraformProperty(name: "not_after", @out: true, min: 0, max: 1)]
        public string @NotAfter { get; }

        [nterraform.Core.TerraformProperty(name: "not_before", @out: true, min: 0, max: 1)]
        public string @NotBefore { get; }

        [nterraform.Core.TerraformProperty(name: "revocation_configuration", @out: false, min: 0, max: 1)]
        public revocation_configuration[] @RevocationConfiguration { get; }

        [nterraform.Core.TerraformProperty(name: "serial", @out: true, min: 0, max: 1)]
        public string @Serial { get; }

        [nterraform.Core.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 0, max: 1)]
        public string @Type { get; }
    }

}
