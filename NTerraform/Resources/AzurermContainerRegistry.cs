using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_container_registry : NTerraform.resource
    {
        public sealed class storage_account
        {
            public storage_account(string @accessKey,
                                   string @name)
            {
                @AccessKey = @accessKey;
                @Name = @name;
            }

            public string @AccessKey { get; }
            public string @Name { get; }
        }

        public azurerm_container_registry(string @location,
                                          string @name,
                                          string @resourceGroupName,
                                          bool? @adminEnabled = null,
                                          string @sku = null,
                                          storage_account[] @storageAccount = null,
                                          string @storageAccountId = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @AdminEnabled = @adminEnabled;
            @Sku = @sku;
            @StorageAccount = @storageAccount;
            @StorageAccountId = @storageAccountId;
        }

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public bool? @AdminEnabled { get; }
        public string @AdminPassword { get; }
        public string @AdminUsername { get; }
        public string @LoginServer { get; }
        public string @Sku { get; }
        public storage_account[] @StorageAccount { get; }
        public string @StorageAccountId { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
