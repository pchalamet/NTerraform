using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_eventhub_namespace")]
    public sealed class azurerm_eventhub_namespace : NTerraform.data
    {
        public azurerm_eventhub_namespace(string @name,
                                          string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "auto_inflate_enabled", @out: true, min: 0, max: 1)]
        public bool? @AutoInflateEnabled { get; }

        [TerraformProperty(name: "capacity", @out: true, min: 0, max: 1)]
        public int? @Capacity { get; }

        [TerraformProperty(name: "default_primary_connection_string", @out: true, min: 0, max: 1)]
        public string @DefaultPrimaryConnectionString { get; }

        [TerraformProperty(name: "default_primary_key", @out: true, min: 0, max: 1)]
        public string @DefaultPrimaryKey { get; }

        [TerraformProperty(name: "default_secondary_connection_string", @out: true, min: 0, max: 1)]
        public string @DefaultSecondaryConnectionString { get; }

        [TerraformProperty(name: "default_secondary_key", @out: true, min: 0, max: 1)]
        public string @DefaultSecondaryKey { get; }

        [TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "maximum_throughput_units", @out: true, min: 0, max: 1)]
        public int? @MaximumThroughputUnits { get; }

        [TerraformProperty(name: "sku", @out: true, min: 0, max: 1)]
        public string @Sku { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
