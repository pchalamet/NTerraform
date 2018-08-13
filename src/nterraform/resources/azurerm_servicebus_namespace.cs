using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_servicebus_namespace")]
    public sealed class azurerm_servicebus_namespace : nterraform.resource
    {
        public azurerm_servicebus_namespace(string @location,
                                            string @name,
                                            string @resourceGroupName,
                                            string @sku,
                                            int? @capacity = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            @Capacity = @capacity;
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

        [nterraform.TerraformProperty(name: "capacity", @out: false, min: 0, max: 1)]
        public int? @Capacity { get; }

        [nterraform.TerraformProperty(name: "default_primary_connection_string", @out: true, min: 0, max: 1)]
        public string @DefaultPrimaryConnectionString { get; }

        [nterraform.TerraformProperty(name: "default_primary_key", @out: true, min: 0, max: 1)]
        public string @DefaultPrimaryKey { get; }

        [nterraform.TerraformProperty(name: "default_secondary_connection_string", @out: true, min: 0, max: 1)]
        public string @DefaultSecondaryConnectionString { get; }

        [nterraform.TerraformProperty(name: "default_secondary_key", @out: true, min: 0, max: 1)]
        public string @DefaultSecondaryKey { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
