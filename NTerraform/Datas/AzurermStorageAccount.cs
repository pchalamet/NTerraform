using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_storage_account")]
    public sealed class azurerm_storage_account : NTerraform.data
    {
        [TerraformStructure(category: "", typeName: "custom_domain")]
        public sealed class custom_domain
        {
            public custom_domain()
            {
            }

            [TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }
        }

        public azurerm_storage_account(string @name,
                                       string @resourceGroupName,
                                       custom_domain[] @customDomain = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @CustomDomain = @customDomain;
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "access_tier", @out: true, min: 0, max: 1)]
        public string @AccessTier { get; }

        [TerraformProperty(name: "account_encryption_source", @out: true, min: 0, max: 1)]
        public string @AccountEncryptionSource { get; }

        [TerraformProperty(name: "account_kind", @out: true, min: 0, max: 1)]
        public string @AccountKind { get; }

        [TerraformProperty(name: "account_replication_type", @out: true, min: 0, max: 1)]
        public string @AccountReplicationType { get; }

        [TerraformProperty(name: "account_tier", @out: true, min: 0, max: 1)]
        public string @AccountTier { get; }

        [TerraformProperty(name: "custom_domain", @out: false, min: 0, max: 1)]
        public custom_domain[] @CustomDomain { get; }

        [TerraformProperty(name: "enable_blob_encryption", @out: true, min: 0, max: 1)]
        public bool? @EnableBlobEncryption { get; }

        [TerraformProperty(name: "enable_file_encryption", @out: true, min: 0, max: 1)]
        public bool? @EnableFileEncryption { get; }

        [TerraformProperty(name: "enable_https_traffic_only", @out: true, min: 0, max: 1)]
        public bool? @EnableHttpsTrafficOnly { get; }

        [TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

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
