using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_notification_hub_namespace")]
    public sealed class azurerm_notification_hub_namespace : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "sku")]
        public sealed class sku : nterraform.Core.structure
        {
            public sku()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }
        }

        public azurerm_notification_hub_namespace(string @name,
                                                  string @resourceGroupName,
                                                  FSharpList<sku> @sku = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku ?? FSharpList<sku>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "enabled", @out: true, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "namespace_type", @out: true, min: 0, max: 1)]
        public string @NamespaceType { get; }

        [nterraform.Core.TerraformProperty(name: "servicebus_endpoint", @out: true, min: 0, max: 1)]
        public string @ServicebusEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: false, min: 0, max: 0)]
        public FSharpList<sku> @Sku { get; }
    }

}
