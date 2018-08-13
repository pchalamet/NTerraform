using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_key_vault_certificate")]
    public sealed class azurerm_key_vault_certificate : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "certificate_policy")]
        public sealed class certificate_policy : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "secret_properties")]
            public sealed class secret_properties : nterraform.structure
            {
                public secret_properties(string @contentType)
                {
                    @ContentType = @contentType;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "content_type", @out: false, min: 1, max: 1)]
                public string @ContentType { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "x509_certificate_properties")]
            public sealed class x509_certificate_properties : nterraform.structure
            {
                public x509_certificate_properties(string[] @keyUsage,
                                                   string @subject,
                                                   int @validityInMonths)
                {
                    @KeyUsage = @keyUsage;
                    @Subject = @subject;
                    @ValidityInMonths = @validityInMonths;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "key_usage", @out: false, min: 1, max: 1)]
                public string[] @KeyUsage { get; }

                [nterraform.TerraformProperty(name: "subject", @out: false, min: 1, max: 1)]
                public string @Subject { get; }

                [nterraform.TerraformProperty(name: "validity_in_months", @out: false, min: 1, max: 1)]
                public int @ValidityInMonths { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "issuer_parameters")]
            public sealed class issuer_parameters : nterraform.structure
            {
                public issuer_parameters(string @name)
                {
                    @Name = @name;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "key_properties")]
            public sealed class key_properties : nterraform.structure
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
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "exportable", @out: false, min: 1, max: 1)]
                public bool @Exportable { get; }

                [nterraform.TerraformProperty(name: "key_size", @out: false, min: 1, max: 1)]
                public int @KeySize { get; }

                [nterraform.TerraformProperty(name: "key_type", @out: false, min: 1, max: 1)]
                public string @KeyType { get; }

                [nterraform.TerraformProperty(name: "reuse_key", @out: false, min: 1, max: 1)]
                public bool @ReuseKey { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "lifetime_action")]
            public sealed class lifetime_action : nterraform.structure
            {
                [nterraform.TerraformStructure(category: "resource", typeName: "trigger")]
                public sealed class trigger : nterraform.structure
                {
                    public trigger(int? @daysBeforeExpiry = null,
                                   int? @lifetimePercentage = null)
                    {
                        @DaysBeforeExpiry = @daysBeforeExpiry;
                        @LifetimePercentage = @lifetimePercentage;
                        base._validate_();
                    }

                    [nterraform.TerraformProperty(name: "days_before_expiry", @out: false, min: 0, max: 1)]
                    public int? @DaysBeforeExpiry { get; }

                    [nterraform.TerraformProperty(name: "lifetime_percentage", @out: false, min: 0, max: 1)]
                    public int? @LifetimePercentage { get; }
                }

                [nterraform.TerraformStructure(category: "resource", typeName: "action")]
                public sealed class action : nterraform.structure
                {
                    public action(string @actionType)
                    {
                        @ActionType = @actionType;
                        base._validate_();
                    }

                    [nterraform.TerraformProperty(name: "action_type", @out: false, min: 1, max: 1)]
                    public string @ActionType { get; }
                }

                public lifetime_action(action[] @action,
                                       trigger[] @trigger)
                {
                    @Action = @action;
                    @Trigger = @trigger;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "action", @out: false, min: 1, max: 1)]
                public action[] @Action { get; }

                [nterraform.TerraformProperty(name: "trigger", @out: false, min: 1, max: 1)]
                public trigger[] @Trigger { get; }
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
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "issuer_parameters", @out: false, min: 1, max: 1)]
            public issuer_parameters[] @IssuerParameters { get; }

            [nterraform.TerraformProperty(name: "key_properties", @out: false, min: 1, max: 1)]
            public key_properties[] @KeyProperties { get; }

            [nterraform.TerraformProperty(name: "secret_properties", @out: false, min: 1, max: 1)]
            public secret_properties[] @SecretProperties { get; }

            [nterraform.TerraformProperty(name: "lifetime_action", @out: false, min: 0, max: 0)]
            public lifetime_action[] @LifetimeAction { get; }

            [nterraform.TerraformProperty(name: "x509_certificate_properties", @out: false, min: 0, max: 1)]
            public x509_certificate_properties[] @X509CertificateProperties { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "certificate")]
        public sealed class certificate : nterraform.structure
        {
            public certificate(string @contents,
                               string @password = null)
            {
                @Contents = @contents;
                @Password = @password;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "contents", @out: false, min: 1, max: 1)]
            public string @Contents { get; }

            [nterraform.TerraformProperty(name: "password", @out: false, min: 0, max: 1)]
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "certificate_policy", @out: false, min: 1, max: 1)]
        public certificate_policy[] @CertificatePolicy { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "vault_uri", @out: false, min: 1, max: 1)]
        public string @VaultUri { get; }

        [nterraform.TerraformProperty(name: "certificate", @out: false, min: 0, max: 1)]
        public certificate[] @Certificate { get; }

        [nterraform.TerraformProperty(name: "certificate_data", @out: true, min: 0, max: 1)]
        public string @CertificateData { get; }

        [nterraform.TerraformProperty(name: "secret_id", @out: true, min: 0, max: 1)]
        public string @SecretId { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }
    }

}
