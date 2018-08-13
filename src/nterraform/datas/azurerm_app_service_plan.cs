using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_app_service_plan")]
    public sealed class azurerm_app_service_plan : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "sku")]
        public sealed class sku : nterraform.structure
        {
            public sku()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "capacity", @out: true, min: 0, max: 1)]
            public int? @Capacity { get; }

            [nterraform.TerraformProperty(name: "size", @out: true, min: 0, max: 1)]
            public string @Size { get; }

            [nterraform.TerraformProperty(name: "tier", @out: true, min: 0, max: 1)]
            public string @Tier { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "properties")]
        public sealed class properties : nterraform.structure
        {
            public properties()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "app_service_environment_id", @out: true, min: 0, max: 1)]
            public string @AppServiceEnvironmentId { get; }

            [nterraform.TerraformProperty(name: "per_site_scaling", @out: true, min: 0, max: 1)]
            public bool? @PerSiteScaling { get; }

            [nterraform.TerraformProperty(name: "reserved", @out: true, min: 0, max: 1)]
            public bool? @Reserved { get; }
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "kind", @out: true, min: 0, max: 1)]
        public string @Kind { get; }

        [nterraform.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "maximum_number_of_workers", @out: true, min: 0, max: 1)]
        public int? @MaximumNumberOfWorkers { get; }

        [nterraform.TerraformProperty(name: "properties", @out: false, min: 0, max: 0)]
        public properties[] @Properties { get; }

        [nterraform.TerraformProperty(name: "sku", @out: false, min: 0, max: 0)]
        public sku[] @Sku { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
