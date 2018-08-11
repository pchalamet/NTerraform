using System.Collections.Generic;

namespace NTerraform.Datas
{
    public sealed class azurerm_notification_hub_namespace : NTerraform.data
    {
        public sealed class sku
        {
            public sku()
            {
            }

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

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public bool? @Enabled { get; }
        public string @Location { get; }
        public string @NamespaceType { get; }
        public string @ServicebusEndpoint { get; }
        public sku[] @Sku { get; }
    }

}
