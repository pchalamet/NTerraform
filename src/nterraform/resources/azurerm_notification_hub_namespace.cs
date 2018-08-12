using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_notification_hub_namespace")]
    public sealed class azurerm_notification_hub_namespace : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "sku")]
        public sealed class sku : nterraform.Core.structure
        {
            public sku(string @name)
            {
                @Name = @name;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "namespace_type", @out: false, min: 1, max: 1)]
        public string @NamespaceType { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public sku[] @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.Core.TerraformProperty(name: "servicebus_endpoint", @out: true, min: 0, max: 1)]
        public string @ServicebusEndpoint { get; }
    }

}
