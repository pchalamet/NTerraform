using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_automation_account : NTerraform.resource
    {
        public class sku
        {
            public sku(string @name = null)
            {
                @Name = @name;
            }

            public string @Name { get; }
        }

        public azurerm_automation_account(string @location,
                                          string @name,
                                          string @resourceGroupName,
                                          sku[] @sku)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
        }

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public sku[] @Sku { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
