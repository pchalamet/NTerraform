using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_storage_account")]
    public sealed class azurerm_storage_account : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "network_rules")]
        public sealed class network_rules : nterraform.structure
        {
            public network_rules(string[] @ipRules = null,
                                 string[] @virtualNetworkSubnetIds = null)
            {
                @IpRules = @ipRules;
                @VirtualNetworkSubnetIds = @virtualNetworkSubnetIds;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "bypass", @out: true, min: 0, max: 1)]
            public string[] @Bypass { get; }

            [nterraform.TerraformProperty(name: "ip_rules", @out: false, min: 0, max: 1)]
            public string[] @IpRules { get; }

            [nterraform.TerraformProperty(name: "virtual_network_subnet_ids", @out: false, min: 0, max: 1)]
            public string[] @VirtualNetworkSubnetIds { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "identity")]
        public sealed class identity : nterraform.structure
        {
            public identity(string @type)
            {
                @Type = @type;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.TerraformProperty(name: "principal_id", @out: true, min: 0, max: 1)]
            public string @PrincipalId { get; }

            [nterraform.TerraformProperty(name: "tenant_id", @out: true, min: 0, max: 1)]
            public string @TenantId { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "custom_domain")]
        public sealed class custom_domain : nterraform.structure
        {
            public custom_domain(string @name,
                                 bool? @useSubdomain = null)
            {
                @Name = @name;
                @UseSubdomain = @useSubdomain;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "use_subdomain", @out: false, min: 0, max: 1)]
            public bool? @UseSubdomain { get; }
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "account_replication_type", @out: false, min: 1, max: 1)]
        public string @AccountReplicationType { get; }

        [nterraform.TerraformProperty(name: "account_tier", @out: false, min: 1, max: 1)]
        public string @AccountTier { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "access_tier", @out: true, min: 0, max: 1)]
        public string @AccessTier { get; }

        [nterraform.TerraformProperty(name: "account_encryption_source", @out: false, min: 0, max: 1)]
        public string @AccountEncryptionSource { get; }

        [nterraform.TerraformProperty(name: "account_kind", @out: false, min: 0, max: 1)]
        public string @AccountKind { get; }

        [nterraform.TerraformProperty(name: "account_type", @out: true, min: 0, max: 1)]
        public string @AccountType { get; }

        [nterraform.TerraformProperty(name: "custom_domain", @out: false, min: 0, max: 1)]
        public custom_domain[] @CustomDomain { get; }

        [nterraform.TerraformProperty(name: "enable_blob_encryption", @out: false, min: 0, max: 1)]
        public bool? @EnableBlobEncryption { get; }

        [nterraform.TerraformProperty(name: "enable_file_encryption", @out: false, min: 0, max: 1)]
        public bool? @EnableFileEncryption { get; }

        [nterraform.TerraformProperty(name: "enable_https_traffic_only", @out: false, min: 0, max: 1)]
        public bool? @EnableHttpsTrafficOnly { get; }

        [nterraform.TerraformProperty(name: "identity", @out: false, min: 0, max: 1)]
        public identity[] @Identity { get; }

        [nterraform.TerraformProperty(name: "network_rules", @out: false, min: 0, max: 1)]
        public network_rules[] @NetworkRules { get; }

        [nterraform.TerraformProperty(name: "primary_access_key", @out: true, min: 0, max: 1)]
        public string @PrimaryAccessKey { get; }

        [nterraform.TerraformProperty(name: "primary_blob_connection_string", @out: true, min: 0, max: 1)]
        public string @PrimaryBlobConnectionString { get; }

        [nterraform.TerraformProperty(name: "primary_blob_endpoint", @out: true, min: 0, max: 1)]
        public string @PrimaryBlobEndpoint { get; }

        [nterraform.TerraformProperty(name: "primary_connection_string", @out: true, min: 0, max: 1)]
        public string @PrimaryConnectionString { get; }

        [nterraform.TerraformProperty(name: "primary_file_endpoint", @out: true, min: 0, max: 1)]
        public string @PrimaryFileEndpoint { get; }

        [nterraform.TerraformProperty(name: "primary_location", @out: true, min: 0, max: 1)]
        public string @PrimaryLocation { get; }

        [nterraform.TerraformProperty(name: "primary_queue_endpoint", @out: true, min: 0, max: 1)]
        public string @PrimaryQueueEndpoint { get; }

        [nterraform.TerraformProperty(name: "primary_table_endpoint", @out: true, min: 0, max: 1)]
        public string @PrimaryTableEndpoint { get; }

        [nterraform.TerraformProperty(name: "secondary_access_key", @out: true, min: 0, max: 1)]
        public string @SecondaryAccessKey { get; }

        [nterraform.TerraformProperty(name: "secondary_blob_connection_string", @out: true, min: 0, max: 1)]
        public string @SecondaryBlobConnectionString { get; }

        [nterraform.TerraformProperty(name: "secondary_blob_endpoint", @out: true, min: 0, max: 1)]
        public string @SecondaryBlobEndpoint { get; }

        [nterraform.TerraformProperty(name: "secondary_connection_string", @out: true, min: 0, max: 1)]
        public string @SecondaryConnectionString { get; }

        [nterraform.TerraformProperty(name: "secondary_location", @out: true, min: 0, max: 1)]
        public string @SecondaryLocation { get; }

        [nterraform.TerraformProperty(name: "secondary_queue_endpoint", @out: true, min: 0, max: 1)]
        public string @SecondaryQueueEndpoint { get; }

        [nterraform.TerraformProperty(name: "secondary_table_endpoint", @out: true, min: 0, max: 1)]
        public string @SecondaryTableEndpoint { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
