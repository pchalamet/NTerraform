using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_storage_container")]
    public sealed class azurerm_storage_container : nterraform.Core.resource
    {
        public azurerm_storage_container(string @name,
                                         string @resourceGroupName,
                                         string @storageAccountName,
                                         string @containerAccessType = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @StorageAccountName = @storageAccountName;
            @ContainerAccessType = @containerAccessType;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "storage_account_name", @out: false, min: 1, max: 1)]
        public string @StorageAccountName { get; }

        [nterraform.Core.TerraformProperty(name: "container_access_type", @out: false, min: 0, max: 1)]
        public string @ContainerAccessType { get; }

        [nterraform.Core.TerraformProperty(name: "properties", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Properties { get; }
    }

}
