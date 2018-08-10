using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_storage_queue : NTerraform.resource
    {
        public azurerm_storage_queue(string @name,
                                     string @resourceGroupName,
                                     string @storageAccountName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @StorageAccountName = @storageAccountName;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @StorageAccountName { get; }
    }

}
