using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_storage_account : NTerraform.resource
    {
        public sealed class custom_domain
        {
            public custom_domain(string @name,
                                 bool? @useSubdomain = null)
            {
                @Name = @name;
                @UseSubdomain = @useSubdomain;
            }

            public string @Name { get; }
            public bool? @UseSubdomain { get; }
        }

        public sealed class network_rules
        {
            public network_rules(string[] @ipRules = null,
                                 string[] @virtualNetworkSubnetIds = null)
            {
                @IpRules = @ipRules;
                @VirtualNetworkSubnetIds = @virtualNetworkSubnetIds;
            }

            public string[] @Bypass { get; }
            public string[] @IpRules { get; }
            public string[] @VirtualNetworkSubnetIds { get; }
        }

        public sealed class identity
        {
            public identity(string @type)
            {
                @Type = @type;
            }

            public string @Type { get; }
            public string @PrincipalId { get; }
            public string @TenantId { get; }
        }

        public azurerm_storage_account(string @accountReplicationType,
                                       string @accountTier,
                                       string @location,
                                       string @name,
                                       string @resourceGroupName,
                                       string @accountEncryptionSource = null,
                                       string @accountKind = null,
                                       custom_domain[] @customDomain = null,
                                       bool? @enableBlobEncryption = null,
                                       bool? @enableFileEncryption = null,
                                       bool? @enableHttpsTrafficOnly = null,
                                       identity[] @identity = null,
                                       network_rules[] @networkRules = null)
        {
            @AccountReplicationType = @accountReplicationType;
            @AccountTier = @accountTier;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @AccountEncryptionSource = @accountEncryptionSource;
            @AccountKind = @accountKind;
            @CustomDomain = @customDomain;
            @EnableBlobEncryption = @enableBlobEncryption;
            @EnableFileEncryption = @enableFileEncryption;
            @EnableHttpsTrafficOnly = @enableHttpsTrafficOnly;
            @Identity = @identity;
            @NetworkRules = @networkRules;
        }

        public string @AccountReplicationType { get; }
        public string @AccountTier { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @AccessTier { get; }
        public string @AccountEncryptionSource { get; }
        public string @AccountKind { get; }
        public string @AccountType { get; }
        public custom_domain[] @CustomDomain { get; }
        public bool? @EnableBlobEncryption { get; }
        public bool? @EnableFileEncryption { get; }
        public bool? @EnableHttpsTrafficOnly { get; }
        public identity[] @Identity { get; }
        public network_rules[] @NetworkRules { get; }
        public string @PrimaryAccessKey { get; }
        public string @PrimaryBlobConnectionString { get; }
        public string @PrimaryBlobEndpoint { get; }
        public string @PrimaryConnectionString { get; }
        public string @PrimaryFileEndpoint { get; }
        public string @PrimaryLocation { get; }
        public string @PrimaryQueueEndpoint { get; }
        public string @PrimaryTableEndpoint { get; }
        public string @SecondaryAccessKey { get; }
        public string @SecondaryBlobConnectionString { get; }
        public string @SecondaryBlobEndpoint { get; }
        public string @SecondaryConnectionString { get; }
        public string @SecondaryLocation { get; }
        public string @SecondaryQueueEndpoint { get; }
        public string @SecondaryTableEndpoint { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
