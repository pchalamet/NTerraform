using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_key_vault_certificate : NTerraform.resource
    {
        public class certificate
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

        public class certificate_policy
        {
            public class secret_properties
            {
                public secret_properties(string @contentType)
                {
                    @ContentType = @contentType;
                }

                public string @ContentType { get; }
            }

            public class x509_certificate_properties
            {
                public x509_certificate_properties(List<string> @keyUsage,
                                                   string @subject,
                                                   int @validityInMonths)
                {
                    @KeyUsage = @keyUsage;
                    @Subject = @subject;
                    @ValidityInMonths = @validityInMonths;
                }

                public List<string> @KeyUsage { get; }
                public string @Subject { get; }
                public int @ValidityInMonths { get; }
            }

            public class issuer_parameters
            {
                public issuer_parameters(string @name)
                {
                    @Name = @name;
                }

                public string @Name { get; }
            }

            public class key_properties
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

            public class lifetime_action
            {
                public class action
                {
                    public action(string @actionType)
                    {
                        @ActionType = @actionType;
                    }

                    public string @ActionType { get; }
                }

                public class trigger
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

                public lifetime_action(List<action> @action,
                                       List<trigger> @trigger)
                {
                    @Action = @action;
                    @Trigger = @trigger;
                }

                public List<action> @Action { get; }
                public List<trigger> @Trigger { get; }
            }

            public certificate_policy(List<issuer_parameters> @issuerParameters,
                                      List<key_properties> @keyProperties,
                                      List<secret_properties> @secretProperties,
                                      List<lifetime_action> @lifetimeAction = null,
                                      List<x509_certificate_properties> @x509CertificateProperties = null)
            {
                @IssuerParameters = @issuerParameters;
                @KeyProperties = @keyProperties;
                @SecretProperties = @secretProperties;
                @LifetimeAction = @lifetimeAction;
                @X509CertificateProperties = @x509CertificateProperties;
            }

            public List<issuer_parameters> @IssuerParameters { get; }
            public List<key_properties> @KeyProperties { get; }
            public List<secret_properties> @SecretProperties { get; }
            public List<lifetime_action> @LifetimeAction { get; }
            public List<x509_certificate_properties> @X509CertificateProperties { get; }
        }

        public azurerm_key_vault_certificate(List<certificate_policy> @certificatePolicy,
                                             string @name,
                                             string @vaultUri,
                                             List<certificate> @certificate = null)
        {
            @CertificatePolicy = @certificatePolicy;
            @Name = @name;
            @VaultUri = @vaultUri;
            @Certificate = @certificate;
        }

        public List<certificate_policy> @CertificatePolicy { get; }
        public string @Name { get; }
        public string @VaultUri { get; }
        public List<certificate> @Certificate { get; }
        public string @CertificateData { get; }
        public string @SecretId { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @Version { get; }
    }

}
