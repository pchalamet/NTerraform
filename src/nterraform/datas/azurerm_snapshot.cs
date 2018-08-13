using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_snapshot")]
    public sealed class azurerm_snapshot : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "encryption_settings")]
        public sealed class encryption_settings : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "data", typeName: "disk_encryption_key")]
            public sealed class disk_encryption_key : nterraform.structure
            {
                public disk_encryption_key()
                {
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "secret_url", @out: true, min: 0, max: 1)]
                public string @SecretUrl { get; }

                [nterraform.TerraformProperty(name: "source_vault_id", @out: true, min: 0, max: 1)]
                public string @SourceVaultId { get; }
            }

            [nterraform.TerraformStructure(category: "data", typeName: "key_encryption_key")]
            public sealed class key_encryption_key : nterraform.structure
            {
                public key_encryption_key()
                {
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "key_url", @out: true, min: 0, max: 1)]
                public string @KeyUrl { get; }

                [nterraform.TerraformProperty(name: "source_vault_id", @out: true, min: 0, max: 1)]
                public string @SourceVaultId { get; }
            }

            public encryption_settings(disk_encryption_key[] @diskEncryptionKey = null,
                                       key_encryption_key[] @keyEncryptionKey = null)
            {
                @DiskEncryptionKey = @diskEncryptionKey;
                @KeyEncryptionKey = @keyEncryptionKey;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "disk_encryption_key", @out: false, min: 0, max: 0)]
            public disk_encryption_key[] @DiskEncryptionKey { get; }

            [nterraform.TerraformProperty(name: "enabled", @out: true, min: 0, max: 1)]
            public bool? @Enabled { get; }

            [nterraform.TerraformProperty(name: "key_encryption_key", @out: false, min: 0, max: 0)]
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

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "creation_option", @out: true, min: 0, max: 1)]
        public string @CreationOption { get; }

        [nterraform.TerraformProperty(name: "disk_size_gb", @out: true, min: 0, max: 1)]
        public string @DiskSizeGb { get; }

        [nterraform.TerraformProperty(name: "encryption_settings", @out: false, min: 0, max: 0)]
        public encryption_settings[] @EncryptionSettings { get; }

        [nterraform.TerraformProperty(name: "os_type", @out: true, min: 0, max: 1)]
        public string @OsType { get; }

        [nterraform.TerraformProperty(name: "source_resource_id", @out: true, min: 0, max: 1)]
        public string @SourceResourceId { get; }

        [nterraform.TerraformProperty(name: "source_uri", @out: true, min: 0, max: 1)]
        public string @SourceUri { get; }

        [nterraform.TerraformProperty(name: "storage_account_id", @out: true, min: 0, max: 1)]
        public string @StorageAccountId { get; }

        [nterraform.TerraformProperty(name: "time_created", @out: true, min: 0, max: 1)]
        public string @TimeCreated { get; }
    }

}
