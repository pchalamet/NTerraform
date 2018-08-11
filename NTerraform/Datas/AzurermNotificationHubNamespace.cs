using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_notification_hub_namespace")]
    public sealed class azurerm_notification_hub_namespace : NTerraform.data
    {
        [TerraformStructure(category: "", typeName: "sku")]
        public sealed class sku
        {
            public sku()
            {
            }

            [TerraformProperty(name: "name", @out: true, nested: false, min: 0, max: 1)]
            public string @Name { get; }
        }

        public azurerm_notification_hub_namespace(string @name,
                                                  string @resourceGroupName,
                                                  sku[] @sku = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
        }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "enabled", @out: true, nested: true, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [TerraformProperty(name: "location", @out: true, nested: true, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "namespace_type", @out: true, nested: true, min: 0, max: 1)]
        public string @NamespaceType { get; }

        [TerraformProperty(name: "servicebus_endpoint", @out: true, nested: true, min: 0, max: 1)]
        public string @ServicebusEndpoint { get; }

        [TerraformProperty(name: "sku", @out: false, nested: true, min: 0, max: 0)]
        public sku[] @Sku { get; }
    }

}
