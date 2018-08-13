using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_storage_account")]
    public sealed class azurerm_storage_account : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "custom_domain")]
        public sealed class custom_domain : nterraform.structure
        {
            public custom_domain()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }
        }

        public azurerm_storage_account(string @name,
                                       string @resourceGroupName,
                                       custom_domain[] @customDomain = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @CustomDomain = @customDomain;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "access_tier", @out: true, min: 0, max: 1)]
        public string @AccessTier { get; }

        [nterraform.TerraformProperty(name: "account_encryption_source", @out: true, min: 0, max: 1)]
        public string @AccountEncryptionSource { get; }

        [nterraform.TerraformProperty(name: "account_kind", @out: true, min: 0, max: 1)]
        public string @AccountKind { get; }

        [nterraform.TerraformProperty(name: "account_replication_type", @out: true, min: 0, max: 1)]
        public string @AccountReplicationType { get; }

        [nterraform.TerraformProperty(name: "account_tier", @out: true, min: 0, max: 1)]
        public string @AccountTier { get; }

        [nterraform.TerraformProperty(name: "custom_domain", @out: false, min: 0, max: 1)]
        public custom_domain[] @CustomDomain { get; }

        [nterraform.TerraformProperty(name: "enable_blob_encryption", @out: true, min: 0, max: 1)]
        public bool? @EnableBlobEncryption { get; }

        [nterraform.TerraformProperty(name: "enable_file_encryption", @out: true, min: 0, max: 1)]
        public bool? @EnableFileEncryption { get; }

        [nterraform.TerraformProperty(name: "enable_https_traffic_only", @out: true, min: 0, max: 1)]
        public bool? @EnableHttpsTrafficOnly { get; }

        [nterraform.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

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
