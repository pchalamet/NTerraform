using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_snapshot : NTerraform.resource
    {
        public class encryption_settings
        {
            public class key_encryption_key
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

            public class disk_encryption_key
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

        public string @CreateOption { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public int? @DiskSizeGb { get; }
        public encryption_settings[] @EncryptionSettings { get; }
        public string @SourceResourceId { get; }
        public string @SourceUri { get; }
        public string @StorageAccountId { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
