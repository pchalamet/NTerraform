using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.datas
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
            public FSharpOption<string> @Name { get; }
        }

        public azurerm_storage_account(string @name,
                                       string @resourceGroupName,
                                       FSharpOption<FSharpList<custom_domain>> @customDomain = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @CustomDomain = @customDomain ?? FSharpList<custom_domain>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "access_tier", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AccessTier { get; }

        [nterraform.Core.TerraformProperty(name: "account_encryption_source", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AccountEncryptionSource { get; }

        [nterraform.Core.TerraformProperty(name: "account_kind", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AccountKind { get; }

        [nterraform.Core.TerraformProperty(name: "account_replication_type", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AccountReplicationType { get; }

        [nterraform.Core.TerraformProperty(name: "account_tier", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AccountTier { get; }

        [nterraform.Core.TerraformProperty(name: "custom_domain", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<custom_domain>> @CustomDomain { get; }

        [nterraform.Core.TerraformProperty(name: "enable_blob_encryption", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @EnableBlobEncryption { get; }

        [nterraform.Core.TerraformProperty(name: "enable_file_encryption", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @EnableFileEncryption { get; }

        [nterraform.Core.TerraformProperty(name: "enable_https_traffic_only", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @EnableHttpsTrafficOnly { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Location { get; }

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
