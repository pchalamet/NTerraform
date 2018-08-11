using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_storage_container : NTerraform.resource
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
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @StorageAccountName { get; }
        public string @ContainerAccessType { get; }
        public Dictionary<string,string> @Properties { get; }
    }

}
