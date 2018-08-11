using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_notification_hub_namespace")]
    public sealed class azurerm_notification_hub_namespace : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "sku")]
        public sealed class sku
        {
            public sku(string @name)
            {
                @Name = @name;
            }

            [TerraformProperty(name: "name", @out: false, nested: false, min: 1, max: 1)]
            public string @Name { get; }
        }

        public azurerm_notification_hub_namespace(string @location,
                                                  string @name,
                                                  string @namespaceType,
                                                  string @resourceGroupName,
                                                  sku[] @sku,
                                                  bool? @enabled = null)
        {
            @Location = @location;
            @Name = @name;
            @NamespaceType = @namespaceType;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            @Enabled = @enabled;
        }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "namespace_type", @out: false, nested: true, min: 1, max: 1)]
        public string @NamespaceType { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "sku", @out: false, nested: true, min: 1, max: 1)]
        public sku[] @Sku { get; }

        [TerraformProperty(name: "enabled", @out: false, nested: true, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [TerraformProperty(name: "servicebus_endpoint", @out: true, nested: true, min: 0, max: 1)]
        public string @ServicebusEndpoint { get; }
    }

}
