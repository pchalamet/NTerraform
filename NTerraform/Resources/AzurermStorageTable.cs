using System.Collections.Generic;

namespace NTerraform.Resources
{
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

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @StorageAccountName { get; }
    }

}
