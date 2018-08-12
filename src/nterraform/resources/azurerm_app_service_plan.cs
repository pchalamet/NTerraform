using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_app_service_plan")]
    public sealed class azurerm_app_service_plan : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "sku")]
        public sealed class sku : nterraform.Core.structure
        {
            public sku(string @size,
                       string @tier)
            {
                @Size = @size;
                @Tier = @tier;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "size", @out: false, min: 1, max: 1)]
            public string @Size { get; }

            [nterraform.Core.TerraformProperty(name: "tier", @out: false, min: 1, max: 1)]
            public string @Tier { get; }

            [nterraform.Core.TerraformProperty(name: "capacity", @out: true, min: 0, max: 1)]
            public int? @Capacity { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "properties")]
        public sealed class properties : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "app_service_environment_id", @out: false, min: 0, max: 1)]
            public string @AppServiceEnvironmentId { get; }

            [nterraform.Core.TerraformProperty(name: "per_site_scaling", @out: false, min: 0, max: 1)]
            public bool? @PerSiteScaling { get; }

            [nterraform.Core.TerraformProperty(name: "reserved", @out: false, min: 0, max: 1)]
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public sku[] @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "kind", @out: false, min: 0, max: 1)]
        public string @Kind { get; }

        [nterraform.Core.TerraformProperty(name: "maximum_number_of_workers", @out: true, min: 0, max: 1)]
        public int? @MaximumNumberOfWorkers { get; }

        [nterraform.Core.TerraformProperty(name: "properties", @out: false, min: 0, max: 1)]
        public properties[] @Properties { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
