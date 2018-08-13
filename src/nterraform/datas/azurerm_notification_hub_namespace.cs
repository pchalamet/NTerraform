using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_notification_hub_namespace")]
    public sealed class azurerm_notification_hub_namespace : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "sku")]
        public sealed class sku : nterraform.structure
        {
            public sku()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }
        }

        public azurerm_notification_hub_namespace(string @name,
                                                  string @resourceGroupName,
                                                  sku[] @sku = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "enabled", @out: true, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "namespace_type", @out: true, min: 0, max: 1)]
        public string @NamespaceType { get; }

        [nterraform.TerraformProperty(name: "servicebus_endpoint", @out: true, min: 0, max: 1)]
        public string @ServicebusEndpoint { get; }

        [nterraform.TerraformProperty(name: "sku", @out: false, min: 0, max: 0)]
        public sku[] @Sku { get; }
    }

}
