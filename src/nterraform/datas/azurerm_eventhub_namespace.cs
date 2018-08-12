using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_eventhub_namespace")]
    public sealed class azurerm_eventhub_namespace : nterraform.Core.data
    {
        public azurerm_eventhub_namespace(string @name,
                                          string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "auto_inflate_enabled", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @AutoInflateEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "capacity", @out: true, min: 0, max: 1)]
        public FSharpOption<int> @Capacity { get; }

        [nterraform.Core.TerraformProperty(name: "default_primary_connection_string", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @DefaultPrimaryConnectionString { get; }

        [nterraform.Core.TerraformProperty(name: "default_primary_key", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @DefaultPrimaryKey { get; }

        [nterraform.Core.TerraformProperty(name: "default_secondary_connection_string", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @DefaultSecondaryConnectionString { get; }

        [nterraform.Core.TerraformProperty(name: "default_secondary_key", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @DefaultSecondaryKey { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Location { get; }

        [nterraform.Core.TerraformProperty(name: "maximum_throughput_units", @out: true, min: 0, max: 1)]
        public FSharpOption<int> @MaximumThroughputUnits { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }
    }

}
