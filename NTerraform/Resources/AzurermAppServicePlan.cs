using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_app_service_plan")]
    public sealed class azurerm_app_service_plan : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "sku")]
        public sealed class sku
        {
            public sku(string @size,
                       string @tier)
            {
                @Size = @size;
                @Tier = @tier;
            }

            [TerraformProperty(name: "size", @out: false, nested: false, min: 1, max: 1)]
            public string @Size { get; }

            [TerraformProperty(name: "tier", @out: false, nested: false, min: 1, max: 1)]
            public string @Tier { get; }

            [TerraformProperty(name: "capacity", @out: true, nested: false, min: 0, max: 1)]
            public int? @Capacity { get; }
        }

        [TerraformStructure(category: "", typeName: "properties")]
        public sealed class properties
        {
            public properties(string @appServiceEnvironmentId = null,
                              bool? @perSiteScaling = null,
                              bool? @reserved = null)
            {
                @AppServiceEnvironmentId = @appServiceEnvironmentId;
                @PerSiteScaling = @perSiteScaling;
                @Reserved = @reserved;
            }

            [TerraformProperty(name: "app_service_environment_id", @out: false, nested: false, min: 0, max: 1)]
            public string @AppServiceEnvironmentId { get; }

            [TerraformProperty(name: "per_site_scaling", @out: false, nested: false, min: 0, max: 1)]
            public bool? @PerSiteScaling { get; }

            [TerraformProperty(name: "reserved", @out: false, nested: false, min: 0, max: 1)]
            public bool? @Reserved { get; }
        }

        public azurerm_app_service_plan(string @location,
                                        string @name,
                                        string @resourceGroupName,
                                        sku[] @sku,
                                        string @kind = null,
                                        properties[] @properties = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            @Kind = @kind;
            @Properties = @properties;
        }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "sku", @out: false, nested: true, min: 1, max: 1)]
        public sku[] @Sku { get; }

        [TerraformProperty(name: "kind", @out: false, nested: true, min: 0, max: 1)]
        public string @Kind { get; }

        [TerraformProperty(name: "maximum_number_of_workers", @out: true, nested: true, min: 0, max: 1)]
        public int? @MaximumNumberOfWorkers { get; }

        [TerraformProperty(name: "properties", @out: false, nested: true, min: 0, max: 1)]
        public properties[] @Properties { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
