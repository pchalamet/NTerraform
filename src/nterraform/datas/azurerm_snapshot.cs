using System.Collections.Generic;

namespace nterraform.datas.azurerm
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_snapshot")]
    public sealed class azurerm_snapshot : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "encryption_settings")]
        public sealed class encryption_settings : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "data", typeName: "disk_encryption_key")]
            public sealed class disk_encryption_key : nterraform.Core.structure
            {
                public disk_encryption_key()
                {
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "secret_url", @out: true, min: 0, max: 1)]
                public string @SecretUrl { get; }

                [nterraform.Core.TerraformProperty(name: "source_vault_id", @out: true, min: 0, max: 1)]
                public string @SourceVaultId { get; }
            }

            [nterraform.Core.TerraformStructure(category: "data", typeName: "key_encryption_key")]
            public sealed class key_encryption_key : nterraform.Core.structure
            {
                public key_encryption_key()
                {
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "key_url", @out: true, min: 0, max: 1)]
                public string @KeyUrl { get; }

                [nterraform.Core.TerraformProperty(name: "source_vault_id", @out: true, min: 0, max: 1)]
                public string @SourceVaultId { get; }
            }

            public encryption_settings(disk_encryption_key[] @diskEncryptionKey = null,
                                       key_encryption_key[] @keyEncryptionKey = null)
            {
                @DiskEncryptionKey = @diskEncryptionKey;
                @KeyEncryptionKey = @keyEncryptionKey;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "disk_encryption_key", @out: false, min: 0, max: 0)]
            public disk_encryption_key[] @DiskEncryptionKey { get; }

            [nterraform.Core.TerraformProperty(name: "enabled", @out: true, min: 0, max: 1)]
            public bool? @Enabled { get; }

            [nterraform.Core.TerraformProperty(name: "key_encryption_key", @out: false, min: 0, max: 0)]
            public key_encryption_key[] @KeyEncryptionKey { get; }
        }

        public azurerm_snapshot(string @name,
                                string @resourceGroupName,
                                encryption_settings[] @encryptionSettings = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @EncryptionSettings = @encryptionSettings;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "creation_option", @out: true, min: 0, max: 1)]
        public string @CreationOption { get; }

        [nterraform.Core.TerraformProperty(name: "disk_size_gb", @out: true, min: 0, max: 1)]
        public string @DiskSizeGb { get; }

        [nterraform.Core.TerraformProperty(name: "encryption_settings", @out: false, min: 0, max: 0)]
        public encryption_settings[] @EncryptionSettings { get; }

        [nterraform.Core.TerraformProperty(name: "os_type", @out: true, min: 0, max: 1)]
        public string @OsType { get; }

        [nterraform.Core.TerraformProperty(name: "source_resource_id", @out: true, min: 0, max: 1)]
        public string @SourceResourceId { get; }

        [nterraform.Core.TerraformProperty(name: "source_uri", @out: true, min: 0, max: 1)]
        public string @SourceUri { get; }

        [nterraform.Core.TerraformProperty(name: "storage_account_id", @out: true, min: 0, max: 1)]
        public string @StorageAccountId { get; }

        [nterraform.Core.TerraformProperty(name: "time_created", @out: true, min: 0, max: 1)]
        public string @TimeCreated { get; }
    }

}
