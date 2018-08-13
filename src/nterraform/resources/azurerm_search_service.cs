using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_search_service")]
    public sealed class azurerm_search_service : nterraform.resource
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public string @Sku { get; }

        [nterraform.TerraformProperty(name: "partition_count", @out: true, min: 0, max: 1)]
        public int? @PartitionCount { get; }

        [nterraform.TerraformProperty(name: "replica_count", @out: true, min: 0, max: 1)]
        public int? @ReplicaCount { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
