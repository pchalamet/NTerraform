using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_storage_queue")]
    public sealed class azurerm_storage_queue : nterraform.resource
    {
        public azurerm_storage_queue(string @name,
                                     string @resourceGroupName,
                                     string @storageAccountName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @StorageAccountName = @storageAccountName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "storage_account_name", @out: false, min: 1, max: 1)]
        public string @StorageAccountName { get; }
    }

}
