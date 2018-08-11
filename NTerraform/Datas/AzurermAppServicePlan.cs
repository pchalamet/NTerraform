using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_app_service_plan")]
    public sealed class azurerm_app_service_plan : NTerraform.data
    {
        [TerraformStructure(category: "", typeName: "properties")]
        public sealed class properties
        {
            public properties()
            {
            }

            [TerraformProperty(name: "app_service_environment_id", @out: true, nested: false, min: 0, max: 1)]
            public string @AppServiceEnvironmentId { get; }

            [TerraformProperty(name: "per_site_scaling", @out: true, nested: false, min: 0, max: 1)]
            public bool? @PerSiteScaling { get; }

            [TerraformProperty(name: "reserved", @out: true, nested: false, min: 0, max: 1)]
            public bool? @Reserved { get; }
        }

        [TerraformStructure(category: "", typeName: "sku")]
        public sealed class sku
        {
            public sku()
            {
            }

            [TerraformProperty(name: "capacity", @out: true, nested: false, min: 0, max: 1)]
            public int? @Capacity { get; }

            [TerraformProperty(name: "size", @out: true, nested: false, min: 0, max: 1)]
            public string @Size { get; }

            [TerraformProperty(name: "tier", @out: true, nested: false, min: 0, max: 1)]
            public string @Tier { get; }
        }

        public azurerm_app_service_plan(string @name,
                                        string @resourceGroupName,
                                        properties[] @properties = null,
                                        sku[] @sku = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Properties = @properties;
            @Sku = @sku;
        }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "kind", @out: true, nested: true, min: 0, max: 1)]
        public string @Kind { get; }

        [TerraformProperty(name: "location", @out: true, nested: true, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "maximum_number_of_workers", @out: true, nested: true, min: 0, max: 1)]
        public int? @MaximumNumberOfWorkers { get; }

        [TerraformProperty(name: "properties", @out: false, nested: true, min: 0, max: 0)]
        public properties[] @Properties { get; }

        [TerraformProperty(name: "sku", @out: false, nested: true, min: 0, max: 0)]
        public sku[] @Sku { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
