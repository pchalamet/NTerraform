using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_managed_disk")]
    public sealed class azurerm_managed_disk : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "encryption_settings")]
        public sealed class encryption_settings
        {
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

        public azurerm_managed_disk(string @createOption,
                                    string @location,
                                    string @name,
                                    string @resourceGroupName,
                                    string @storageAccountType,
                                    encryption_settings[] @encryptionSettings = null,
                                    string @imageReferenceId = null,
                                    string @osType = null,
                                    string @sourceResourceId = null,
                                    string[] @zones = null)
        {
            @CreateOption = @createOption;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @StorageAccountType = @storageAccountType;
            @EncryptionSettings = @encryptionSettings;
            @ImageReferenceId = @imageReferenceId;
            @OsType = @osType;
            @SourceResourceId = @sourceResourceId;
            @Zones = @zones;
        }

        [TerraformProperty(name: "create_option", @out: false, nested: true, min: 1, max: 1)]
        public string @CreateOption { get; }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "storage_account_type", @out: false, nested: true, min: 1, max: 1)]
        public string @StorageAccountType { get; }

        [TerraformProperty(name: "disk_size_gb", @out: true, nested: true, min: 0, max: 1)]
        public int? @DiskSizeGb { get; }

        [TerraformProperty(name: "encryption_settings", @out: false, nested: true, min: 0, max: 1)]
        public encryption_settings[] @EncryptionSettings { get; }

        [TerraformProperty(name: "image_reference_id", @out: false, nested: true, min: 0, max: 1)]
        public string @ImageReferenceId { get; }

        [TerraformProperty(name: "os_type", @out: false, nested: true, min: 0, max: 1)]
        public string @OsType { get; }

        [TerraformProperty(name: "source_resource_id", @out: false, nested: true, min: 0, max: 1)]
        public string @SourceResourceId { get; }

        [TerraformProperty(name: "source_uri", @out: true, nested: true, min: 0, max: 1)]
        public string @SourceUri { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "zones", @out: false, nested: true, min: 0, max: 1)]
        public string[] @Zones { get; }
    }

}
