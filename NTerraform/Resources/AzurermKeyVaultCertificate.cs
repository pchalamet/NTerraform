using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_key_vault_certificate")]
    public sealed class azurerm_key_vault_certificate : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "certificate_policy")]
        public sealed class certificate_policy
        {
            [TerraformStructure(category: "", typeName: "lifetime_action")]
            public sealed class lifetime_action
            {
                [TerraformStructure(category: "", typeName: "action")]
                public sealed class action
                {
                    public action(string @actionType)
                    {
                        @ActionType = @actionType;
                    }

                    [TerraformProperty(name: "action_type", @out: false, nested: false, min: 1, max: 1)]
                    public string @ActionType { get; }
                }

                [TerraformStructure(category: "", typeName: "trigger")]
                public sealed class trigger
                {
                    public trigger(int? @daysBeforeExpiry = null,
                                   int? @lifetimePercentage = null)
                    {
                        @DaysBeforeExpiry = @daysBeforeExpiry;
                        @LifetimePercentage = @lifetimePercentage;
                    }

                    [TerraformProperty(name: "days_before_expiry", @out: false, nested: false, min: 0, max: 1)]
                    public int? @DaysBeforeExpiry { get; }

                    [TerraformProperty(name: "lifetime_percentage", @out: false, nested: false, min: 0, max: 1)]
                    public int? @LifetimePercentage { get; }
                }

                public lifetime_action(action[] @action,
                                       trigger[] @trigger)
                {
                    @Action = @action;
                    @Trigger = @trigger;
                }

                [TerraformProperty(name: "action", @out: false, nested: false, min: 1, max: 1)]
                public action[] @Action { get; }

                [TerraformProperty(name: "trigger", @out: false, nested: false, min: 1, max: 1)]
                public trigger[] @Trigger { get; }
            }

            [TerraformStructure(category: "", typeName: "secret_properties")]
            public sealed class secret_properties
            {
                public secret_properties(string @contentType)
                {
                    @ContentType = @contentType;
                }

                [TerraformProperty(name: "content_type", @out: false, nested: false, min: 1, max: 1)]
                public string @ContentType { get; }
            }

            [TerraformStructure(category: "", typeName: "x509_certificate_properties")]
            public sealed class x509_certificate_properties
            {
                public x509_certificate_properties(string[] @keyUsage,
                                                   string @subject,
                                                   int @validityInMonths)
                {
                    @KeyUsage = @keyUsage;
                    @Subject = @subject;
                    @ValidityInMonths = @validityInMonths;
                }

                [TerraformProperty(name: "key_usage", @out: false, nested: false, min: 1, max: 1)]
                public string[] @KeyUsage { get; }

                [TerraformProperty(name: "subject", @out: false, nested: false, min: 1, max: 1)]
                public string @Subject { get; }

                [TerraformProperty(name: "validity_in_months", @out: false, nested: false, min: 1, max: 1)]
                public int @ValidityInMonths { get; }
            }

            [TerraformStructure(category: "", typeName: "issuer_parameters")]
            public sealed class issuer_parameters
            {
                public issuer_parameters(string @name)
                {
                    @Name = @name;
                }

                [TerraformProperty(name: "name", @out: false, nested: false, min: 1, max: 1)]
                public string @Name { get; }
            }

            [TerraformStructure(category: "", typeName: "key_properties")]
            public sealed class key_properties
            {
                public key_properties(bool @exportable,
                                      int @keySize,
                                      string @keyType,
                                      bool @reuseKey)
                {
                    @Exportable = @exportable;
                    @KeySize = @keySize;
                    @KeyType = @keyType;
                    @ReuseKey = @reuseKey;
                }

                [TerraformProperty(name: "exportable", @out: false, nested: false, min: 1, max: 1)]
                public bool @Exportable { get; }

                [TerraformProperty(name: "key_size", @out: false, nested: false, min: 1, max: 1)]
                public int @KeySize { get; }

                [TerraformProperty(name: "key_type", @out: false, nested: false, min: 1, max: 1)]
                public string @KeyType { get; }

                [TerraformProperty(name: "reuse_key", @out: false, nested: false, min: 1, max: 1)]
                public bool @ReuseKey { get; }
            }

            public certificate_policy(issuer_parameters[] @issuerParameters,
                                      key_properties[] @keyProperties,
                                      secret_properties[] @secretProperties,
                                      lifetime_action[] @lifetimeAction = null,
                                      x509_certificate_properties[] @x509CertificateProperties = null)
            {
                @IssuerParameters = @issuerParameters;
                @KeyProperties = @keyProperties;
                @SecretProperties = @secretProperties;
                @LifetimeAction = @lifetimeAction;
                @X509CertificateProperties = @x509CertificateProperties;
            }

            [TerraformProperty(name: "issuer_parameters", @out: false, nested: false, min: 1, max: 1)]
            public issuer_parameters[] @IssuerParameters { get; }

            [TerraformProperty(name: "key_properties", @out: false, nested: false, min: 1, max: 1)]
            public key_properties[] @KeyProperties { get; }

            [TerraformProperty(name: "secret_properties", @out: false, nested: false, min: 1, max: 1)]
            public secret_properties[] @SecretProperties { get; }

            [TerraformProperty(name: "lifetime_action", @out: false, nested: false, min: 0, max: 0)]
            public lifetime_action[] @LifetimeAction { get; }

            [TerraformProperty(name: "x509_certificate_properties", @out: false, nested: false, min: 0, max: 1)]
            public x509_certificate_properties[] @X509CertificateProperties { get; }
        }

        [TerraformStructure(category: "", typeName: "certificate")]
        public sealed class certificate
        {
            public certificate(string @contents,
                               string @password = null)
            {
                @Contents = @contents;
                @Password = @password;
            }

            [TerraformProperty(name: "contents", @out: false, nested: false, min: 1, max: 1)]
            public string @Contents { get; }

            [TerraformProperty(name: "password", @out: false, nested: false, min: 0, max: 1)]
            public string @Password { get; }
        }

        public azurerm_key_vault_certificate(certificate_policy[] @certificatePolicy,
                                             string @name,
                                             string @vaultUri,
                                             certificate[] @certificate = null)
        {
            @CertificatePolicy = @certificatePolicy;
            @Name = @name;
            @VaultUri = @vaultUri;
            @Certificate = @certificate;
        }

        [TerraformProperty(name: "certificate_policy", @out: false, nested: true, min: 1, max: 1)]
        public certificate_policy[] @CertificatePolicy { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "vault_uri", @out: false, nested: true, min: 1, max: 1)]
        public string @VaultUri { get; }

        [TerraformProperty(name: "certificate", @out: false, nested: true, min: 0, max: 1)]
        public certificate[] @Certificate { get; }

        [TerraformProperty(name: "certificate_data", @out: true, nested: true, min: 0, max: 1)]
        public string @CertificateData { get; }

        [TerraformProperty(name: "secret_id", @out: true, nested: true, min: 0, max: 1)]
        public string @SecretId { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "version", @out: true, nested: true, min: 0, max: 1)]
        public string @Version { get; }
    }

}
