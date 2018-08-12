using System.Collections.Generic;

namespace nterraform.datas.azurerm
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_storage_account")]
    public sealed class azurerm_storage_account : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "custom_domain")]
        public sealed class custom_domain : nterraform.Core.structure
        {
            public custom_domain()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
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

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "access_tier", @out: true, min: 0, max: 1)]
        public string @AccessTier { get; }

        [nterraform.Core.TerraformProperty(name: "account_encryption_source", @out: true, min: 0, max: 1)]
        public string @AccountEncryptionSource { get; }

        [nterraform.Core.TerraformProperty(name: "account_kind", @out: true, min: 0, max: 1)]
        public string @AccountKind { get; }

        [nterraform.Core.TerraformProperty(name: "account_replication_type", @out: true, min: 0, max: 1)]
        public string @AccountReplicationType { get; }

        [nterraform.Core.TerraformProperty(name: "account_tier", @out: true, min: 0, max: 1)]
        public string @AccountTier { get; }

        [nterraform.Core.TerraformProperty(name: "custom_domain", @out: false, min: 0, max: 1)]
        public custom_domain[] @CustomDomain { get; }

        [nterraform.Core.TerraformProperty(name: "enable_blob_encryption", @out: true, min: 0, max: 1)]
        public bool? @EnableBlobEncryption { get; }

        [nterraform.Core.TerraformProperty(name: "enable_file_encryption", @out: true, min: 0, max: 1)]
        public bool? @EnableFileEncryption { get; }

        [nterraform.Core.TerraformProperty(name: "enable_https_traffic_only", @out: true, min: 0, max: 1)]
        public bool? @EnableHttpsTrafficOnly { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "primary_access_key", @out: true, min: 0, max: 1)]
        public string @PrimaryAccessKey { get; }

        [nterraform.Core.TerraformProperty(name: "primary_blob_connection_string", @out: true, min: 0, max: 1)]
        public string @PrimaryBlobConnectionString { get; }

        [nterraform.Core.TerraformProperty(name: "primary_blob_endpoint", @out: true, min: 0, max: 1)]
        public string @PrimaryBlobEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "primary_connection_string", @out: true, min: 0, max: 1)]
        public string @PrimaryConnectionString { get; }

        [nterraform.Core.TerraformProperty(name: "primary_file_endpoint", @out: true, min: 0, max: 1)]
        public string @PrimaryFileEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "primary_location", @out: true, min: 0, max: 1)]
        public string @PrimaryLocation { get; }

        [nterraform.Core.TerraformProperty(name: "primary_queue_endpoint", @out: true, min: 0, max: 1)]
        public string @PrimaryQueueEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "primary_table_endpoint", @out: true, min: 0, max: 1)]
        public string @PrimaryTableEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_access_key", @out: true, min: 0, max: 1)]
        public string @SecondaryAccessKey { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_blob_connection_string", @out: true, min: 0, max: 1)]
        public string @SecondaryBlobConnectionString { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_blob_endpoint", @out: true, min: 0, max: 1)]
        public string @SecondaryBlobEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_connection_string", @out: true, min: 0, max: 1)]
        public string @SecondaryConnectionString { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_location", @out: true, min: 0, max: 1)]
        public string @SecondaryLocation { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_queue_endpoint", @out: true, min: 0, max: 1)]
        public string @SecondaryQueueEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "secondary_table_endpoint", @out: true, min: 0, max: 1)]
        public string @SecondaryTableEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
