using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_cdn_profile : NTerraform.resource
    {
        public azurerm_cdn_profile(string @location,
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
