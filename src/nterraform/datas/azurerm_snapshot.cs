using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.datas
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
                public FSharpOption<string> @SecretUrl { get; }

                [nterraform.Core.TerraformProperty(name: "source_vault_id", @out: true, min: 0, max: 1)]
                public FSharpOption<string> @SourceVaultId { get; }
            }

            [nterraform.Core.TerraformStructure(category: "data", typeName: "key_encryption_key")]
            public sealed class key_encryption_key : nterraform.Core.structure
            {
                public key_encryption_key()
                {
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "key_url", @out: true, min: 0, max: 1)]
                public FSharpOption<string> @KeyUrl { get; }

                [nterraform.Core.TerraformProperty(name: "source_vault_id", @out: true, min: 0, max: 1)]
                public FSharpOption<string> @SourceVaultId { get; }
            }

            public encryption_settings(FSharpOption<FSharpList<disk_encryption_key>> @diskEncryptionKey = null,
                                       FSharpOption<FSharpList<key_encryption_key>> @keyEncryptionKey = null)
            {
                @DiskEncryptionKey = @diskEncryptionKey ?? FSharpList<disk_encryption_key>.Empty;
                @KeyEncryptionKey = @keyEncryptionKey ?? FSharpList<key_encryption_key>.Empty;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "disk_encryption_key", @out: false, min: 0, max: 0)]
            public FSharpOption<FSharpList<disk_encryption_key>> @DiskEncryptionKey { get; }

            [nterraform.Core.TerraformProperty(name: "enabled", @out: true, min: 0, max: 1)]
            public FSharpOption<bool> @Enabled { get; }

            [nterraform.Core.TerraformProperty(name: "key_encryption_key", @out: false, min: 0, max: 0)]
            public FSharpOption<FSharpList<key_encryption_key>> @KeyEncryptionKey { get; }
        }

        public azurerm_snapshot(string @name,
                                string @resourceGroupName,
                                FSharpOption<FSharpList<encryption_settings>> @encryptionSettings = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @EncryptionSettings = @encryptionSettings ?? FSharpList<encryption_settings>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "creation_option", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @CreationOption { get; }

        [nterraform.Core.TerraformProperty(name: "disk_size_gb", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @DiskSizeGb { get; }

        [nterraform.Core.TerraformProperty(name: "encryption_settings", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<encryption_settings>> @EncryptionSettings { get; }

        [nterraform.Core.TerraformProperty(name: "os_type", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @OsType { get; }

        [nterraform.Core.TerraformProperty(name: "source_resource_id", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SourceResourceId { get; }

        [nterraform.Core.TerraformProperty(name: "source_uri", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SourceUri { get; }

        [nterraform.Core.TerraformProperty(name: "storage_account_id", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @StorageAccountId { get; }

        [nterraform.Core.TerraformProperty(name: "time_created", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @TimeCreated { get; }
    }

}
