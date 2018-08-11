using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_managed_disk : NTerraform.resource
    {
        public sealed class encryption_settings
        {
            public sealed class disk_encryption_key
            {
                public disk_encryption_key(string @secretUrl,
                                           string @sourceVaultId)
                {
                    @SecretUrl = @secretUrl;
                    @SourceVaultId = @sourceVaultId;
                }

                public string @SecretUrl { get; }
                public string @SourceVaultId { get; }
            }

            public sealed class key_encryption_key
            {
                public key_encryption_key(string @keyUrl,
                                          string @sourceVaultId)
                {
                    @KeyUrl = @keyUrl;
                    @SourceVaultId = @sourceVaultId;
                }

                public string @KeyUrl { get; }
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

            public bool @Enabled { get; }
            public disk_encryption_key[] @DiskEncryptionKey { get; }
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

        public string @CreateOption { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @StorageAccountType { get; }
        public int? @DiskSizeGb { get; }
        public encryption_settings[] @EncryptionSettings { get; }
        public string @ImageReferenceId { get; }
        public string @OsType { get; }
        public string @SourceResourceId { get; }
        public string @SourceUri { get; }
        public Dictionary<string,string> @Tags { get; }
        public string[] @Zones { get; }
    }

}
