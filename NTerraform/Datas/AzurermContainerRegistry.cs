using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_container_registry")]
    public sealed class azurerm_container_registry : NTerraform.data
    {
        public azurerm_container_registry(string @name,
                                          string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "admin_enabled", @out: true, min: 0, max: 1)]
        public bool? @AdminEnabled { get; }

        [TerraformProperty(name: "admin_password", @out: true, min: 0, max: 1)]
        public string @AdminPassword { get; }

        [TerraformProperty(name: "admin_username", @out: true, min: 0, max: 1)]
        public string @AdminUsername { get; }

        [TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "login_server", @out: true, min: 0, max: 1)]
        public string @LoginServer { get; }

        [TerraformProperty(name: "sku", @out: true, min: 0, max: 1)]
        public string @Sku { get; }

        [TerraformProperty(name: "storage_account_id", @out: true, min: 0, max: 1)]
        public string @StorageAccountId { get; }
    }

}
