using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_snapshot")]
    public sealed class azurerm_snapshot : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "encryption_settings")]
        public sealed class encryption_settings
        {
            [TerraformStructure(category: "", typeName: "disk_encryption_key")]
            public sealed class disk_encryption_key
            {
                public disk_encryption_key(string @secretUrl,
                                           string @sourceVaultId)
                {
                    @SecretUrl = @secretUrl;
                    @SourceVaultId = @sourceVaultId;
                }

                [TerraformProperty(name: "secret_url", @out: false, nested: false, min: 1, max: 1)]
                public string @SecretUrl { get; }

                [TerraformProperty(name: "source_vault_id", @out: false, nested: false, min: 1, max: 1)]
                public string @SourceVaultId { get; }
            }

            [TerraformStructure(category: "", typeName: "key_encryption_key")]
            public sealed class key_encryption_key
            {
                public key_encryption_key(string @keyUrl,
                                          string @sourceVaultId)
                {
                    @KeyUrl = @keyUrl;
                    @SourceVaultId = @sourceVaultId;
                }

                [TerraformProperty(name: "key_url", @out: false, nested: false, min: 1, max: 1)]
                public string @KeyUrl { get; }

                [TerraformProperty(name: "source_vault_id", @out: false, nested: false, min: 1, max: 1)]
                public string @SourceVaultId { get; }
            }

            public encryption_settings(bool @enabled,
                                       disk_encryption_key[] @diskEncryptionKey = null,
                                       key_encryption_key[] @keyEncryptionKey = null)
            {
                @Enabled = @enabled;
                @DiskEncryptionKey = @diskEncryptionKey;
                @KeyEncryptionKey = @keyEncryptionKey;
            }

            [TerraformProperty(name: "enabled", @out: false, nested: false, min: 1, max: 1)]
            public bool @Enabled { get; }

            [TerraformProperty(name: "disk_encryption_key", @out: false, nested: false, min: 0, max: 1)]
            public disk_encryption_key[] @DiskEncryptionKey { get; }

            [TerraformProperty(name: "key_encryption_key", @out: false, nested: false, min: 0, max: 1)]
            public key_encryption_key[] @KeyEncryptionKey { get; }
        }

        public azurerm_snapshot(string @createOption,
                                string @location,
                                string @name,
                                string @resourceGroupName,
                                encryption_settings[] @encryptionSettings = null,
                                string @sourceResourceId = null,
                                string @sourceUri = null,
                                string @storageAccountId = null)
        {
            @CreateOption = @createOption;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @EncryptionSettings = @encryptionSettings;
            @SourceResourceId = @sourceResourceId;
            @SourceUri = @sourceUri;
            @StorageAccountId = @storageAccountId;
        }

        [TerraformProperty(name: "create_option", @out: false, nested: true, min: 1, max: 1)]
        public string @CreateOption { get; }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "disk_size_gb", @out: true, nested: true, min: 0, max: 1)]
        public int? @DiskSizeGb { get; }

        [TerraformProperty(name: "encryption_settings", @out: false, nested: true, min: 0, max: 1)]
        public encryption_settings[] @EncryptionSettings { get; }

        [TerraformProperty(name: "source_resource_id", @out: false, nested: true, min: 0, max: 1)]
        public string @SourceResourceId { get; }

        [TerraformProperty(name: "source_uri", @out: false, nested: true, min: 0, max: 1)]
        public string @SourceUri { get; }

        [TerraformProperty(name: "storage_account_id", @out: false, nested: true, min: 0, max: 1)]
        public string @StorageAccountId { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
