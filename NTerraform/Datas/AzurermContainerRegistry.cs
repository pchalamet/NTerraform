using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_container_registry : NTerraform.data
    {
        public azurerm_container_registry(string @name,
                                          string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public bool? @AdminEnabled { get; }
        public string @AdminPassword { get; }
        public string @AdminUsername { get; }
        public string @Location { get; }
        public string @LoginServer { get; }
        public string @Sku { get; }
        public string @StorageAccountId { get; }
    }

}
