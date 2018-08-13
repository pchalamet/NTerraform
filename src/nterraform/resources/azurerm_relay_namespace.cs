using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_relay_namespace")]
    public sealed class azurerm_relay_namespace : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "sku")]
        public sealed class sku : nterraform.structure
        {
            public sku(string @name)
            {
                @Name = @name;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }
        }

        public azurerm_relay_namespace(string @location,
                                       string @name,
                                       string @resourceGroupName,
                                       sku[] @sku)
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
        public sku[] @Sku { get; }

        [nterraform.TerraformProperty(name: "metric_id", @out: true, min: 0, max: 1)]
        public string @MetricId { get; }

        [nterraform.TerraformProperty(name: "primary_connection_string", @out: true, min: 0, max: 1)]
        public string @PrimaryConnectionString { get; }

        [nterraform.TerraformProperty(name: "primary_key", @out: true, min: 0, max: 1)]
        public string @PrimaryKey { get; }

        [nterraform.TerraformProperty(name: "secondary_connection_string", @out: true, min: 0, max: 1)]
        public string @SecondaryConnectionString { get; }

        [nterraform.TerraformProperty(name: "secondary_key", @out: true, min: 0, max: 1)]
        public string @SecondaryKey { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
