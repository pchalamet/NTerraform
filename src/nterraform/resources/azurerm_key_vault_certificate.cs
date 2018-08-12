using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_key_vault_certificate")]
    public sealed class azurerm_key_vault_certificate : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "certificate_policy")]
        public sealed class certificate_policy : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "x509_certificate_properties")]
            public sealed class x509_certificate_properties : nterraform.Core.structure
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

                [nterraform.Core.TerraformProperty(name: "key_usage", @out: false, min: 1, max: 1)]
                public string[] @KeyUsage { get; }

                [nterraform.Core.TerraformProperty(name: "subject", @out: false, min: 1, max: 1)]
                public string @Subject { get; }

                [nterraform.Core.TerraformProperty(name: "validity_in_months", @out: false, min: 1, max: 1)]
                public int @ValidityInMonths { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "issuer_parameters")]
            public sealed class issuer_parameters : nterraform.Core.structure
            {
                public issuer_parameters(string @name)
                {
                    @Name = @name;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "key_properties")]
            public sealed class key_properties : nterraform.Core.structure
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

                [nterraform.Core.TerraformProperty(name: "exportable", @out: false, min: 1, max: 1)]
                public bool @Exportable { get; }

                [nterraform.Core.TerraformProperty(name: "key_size", @out: false, min: 1, max: 1)]
                public int @KeySize { get; }

                [nterraform.Core.TerraformProperty(name: "key_type", @out: false, min: 1, max: 1)]
                public string @KeyType { get; }

                [nterraform.Core.TerraformProperty(name: "reuse_key", @out: false, min: 1, max: 1)]
                public bool @ReuseKey { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "lifetime_action")]
            public sealed class lifetime_action : nterraform.Core.structure
            {
                [nterraform.Core.TerraformStructure(category: "resource", typeName: "action")]
                public sealed class action : nterraform.Core.structure
                {
                    public action(string @actionType)
                    {
                        @ActionType = @actionType;
                        base._validate_();
                    }

                    [nterraform.Core.TerraformProperty(name: "action_type", @out: false, min: 1, max: 1)]
                    public string @ActionType { get; }
                }

                [nterraform.Core.TerraformStructure(category: "resource", typeName: "trigger")]
                public sealed class trigger : nterraform.Core.structure
                {
                    public trigger(int? @daysBeforeExpiry = null,
                                   int? @lifetimePercentage = null)
                    {
                        @DaysBeforeExpiry = @daysBeforeExpiry;
                        @LifetimePercentage = @lifetimePercentage;
                        base._validate_();
                    }

                    [nterraform.Core.TerraformProperty(name: "days_before_expiry", @out: false, min: 0, max: 1)]
                    public int? @DaysBeforeExpiry { get; }

                    [nterraform.Core.TerraformProperty(name: "lifetime_percentage", @out: false, min: 0, max: 1)]
                    public int? @LifetimePercentage { get; }
                }

                public lifetime_action(action[] @action,
                                       trigger[] @trigger)
                {
                    @Action = @action;
                    @Trigger = @trigger;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "action", @out: false, min: 1, max: 1)]
                public action[] @Action { get; }

                [nterraform.Core.TerraformProperty(name: "trigger", @out: false, min: 1, max: 1)]
                public trigger[] @Trigger { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "secret_properties")]
            public sealed class secret_properties : nterraform.Core.structure
            {
                public secret_properties(string @contentType)
                {
                    @ContentType = @contentType;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "content_type", @out: false, min: 1, max: 1)]
                public string @ContentType { get; }
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

            [nterraform.Core.TerraformProperty(name: "issuer_parameters", @out: false, min: 1, max: 1)]
            public issuer_parameters[] @IssuerParameters { get; }

            [nterraform.Core.TerraformProperty(name: "key_properties", @out: false, min: 1, max: 1)]
            public key_properties[] @KeyProperties { get; }

            [nterraform.Core.TerraformProperty(name: "secret_properties", @out: false, min: 1, max: 1)]
            public secret_properties[] @SecretProperties { get; }

            [nterraform.Core.TerraformProperty(name: "lifetime_action", @out: false, min: 0, max: 0)]
            public lifetime_action[] @LifetimeAction { get; }

            [nterraform.Core.TerraformProperty(name: "x509_certificate_properties", @out: false, min: 0, max: 1)]
            public x509_certificate_properties[] @X509CertificateProperties { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "certificate")]
        public sealed class certificate : nterraform.Core.structure
        {
            public certificate(string @contents,
                               string @password = null)
            {
                @Contents = @contents;
                @Password = @password;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "contents", @out: false, min: 1, max: 1)]
            public string @Contents { get; }

            [nterraform.Core.TerraformProperty(name: "password", @out: false, min: 0, max: 1)]
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

        [nterraform.Core.TerraformProperty(name: "certificate_policy", @out: false, min: 1, max: 1)]
        public certificate_policy[] @CertificatePolicy { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "vault_uri", @out: false, min: 1, max: 1)]
        public string @VaultUri { get; }

        [nterraform.Core.TerraformProperty(name: "certificate", @out: false, min: 0, max: 1)]
        public certificate[] @Certificate { get; }

        [nterraform.Core.TerraformProperty(name: "certificate_data", @out: true, min: 0, max: 1)]
        public string @CertificateData { get; }

        [nterraform.Core.TerraformProperty(name: "secret_id", @out: true, min: 0, max: 1)]
        public string @SecretId { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }
    }

}
