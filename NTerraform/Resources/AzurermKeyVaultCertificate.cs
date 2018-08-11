using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_key_vault_certificate : NTerraform.resource
    {
        public sealed class certificate
        {
            public certificate(string @contents,
                               string @password = null)
            {
                @Contents = @contents;
                @Password = @password;
            }

            public string @Contents { get; }
            public string @Password { get; }
        }

        public sealed class certificate_policy
        {
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

                public bool @Exportable { get; }
                public int @KeySize { get; }
                public string @KeyType { get; }
                public bool @ReuseKey { get; }
            }

            public sealed class lifetime_action
            {
                public sealed class action
                {
                    public action(string @actionType)
                    {
                        @ActionType = @actionType;
                    }

                    public string @ActionType { get; }
                }

                public sealed class trigger
                {
                    public trigger(int? @daysBeforeExpiry = null,
                                   int? @lifetimePercentage = null)
                    {
                        @DaysBeforeExpiry = @daysBeforeExpiry;
                        @LifetimePercentage = @lifetimePercentage;
                    }

                    public int? @DaysBeforeExpiry { get; }
                    public int? @LifetimePercentage { get; }
                }

                public lifetime_action(action[] @action,
                                       trigger[] @trigger)
                {
                    @Action = @action;
                    @Trigger = @trigger;
                }

                public action[] @Action { get; }
                public trigger[] @Trigger { get; }
            }

            public sealed class secret_properties
            {
                public secret_properties(string @contentType)
                {
                    @ContentType = @contentType;
                }

                public string @ContentType { get; }
            }

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

                public string[] @KeyUsage { get; }
                public string @Subject { get; }
                public int @ValidityInMonths { get; }
            }

            public sealed class issuer_parameters
            {
                public issuer_parameters(string @name)
                {
                    @Name = @name;
                }

                public string @Name { get; }
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

            public issuer_parameters[] @IssuerParameters { get; }
            public key_properties[] @KeyProperties { get; }
            public secret_properties[] @SecretProperties { get; }
            public lifetime_action[] @LifetimeAction { get; }
            public x509_certificate_properties[] @X509CertificateProperties { get; }
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

        public certificate_policy[] @CertificatePolicy { get; }
        public string @Name { get; }
        public string @VaultUri { get; }
        public certificate[] @Certificate { get; }
        public string @CertificateData { get; }
        public string @SecretId { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @Version { get; }
    }

}
