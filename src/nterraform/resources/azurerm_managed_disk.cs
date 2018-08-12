using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_managed_disk")]
    public sealed class azurerm_managed_disk : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "encryption_settings")]
        public sealed class encryption_settings : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "disk_encryption_key")]
            public sealed class disk_encryption_key : nterraform.Core.structure
            {
                public disk_encryption_key(string @secretUrl,
                                           string @sourceVaultId)
                {
                    @SecretUrl = @secretUrl;
                    @SourceVaultId = @sourceVaultId;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "secret_url", @out: false, min: 1, max: 1)]
                public string @SecretUrl { get; }

                [nterraform.Core.TerraformProperty(name: "source_vault_id", @out: false, min: 1, max: 1)]
                public string @SourceVaultId { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "key_encryption_key")]
            public sealed class key_encryption_key : nterraform.Core.structure
            {
                public key_encryption_key(string @keyUrl,
                                          string @sourceVaultId)
                {
                    @KeyUrl = @keyUrl;
                    @SourceVaultId = @sourceVaultId;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "key_url", @out: false, min: 1, max: 1)]
                public string @KeyUrl { get; }

                [nterraform.Core.TerraformProperty(name: "source_vault_id", @out: false, min: 1, max: 1)]
                public string @SourceVaultId { get; }
            }

            public encryption_settings(bool @enabled,
                                       FSharpOption<FSharpList<disk_encryption_key>> @diskEncryptionKey = null,
                                       FSharpOption<FSharpList<key_encryption_key>> @keyEncryptionKey = null)
            {
                @Enabled = @enabled;
                @DiskEncryptionKey = @diskEncryptionKey ?? FSharpList<disk_encryption_key>.Empty;
                @KeyEncryptionKey = @keyEncryptionKey ?? FSharpList<key_encryption_key>.Empty;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
            public bool @Enabled { get; }

            [nterraform.Core.TerraformProperty(name: "disk_encryption_key", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<disk_encryption_key>> @DiskEncryptionKey { get; }

            [nterraform.Core.TerraformProperty(name: "key_encryption_key", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<key_encryption_key>> @KeyEncryptionKey { get; }
        }

        public azurerm_managed_disk(string @createOption,
                                    string @location,
                                    string @name,
                                    string @resourceGroupName,
                                    string @storageAccountType,
                                    FSharpOption<FSharpList<encryption_settings>> @encryptionSettings = null,
                                    FSharpOption<string> @imageReferenceId = null,
                                    FSharpOption<string> @osType = null,
                                    FSharpOption<string> @sourceResourceId = null,
                                    FSharpOption<FSharpList<string>> @zones = null)
        {
            @CreateOption = @createOption;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @StorageAccountType = @storageAccountType;
            @EncryptionSettings = @encryptionSettings ?? FSharpList<encryption_settings>.Empty;
            @ImageReferenceId = @imageReferenceId;
            @OsType = @osType;
            @SourceResourceId = @sourceResourceId;
            @Zones = @zones ?? FSharpList<string>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "create_option", @out: false, min: 1, max: 1)]
        public string @CreateOption { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "storage_account_type", @out: false, min: 1, max: 1)]
        public string @StorageAccountType { get; }

        [nterraform.Core.TerraformProperty(name: "disk_size_gb", @out: true, min: 0, max: 1)]
        public FSharpOption<int> @DiskSizeGb { get; }

        [nterraform.Core.TerraformProperty(name: "encryption_settings", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<encryption_settings>> @EncryptionSettings { get; }

        [nterraform.Core.TerraformProperty(name: "image_reference_id", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @ImageReferenceId { get; }

        [nterraform.Core.TerraformProperty(name: "os_type", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @OsType { get; }

        [nterraform.Core.TerraformProperty(name: "source_resource_id", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @SourceResourceId { get; }

        [nterraform.Core.TerraformProperty(name: "source_uri", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SourceUri { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "zones", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @Zones { get; }
    }

}
