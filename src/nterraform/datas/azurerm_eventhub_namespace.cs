using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_eventhub_namespace")]
    public sealed class azurerm_eventhub_namespace : nterraform.data
    {
        public azurerm_eventhub_namespace(string @name,
                                          string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "auto_inflate_enabled", @out: true, min: 0, max: 1)]
        public bool? @AutoInflateEnabled { get; }

        [nterraform.TerraformProperty(name: "capacity", @out: true, min: 0, max: 1)]
        public int? @Capacity { get; }

        [nterraform.TerraformProperty(name: "default_primary_connection_string", @out: true, min: 0, max: 1)]
        public string @DefaultPrimaryConnectionString { get; }

        [nterraform.TerraformProperty(name: "default_primary_key", @out: true, min: 0, max: 1)]
        public string @DefaultPrimaryKey { get; }

        [nterraform.TerraformProperty(name: "default_secondary_connection_string", @out: true, min: 0, max: 1)]
        public string @DefaultSecondaryConnectionString { get; }

        [nterraform.TerraformProperty(name: "default_secondary_key", @out: true, min: 0, max: 1)]
        public string @DefaultSecondaryKey { get; }

        [nterraform.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "maximum_throughput_units", @out: true, min: 0, max: 1)]
        public int? @MaximumThroughputUnits { get; }

        [nterraform.TerraformProperty(name: "sku", @out: true, min: 0, max: 1)]
        public string @Sku { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
