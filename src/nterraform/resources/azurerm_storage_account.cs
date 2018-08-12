using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_storage_account")]
    public sealed class azurerm_storage_account : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "custom_domain")]
        public sealed class custom_domain : nterraform.Core.structure
        {
            public custom_domain(string @name,
                                 FSharpOption<bool> @useSubdomain = null)
            {
                @Name = @name;
                @UseSubdomain = @useSubdomain;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "use_subdomain", @out: false, min: 0, max: 1)]
            public FSharpOption<bool> @UseSubdomain { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "network_rules")]
        public sealed class network_rules : nterraform.Core.structure
        {
            public network_rules(FSharpOption<FSharpList<string>> @ipRules = null,
                                 FSharpOption<FSharpList<string>> @virtualNetworkSubnetIds = null)
            {
                @IpRules = @ipRules ?? FSharpList<string>.Empty;
                @VirtualNetworkSubnetIds = @virtualNetworkSubnetIds ?? FSharpList<string>.Empty;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "bypass", @out: true, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @Bypass { get; }

            [nterraform.Core.TerraformProperty(name: "ip_rules", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @IpRules { get; }

            [nterraform.Core.TerraformProperty(name: "virtual_network_subnet_ids", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @VirtualNetworkSubnetIds { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "identity")]
        public sealed class identity : nterraform.Core.structure
        {
            public identity(string @type)
            {
                @Type = @type;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.Core.TerraformProperty(name: "principal_id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @PrincipalId { get; }

            [nterraform.Core.TerraformProperty(name: "tenant_id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @TenantId { get; }
        }

        public azurerm_storage_account(string @accountReplicationType,
                                       string @accountTier,
                                       string @location,
                                       string @name,
                                       string @resourceGroupName,
                                       FSharpOption<string> @accountEncryptionSource = null,
                                       FSharpOption<string> @accountKind = null,
                                       FSharpOption<FSharpList<custom_domain>> @customDomain = null,
                                       FSharpOption<bool> @enableBlobEncryption = null,
                                       FSharpOption<bool> @enableFileEncryption = null,
                                       FSharpOption<bool> @enableHttpsTrafficOnly = null,
                                       FSharpOption<FSharpList<identity>> @identity = null,
                                       FSharpOption<FSharpList<network_rules>> @networkRules = null)
        {
            @AccountReplicationType = @accountReplicationType;
            @AccountTier = @accountTier;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @AccountEncryptionSource = @accountEncryptionSource;
            @AccountKind = @accountKind;
            @CustomDomain = @customDomain ?? FSharpList<custom_domain>.Empty;
            @EnableBlobEncryption = @enableBlobEncryption;
            @EnableFileEncryption = @enableFileEncryption;
            @EnableHttpsTrafficOnly = @enableHttpsTrafficOnly;
            @Identity = @identity ?? FSharpList<identity>.Empty;
            @NetworkRules = @networkRules ?? FSharpList<network_rules>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "account_replication_type", @out: false, min: 1, max: 1)]
        public string @AccountReplicationType { get; }

        [nterraform.Core.TerraformProperty(name: "account_tier", @out: false, min: 1, max: 1)]
        public string @AccountTier { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "access_tier", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AccessTier { get; }

        [nterraform.Core.TerraformProperty(name: "account_encryption_source", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @AccountEncryptionSource { get; }

        [nterraform.Core.TerraformProperty(name: "account_kind", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @AccountKind { get; }

        [nterraform.Core.TerraformProperty(name: "account_type", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AccountType { get; }

        [nterraform.Core.TerraformProperty(name: "custom_domain", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<custom_domain>> @CustomDomain { get; }

        [nterraform.Core.TerraformProperty(name: "enable_blob_encryption", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @EnableBlobEncryption { get; }

        [nterraform.Core.TerraformProperty(name: "enable_file_encryption", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @EnableFileEncryption { get; }

        [nterraform.Core.TerraformProperty(name: "enable_https_traffic_only", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @EnableHttpsTrafficOnly { get; }

        [nterraform.Core.TerraformProperty(name: "identity", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<identity>> @Identity { get; }

        [nterraform.Core.TerraformProperty(name: "network_rules", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<network_rules>> @NetworkRules { get; }

        [nterraform.Core.TerraformProperty(name: "primary_access_key", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @PrimaryAccessKey { get; }

        [nterraform.Core.TerraformProperty(name: "primary_blob_connection_string", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @PrimaryBlobConnectionString { get; }

        [nterraform.Core.TerraformProperty(name: "primary_blob_endpoint", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @PrimaryBlobEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "primary_connection_string", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @PrimaryConnectionString { get; }

        [nterraform.Core.TerraformProperty(name: "primary_file_endpoint", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @PrimaryFileEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "primary_location", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @PrimaryLocation { get; }

        [nterraform.Core.TerraformProperty(name: "primary_queue_endpoint", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @PrimaryQueueEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "primary_table_endpoint", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @PrimaryTableEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_access_key", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SecondaryAccessKey { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_blob_connection_string", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SecondaryBlobConnectionString { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_blob_endpoint", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SecondaryBlobEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_connection_string", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SecondaryConnectionString { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_location", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SecondaryLocation { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_queue_endpoint", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SecondaryQueueEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_table_endpoint", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SecondaryTableEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }
    }

}
