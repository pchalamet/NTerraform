using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_container_registry")]
    public sealed class azurerm_container_registry : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "storage_account")]
        public sealed class storage_account
        {
            public storage_account(string @accessKey,
                                   string @name)
            {
                @AccessKey = @accessKey;
                @Name = @name;
            }

            [TerraformProperty(name: "access_key", @out: false, nested: false, min: 1, max: 1)]
            public string @AccessKey { get; }

            [TerraformProperty(name: "name", @out: false, nested: false, min: 1, max: 1)]
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

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "admin_enabled", @out: false, nested: true, min: 0, max: 1)]
        public bool? @AdminEnabled { get; }

        [TerraformProperty(name: "admin_password", @out: true, nested: true, min: 0, max: 1)]
        public string @AdminPassword { get; }

        [TerraformProperty(name: "admin_username", @out: true, nested: true, min: 0, max: 1)]
        public string @AdminUsername { get; }

        [TerraformProperty(name: "login_server", @out: true, nested: true, min: 0, max: 1)]
        public string @LoginServer { get; }

        [TerraformProperty(name: "sku", @out: false, nested: true, min: 0, max: 1)]
        public string @Sku { get; }

        [TerraformProperty(name: "storage_account", @out: false, nested: true, min: 0, max: 1)]
        public storage_account[] @StorageAccount { get; }

        [TerraformProperty(name: "storage_account_id", @out: false, nested: true, min: 0, max: 1)]
        public string @StorageAccountId { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
