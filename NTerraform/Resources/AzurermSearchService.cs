using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_search_service")]
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

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public string @Sku { get; }

        [TerraformProperty(name: "partition_count", @out: true, min: 0, max: 1)]
        public int? @PartitionCount { get; }

        [TerraformProperty(name: "replica_count", @out: true, min: 0, max: 1)]
        public int? @ReplicaCount { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
