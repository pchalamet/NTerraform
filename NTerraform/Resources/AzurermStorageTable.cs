using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_storage_table")]
    public sealed class azurerm_storage_table : NTerraform.resource
    {
        public azurerm_storage_table(string @name,
                                     string @resourceGroupName,
                                     string @storageAccountName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @StorageAccountName = @storageAccountName;
        }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "storage_account_name", @out: false, nested: true, min: 1, max: 1)]
        public string @StorageAccountName { get; }
    }

}
