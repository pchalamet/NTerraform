using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_managed_disk")]
    public sealed class azurerm_managed_disk : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "encryption_settings")]
        public sealed class encryption_settings : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "disk_encryption_key")]
            public sealed class disk_encryption_key : nterraform.structure
            {
                public disk_encryption_key(string @secretUrl,
                                           string @sourceVaultId)
                {
                    @SecretUrl = @secretUrl;
                    @SourceVaultId = @sourceVaultId;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "secret_url", @out: false, min: 1, max: 1)]
                public string @SecretUrl { get; }

                [nterraform.TerraformProperty(name: "source_vault_id", @out: false, min: 1, max: 1)]
                public string @SourceVaultId { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "key_encryption_key")]
            public sealed class key_encryption_key : nterraform.structure
            {
                public key_encryption_key(string @keyUrl,
                                          string @sourceVaultId)
                {
                    @KeyUrl = @keyUrl;
                    @SourceVaultId = @sourceVaultId;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "key_url", @out: false, min: 1, max: 1)]
                public string @KeyUrl { get; }

                [nterraform.TerraformProperty(name: "source_vault_id", @out: false, min: 1, max: 1)]
                public string @SourceVaultId { get; }
            }

            public encryption_settings(bool @enabled,
                                       disk_encryption_key[] @diskEncryptionKey = null,
                                       key_encryption_key[] @keyEncryptionKey = null)
            {
                @Enabled = @enabled;
                @DiskEncryptionKey = @diskEncryptionKey;
                @KeyEncryptionKey = @keyEncryptionKey;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
            public bool @Enabled { get; }

            [nterraform.TerraformProperty(name: "disk_encryption_key", @out: false, min: 0, max: 1)]
            public disk_encryption_key[] @DiskEncryptionKey { get; }

            [nterraform.TerraformProperty(name: "key_encryption_key", @out: false, min: 0, max: 1)]
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "create_option", @out: false, min: 1, max: 1)]
        public string @CreateOption { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "storage_account_type", @out: false, min: 1, max: 1)]
        public string @StorageAccountType { get; }

        [nterraform.TerraformProperty(name: "disk_size_gb", @out: true, min: 0, max: 1)]
        public int? @DiskSizeGb { get; }

        [nterraform.TerraformProperty(name: "encryption_settings", @out: false, min: 0, max: 1)]
        public encryption_settings[] @EncryptionSettings { get; }

        [nterraform.TerraformProperty(name: "image_reference_id", @out: false, min: 0, max: 1)]
        public string @ImageReferenceId { get; }

        [nterraform.TerraformProperty(name: "os_type", @out: false, min: 0, max: 1)]
        public string @OsType { get; }

        [nterraform.TerraformProperty(name: "source_resource_id", @out: false, min: 0, max: 1)]
        public string @SourceResourceId { get; }

        [nterraform.TerraformProperty(name: "source_uri", @out: true, min: 0, max: 1)]
        public string @SourceUri { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "zones", @out: false, min: 0, max: 1)]
        public string[] @Zones { get; }
    }

}
