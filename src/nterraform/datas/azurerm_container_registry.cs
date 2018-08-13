using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_container_registry")]
    public sealed class azurerm_container_registry : nterraform.data
    {
        public azurerm_container_registry(string @name,
                                          string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "admin_enabled", @out: true, min: 0, max: 1)]
        public bool? @AdminEnabled { get; }

        [nterraform.TerraformProperty(name: "admin_password", @out: true, min: 0, max: 1)]
        public string @AdminPassword { get; }

        [nterraform.TerraformProperty(name: "admin_username", @out: true, min: 0, max: 1)]
        public string @AdminUsername { get; }

        [nterraform.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "login_server", @out: true, min: 0, max: 1)]
        public string @LoginServer { get; }

        [nterraform.TerraformProperty(name: "sku", @out: true, min: 0, max: 1)]
        public string @Sku { get; }

        [nterraform.TerraformProperty(name: "storage_account_id", @out: true, min: 0, max: 1)]
        public string @StorageAccountId { get; }
    }

}
