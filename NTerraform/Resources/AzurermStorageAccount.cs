using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_storage_account")]
    public sealed class azurerm_storage_account : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "custom_domain")]
        public sealed class custom_domain
        {
            public custom_domain(string @name,
                                 bool? @useSubdomain = null)
            {
                @Name = @name;
                @UseSubdomain = @useSubdomain;
            }

            [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "use_subdomain", @out: false, min: 0, max: 1)]
            public bool? @UseSubdomain { get; }
        }

        [TerraformStructure(category: "", typeName: "network_rules")]
        public sealed class network_rules
        {
            public network_rules(string[] @ipRules = null,
                                 string[] @virtualNetworkSubnetIds = null)
            {
                @IpRules = @ipRules;
                @VirtualNetworkSubnetIds = @virtualNetworkSubnetIds;
            }

            [TerraformProperty(name: "bypass", @out: true, min: 0, max: 1)]
            public string[] @Bypass { get; }

            [TerraformProperty(name: "ip_rules", @out: false, min: 0, max: 1)]
            public string[] @IpRules { get; }

            [TerraformProperty(name: "virtual_network_subnet_ids", @out: false, min: 0, max: 1)]
            public string[] @VirtualNetworkSubnetIds { get; }
        }

        [TerraformStructure(category: "", typeName: "identity")]
        public sealed class identity
        {
            public identity(string @type)
            {
                @Type = @type;
            }

            [TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [TerraformProperty(name: "principal_id", @out: true, min: 0, max: 1)]
            public string @PrincipalId { get; }

            [TerraformProperty(name: "tenant_id", @out: true, min: 0, max: 1)]
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

        [TerraformProperty(name: "account_replication_type", @out: false, min: 1, max: 1)]
        public string @AccountReplicationType { get; }

        [TerraformProperty(name: "account_tier", @out: false, min: 1, max: 1)]
        public string @AccountTier { get; }

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "access_tier", @out: true, min: 0, max: 1)]
        public string @AccessTier { get; }

        [TerraformProperty(name: "account_encryption_source", @out: false, min: 0, max: 1)]
        public string @AccountEncryptionSource { get; }

        [TerraformProperty(name: "account_kind", @out: false, min: 0, max: 1)]
        public string @AccountKind { get; }

        [TerraformProperty(name: "account_type", @out: true, min: 0, max: 1)]
        public string @AccountType { get; }

        [TerraformProperty(name: "custom_domain", @out: false, min: 0, max: 1)]
        public custom_domain[] @CustomDomain { get; }

        [TerraformProperty(name: "enable_blob_encryption", @out: false, min: 0, max: 1)]
        public bool? @EnableBlobEncryption { get; }

        [TerraformProperty(name: "enable_file_encryption", @out: false, min: 0, max: 1)]
        public bool? @EnableFileEncryption { get; }

        [TerraformProperty(name: "enable_https_traffic_only", @out: false, min: 0, max: 1)]
        public bool? @EnableHttpsTrafficOnly { get; }

        [TerraformProperty(name: "identity", @out: false, min: 0, max: 1)]
        public identity[] @Identity { get; }

        [TerraformProperty(name: "network_rules", @out: false, min: 0, max: 1)]
        public network_rules[] @NetworkRules { get; }

        [TerraformProperty(name: "primary_access_key", @out: true, min: 0, max: 1)]
        public string @PrimaryAccessKey { get; }

        [TerraformProperty(name: "primary_blob_connection_string", @out: true, min: 0, max: 1)]
        public string @PrimaryBlobConnectionString { get; }

        [TerraformProperty(name: "primary_blob_endpoint", @out: true, min: 0, max: 1)]
        public string @PrimaryBlobEndpoint { get; }

        [TerraformProperty(name: "primary_connection_string", @out: true, min: 0, max: 1)]
        public string @PrimaryConnectionString { get; }

        [TerraformProperty(name: "primary_file_endpoint", @out: true, min: 0, max: 1)]
        public string @PrimaryFileEndpoint { get; }

        [TerraformProperty(name: "primary_location", @out: true, min: 0, max: 1)]
        public string @PrimaryLocation { get; }

        [TerraformProperty(name: "primary_queue_endpoint", @out: true, min: 0, max: 1)]
        public string @PrimaryQueueEndpoint { get; }

        [TerraformProperty(name: "primary_table_endpoint", @out: true, min: 0, max: 1)]
        public string @PrimaryTableEndpoint { get; }

        [TerraformProperty(name: "secondary_access_key", @out: true, min: 0, max: 1)]
        public string @SecondaryAccessKey { get; }

        [TerraformProperty(name: "secondary_blob_connection_string", @out: true, min: 0, max: 1)]
        public string @SecondaryBlobConnectionString { get; }

        [TerraformProperty(name: "secondary_blob_endpoint", @out: true, min: 0, max: 1)]
        public string @SecondaryBlobEndpoint { get; }

        [TerraformProperty(name: "secondary_connection_string", @out: true, min: 0, max: 1)]
        public string @SecondaryConnectionString { get; }

        [TerraformProperty(name: "secondary_location", @out: true, min: 0, max: 1)]
        public string @SecondaryLocation { get; }

        [TerraformProperty(name: "secondary_queue_endpoint", @out: true, min: 0, max: 1)]
        public string @SecondaryQueueEndpoint { get; }

        [TerraformProperty(name: "secondary_table_endpoint", @out: true, min: 0, max: 1)]
        public string @SecondaryTableEndpoint { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
