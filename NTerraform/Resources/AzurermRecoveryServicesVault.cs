using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_recovery_services_vault : NTerraform.resource
    {
        public azurerm_recovery_services_vault(string @location,
                                               string @name,
                                               string @resourceGroupName,
                                               string @sku)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
        }

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @Sku { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
