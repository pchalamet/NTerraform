using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_notification_hub_namespace : NTerraform.resource
    {
        public class sku
        {
            public sku(string @name)
            {
                @Name = @name;
            }

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

        public string @Location { get; }
        public string @Name { get; }
        public string @NamespaceType { get; }
        public string @ResourceGroupName { get; }
        public sku[] @Sku { get; }
        public bool? @Enabled { get; }
        public string @ServicebusEndpoint { get; }
    }

}
