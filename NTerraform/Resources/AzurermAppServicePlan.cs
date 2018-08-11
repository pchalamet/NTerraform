using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_app_service_plan")]
    public sealed class azurerm_app_service_plan : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "properties")]
        public sealed class properties: NTerraform.structure
        {
            public properties(string @appServiceEnvironmentId = null,
                              bool? @perSiteScaling = null,
                              bool? @reserved = null)
            {
                @AppServiceEnvironmentId = @appServiceEnvironmentId;
                @PerSiteScaling = @perSiteScaling;
                @Reserved = @reserved;
                base._validate_();
            }

            [TerraformProperty(name: "app_service_environment_id", @out: false, min: 0, max: 1)]
            public string @AppServiceEnvironmentId { get; }

            [TerraformProperty(name: "per_site_scaling", @out: false, min: 0, max: 1)]
            public bool? @PerSiteScaling { get; }

            [TerraformProperty(name: "reserved", @out: false, min: 0, max: 1)]
            public bool? @Reserved { get; }
        }

        [TerraformStructure(category: "", typeName: "sku")]
        public sealed class sku: NTerraform.structure
        {
            public sku(string @size,
                       string @tier)
            {
                @Size = @size;
                @Tier = @tier;
                base._validate_();
            }

            [TerraformProperty(name: "size", @out: false, min: 1, max: 1)]
            public string @Size { get; }

            [TerraformProperty(name: "tier", @out: false, min: 1, max: 1)]
            public string @Tier { get; }

            [TerraformProperty(name: "capacity", @out: true, min: 0, max: 1)]
            public int? @Capacity { get; }
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
            base._validate_();
        }

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public sku[] @Sku { get; }

        [TerraformProperty(name: "kind", @out: false, min: 0, max: 1)]
        public string @Kind { get; }

        [TerraformProperty(name: "maximum_number_of_workers", @out: true, min: 0, max: 1)]
        public int? @MaximumNumberOfWorkers { get; }

        [TerraformProperty(name: "properties", @out: false, min: 0, max: 1)]
        public properties[] @Properties { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
