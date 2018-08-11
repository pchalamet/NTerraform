using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_snapshot : NTerraform.data
    {
        public class encryption_settings
        {
            public class disk_encryption_key
            {
                public disk_encryption_key()
                {
                }

                public string @SecretUrl { get; }
                public string @SourceVaultId { get; }
            }

            public class key_encryption_key
            {
                public key_encryption_key()
                {
                }

                public string @KeyUrl { get; }
                public string @SourceVaultId { get; }
            }

            public encryption_settings(disk_encryption_key[] @diskEncryptionKey = null,
                                       key_encryption_key[] @keyEncryptionKey = null)
            {
                @DiskEncryptionKey = @diskEncryptionKey;
                @KeyEncryptionKey = @keyEncryptionKey;
            }

            public disk_encryption_key[] @DiskEncryptionKey { get; }
            public bool? @Enabled { get; }
            public key_encryption_key[] @KeyEncryptionKey { get; }
        }

        public azurerm_snapshot(string @name,
                                string @resourceGroupName,
                                encryption_settings[] @encryptionSettings = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @EncryptionSettings = @encryptionSettings;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @CreationOption { get; }
        public string @DiskSizeGb { get; }
        public encryption_settings[] @EncryptionSettings { get; }
        public string @OsType { get; }
        public string @SourceResourceId { get; }
        public string @SourceUri { get; }
        public string @StorageAccountId { get; }
        public string @TimeCreated { get; }
    }

}
