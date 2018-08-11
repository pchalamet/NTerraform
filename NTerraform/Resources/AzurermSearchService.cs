using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_search_service : NTerraform.resource
    {
        public azurerm_search_service(string @location,
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
        public int? @PartitionCount { get; }
        public int? @ReplicaCount { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
