using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_container_registry")]
    public sealed class azurerm_container_registry : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "storage_account")]
        public sealed class storage_account : nterraform.Core.structure
        {
            public storage_account(string @accessKey,
                                   string @name)
            {
                @AccessKey = @accessKey;
                @Name = @name;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "access_key", @out: false, min: 1, max: 1)]
            public string @AccessKey { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "admin_enabled", @out: false, min: 0, max: 1)]
        public bool? @AdminEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "admin_password", @out: true, min: 0, max: 1)]
        public string @AdminPassword { get; }

        [nterraform.Core.TerraformProperty(name: "admin_username", @out: true, min: 0, max: 1)]
        public string @AdminUsername { get; }

        [nterraform.Core.TerraformProperty(name: "login_server", @out: true, min: 0, max: 1)]
        public string @LoginServer { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: false, min: 0, max: 1)]
        public string @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "storage_account", @out: false, min: 0, max: 1)]
        public storage_account[] @StorageAccount { get; }

        [nterraform.Core.TerraformProperty(name: "storage_account_id", @out: false, min: 0, max: 1)]
        public string @StorageAccountId { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
