using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_storage_share : NTerraform.resource
    {
        public azurerm_storage_share(string @name,
                                     string @resourceGroupName,
                                     string @storageAccountName,
                                     int? @quota = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @StorageAccountName = @storageAccountName;
            @Quota = @quota;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @StorageAccountName { get; }
        public int? @Quota { get; }
        public string @Url { get; }
    }

}
